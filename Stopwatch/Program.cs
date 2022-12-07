using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace StopWatch
{
    internal interface IContextBase
    {
        void PressFirstButton();
        void PressSecondButton();

    }
    internal interface IState
    {
        String TextOnFirstButton();
        String TextOnSecondButton();
        IState PressFirstButton();
        IState PressSecondButton();
    }

    namespace ConcreteState
    {
        // Actions When Clicks on Buttons at InitialScreenState
        internal class InitialScreenState : IState
        {
            public IState PressFirstButton()
            {
                Console.WriteLine("StopWatch Started");
                return new RunningState();
            }
            public IState PressSecondButton()
            {
                return new InitialScreenState();
            }

            public string TextOnFirstButton()
            {
                return "Start";
            }

            public string TextOnSecondButton()
            {
                return "Lap";
            }
        }

        // Actions When Clicks on Buttons at LappingState

        internal class LappingState : IState
        {
            public IState PressFirstButton()
            {
                Console.WriteLine("StopWatch Stoped");
                return new DisplayingResultState();
            }

            public IState PressSecondButton()
            {
                Console.WriteLine("StopWatch Lap");
                return new LappingState();
            }

            public string TextOnFirstButton()
            {
                return "Stop";
            }

            public string TextOnSecondButton()
            {
                return "Lap";
            }
        }

        // Actions When Clicks on Buttons at RunningState
        internal class RunningState : IState
        {
            public IState PressFirstButton()
            {
                Console.WriteLine("StopWatch Started");
                return new InitialScreenState();
            }

            public IState PressSecondButton()
            {
                Console.WriteLine("StopWatch Lap");
                return new LappingState();
            }

            public string TextOnFirstButton()
            {
                return "Stop";
            }

            public string TextOnSecondButton()
            {
                return "Lap";
            }
        }

        // Actions When Clicks on Buttons at DisplayingResultState
        internal class DisplayingResultState : IState
        {
            public IState PressFirstButton()
            {
                Console.WriteLine("StopWatch ReStarted");
                return new RunningState();
            }

            public IState PressSecondButton()
            {
                Console.WriteLine("StopWatch Reset");
                return new InitialScreenState();
            }

            public string TextOnFirstButton()
            {
                return "Start";
            }

            public string TextOnSecondButton()
            {
                return "Reset";
            }
        }
    }

    internal class Context : IContextBase
    {
        public Context(IState state)
        {
            State = state;
        }
        public IState State { get; set; }
        private void DisplayText()
        {
            Console.WriteLine("Current State[{0}], Button1[{1}], Button2[{2}]", State.GetType().Name, State.TextOnFirstButton(), State.TextOnSecondButton());
        }
        public void PressFirstButton()
        {
            State = State.PressFirstButton();
            DisplayText();
        }
        public void PressSecondButton()
        {
            State = State.PressSecondButton();
            DisplayText();
        }
    }
}
