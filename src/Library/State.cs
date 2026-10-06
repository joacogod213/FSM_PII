using System.Collections.Generic;

namespace Library.Base
{
    public class State
    {
        private readonly List<TransitionFunction> transitions = new List<TransitionFunction>();

        public void AddTransition(InputSymbol input, State nextState)
        {
            transitions.Add(new TransitionFunction(input, nextState));
        }

        public State GetNextState(InputSymbol input)
        {
            foreach (var transition in transitions)
            {
                if (transition.IsTriggeredBy(input))
                {
                    return transition.NextState;
                }
            }
            return null;
        }

        public virtual void OnEnter() { }
        public virtual void OnExit() { }
    }
}