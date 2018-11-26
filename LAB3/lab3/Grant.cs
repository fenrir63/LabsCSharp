using System;

namespace lab3
{
    public class Grant
    {
        
        private IState _state = new Created();
        public void SetState(IState newState)
        {
            _state = newState;
        }

        public void PrintState()
        {
            Console.WriteLine("Current state : " + _state.GetState());
        }

        public void ChangeState()
        {
            PrintState();
            var index = 0;
            var states = _state.GetNextState();
            if (states == null)
            {
                Console.WriteLine("You can't change grant state.");
                
            }
            else
            {
                foreach (var state in states)
                {
                    Console.WriteLine("#" + (index + 1) + " change to " + state.GetState());
                    index++;
                }
                
                do
                {
                    index = 0;
                
                    Console.Write("Choose the index of next state to change : ");
                    index = Convert.ToInt32(Console.ReadLine());

                } while (index > states.Count || index < 0);

                SetState(states[index - 1]);
            }

        }
        
    }
}