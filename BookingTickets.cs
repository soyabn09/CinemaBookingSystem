using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.IO;

namespace ConsoleApp1
{
    class BookingTickets
    {
        // Shows the final ticket
        public void FinalTicket(string Title, string Length, string AR, string DT, string Screen, string Type, string Seats, string Price, int Screen1, int Seats1)
        {
            Console.Clear();
            Console.WriteLine();
            Console.Write(Title + " \n" + Length + " \n" + AR + " \n" + DT + " \n" + Screen + " \n" + Type + " \n" + Seats + " \n" + Price);
            Console.WriteLine();
            Console.WriteLine("=======================================");
            Console.WriteLine();
            Console.WriteLine("Please choose one of the following options:");
            Console.WriteLine();
            Console.WriteLine("[1] CONFIRM BOOKING");
            Console.WriteLine("[2] MENU");
            int choice = int.Parse(Console.ReadLine());

            BookingFiles Files = new BookingFiles();

            if (choice == 1)
            {
                Thread.Sleep(2000);
                Files.Booking(Title, Length, AR, DT, Screen, Type, Seats, Price, "=======================================");
                Files.Seats(Screen1, Seats1, 1);
                Console.Clear();
                Console.WriteLine();
                Console.WriteLine("Booking Confirmed!");
                Console.WriteLine();
            }
            else if (choice == 2)
            {
                Console.Clear();
                Console.WriteLine();
                Console.Write(Title + " \n" + Length + " \n" + AR + " \n" + DT + " \n" + Screen + " \n" + Type + " \n" + Seats + " \n" + Price);
                Console.WriteLine();
                Console.WriteLine("=======================================");
                Console.WriteLine();
                Console.WriteLine("ARE YOU SURE?");
                Console.WriteLine();
                Console.WriteLine("[1] YES");
                Console.WriteLine("[2] NO");
                int choice2 = int.Parse(Console.ReadLine());

                if (choice2 == 1)
                {

                }
                else if (choice2 == 2)
                {
                    FinalTicket(Title, Length, AR, DT, Screen, Type, Seats, Price, Screen1, Seats1);
                }
                else
                {
                    FinalTicket(Title, Length, AR, DT, Screen, Type, Seats, Price, Screen1, Seats1);
                }

            }
            else
            {
                FinalTicket(Title, Length, AR, DT, Screen, Type, Seats, Price, Screen1, Seats1);
            }

        }
    }
}
