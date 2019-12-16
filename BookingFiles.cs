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

        public void Booking(string Title, string Length, string AR, string DT, string Screen, string Type, string Seats, string Price, string Line)
        {
            string[] Booking = new string[9] { Title, Length, AR, DT, Screen, Type, Seats, Price, Line };

            File.AppendAllLines(@"C:\CinemaBookingSystem\Booking.txt", Booking);

        }

        public void Seats(int num1, int num2, int num3)
        {

            string[] Seats = File.ReadAllLines(@"C:\CinemaBookingSystem\Seats.txt");

            if (num1 == 1)
            {

                int result = Subtract1(num2);

                Seats[0] = result.ToString();

                string[] seats = { Seats[0], Seats[1], Seats[2] };

                if (num3 == 1)
                {
                    File.WriteAllLines(@"C:\CinemaBookingSystem\Seats.txt", seats);
                }

            }
            else if (num1 == 2)
            {

                int result = Subtract2(num2);

                Seats[2] = result.ToString();

                string[] seats = { Seats[0], Seats[1], Seats[2] };

                if (num3 == 1)
                {
                    File.WriteAllLines(@"C:\CinemaBookingSystem\Seats.txt", seats);
                }

            }
            else if (num1 == 3)
            {

                int result = Subtract3(num2);

                Seats[2] = result.ToString();

                string[] seats = { Seats[0], Seats[1], Seats[2] };

                if (num3 == 1)
                {
                    File.WriteAllLines(@"C:\CinemaBookingSystem\Seats.txt", seats);
                }

            }
        }

        public int Subtract1(int num1)
        {

            BookingFilms Films = new BookingFilms();

            string[] Seats = File.ReadAllLines(@"C:\CinemaBookingSystem\Seats.txt");

            int[] SeatNum = Array.ConvertAll(Seats, int.Parse);

            if (SeatNum[0] < num1)
            {
                Films.Films();
            }

            return SeatNum[0] - num1;
        }

        public int Subtract2(int num1)
        {

            BookingFilms Films = new BookingFilms();

            string[] Seats = File.ReadAllLines(@"C:\CinemaBookingSystem\Seats.txt");

            int[] SeatNum = Array.ConvertAll(Seats, int.Parse);

            if (SeatNum[1] < num1)
            {
                Films.Films();
            }

            return SeatNum[1] - num1;
        }

        public int Subtract3(int num1)
        {

            BookingFilms Films = new BookingFilms();

            string[] Seats = File.ReadAllLines(@"C:\CinemaBookingSystem\Seats.txt");

            int[] SeatNum = Array.ConvertAll(Seats, int.Parse);

            if (SeatNum[2] < num1)
            {
                Films.Films();
            }

            return SeatNum[2] - num1;
        }
    }
}
