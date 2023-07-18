using System;

namespace OtelRezervasyon
{
    class Program
    {
        static void Main(string[] args)
        {
            Hotel h1 = new Hotel("London Hotel", "London UK" , "05556555555");
            Hotel h2 = new Hotel("Istanbul Hotel", "Türkiye", "05556555555");

            Customer c1 = new Customer("Hatice Erdirik", 1111);

            c1.makeRezervation(h1, "suit", 3);
            c1.makeRezervation(h2, "family", 5);
            c1.makeRezervation(h1, "suit", 4);

            c1.listCustomerRezervations();

            Console.WriteLine("*********************************");
            c1.getInvoice(20230002); // verilen rezervasyon numarasına ait ödeme bilgileri
            Console.WriteLine("*********************************");
            Customer c2 = new Customer("Ayşe Öztürk", 111222);
            c2.makeRezervation(h2, "family", 4);
            c2.listCustomerRezervations();

            Console.WriteLine(h1.ToString());
        }
    }
}
