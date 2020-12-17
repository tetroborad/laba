using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace лаба_2
{
    class Program
    {
        static void Main()
        {
            bool exod = true;
            Console.WriteLine("создадим вашу лошадь");
            Horse hor = new Horse();
            Console.WriteLine("информация про вашу лошадь");
            hor.inf();
            Console.WriteLine("создадим вашего пегаса");
            Pegas peg=new Pegas();
            Console.WriteLine("информация про вашего пегаса");
            peg.inf();
            Console.WriteLine("варианты команды\r\n1-убить и завети нового коня\r\n2-инормацая по коню\r\n3-убить и завести новога пигаса\r\n4-информацая по пигасу\r\n0-следуйщие задание(консоль очистится при переходе к следуйщему заданию)");
            while (exod)
            {
                switch(Console.ReadLine())
                {
                    case "1":
                        hor = new Horse();
                    break;
                    case "2":
                        hor.inf();
                    break;
                    case "3":
                        peg = new Pegas();
                    break;
                    case "4":
                        peg.inf();
                    break;
                    case "0":
                        exod = false;
                    break;
                    default:
                        Console.WriteLine("нет такой команды введите снова");
                        break;
                }
            }
            exod = true;
            Console.Clear();
            Console.WriteLine("создадим питомца вида кота");
            Cat cat=new Cat();
            Console.WriteLine("информация про питомца");
            cat.inf();
            Console.WriteLine("создадим питомца вида собока");
            Dog dog = new Dog();
            Console.WriteLine("информация про питомца");
            dog.inf();
            Console.WriteLine("варианты команды\r\n1-убить и завети нового питомца вида кот\r\n2-инормацая про питомца вида кот\r\n3-убить и завести новога питомца вида собака\r\n4-информацая про питомца вида собака\r\n0-следуйщие задание(консоль очистится при переходе к следуйщему заданию)");
            while (exod)
            {
                switch (Console.ReadLine())
                {
                    case "1":
                        cat = new Cat();
                        break;
                    case "2":
                        cat.inf();
                        break;
                    case "3":
                        dog = new Dog();
                        break;
                    case "4":
                        dog.inf();
                        break;
                    case "0":
                        exod = false;
                        break;
                    default:
                        Console.WriteLine("нет такой команды введите снова");
                        break;
                }
            }
            exod = true;
            Console.Clear();
            Console.WriteLine("узнаем про эволючию");
            Human human = new Human();
            Console.WriteLine("варианты команды\r\n1-повторить информацию про эвольцию\r\n0-закрыть програму");
            while (exod)
            {
                switch (Console.ReadLine())
                {
                    case "1":
                        human = new Human();
                        break;
                    case "0":
                        exod = false;
                        break;
                    default:
                        Console.WriteLine("нет такой команды введите снова");
                        break;
                }
            } 
        }
    }
    
    class Horse
    {
        protected string naim;
        protected bool wings;
        
        public Horse()
        {
            wings = false;
            Console.Write("введите имя");
            naim = Console.ReadLine();

        }
        public void inf()
        {
            Console.WriteLine("его завут"+naim);
            Ran();
            flay();
        }
        protected void Ran ()
        {
            Console.WriteLine(naim+" делает тыгыдык");
        }
        protected void flay()
        {
            if(wings)
            {
                Console.WriteLine(naim + " летит ,хорошо литит");
            }
            else
            {
                Console.WriteLine(naim + " не литит");
            }            
        }
    }
    class Pegas:Horse
    {
         public Pegas()
        {
            wings = true;
        }
    }
    class Pet
    {
        protected string naim;
        protected int age;
        protected bool sex;
        protected double weight;
        protected Pet()
        {
            bool exod = true;
            Console.Write("введите имя питомца");
            naim = Console.ReadLine();
            Console.WriteLine("введите пол питомца\r\nм-если мальчик\r\nд-если девочка");
            while(exod)
            {

                switch (Console.ReadLine())
                {
                    case "м":
                        sex = false;
                        exod = false;
                        break;
                    case "д":
                        sex = true;
                        exod = false;
                        break;
                    default:
                        Console.WriteLine("я в ваших гендорах нехрина не понимаю скажите нармально он мальчик или девочка");
                        break;
                }
            }
            if(sex)
            {
                Console.Write("сколько ей лет:");
                while (!int.TryParse(Console.ReadLine(), out age))
                {
                    Console.WriteLine("это не похоже на возвраст введите снова:");
                }
                Console.Write("какой её вес:");
                while (!double.TryParse(Console.ReadLine(), out weight))
                {
                    Console.WriteLine("это не похоже на вес введите снова:");
                }
            }
            else
            {
                Console.Write("сколько ему лет:");
                while (!int.TryParse(Console.ReadLine(), out age))
                {
                    Console.WriteLine("это не похоже на возвраст введите снова:");
                }
                Console.Write("какой его вес:");
                while (!double.TryParse(Console.ReadLine(), out weight))
                {
                    Console.WriteLine("это не похоже на вес введите снова:");
                }
            }
        }
    }
    class Cat:Pet
    {
        public Cat()
        { }
        public void inf()
        {
            if(sex)
            {
                Console.WriteLine("кошка по имени "+ naim+" прожила "+age+" года и сейчас весит "+weight + " кг");
            }else
            {
                Console.WriteLine("кот по имени " + naim + " прожил " + age + " года и сейчас весит " + weight+" кг");
            }
        }
    }
    class Dog : Pet
    {
        public Dog()
        { }
        public void inf()
        {
            if (sex)
            {
                Console.WriteLine("сучка(в контексте собака женского пола) по имени " + naim + " прожила " + age + " года и сейчас весит " + weight + " кг");
            }
            else
            {
                Console.WriteLine("пес по имени " + naim + " прожил " + age + " года и сейчас весит " + weight + " кг");
            }
        }
    }
    class Fish
    {
        public Fish ()
        {
            Console.WriteLine("от рыбы уноследовали внутриние органы но не жабры");
        }
    }
    class Animal:Fish
    {
        public Animal()
        {
            Console.WriteLine("от животных мы унаследовали волосеной покров но не кокти и клыки");
        }
    }
    class Ape:Animal
    {
        public Ape()
        {
            Console.WriteLine("от обезьян мы унаследовали  но не кокти и клыки");
        }
    }
    class Human:Ape
    {
        public Human()
        {
            Console.WriteLine(" следуйщим видам мы точно передадим интилект");
        }
    }
}
