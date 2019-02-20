using System;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            Computer computer = new Computer();
            computer.Launch("windows");
            Console.WriteLine($"{computer.operationSystem.Name}");

            computer.operationSystem = OperationSystem.getInstance("10.1");
            Console.WriteLine(computer.operationSystem.Name);
            Console.ReadLine();
        }
    }

    class Computer
    {
        public OperationSystem operationSystem { get; set; }
        public void Launch(string osName)
        {
            operationSystem = OperationSystem.getInstance(osName);
        }
    }

    public class OperationSystem
    {
        private static OperationSystem operationSystem;

        public string Name { get; set; }
        protected OperationSystem(string name)
        {
            Name = name;
        }

        public static OperationSystem getInstance(string name)
        {
            if (operationSystem == null)
            {
                operationSystem = new OperationSystem(name);
            }
            return operationSystem;
        }
    }
}
