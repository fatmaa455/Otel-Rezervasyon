using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtelRezervasyon
{
    class Hotel
    {
        private string hotelName;
        private string address;
        private string telephone;
        private Room[] rooms=new Room[100]; // kuvvetli ilişki(composition) otel olmadan oda olamaz
        // 100 tane oda oluşturulabilir

        public Hotel(String hotelName, String address, String telephone)
        {
            this.hotelName = hotelName;
            this.address = address;
            this.telephone = telephone;

            // her otel oluştuğunda default olarak dört tane oda gelir
            rooms[0] = new Room(101, "standart", 100);
            rooms[1] = new Room(201, "family", 200);
            rooms[2] = new Room(301, "suit", 400);
            rooms[3] = new Room(302, "suit", 400);
        }

        public string HotelName { get => hotelName; set => hotelName = value; }
        public string Address { get => address; set => address = value; }
        public string Telephone { get => telephone; set => telephone = value; }
        public Room[] Rooms { get => rooms; set => rooms = value; }

        // otel bilgilerini döndürdük
        public override string ToString()
        {
            return "Otelin adı: " + hotelName + " otel adres: " + address + " telefon: " + telephone;
        }
    }
}
