using ManagementApp.Model;
using ManagementApp.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using System.Web;

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

        public async Task<Ticket> AddTicket(int colId, string title, string description)
        {
            context.Tickets.Add(new Ticket()
           {
                ColumnId = colId,
                Title = title,
                Description = description
            });
           context.SaveChanges();
            return await context.Tickets
                .Where<Ticket>(x=> x.ColumnId==colId)
                .Where<Ticket>(x => x.Title == title)
                .Where<Ticket>(x => x.Description == description)
                .SingleOrDefaultAsync<Ticket>();
        }

        public async Task<Ticket> EditTicket(int ticketId, string title)
        {
            var result = context.Tickets.SingleOrDefault(x => x.TicketId == ticketId);
            if(result != null)
            {
                result.Title = title;
                context.SaveChanges();
            }
            return await context.Tickets.SingleOrDefaultAsync(x => x.TicketId == ticketId);
        }
    }
}
