using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EuroKasa
{
    class Program
    {
        static void Main(string[] args)
        {
            NonSpecialTicket Normalny = new NonSpecialTicket(1, "Normalny",10.0M, 10);
            NonSpecialTicket Ulgowy = new NonSpecialTicket(2, "Ulgowy",5.0M, 25);
            SpecialTicket MKarta = new SpecialTicket(3, "MKarta",0.0M, 30);
            IPrinter printer = new Printer();
            printer.Print(Normalny);
            printer.Print(Ulgowy);
            printer.Print(MKarta);
            string quantityofspecialticket = MKarta.GetQuantityOfTickets();
            Console.WriteLine(quantityofspecialticket);
            Console.WriteLine(Normalny.TicketType());
            Console.ReadKey();

        }
    }
}
