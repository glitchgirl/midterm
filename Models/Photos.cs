using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Smtih_Midterm.Models
{
    public class Photos
    {
        [Key]
        public int PhotoFilter { get; set; }

        public string Pic1 { get; set; }
        public string Pic2 { get; set; }
        public string Pic3 { get; set; }
    }
}
