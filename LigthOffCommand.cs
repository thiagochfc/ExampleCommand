namespace ExampleCommand
{
    public class LigthOffCommand : ICommand
    {

        public Ligth _ligth;
        public LigthOffCommand(Ligth ligth) => 
            _ligth = ligth;
        
        public void Executar() =>
            _ligth.Off();
    }
}