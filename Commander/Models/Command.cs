using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Commander.Models
{
    public class Command
    {
        public Command(int Id, string howTo, string line, string platform)
        {
            this.Id = Id;
            this.howTo = howTo;
            this.line = line;
            this.platform = platform;
        }

        public Command()
        {
        }

        [Key]
          public int Id { get; set; }

          [Required]
          public string howTo { get; set; }
       
          [Required]
          public string line { get; set; }

          [Required]
          public string platform { get; set; }
    }
}
