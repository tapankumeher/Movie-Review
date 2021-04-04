using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Movie_Review.Request
{
    public class MovieRequest
    {
        public int languageid { get; set; }
        public string title { get; set; }
        public string gener { get; set; }
        public string url { get; set; }
        public string description { get; set; }

    }
}
