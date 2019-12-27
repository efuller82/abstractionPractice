﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstractionPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            //MyAbstractClass abClass = new MyAbstractClass(); 
            classA a = new classA();
            a.PrintMessage();
            a.PrintMessage();
            Console.Read();
        }
    }
    abstract class MyAbstractClass
    {
        private string message = "Hello C#";
        public void PrintMessage()
        {
            Console.WriteLine(message);
        }
        public abstract void PrintMessageAbstract();
    }
    class ClassA : MyAbstractClass
    {
        public override void PrintMessageAbstract()
            {
                Console.WriteLine("C# is fun!");
            }
    }
}
