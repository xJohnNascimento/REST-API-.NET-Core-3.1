using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Commander.Dtos
{
    public class CommandReadDto
    {
        public int Id { get; set; }
        public string FirstField { get; set; }
        public string SecondField { get; set; }
    }
}
