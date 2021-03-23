namespace ExampleCommand
{
    public class LigthOnCommand : ICommand
    {

        public Ligth _ligth;
        public LigthOnCommand(Ligth ligth) => 
            _ligth = ligth;
        
        public void Executar() =>
            _ligth.On();
    }
}