using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ManagementApp.Model
{
    public class Column
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public int BoardId { get; set; }
        public IReadOnlyList<Ticket> Tickets { get; set; }
    }
}
