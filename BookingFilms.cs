using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.IO;

namespace ConsoleApp1
{
    class BookingFilms
    {
        public void Films()
        {
            BookingFilms Seats = new BookingFilms();

            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("==================================================");
            Console.WriteLine();
            Console.Write("Title: Avengers: EndGame \nLength: 3h 2m \nAge Rating: PG \nDate/Time: 12:30 13/12/19  \nScreen No: 1");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("==================================================");
            Console.WriteLine();
            Console.Write("Title: Joker \nLength: 2h 2m \nAge Rating: R \nDate/Time: 16:30 13/12/19  \nScreen No: 2");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("==================================================");
            Console.WriteLine();
            Console.Write("Title: Toy Story 4 \nLength: 1h 40m \nAge Rating: U \nDate/Time: 18:30 13/12/19  \nScreen No: 3");
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
                Seats.Seats("Avengers: Endgame", "3h 2m", "PG", "12:30 13/12/19", "1");
                Thread.Sleep(2000);
            }
            else if (choice == 2)
            {
                // FILM CHOICE JOKER
                Console.WriteLine();
                Seats.Seats("Joker", "2h 2m", "R", "16:30 13/12/19", "2");
                Thread.Sleep(2000);
            }
            else if (choice == 3)
            {
                // FILM CHOICE TOY STORY 4
                Console.WriteLine();
                Seats.Seats("Toy Story 4", "1h 40m", "U", "18:30 13/12/19", "3");
                Thread.Sleep(2000);
            }
            else
            {
                // BACK TO OPTIONS
                Films();
            }
        }

        public void Seats(string Title, string Length, string AR, string DT, string Screen)
        {

            BookingSeats Seats = new BookingSeats();

            Console.WriteLine();
            Console.WriteLine("Please choose one of the following choice of seats:");
            Console.WriteLine();
            Console.WriteLine("[1] Standard Seats - £9.99");
            Console.WriteLine("[2] VIP Seats - £15.00");
            int choice = int.Parse(Console.ReadLine());

            if (choice == 1)
            {
                // FILM CHOICE AVENGERS
                Console.WriteLine();
                Seats.Standard(Title, Length, AR, DT, Screen);
                Thread.Sleep(2000);
            }
            else if (choice == 2)
            {
                // FILM CHOICE JOKER
                Console.WriteLine();
                Seats.VIP(Title, Length, AR, DT, Screen);
                Thread.Sleep(2000);
            }
            else
            {
                // BACK TO FILM OPTIONS
                Films();
            }
        }
    }
}
