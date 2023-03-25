using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

// State.cs
namespace IState
{
    public abstract class State
    {
        protected Context _context;

        public void SetContext(Context context)
        {
            _context = context;
        }

        public abstract void Handle();
    }
}


