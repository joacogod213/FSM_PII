using System;
using Library.Base;

namespace Library.Player
{
    public class Paused : State
    {
        public override void OnEnter()
        {
            Console.WriteLine("Reproducción en pausa.");
        }
    }
}