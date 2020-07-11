using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Smtih_Midterm.Models
{
    public class Info
    {
        [Key]
        public int HouseId { get; set; }

        public int RegionId { get; set; }

        public Region Region { get; set; }

        public string Address { get; set; }

        public int Price { get; set; }

        public int BedRCount { get; set; }

        public int SqFt { get; set; }

        public int BathCount { get; set; }

        public int Year { get; set; }

        public string CodeOut { get; set; }

        public string CodeIn { get; set; }
    }
}
