using System;

namespace ExampleCommand
{
    public class Ligth
    {
        public string Local { get; private set; }

        public Ligth(string local) 
            => Local = local;
        public void On() =>
            Console.WriteLine($"Ligando a luz = {Local}!");

        public void Off() =>
            Console.WriteLine($"Desligado a luz = {Local}!");
    }
}