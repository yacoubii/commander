using Commander.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Commander.Data
{
    public class MockCommanderRepo : ICommanderRepo
    {
        public void CreateCommand(Command cmd)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Command> GetAllCommands()
        {
            var commands = new List<Command>
            {
                new Command(0,"Boil an egg", "Boil water", "pan" ),
                new Command(1,"Boil an egg1", "Boil water1", "pan1" )
            };
            return commands;
        }
  

        public Command GetCommandById(int Id)
        {
            return new Command(0,"Boil an egg", "Boil water", "pan" );
        }

        public bool SaveChanges()
        {
            throw new NotImplementedException();
        }
    }
}
