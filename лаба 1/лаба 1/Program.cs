using System;
using System.Runtime.CompilerServices;

namespace лаба_1
{
    class Program
    {
        static void Main()
        {
            Circle one = new Circle(0, 0, 0);
            Circle two = new Circle(0, 0, 0);
            int x, y, r;
            bool t = true;
            bool c_1 = false;
            bool c_2 = false;
            Console.WriteLine("уважаймый пользователь(а скарее всего не уважаймый) приветствую тебя(нет я приветствую только аниме и пиво а ты не пиво и не аниме так-что пошол вон)");
            while (true && t)
            {
                Console.WriteLine("что ты можеш сделать с програмой:\r\n(не ломать ,пожалуйста ,Егор Иванович я пошутил вы уважаймы мной человек)\r\n1-создать условный круг с задаными кардинатоми и радиусом\r\n2-создать 2-ой условный круг с задаными кардинатоми и радиусом\r\n3-переместить круг 1 в случайные кардинаты\r\n4-переместить круг 2 в случайные кардинаты\r\n5-узнать длину 1-ого круга\r\n6-узнать длину 2-ог круга\r\n7-узнать растояние между центроми кругов(обязательно создать круг 1 и 2 при помощи соответствуещих команд)\r\n8-узнать ответ на вопрос в скольки точках они пересекаются\r\n(обязательно создать круг 1 и 2 при помощи соответствуещих команд)\r\n0-закрыть програму(наконец)");
                switch (Console.ReadLine())
                {
                    case "0":
                        t = false;
                        break;
                    case "1":
                        Console.Clear();
                        Console.WriteLine("введите целое число кардинату x для кругав диопазоне от -99 до 99");
                        while (!int.TryParse(Console.ReadLine(), out x))
                            Console.WriteLine("ошибка ввода введите сново");
                        Console.WriteLine("введите целое число кардинату y для кругав диопазоне от -99 до 99");
                        while (!int.TryParse(Console.ReadLine(), out y))
                            Console.WriteLine("ошибка ввода введите сново");
                        Console.WriteLine("введите целое число r радиус для круга");
                        while (!int.TryParse(Console.ReadLine(), out r))
                            Console.WriteLine("ошибка ввода введите сново");
                        one = new Circle(x, y, r);
                        one.inf();
                        Console.WriteLine("нажмите любую кнопку чтобы продолжить");
                        Console.ReadKey();
                        Console.Clear();
                        c_1 = true;
                        break;
                    case "2":
                        Console.Clear();
                        Console.WriteLine("введите целое число кардинату x для круга в диопазоне от -99 до 99");
                        while (!int.TryParse(Console.ReadLine(), out x))
                            Console.WriteLine("ошибка ввода введите сново");
                        Console.WriteLine("введите целое число кардинату y для кругав диопазоне от -99 до 99");
                        while (!int.TryParse(Console.ReadLine(), out y))
                            Console.WriteLine("ошибка ввода введите сново");
                        Console.WriteLine("введите целое число r радиус для круга");
                        while (!int.TryParse(Console.ReadLine(), out r))
                            Console.WriteLine("ошибка ввода введите сново");
                        two = new Circle(x, y, r);
                        two.inf();
                        Console.WriteLine("нажмите любую кнопку чтобы продолжить");
                        Console.ReadKey();
                        Console.Clear();
                        c_2 = true;
                        break;
                    case "3":
                        Console.Clear();
                        if (c_1)
                        {
                            one.ranbox();
                        }
                        else
                        {
                            Console.WriteLine("ответь на вопрос: что я должен переместить в рандомное место не уважаймый мной пользователь");
                        }
                        Console.WriteLine("нажмите любую кнопку чтобы продолжить");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case "4":
                        Console.Clear();
                        if (c_2)
                        {
                            two.ranbox();
                        }
                        else
                        {
                            Console.WriteLine("ответь на вопрос: что я должен переместить в рандомное место не уважаймый мной пользователь");
                        }
                        Console.WriteLine("нажмите любую кнопку чтобы продолжить");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case "6":
                        Console.Clear();
                        if (c_2)
                        {
                            two.length();
                        }
                        else
                        {
                            Console.WriteLine("ответь на вопрос: как я узнаю длину круга которого нету");
                        }
                        Console.WriteLine("нажмите любую кнопку чтобы продолжить");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case "5":
                        Console.Clear();
                        if (c_1)
                        {
                            one.length();
                        }
                        else
                        {
                            Console.WriteLine("ответь на вопрос: как я узнаю длину круга которого нету");
                        }
                        Console.WriteLine("нажмите любую кнопку чтобы продолжить");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case "7":
                        Console.Clear();
                        if (c_1 && c_2)
                        {
                            Console.WriteLine("растояние между центроми кругов примерно равно " + Math.Ceiling(one.distance(one, two)));
                        }
                        else
                        {
                            Console.WriteLine("ответь на вопрос: как я узнаю растояние между кругами когда ты не создал этих кругов");
                        }
                        Console.WriteLine("нажмите любую кнопку чтобы продолжить");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case "8":
                        Console.Clear();
                        if (c_1 && c_2)
                        {
                            one.touch(one, two);
                        }
                        else
                        {
                            Console.WriteLine("ответь на вопрос: как я узнаю пересекаются ли в 1 точке 2 круга если не хвотает кругов");
                        }
                        Console.WriteLine("нажмите любую кнопку чтобы продолжить");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("нет такой команды. нажмите любую кнопку чтобы продолжить");
                        Console.ReadKey();
                        break;
                }
            }
        }
    }
    class Circle
    {
        Random rnt = new Random();
        private int r, x, y;
        public Circle(int x, int y, int r)
        {
            this.x = x;
            this.y = y;
            this.r = r;
        }
        int for_Z(int t)
        {
            if (t == 1)
            {
                return x;
            }
            else if (t == 2)
            {
                return y;
            }
            else
            {
                return r;
            }
        }
        public void inf()
        {
            Console.WriteLine("кардинаты круга у={0} x={1}", y, x);
            Console.WriteLine("его радиус " + r);
        }
        public void length()
        {
            Console.WriteLine(2 * Math.PI * r);
        }
        public void ranbox()
        {
            x = rnt.Next(-99, 100);
            y = rnt.Next(-99, 100);
            inf();
        }
        public double distance(Circle circle_1, Circle circle_2)
        {
            return Math.Sqrt(Math.Pow(circle_1.for_Z(1) - circle_2.for_Z(1), 2) + Math.Pow(circle_1.for_Z(2) - circle_2.for_Z(2), 2));
        }
        public void touch(Circle circle_1, Circle circle_2)
        {
            if (distance(circle_1, circle_2) == circle_1.for_Z(0) + circle_2.for_Z(0))
            {
                Console.WriteLine("они пересекаютя в одной точке");
            }
            else if (distance(circle_1, circle_2) > Math.Sqrt(circle_1.for_Z(0) - circle_2.for_Z(0))&& distance(circle_1, circle_2) < circle_1.for_Z(0) + circle_2.for_Z(0))
            {
                Console.WriteLine("они пересекаютя в двух точках");
            }
            else if (distance(circle_1, circle_2) == Math.Sqrt(circle_1.for_Z(0) - circle_2.for_Z(0)))
            {
                Console.WriteLine("они пересекаютя в одной точке");
            }
            else
            {
                Console.WriteLine("я не знаю что ты написал в кардинаты кругов но они не пересикаются ты доволен\r\nP.S.-если хочеш щетй что они пересикаются в 3 точках только Егор иванувичу не слова об этом");
            }
        }
    }
}