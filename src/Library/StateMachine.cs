using System.Collections.Generic;

namespace Library.Base
{
    public class StateMachine
    {
        private readonly List<State> states = new List<State>();

        public State CurrentState { get; private set; }

        public void AddState(State state)
        {
            states.Add(state);
            if (CurrentState == null)
            {
                CurrentState = state;
                CurrentState.OnEnter();
            }
        }

        public bool ProcessInput(InputSymbol input)
        {
            if (CurrentState == null)
            {
                return false;
            }

            var nextState = CurrentState.GetNextState(input);
            if (nextState == null)
            {
                return false;
            }

            CurrentState.OnExit();
            CurrentState = nextState;
            CurrentState.OnEnter();
            return true;
        }

        public bool ProcessInputs(InputSymbol[] inputs)
        {
            bool allValid = true;
            foreach (var input in inputs)
            {
                if (!ProcessInput(input))
                {
                    allValid = false;
                }
            }
            return allValid;
        }
    }
}