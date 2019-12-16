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

            BookingFiles File = new BookingFiles();

            BookingFilms Film = new BookingFilms();

            File.CreateDirectory();

            File.CreateFiles();

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
                Film.Films();
            }
            else if (user == 2)
            {
                // HELP
                Console.WriteLine();
                Console.WriteLine("Not Implemented");
                Help();
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

        static void Help()
        {

            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("==================================================");
            Console.WriteLine();
            Console.Write("Films: \n\nBLAH BLAH BLAH");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("==================================================");
            Console.WriteLine();
            Console.Write("Type of Seats: \n\nBLAH BLAH BLAH");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("==================================================");
            Console.WriteLine();
            Console.Write("Ticket: \n\nBLAH BLAH BLAH");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("==================================================");
            Console.WriteLine();
            Console.WriteLine("Please choose the following option:");
            Console.WriteLine();
            Console.WriteLine("[1] BACK");
            int user = int.Parse(Console.ReadLine());

            if (user == 1)
            {
                // BACK TO MENU
                Thread.Sleep(1000);
            }
            else
            {
                // BACK TO OPTIONS
                Console.WriteLine();
                Thread.Sleep(2000);
                Help();
            }
        }

    }
}
