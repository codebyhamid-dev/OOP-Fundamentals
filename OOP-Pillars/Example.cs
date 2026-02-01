using System;

namespace OOP_Pillars
{
    abstract class Example
    {
        public string Id { get; set; }
        public string Name { get; set; }

        public Example(string id, string name)
        {
            Id = id;
            Name = name;
        }

        public abstract void Info();
    }

    class Example1 : Example
    {
        public string Desp { get; set; }

        public Example1(string desp, string id, string name) : base(id, name)
        {
            Desp = desp;
        }

        public override void Info()
        {
            Console.WriteLine($"{Id}, {Name}, {Desp}");
        }
    }
}