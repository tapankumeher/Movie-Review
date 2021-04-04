using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Movie_Review.Request
{
    public class ReviewRequest
    {
        public int movieid { get; set; }
        public string comment { get; set; }
    }
}
