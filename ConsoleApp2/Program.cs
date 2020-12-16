using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
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
            //Console.ReadLine();

            Assembly asm = Assembly.LoadFrom("C:/Users/MyHome/source/repos/ConsoleApp2/ConsoleApp2/MultiFileLibrary.dll");
            Assembly asmProg = Assembly.LoadFrom("C:/Users/MyHome/source/repos/ConsoleApp2/ConsoleApp2/Program.dll");
            Console.WriteLine(asm.FullName);
            Console.WriteLine(asmProg.FullName);
            Assembly asmLoad = Assembly.Load("Program, Version=0.0.0.0, Culture=neutral, PublicKeyToken=9cef6fafa82c8137");
            // получаем все типы из сборки MultiFileLibrary.dll
            Type[] types = asm.GetTypes();
            foreach (Type t in types)
            {
                Console.WriteLine(t.Name);
            }

            // получаем все типы из сборки Program.dll
            Type[] typesProg = asmProg.GetTypes();
            foreach (Type t in typesProg)
            {
                Console.WriteLine(t.Namespace);
            }
            Console.WriteLine(asmProg.DefinedTypes);
            Console.WriteLine(asmLoad.GetName().Name);
            Console.ReadLine();
        }
    }
}
