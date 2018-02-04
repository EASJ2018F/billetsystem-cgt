using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilletLib
{
    public interface ITicketIssuer
    {
        Ticket IssueTicket(TicketOrder order);
    }
}
