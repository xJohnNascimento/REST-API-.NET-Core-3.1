using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Commander.Dtos
{
    public class CommandCreateDto
    {
        [Required]
        public string FirstField { get; set; }

        [Required]
        public string SecondField { get; set; }

        [Required]
        public string ThirdField { get; set; }
    }
}
