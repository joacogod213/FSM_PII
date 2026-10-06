namespace Library.Base
{
    public class TransitionFunction
    {
        public InputSymbol TriggerInput { get; }
        public State NextState { get; }

        public TransitionFunction(InputSymbol triggerInput, State nextState)
        {
            TriggerInput = triggerInput;
            NextState = nextState;
        }

        public bool IsTriggeredBy(InputSymbol input)
        {
            return TriggerInput == input;
        }
    }
}