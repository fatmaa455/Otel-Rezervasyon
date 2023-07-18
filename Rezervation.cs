using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtelRezervasyon
{
    class Rezervation
    {
        private static int counter=20230001;
        private int rezID;
        private Hotel hotel;
        private int roomNumber;
        private int day;

        public Rezervation(Hotel hotel, int roomNumber, int day)
        {
            this.hotel = hotel;
            this.roomNumber = roomNumber;
            this.day = day;
            rezID = counter;
            counter++;
        }

        public int RezID { get => rezID; set => rezID = value; }
        public Hotel Hotel { get => hotel; set => hotel = value; }
        public int RoomNumber { get => roomNumber; set => roomNumber = value; }
        public int Day { get => day; set => day = value; }

        public void calculatePayment()
        {
            int i = 0;
            double dailyPrice = 0;
            double payment = 0;

            while(hotel.Rooms[i].RoomNumber != roomNumber)
            {
                i++;
            }
            if(hotel.Rooms[i].RoomNumber == roomNumber)
            {
                dailyPrice = hotel.Rooms[i].Price;
            }

            payment = day * dailyPrice;

            Console.WriteLine("{0} günlük ödeme tutarı {1}",day,payment);
        }

        public override string ToString()
        {
            return "RezID: " + rezID + " oda numarası: " + roomNumber + " otel adı: " + hotel.HotelName + "day: " + day;
        }
    }
}
