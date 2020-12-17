using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace лаба_4
{
    class Program
    {
        static void Main(string[] args)
        {

        }
    }
    abstract class Pet
    {
        protected string naim;
        protected int age;
        protected bool hungry;
        abstract public void voice();
    }
    class Snake:Pet
    {
        public override void voice()
        {
            Console.WriteLine("ссссссссссс");
        }
    }
    class dog : Pet
    {
        public override void voice()
        {
            Console.WriteLine("гав");
        }
    }
    class PatrolDog : Pet
    {
        public override void voice()
        {
            Console.WriteLine("нюх нюх наркатой воняет");
        }
    }
    class Cat : Pet
    {
        public override void voice()
        {
            Console.WriteLine("мяу");
        }
    }
    class Fish : Pet
    {
        public override void voice()
        {
            Console.WriteLine("(молчит)");
        }
    }
    interface PassangersAuto
    {
        void traffic();
    }
    interface CargoAuto
    {
         void traffic();
    }
    class Truck:CargoAuto
    {
        public void traffic()
        {
            Console.WriteLine("перевезли груз");
        }
    }
    class Sedan:PassangersAuto
    {
        public void traffic()
        {
            Console.WriteLine("перевезли пасажира");
        }
    }
    class Pickup:PassangersAuto,CargoAuto
    {
        public void traffic()
        {
            Console.WriteLine("перевезли пасажира");
        }
        void CargoAuto.traffic() 
        {
            Console.WriteLine("перевезли груз");
        }
    }
}
