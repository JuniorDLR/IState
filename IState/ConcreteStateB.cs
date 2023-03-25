using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

// ConcreteStateB.cs
namespace IState
{
    public class ConcreteStateB : State
    {
        public override void Handle()
        {
            // Lógica para manejar el estado B
            Console.WriteLine("Manejando el estado B.");
            _context.TransitionTo(new ConcreteStateA());
        }
    }
}




