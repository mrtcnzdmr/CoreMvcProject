using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CoreMvcProject.Models
{
    public class Unit
    {
        [Key]
        public int UnitId { get; set; }
        public string UnitName { get; set; }
        public IList<Personal> Personals { get; set; }
    }
}
