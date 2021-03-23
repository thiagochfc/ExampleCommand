using System.Collections.Generic;

namespace ExampleCommand
{
    public class Invoker
    {
        public List<ICommand> _commands;

        public Invoker()
        {
            _commands = new List<ICommand>(1)
            {
                new NoCommand()
            };
        }

        public void AddCommand(ICommand command)
        {
            _commands.Add(command);
        }

        public void RemoveCommand(ICommand command)
        {
            _commands.Remove(command);
        }

        public void Executar()
        {
            foreach (var command in _commands)
                command.Executar();
        }
    }
}