using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Smtih_Midterm.Models
{
    public class Region
    {
        [Key]
        public int RegionId { get; set; }

        public string Name { get; set; }
    }
}
