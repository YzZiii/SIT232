using System;

namespace SimpleReactionMachine
{
    public class SimpleReactionController : IController
    {   
        // Instance variables and properties
        private IGui _gui;
        private IRandom _rng;
        private State _state;
        private double _ticks;

        public IGui Gui => _gui;
        public IRandom Rng => _rng;
        public State State => _state;
        public double Ticks
        {
            get => _ticks;
            set => _ticks = value;
        }
        /// <summary>
        /// Connects the controller to the Gui
        /// and Random Number Generator
        /// </summary>
        /// <param name="gui">IGui concraete implementation</param>
        /// <param name="rng">IRandom concreate implementation</param>
        public void Connect(IGui gui, IRandom rng)
        {
            _gui = gui;
            _rng = rng;
            Init();
        }
        /// <summary>
        /// Initialises the state of
        /// the controller
        ///  at the start of the program
        /// </summary>
        public void Init()
        {
            _state = new OnState(this);
        }
        /// <summary>
        /// Inserted coin event handle
        /// </summary>
       public void CoinInserted()
        {
            _state.CoinInserted();
        }
        /// <summary>
        /// Go or Stop pressed event handler
        /// </summary>
        public void GoStopPressed()
        {
            _state.GoStopPressed();
        }
        /// <summary>
        /// Tick event handler
        /// </summary>
       public void Tick()
        {
            _state.Tick();
        }
        /// <summary>
        /// Sets the state of the controller to the desired state
        /// </summary>
        /// <param name="state">The new state to transition to</param>
        public void SetState(State state)
        {
            _state = state;
        }
    }
    /// <summary>
    /// All the members are public by default
    /// </summary>
    public interface State
    {
        void CoinInserted();
        void GoStopPressed();
        void Tick();
    }
    /// <summary>
    /// State of the game when it is waiting for a coin to be inserted
    /// </summary>
    public class OnState : State
    {
        private SimpleReactionController _controller;

        public OnState(SimpleReactionController controller)
        {
            _controller = controller;
            _controller.Gui.Init();
            _controller.Gui.SetDisplay("Insert coin");
        }
       public void CoinInserted()
       {
            _controller.SetState(new ReadyState(_controller));
        }

        public void GoStopPressed() { return; }

       public void Tick() { return; }
    }
    /// <summary>
    /// State of the game when a coin has been inserted
    /// but the game is not yet started
    /// </summary>
    public class ReadyState : State
    {
        private SimpleReactionController _controller;

        public ReadyState(SimpleReactionController controller)
        {
            _controller = controller;
            _controller.Gui.SetDisplay("Press GO!");
        }

        public void CoinInserted() { return; }

        public void GoStopPressed()
        {
            _controller.SetState(new WaitingState(_controller));
        }

        public void Tick() { return; }
    }
    /// <summary>
    /// State of the game when the game has started 
    /// and it is waiting for the random time
    /// </summary>
    public class WaitingState : State
   {
       private SimpleReactionController _controller;
       private int _waitTime;

        public WaitingState(SimpleReactionController controller)
       {
            _controller = controller;
            _waitTime = _controller.Rng.GetRandom(100, 250);
           _controller.Ticks = 0;
           _controller.Gui.SetDisplay("Wait...");
        }

        public void CoinInserted() { return; }

        public void GoStopPressed()
        {
            _controller.SetState(new OnState(_controller));
        }

        public void Tick()
        {
           _controller.Ticks++;
           if (_controller.Ticks >= _waitTime)
           {
               _controller.SetState(new RunState(_controller));
            }
        }
    }
    /// <summary>
    /// State of the game when te timer is counting and it is 
    /// waiting for the user to react by pressing the go or stop buttion
    /// </summary>
   public class RunState : State
    {
        private SimpleReactionController _controller;
        private int _gameTime;

        public RunState(SimpleReactionController controller)
        {
            _controller = controller;
            _gameTime = 200;
           _controller.Ticks = 0;            
            _controller.Gui.SetDisplay($"{(_controller.Ticks / 100):0.00}");
       }
       public void CoinInserted() { return; }

        public void GoStopPressed()
        {
            _controller.SetState(new GameOverState(_controller));
        }

        public void Tick()
        {
            _controller.Ticks++;
            _controller.Gui.SetDisplay($"{(_controller.Ticks / 100):0.00}");
            if (_controller.Ticks >= _gameTime)
           {
                _controller.SetState(new GameOverState(_controller));
           }
        }
    }
    /// <summary>
    /// State of the game when the time
    /// has expired or the user reacted
    /// </summary>
    public class GameOverState : State
    {
        private SimpleReactionController _controller;
        private int _displayTime;

        public GameOverState(SimpleReactionController controller)
        {
            _controller = controller;
            _displayTime = 300;
            _controller.Gui.SetDisplay($"{(_controller.Ticks / 100):0.00}");
            _controller.Ticks = 0;
        }

       public void CoinInserted() { return; }

        public void GoStopPressed()
        {
            _controller.SetState(new OnState(_controller));
        }

        public void Tick()
        {
            _controller.Ticks++;
            if (_controller.Ticks >= _displayTime)
           {
               _controller.SetState(new OnState(_controller));
           }
       }
   }
}