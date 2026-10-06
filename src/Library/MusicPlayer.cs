using Library.Base;

namespace Library.Player
{
    public class MusicPlayer
    {
        private readonly StateMachine stateMachine = new StateMachine();

        private readonly InputSymbol play = new PlayingSymbol();
        private readonly InputSymbol pause = new PausedSymbol();
        private readonly InputSymbol stop = new StoppedSymbol();

        public MusicPlayer()
        {
            var stopped = new Stopped();
            var playing = new Playing();
            var paused = new Paused();

            stopped.AddTransition(play, playing);
            playing.AddTransition(pause, paused);
            playing.AddTransition(stop, stopped);
            paused.AddTransition(play, playing);
            paused.AddTransition(stop, stopped);

            // El primer estado agregado (Stopped) queda como estado inicial.
            stateMachine.AddState(stopped);
            stateMachine.AddState(playing);
            stateMachine.AddState(paused);
        }

        public State CurrentState => stateMachine.CurrentState;

        public bool Play() => stateMachine.ProcessInput(play);
        public bool Pause() => stateMachine.ProcessInput(pause);
        public bool Stop() => stateMachine.ProcessInput(stop);
    }
}