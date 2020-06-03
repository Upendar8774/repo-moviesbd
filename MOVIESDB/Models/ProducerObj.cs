using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MOVIESDB.Models
{
    public class ProducerObj
    {
        public int ProducerId { get; set; }
        public string Name { get; set; }
        public string Sex { get; set; }
        public DateTime? Dob { get; set; }
        public string Bio { get; set; }
    }
}