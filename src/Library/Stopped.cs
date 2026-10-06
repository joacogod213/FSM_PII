using System;
using Library.Base;

namespace Library.Player
{
    public class Stopped : State
    {
        public override void OnEnter()
        {
            Console.WriteLine("Reproductor detenido.");
        }
    }
}