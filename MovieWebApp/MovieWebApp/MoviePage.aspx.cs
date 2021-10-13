using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.Entity;
using MovieData;

namespace MovieWebApp
{
    public partial class MoviePage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_Save_Click(object sender, EventArgs e)
        {
            MovieDbEntities movieDbEntities = new MovieDbEntities();
            movie moviedata = new movie();
            moviedata.Name = txtMovieName.Text;
            moviedata.MovieType = txtMovieType.Text;
            moviedata.MovieDesc = txtMovieDesc.Text;
            movieDbEntities.movies.Add(moviedata);
            movieDbEntities.SaveChanges();
            lblResult.Text = "Record added..";

        }

        protected void btnEdit_Click(object sender, EventArgs e)
        {
            MovieDbEntities movieDbEntities = new MovieDbEntities();
            var result = movieDbEntities.movies.ToList().Find(obj => obj.Id == Convert.ToInt32(txtMovieId.Text));

            txtMovieName.Text = result.Name;
            txtMovieType.Text = result.MovieType;
            txtMovieDesc.Text = result.MovieDesc;
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            MovieDbEntities movieDbEntities = new MovieDbEntities();
            movie moviedata = new movie();
            moviedata.Name = txtMovieName.Text;
            moviedata.MovieType = txtMovieType.Text;
            moviedata.MovieDesc = txtMovieDesc.Text;
            moviedata.Id = Convert.ToInt32(txtMovieId.Text);
            movieDbEntities.Entry(moviedata).State = EntityState.Modified;
            movieDbEntities.SaveChanges();
            lblResult.Text = "Updated";

        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            MovieDbEntities movieDbEntities = new MovieDbEntities();
            movie moviedata = new movie();
            moviedata.Name = txtMovieName.Text;
            moviedata.MovieType = txtMovieType.Text;
            moviedata.MovieDesc = txtMovieDesc.Text;
            moviedata.Id = Convert.ToInt32(txtMovieId.Text);
            movieDbEntities.Entry(moviedata).State = EntityState.Deleted;
            movieDbEntities.SaveChanges();
            lblResult.Text = "Deleted";
        }
    }
}