using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MOVIESDB.Models
{
    public class Movies
    {
        public int MovieId { get; set; }
        public string Name { get; set; }
        public string Plot { get; set; }
        public DateTime? YoR { get; set; }
        public string Poster { get; set; }
    }
}