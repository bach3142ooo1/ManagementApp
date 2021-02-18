using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ManagementApp.Model
{
    public class Ticket
    {
        public int TicketId { get; set; }
        public int ColumnId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public IReadOnlyList<Task> Tasks { get; set; }
    }
}
