using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ManagementApp.Model
{
    public class Task
    {
        public int ticketId { get; set; }
        public int Id { get; set; }
        public string Title { get; set; }
        public bool Status { get; set; }
    }
}
