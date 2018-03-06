using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace March5.Models
{
    public class SuggestionModel
    {
        [Key]
        public int RecordNum { get; set; }


        public string Movie { get; set; }
        public string MovieStar { get; set; }
        public int ReviewStars { get; set; }
    }
}