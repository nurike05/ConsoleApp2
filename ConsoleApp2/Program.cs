using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Greeting greeting = new Greeting();
            Applausing applausing = new Applausing();
            greeting.SayHello();
            applausing.Applause();
            Console.ReadLine();
        }
    }
}
