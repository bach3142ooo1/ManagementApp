using ManagementApp.Model;
using ManagementApp.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ManagementApp.DataAccess.Repository
{
    public class TicketRepository<T>: ITicketRepository<Ticket>
    {
        public readonly ManagementContext context;

        public TicketRepository(ManagementContext context)
        {
            this.context = context;
        }

        public async Task<Ticket> GetbyIdAsync(int id)
        {
            return await context.Tickets.
                Include(x => x.Tasks).FirstOrDefaultAsync(x => x.TicketId == id);
        }

        public async Task<IReadOnlyList<Ticket>> ListAllAsync()
        {
            return await context.Tickets.
                Include(x => x.Tasks).ToListAsync<Ticket>();
        }
    }
}
