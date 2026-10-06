using System;
using Library.Base;

namespace Library.Player
{
    public class Playing : State
    {
        public override void OnEnter()
        {
            Console.WriteLine("Reproduciendo canción...");
        }
    }
}