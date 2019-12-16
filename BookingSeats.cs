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

            File.Seats(Convert.ToInt16(Screen), seats, 0);

            double price = seats * 9.99;

            BookingTickets Ticket = new BookingTickets();

            int Screen1 = Convert.ToInt32(Screen);
            int Seats1 = Convert.ToInt32(seats);

            Ticket.FinalTicket("Title: " + Title, "Length: " + Length, "Age Rating: " + AR, "Date/Time: " + DT, "Screen No: " + Screen, "Type: Standard", "Seats: " + seats.ToString(), "Total Price: " + price.ToString(), Screen1, Seats1);
        }

        public void VIP(string Title, string Length, string AR, string DT, string Screen)
        {
            Console.Write("Please input the amount of seats: ");
            int seats = int.Parse(Console.ReadLine());

            BookingFiles File = new BookingFiles();

            File.Seats(Convert.ToInt16(Screen), seats, 0);

            double price = seats * 15.00;

            BookingTickets Ticket = new BookingTickets();

            int Screen1 = Convert.ToInt32(Screen);
            int Seats1 = Convert.ToInt32(seats);

            Ticket.FinalTicket("Title: " + Title, "Length: " + Length, "Age Rating: " + AR, "Date/Time: " + DT, "Screen No: " + Screen, "Type: VIP", "Seats: " + seats.ToString(), "Total Price: " + price.ToString(), Screen1, Seats1);
        }
    }
}
