using System;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    class Client
    {
        private AbstractProductA abstractProductA;
        private AbstractProductB abstractProductB;
        public Client(AbstractFactory factory)
        {
            abstractProductA = factory.CreateProductA();
        }
    }

    public abstract class AbstractFactory
    {
        public abstract AbstractProductA CreateProductA();
        public abstract AbstractProductB CreateProductB();
    }

    public class ConcreteFactory1 : AbstractFactory//
    {
        public override AbstractProductA CreateProductA()
        {
            return new ConcreteProductA1();
        }
        public override AbstractProductB CreateProductB()
        {
            return new ConcreteProductB1();
        }
    }


    public abstract class AbstractProductA { }//інтерфейс для класів, об'єкти яких будуть створювати
    public abstract class AbstractProductB { }//інтерфейс для класів, об'єкти яких будуть створювати

    class ConcreteProductA1 : AbstractProductA { }//клас, об'єкти якого будуть створюватись
    class ConcreteProductA2 : AbstractProductA { }//клас, об'єкти якого будуть створюватись
    class ConcreteProductB1 : AbstractProductB { }//клас, об'єкти якого будуть створюватись
    class ConcreteProductB2 : AbstractProductB { }//клас, об'єкти якого будуть створюватись
}
