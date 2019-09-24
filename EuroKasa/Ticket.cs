using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EuroKasa
{
    abstract class Ticket
    {
        public string Name { get; }
        public decimal Price { get; }
        public int Quantity { get; }
        private int Id { get; }
        public string TicketNumber { get; }

        public Ticket(int Id,string name, decimal price, int quantity)
        {
            Name = name;
            Price = price;
            Quantity = quantity;
            TicketNumber = GenerateTicketNumber(Id);
        }

        public string GetQuantityOfTickets()
        {
            string name_quantity = string.Format("{0}, ilość: {1}", Name, Quantity);
            return name_quantity;
        }

        public abstract string TicketType();

        string GenerateTicketNumber(int id)
        {
            var ticketNumber = string.Format("94{0:D10}", id);
            return ticketNumber;
        }
    }
}
