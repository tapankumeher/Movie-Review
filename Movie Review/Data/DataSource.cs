using Movie_Review.Models;
using Movie_Review.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Movie_Review.Data
{
    public class DataSource
    {
        private MovieDbContext _db;
        public DataSource(MovieDbContext context)
        {
            _db = context;
        }
        public List<Language> Languages()
        {
            return _db.Language.ToList();
        }
        public List<Language> AddLanguage(LanguageRequest request)
        {
            Language lang = new Language();
            lang.Name = request.title;
            _db.Language.Add(lang);
            _db.SaveChanges();
            return _db.Language.ToList();
        }
        public List<Movie> Movies()
        {
            return _db.Movie.ToList();
        }
        public List<Movie> Movies(int languageId)
        {
            return _db.Movie.Where(a => a.LanguageId == languageId).ToList();
        }
        public List<Movie> AddMovie(MovieRequest request)
        {
            Movie movie = new Movie
            {
                Description = request.description,
                Geners = request.gener,
                ImageURL = request.url,
                LanguageId = request.languageid,
                RealeseDate = DateTime.Now.AddDays(7),
                Name = request.title
            };

            _db.Movie.Add(movie);
            _db.SaveChanges();
            return _db.Movie.ToList();
        }
        public List<Review> Reviews()
        {
            return _db.Review.ToList();
        }
        public List<Review> Reviews(int movieId)
        {
            return _db.Review.Where(a => a.MovieId == movieId).ToList();
        }
        public List<Review> AddReview(ReviewRequest request)
        {
            Review review = new Review();
            review.MovieId = request.movieid;
            review.Comment = request.comment;
            _db.Review.Add(review);
            _db.SaveChanges();
            return _db.Review.ToList();
        }

    }
}
