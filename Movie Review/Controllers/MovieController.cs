using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Movie_Review.Data;
using Movie_Review.Models;
using Movie_Review.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Movie_Review.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class MovieReview : ControllerBase
    {

        
        private DataSource dataConn;
        public MovieReview(MovieDbContext context)
        {
            
            dataConn = new DataSource(context);
        }
        [HttpGet("Language")]
        public List<Language> Languages()
        {
            return dataConn.Languages();
        }
        [HttpPost("Languages")]
        public List<Language>Addlanguages(LanguageRequest request)
        {
        return dataConn.AddLanguage(request);   
        }
        [HttpGet("Movies")]
        public List<Movie> Movies()
        {
            return dataConn.Movies();
        }
       [HttpGet("Movies By Language")]
       public List<Movie> Movies(int languageid)
        {
            return dataConn.Movies(languageid);
        }
        [HttpPost("AddMovies")]
        public List<Movie> AddMovie(MovieRequest request)
        {
            return dataConn.AddMovie(request);
        }
        [HttpGet("Review")]
        public List<Review> Reviews()
        {
            return dataConn.Reviews();
        }
        [HttpGet("Review By Movies")]
        public List<Review> Reviews(int movieid)
        {
            return dataConn.Reviews(movieid);
        }
        [HttpPost("AddReview")]
        public List<Review>AddReview(ReviewRequest request)
        {
            var review = dataConn.AddReview(request);
            return review;
        }
    }
}
