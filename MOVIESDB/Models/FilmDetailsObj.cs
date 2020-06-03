using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MOVIESDB.Models
{
    public class FilmDetailsObj
    {
        public int FilmId { get; set; }
        public int ActorId { get; set; }
        public string ActorName { get; set; }
        public int MovieId { get; set; }
        public string MovieName { get; set; }

        public int ProducerId { get; set; }
        public string ProducerName { get; set; }




    }
}