using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Video_Videolocadora.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public String Name { get; set; }

        public List<String> chingamentos { get; set; }

        public Movie()
        {
            this.chingamentos = new List<String>();
        }

    }
}