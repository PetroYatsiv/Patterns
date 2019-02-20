using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Method
{
    class Program
    {
        static void Main(string[] args)
        {
            Developer panelDevloper = new PanelHouseDeveloper();
            panelDevloper.BuildHouse();
            panelDevloper = new WoodHouseDeveloper();
            panelDevloper.BuildHouse();
            Console.ReadLine();
        }
    }
    #region first implementation
    abstract class Product
    {
    }
    abstract class Creator
    {
        public abstract Product FactoryMthod();
    }

    class ConcreteProductA : Product
    {
    }

    class ConcreteProductB : Product
    {
    }

    class ConcreteCreatorA : Creator
    {
        public override Product FactoryMthod()
        {
            return new ConcreteProductA();
        }
    }

    class ConcreteCreatorB : Creator
    {
        public override Product FactoryMthod()
        {
            return new ConcreteProductB();
        }
    }
    #endregion

    #region second implementation

    public abstract class Developer
    {
        abstract public House BuildHouse();
    }

    public class PanelHouseDeveloper : Developer
    {
        public override House BuildHouse()
        {
            return new PanelHouse();
        }
    }

    public class WoodHouseDeveloper : Developer
    {
        public override House BuildHouse()
        {
            return new WoodHouse();
        }
    }

    public abstract class House
    {
    }

    public class PanelHouse : House
    {
        public PanelHouse()
        {
            Console.WriteLine("panel house builded.");
        }
    }
    public class WoodHouse : House
    {
        public WoodHouse()
        {
            Console.WriteLine("Wood house build");
        }
    }

    #endregion
}
