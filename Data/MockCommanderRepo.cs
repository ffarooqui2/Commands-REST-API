using Commander.Models;

namespace Commander.Data
{
    // Implements the CommanderRepo Interface
    public class MockCommanderRepo : ICommanderRepo
    {
        public void CreateCommand(Command cmd)
        {
            throw new NotImplementedException();
        }

        public void DeleteCommand(Command cmd)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Command> GetAllCommands()
        {
            var commands = new List<Command>
            {
                new() { Id=0,HowTo="Boil an egg",Line="Boil water",Platform="Kettle & Pan"},
                new() { Id=1,HowTo="Cut Bread",Line="Get a knife",Platform="Chopping Board"},
                new() { Id=2,HowTo="Make a cup of tea",Line="Place tea bag in cup",Platform="Kettle & Cup"}
            };

            return commands;
        }

        public Command GetCommandById(int id)
        {
            return new Command
            {
                Id=0,
                HowTo="Boil an egg",
                Line="Boil water",
                Platform="Kettle & Pan"
            };
        }

        public bool SaveChanges()
        {
            throw new NotImplementedException();
        }

        public void UpdateCommand(Command cmd)
        {
            throw new NotImplementedException();
        }
    }
}