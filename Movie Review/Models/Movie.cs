using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Movie_Review.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime RealeseDate { get; set; }
        public string Geners { get; set; }
        public int LanguageId { get; set; }
        public string Description { get; set; }
        public string ImageURL { get; set; }
    }
}
