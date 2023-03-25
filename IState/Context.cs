using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System;



// Context.cs
using System;

namespace IState
{
    public class Context
    {
        private State _state;

        public Context(State state)
        {
            TransitionTo(state);
        }

        public void TransitionTo(State state)
        {
            Console.WriteLine($"Transicionando a {state.GetType().Name}.");
            _state = state;
            _state.SetContext(this);
        }

        public void Request()
        {
            _state.Handle();
        }

        public State CurrentState => _state;
    }
}
