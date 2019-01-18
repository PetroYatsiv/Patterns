using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns
{
    class Program
    {
        static void Main(string[] args)
        {
            Invoker invoker = new Invoker();
            Receiver receiver = new Receiver();
            ConcreteCommand command = new ConcreteCommand(receiver);

            invoker.SetCommand(command);
            invoker.Run();


            Pult pult = new Pult();
            Tv tv = new Tv();
            //pult.SetCommand(new TvOnConcreteCommand(tv));
            pult.PressButtonOn();//execute tv command on
            pult.PrssButtonOff();//undo command on

            pult.SetCommand(new TvOffConcreteCommand(tv));
            pult.PressButtonOn();//execute tv command off
            pult.PrssButtonOff();//undo command off
        }
    }

    #region first example
    abstract class Command
    {
        public abstract void Execute();
        public abstract void Undo();
    }

    class ConcreteCommand : Command
    {
        Receiver receiver;
        public ConcreteCommand(Receiver receiver)
        {
            this.receiver = receiver;
        }
        public override void Execute()
        {
            receiver.Operation();
        }

        public override void Undo()
        {

        }
    }

    class Receiver
    {
        public void Operation()
        {

        }
    }

    class Invoker
    {
        Command command;
        public void SetCommand(Command command)
        {
            this.command = command;
        }

        public void Run()
        {
            command.Execute();
        }

        public void Cancel()
        {
            command.Undo();
        }
    }
    #endregion


    #region second example
    interface ICommand
    {
        void Execute();
        void Undo();
    }

    //receiver class
    class Tv
    {
        public void On() { }
        public void Off() { }

    }

    class Pult
    {
        ICommand command;
        public Pult()
        { }

        public void SetCommand(ICommand command)
        {
            this.command = command;
        }

        public void PressButtonOn()
        {
            command.Execute();
        }

        public void PrssButtonOff()
        {
            command.Undo();
        }
    }

    class TvOnConcreteCommand : ICommand
    {
        Tv tv;
        public TvOnConcreteCommand(Tv tv)
        {
            this.tv = tv;
        }

        public void Execute()
        {
            tv.On();
        }

        public void Undo()
        {
            tv.Off();
        }
    }

    class TvOffConcreteCommand : ICommand
    {
        Tv tv;
        public TvOffConcreteCommand(Tv tv)
        {
            this.tv = tv;
        }
        public void Execute() //execute Off command
        {
            tv.On();
        }

        public void Undo()// Undo Off command
        {
            tv.Off();
        }
    }


    #endregion
}
