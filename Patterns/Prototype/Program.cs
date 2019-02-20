using System;

namespace Prototype
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
    #region Example realization Prototype
    public abstract class Prototype
    {
        public int Id { get; set; }
        public Prototype(int id)
        {
            Id = id;
        }
        public abstract Prototype Clone();
    }

    class ConcetePrototype1 : Prototype
    {
        public ConcetePrototype1(int id): base (id)
        {
        }
        public override Prototype Clone()
        {
            return new ConcetePrototype1(Id);
        }
    }

    class ConcetePrototype2 : Prototype
    {
        public ConcetePrototype2(int id) : base(id)
        {
        }
        public override Prototype Clone()
        {
            return new ConcetePrototype2(Id);
        }
    }
    #endregion
}
