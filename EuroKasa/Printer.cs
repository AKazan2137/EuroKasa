using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EuroKasa
{
    class Printer
    {
        public void Print(NonSpecialTicket nonSpecialTicket)
        {
            Console.WriteLine("Nazwa: {0}", nonSpecialTicket.Name);
            Console.WriteLine("Cena: {0}", nonSpecialTicket.Price);
            Console.WriteLine();
        }
        public void Print(SpecialTicket specialTicket)
        {
            Console.WriteLine("Nazwa: {0}", specialTicket.Name);
            Console.WriteLine("Cena: {0}", specialTicket.Price);
            Console.WriteLine();
        }
    }
}
