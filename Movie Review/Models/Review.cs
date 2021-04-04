using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Movie_Review.Models
{
    public class Review
    {
        public int Id { get; set; }
        public string Comment { get; set; }
        public int MovieId { get; set; }
    }
}
