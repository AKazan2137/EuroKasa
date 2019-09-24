using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EuroKasa
{
    class Printer:IPrinter
    {
        public void Print(Ticket ticket)
        {
            Console.WriteLine("Nazwa: {0}", ticket.Name);
            Console.WriteLine("Cena: {0}", ticket.Price);
            Console.WriteLine();
        
        }
    }
}
