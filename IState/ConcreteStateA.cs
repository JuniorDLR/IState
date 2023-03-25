using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using IState;



namespace IState
{
    public class ConcreteStateA : State
    {
        public override void Handle()
        {
            // Lógica para manejar el estado A
            Console.WriteLine("Manejando el estado A.");
            _context.TransitionTo(new ConcreteStateB());
        }
    }
}


