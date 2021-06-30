using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Commander.Dtos
{
    public class CommandReadDto
    {
        public CommandReadDto(int Id, string howTo, string line)
        {
            this.Id = Id;
            this.howTo = howTo;
            this.line = line;
        }

        public int Id { get; set; }

        public string howTo { get; set; }

        public string line { get; set; }

    }
}
