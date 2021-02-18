using ManagementApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ManagementApp.Interface
{
    public interface ITicketRepository<Ticket>
    {
        Task<Ticket> GetbyIdAsync(int id);
        Task<IReadOnlyList<Ticket>> ListAllAsync();
    }
}
