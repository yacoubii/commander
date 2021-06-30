using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Commander.Dtos
{
    public class CommandCreateDto
    {
        public CommandCreateDto(string howTo, string line, string platform)
        {
            this.howTo = howTo;
            this.line = line;
            this.platform = platform;
        }
        public CommandCreateDto()
        {
        }


        [Required]
        public string howTo { get; set; }

        [Required]
        public string line { get; set; }

        [Required]
        public string platform { get; set; }
    }
}
