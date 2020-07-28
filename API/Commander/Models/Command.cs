using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Commander.Models
{
    public class Command
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(250)]
        public string FirstField { get; set; }

        [Required]
        public string SecondField { get; set; }

        [Required]
        public string ThirdField { get; set; }
    }
}
