using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardSort
{
    class Program
    {
        static void Main(string[] args)
        {


            var tickets = TicketHelper.GenerateTickets();

            TicketHelper.DisplayTickets(tickets);

            Console.WriteLine("****-------------------------*****");

            var sorted = TicketSortManager.Sort(tickets);

            TicketHelper.DisplayTickets(sorted);
        }
    }
}
