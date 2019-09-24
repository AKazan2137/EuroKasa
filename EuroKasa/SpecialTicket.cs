using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EuroKasa
{
    class SpecialTicket:Ticket
    {


        public SpecialTicket(string name, decimal price, int quantity) :
            base(name, price, quantity)
        {
        }
        public override string TicketType()
        {
            return "Specjalny";
        }
        
    }
}
