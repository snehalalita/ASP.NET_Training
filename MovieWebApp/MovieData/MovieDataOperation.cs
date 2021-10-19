using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace MovieData
{
    public class MovieDataOperation
    {
        MovieDbEntities movieEntities = new MovieDbEntities();
        public string insertMovie(movie moviedata)
        {
            movieEntities.movies.Add(moviedata);
            movieEntities.SaveChanges();
            return "Movie Data inserted";
        }

        public string updateMovie(movie moviedata)
        {
            movieEntities.Entry(moviedata).State = System.Data.Entity.EntityState.Modified;
            movieEntities.SaveChanges();
            return "Movie data updated";
        }

        public movie editMovieById(int movieId)
        {
            movie mov = new movie();
            var result = movieEntities.movies.ToList().Find(obj => obj.Id ==movieId);
            mov.Id = result.Id;
            mov.Name = result.Name;
            mov.MovieType = result.MovieType;
            mov.MovieDesc = result.MovieDesc;
            return mov;
        }

        public string deleteMovie(movie moviedata)
        {
            movieEntities.Entry(moviedata).State = EntityState.Deleted;
            movieEntities.SaveChanges();
            return "Movie Data deleted";
        }

        public DataTable selectMovies()
        {
            var result = movieEntities.movies.ToList();
            DataTable dtmovies = new DataTable();
            dtmovies = toDataTable<movie>(result);
            return dtmovies;
        }

        private DataTable toDataTable<T>(List<T> items)
        {
            DataTable data = new DataTable(typeof(T).Name);
            PropertyInfo[] propertyInfos = typeof(T).GetProperties(BindingFlags.Public | BindingFlags.Instance);
            foreach(PropertyInfo property in propertyInfos)
            {
                data.Columns.Add(property.Name);
            }
            foreach (T item in items)
            {
                var values = new object[propertyInfos.Length];
                for (int i = 0; i < propertyInfos.Length; i++)
                {
                    values[i] = propertyInfos[i].GetValue(item, null);
                }
                data.Rows.Add(values);
            }
            return data;
        }
    }
}
