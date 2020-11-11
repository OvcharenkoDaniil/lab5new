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
    //первый уровень
    abstract class Tennis
    {
        public virtual int Field(int a, int b)
        {
            int square = a * b;
            Console.WriteLine("Tennis is kind of sport");
            Console.Write("Area of field is ");
            return square;
        }
        private string kind;
        public string Kind { get; set; }
        public Tennis()
        {
            Kind = "Sport";
        }
        public abstract override string ToString();
    }
    //второй уровень
    class Inventory : Tennis, ITennis
    {
        public Inventory() : base()
        {
            Console.WriteLine("Inventory is the array of finished goods or goods used in production held by a company");
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
    //третий уровень
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
    //четвертый уровень, закрытый
    sealed class BallOfBasket : Ball
    {
        public static string sport { get; set; }
        public BallOfBasket(string color, int radius) : base(color, radius)
        {
            this.color = color;
            this.radius = radius;
            sport = "Basketball";
        }
        public override double Volume()
        {
            double volume = 4 / 3 * pi * radius * radius * radius + 1.67;
            return volume;
        }
        public override string ToString()
        {
            Console.WriteLine("Object is BallOfBasket");
            return $"Kind: {Kind} \n Color: {color} \n Sport: {sport}";
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }
            if (obj.GetType() != this.GetType())
            {
                return false;
            }
            BallOfBasket temp = (BallOfBasket)obj;
            return temp.color == this.color && temp.radius == this.radius;
        }

        public override int GetHashCode()
        {
            double tmp = (Math.Pow((double)radius, (double)2)) + (Math.Pow((double)radius, (double)2)) + (Math.Pow((double)radius, (double)2)) * 1000;
            return (int)tmp;
        }
    }
    class Print
    {
        public static string sport { get; set; }
        public string color { get; set; }
        public int radius { get; set; }
        public Print(string color, int radius)
        {
            this.color = color;
            this.radius = radius;
            sport = "Basketball";
        }
        public static void IAmPrinting(ITennis obj)
        {
            Console.WriteLine(obj.ToString());
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Tennis a1 = new Inventory();
            ITennis a2 = new Inventory();
            Console.WriteLine($"It is class'es method: {a1.Field(4, 5)}");
            Console.WriteLine($"It is Interface: {a2.Field(4, 5)}");
            Console.WriteLine();

            

            Console.ReadKey();
        }
    }
}