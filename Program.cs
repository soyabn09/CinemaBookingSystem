using System;
using System.Threading;
using System.IO;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {
                Console.Clear();
                Menu();
            }
        }

        static void Menu()
        {

            BookingFiles files = new BookingFiles();

            Program film = new Program();

            files.CreateDirectory();

            files.CreateFiles();

            Console.WriteLine();
            Console.WriteLine("Cinema Booking System");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Please choose one of the following options:");
            Console.WriteLine();
            Console.WriteLine("[1] START");
            Console.WriteLine("[2] HELP");
            int user = int.Parse(Console.ReadLine());

            if (user == 1)
            {
                // FILM CHOICES
                film.Films();
            }
            else if (user == 2)
            {
                // HELP
                Console.WriteLine();
                Console.WriteLine("Not Implemented");
                Thread.Sleep(2000);
            }
            else
            {
                // BACK TO OPTIONS
                Console.WriteLine();
                Console.WriteLine("Incorrect Option");
                Thread.Sleep(2000);
            }

        }

        public void Films()
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("==================================================");
            Console.WriteLine();
            Console.Write("Title: Avengers: EndGame \nLength: 3h 2m \nAge Rating: PG");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("==================================================");
            Console.WriteLine();
            Console.Write("Title: Joker \nLength: 2h 2m \nAge Rating: R");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("==================================================");
            Console.WriteLine();
            Console.Write("Title: Toy Story 4 \nLength: 1h 40m \nAge Rating: U");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("==================================================");
            Console.WriteLine();
            Console.WriteLine("Please choose one of the above films:");
            Console.WriteLine();
            Console.WriteLine("[1] Avengers: Endgame");
            Console.WriteLine("[2] Joker");
            Console.WriteLine("[3] Toy Story 4");
            int choice = int.Parse(Console.ReadLine());

            if (choice == 1)
            {
                // FILM CHOICE AVENGERS
                Console.WriteLine();
                Console.WriteLine("Not Implemented");
                Thread.Sleep(2000);
            }
            else if (choice == 2)
            {
                // FILM CHOICE JOKER
                Console.WriteLine();
                Console.WriteLine("Not Implemented");
                Thread.Sleep(2000);
            }
            else if (choice == 3)
            {
                // FILM CHOICE TOY STORY 4
                Console.WriteLine();
                Console.WriteLine("Not Implemented");
                Thread.Sleep(2000);
            }
            else
            {
                // BACK TO OPTIONS
                Films();
            }
        }
    }
}
