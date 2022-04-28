using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CoreMvcProject.Models
{
    public class Personal
    {
        [Key]
        public int PersonalId { get; set; }
        public string PersonalFirstName { get; set; }
        public string PersonalLastName { get; set; }
        public string PersonalCity { get; set; }
        public int UnitId { get; set; }
        public Unit Unit { get; set; }
    }
}
