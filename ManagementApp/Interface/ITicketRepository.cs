using ManagementApp.Model;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ManagementApp.Interface
{
    public interface ITicketRepository<Ticket>
    {
        Task<Ticket> GetbyIdAsync(int id);
        Task<IReadOnlyList<Ticket>> ListAllAsync();
        Task<Ticket> AddTicket(int colId, String title, string description);
        Task<Ticket> EditTicket(int ticketId, String title);
        Task<Ticket> EditTicketDescription(int ticketId, String description);
        void DeleteTicket(int ticketId);
    }
}
