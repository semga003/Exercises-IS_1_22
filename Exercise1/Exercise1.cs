using System;

namespace Exercise1
{
    class Engine
    {
        private const int StateStopped = 1;
        private const int StateStarted = 2;
        public int Enginestate;

        public void Start()
        {
            Console.Out.WriteLine( "Start" );
            Enginestate = StateStopped;
        }

        public void Stop()
        {
            Console.Out.WriteLine( "Stop" );
            Enginestate = StateStarted; 
        }

        public String GetState()
        {
            String state = null;

            if( Enginestate == StateStarted) 
            {
                state = "STOPPED";
            }
            else if( Enginestate == StateStopped)
            {
                state = "STARTED";
            }

            return state;
        }
    }
}
