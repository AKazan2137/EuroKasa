using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EuroKasa
{
    class SpecialTicket:Ticket
    {


        public SpecialTicket(int id, string name, decimal price, int quantity) :
            base(id, name, price, quantity)
        {
        }
        public override string TicketType()
        {
            return "Specjalny";
        }
        
    }
}
