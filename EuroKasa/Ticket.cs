using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EuroKasa
{
    abstract class Ticket
    {
        public string Name;
        public decimal Price;
        public int Quantity;

        public Ticket(string name, decimal price, int quantity)
        {
            Name = name;
            Price = price;
            Quantity = quantity;
        }

        public string GetQuantityOfTickets()
        {
            string name_quantity = string.Format("{0}, ilość: {1}", Name, Quantity);
            return name_quantity;
        }

        public abstract string TicketType();
    }
}
