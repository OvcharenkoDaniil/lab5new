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
    
}