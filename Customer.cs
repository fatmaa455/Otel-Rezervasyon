using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtelRezervasyon
{
    class Customer
    {
        private string name;
        private int national_id;
        private Rezervation[] rezervations=new Rezervation[10];

        public Customer(string name, int national_id)
        {
            this.name = name;
            this.national_id = national_id;
        }

        public string Name { get => name; set => name = value; }
        public int National_id { get => national_id; set => national_id = value; }
        public Rezervation[] Rezervations { get => rezervations; set => rezervations = value; }

        public void makeRezervation(Hotel hotel,string roomType,int day)
        {
            int roomNumber = 0;

            Room[] rooms = hotel.Rooms;

            int i= 0;

            while(rooms[i] != null && (rooms[i].IsAvailable == false || rooms[i].RoomType.CompareTo(roomType) != 0))
            {
                i++;
            }
            if(rooms[i] != null)
            {
                roomNumber = rooms[i].RoomNumber;
                rooms[i].IsAvailable = false;
                Rezervation rezervation = new Rezervation(hotel, roomNumber, day);
                appendRezervation(rezervation);
            }
            else
            {
                Console.WriteLine("Seçtiğiniz oda tipinin müsaitlik durumu bulunmamaktadır...");
            }
        }

        private void appendRezervation(Rezervation rezervation)
        {
            int i = 0;

            while(rezervations[i] != null && i<rezervations.Length)
            {
                i++;
            }
            if(rezervations[i] == null)
            {
                rezervations[i] = rezervation;
            }
        }
        public void getInvoice(int rezID)
        {
            int i = 0;
            while(rezervations[i].RezID != rezID)
            {
                i++;
            }
            if(rezervations[i].RezID == rezID)
            {
                rezervations[i].calculatePayment();
            }
        }

        public void listCustomerRezervations()
        {
            int i = 0;
            while(rezervations[i] != null)
            {
                Console.WriteLine(rezervations[i]);
                i++;
            }
        }
       

    }
}
