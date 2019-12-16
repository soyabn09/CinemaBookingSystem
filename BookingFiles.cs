using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.IO;

namespace ConsoleApp1
{
    class BookingFiles
    {
        public void CreateDirectory()
        {
            Directory.CreateDirectory("C:\\CinemaBookingSystem");
        }

        public void CreateFiles()
        {
            if (!File.Exists(@"C:\CinemaBookingSystem\Booking.txt"))
            {
                File.Create(@"C:\CinemaBookingSystem\Booking.txt");
            }

            if (!File.Exists(@"C:\CinemaBookingSystem\Seats.txt"))
            {
                string[] seats = new string[3] {"30", "30", "30"};

                File.WriteAllLines(@"C:\CinemaBookingSystem\Seats.txt", seats);
            }

        }

        public void Booking()
        {

        }

        public void Seats(int num1, int num2)
        {

            string[] Seats = File.ReadAllLines(@"C:\CinemaBookingSystem\Seats.txt");

            if (num1 == 1)
            {
                Console.WriteLine(Seats[1]);
            }
            else if (num1 == 2)
            {
                Console.WriteLine(Seats[2]);

            }
            else if (num1 == 3)
            {
                Console.WriteLine(Seats[3]);

            }
        }
    }
}
