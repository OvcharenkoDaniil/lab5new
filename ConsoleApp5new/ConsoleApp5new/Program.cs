using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5
{
    interface ITennis
    {
        int Field(int a, int b);
        
    }
    abstract class Tennis
    {
        public virtual int Field(int a, int b)
        {
            int square = a * b;
            Console.WriteLine("Tennis is kind of sport");
            Console.Write("Area of field is ");
            return square;
        }
        public string Kind {get; set;}
        public Tennis()
        {
            Kind = "Sport";
        }
        public abstract override string ToString();
    }
    class Inventory : Tennis, ITennis
    {
        public Inventory() : base()
        {
            Console.WriteLine("This is Inventory!");
        }
        public override int Field(int a, int b)
        {
            int cube = a * b * b;
            Console.WriteLine("Tennis is kind of sport(C)");
            return cube;
        }
        int ITennis.Field(int a, int b)
        {
            int square = a * b;
            Console.WriteLine("Tennis is kind of sport(I)");
            return square;
        }
        public override string ToString()
        {
            Console.WriteLine("Object is Inventory");
            return $"Kind: {Kind}";
        }

    }
    class Bench : Inventory
    {
        public string color { get; set; }
        public Bench(string color) : base()
        {
            this.color = color;
        }
        public override string ToString()
        {
            Console.WriteLine("Object is Bench");
            return $"Kind: {Kind} \n Color: {color}";
        }
    }
    class Bars : Inventory
    {
        public string color { get; set; }
        public Bars(string color) : base()
        {
            this.color = color;
        }
        public override string ToString()
        {
            Console.WriteLine("Object is Bars");
            return $"Kind: {Kind} \n Color: {color}";
        }
    }
    class Ball : Inventory
    {
        public string color { get; set; }
        public int radius { get; set; }
        public const double pi = 3.14;
        public Ball(string color, int radius) : base()
        {
            this.color = color;
            this.radius = radius;
        }
        public virtual double Volume()
        {
            double volume = 4 / 3 * pi * radius * radius * radius;
            return volume;
        }
        public override string ToString()
        {
            Console.WriteLine("Object is Ball");
            return $"Kind: {Kind} \n Color: {color}";
        }
    }
    class Mats : Inventory
    {
        public string color { get; set; }
        public Mats(string color) : base()
        {
            this.color = color;
        }
        public override string ToString()
        {
            Console.WriteLine("Object is Mats");
            return $"Kind: {Kind} \n Color: {color}";
        }
    }
    
    
    class Program
    {
        static void Main(string[] args)
        {
            Tennis a1 = new Inventory();
            
            Console.ReadKey();
        }
    }
}