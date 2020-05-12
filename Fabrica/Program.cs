using System;
using System.ComponentModel.Design;

namespace Fabrica
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Menu();
        }

        public static void Movement(int maxspeed)
        {
            Random rnd = new Random();
            int randomnubmer;
            double distance = 10.0;
            int speed = 0;
            while (distance > 0)
            {
                randomnubmer = rnd.Next(1, 100);
                if (speed < maxspeed / 2 && speed !<= maxspeed - 10)
                {
                    if (randomnubmer <= 70)
                    {
                        speed = speed + 15;
                        Console.WriteLine("Скорость увеличивается");
                    }
                    if (randomnubmer >= 90)
                    {
                        speed = speed - 10;
                        Console.WriteLine("Скорость уменьшается");

                    }
                }
                else
                {
                    if (randomnubmer <= 50 && speed! <= maxspeed - 10)
                    {
                        speed = speed + 15;
                        Console.WriteLine("Скорость увеличивается");
                    }
                    if (randomnubmer >= 70)
                    {
                        speed = speed - 10;
                        Console.WriteLine("Скорость уменьшается");
                    }
                }
                distance = distance - (speed / 60);
                Console.WriteLine("\nСкорость составляет" + speed + "\n\nОсталось проехать" + distance + "км");
            }
            Console.WriteLine("Машина добралась до стоянки");
        }

        public static void Menu()
        {
            int i;
            BMW bmw = new BMW();
            Mercedes mercedes = new Mercedes();
            Console.WriteLine("Вы хотите добавить машину? \n 1. Да ");
            i = Convert.ToInt32(Console.ReadLine());
            if (i == 1)
            {
                int j;
                Console.WriteLine("Выберете марку машины: \n 1.BMW \n 2.Mercedes");
                i = Convert.ToInt32(Console.ReadLine());

                if (i == 1)
                    Console.WriteLine("Вы выбрали BMW");
                if (i == 2)
                    Console.WriteLine("Вы выбрали Mercedes");
                Console.WriteLine("Выберете кузов машины: \n 1.Седан \n 2.Купе");
                j = Convert.ToInt32(Console.ReadLine());
                if (i == 1)
                {
                    if (j == 1)
                        Movement(bmw.createSedan());
                    else
                        Movement(bmw.createCoupe());
                }
                if (i == 2)
                    Console.WriteLine("Вы выбрали Mercedes");
                if (j == 1)
                    Movement(mercedes.createSedan());
                else
                    Movement(mercedes.createCoupe());
            }
            Menu();

        }
    }
}
