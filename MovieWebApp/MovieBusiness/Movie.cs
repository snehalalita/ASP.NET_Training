using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MovieData;

namespace MovieBusiness
{
    public class Movie
    {
        MovieData.MovieDataOperation dataOperationObj = new MovieDataOperation();
        public string insertMovie(movie moviedata)
        {
            string msg = dataOperationObj.insertMovie(moviedata);
            return msg;
        }

        public string updateMovie(movie moviedata)
        {
            string msg = dataOperationObj.updateMovie(moviedata);
            return msg;
        }

        public movie editMovieById(int movieId)
        {
            movie mov = dataOperationObj.editMovieById(movieId);
            return mov;
        }

        public string deleteMovie(movie moviedata)
        {
            string msg = dataOperationObj.deleteMovie(moviedata);
            return msg;
        }

        public DataTable selectMovies()
        {
            DataTable dtmovies = dataOperationObj.selectMovies();
            return dtmovies;
        }
    }
}
