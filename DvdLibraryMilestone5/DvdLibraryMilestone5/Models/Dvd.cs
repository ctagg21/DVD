using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DvdLibraryMilestone5.Models
{
    public class Dvd
    {
        public int DvdId { get; set; }
        public string Title { get; set; }
        public string RatingId { get; set; }
        public string Director { get; set; }
        [MaxLength(4)]
        public string ReleaseYear { get; set; }
        public string Notes { get; set; }



        public virtual Rating Rating { get; set; }
    }
}