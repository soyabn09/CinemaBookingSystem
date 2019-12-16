using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class BookingSeats
    {
        public void Standard(string Title, string Length, string AR, string DT, string Screen)
        {
            Console.Write("Please input the amount of seats: ");
            int seats = int.Parse(Console.ReadLine());

            BookingFiles File = new BookingFiles();

            File.Seats(Convert.ToInt16(Screen), seats);
        }

        public void VIP(string Title, string Length, string AR, string DT, string Screen)
        {
            Console.Write("Please input the amount of seats: ");
            int seats = int.Parse(Console.ReadLine());

            BookingFiles File = new BookingFiles();

            File.Seats(Convert.ToInt16(Screen), seats);
        }
    }
}
