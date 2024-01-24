using Commander.Models;

namespace Commander.Data
{
    // implementation class  using a DB Context
    public class SqlCommanderRepo : ICommanderRepo
    {
        private readonly CommanderContext _context;

        // Constructor
        public SqlCommanderRepo(CommanderContext context)
        {
            _context = context;
        }

        public void CreateCommand(Command cmd)
        {
            ArgumentNullException.ThrowIfNull(cmd);
            _context.Add(cmd);
        }

        public void DeleteCommand(Command cmd)
        {
            ArgumentNullException.ThrowIfNull(cmd);
            _context.Commands.Remove(cmd);
        }

        public IEnumerable<Command> GetAllCommands()
        {
            return _context.Commands.ToList();
        }

        public Command? GetCommandById(int id)
        {
            return _context.Commands.FirstOrDefault(p => p.Id == id);
        }

        public bool SaveChanges()
        {
            return _context.SaveChanges() >= 0;
        }

        public void UpdateCommand(Command cmd)
        {
            // Nothing
        }
    }
}