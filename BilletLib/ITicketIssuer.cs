using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilletLib
{
    /// <summary>
    /// ITicketIssuer defines the interface that ticket issuer implementations must satisfy.
    /// </summary>
    public interface ITicketIssuer
    {
        /// <summary>
        /// IssueTicket issues a Ticket based on an incoming TicketOrder
        /// according to its own rules, discounts, etc.
        /// </summary>
        Ticket IssueTicket(TicketOrder order);
    }
}
