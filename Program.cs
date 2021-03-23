using System;

namespace ExampleCommand
{
    class Program
    {
        static void Main(string[] args)
        {
            var invoker = new Invoker();

            var ligth = new Ligth("Cozinha");
            var ligthOnCommand = new LigthOnCommand(ligth);
            var ligthOffCommand = new LigthOffCommand(ligth);

            invoker.AddCommand(ligthOnCommand);
            invoker.AddCommand(ligthOffCommand);

            invoker.Executar();
        }
    }
}
