using ManagementApp.Interface;
using ManagementApp.Model;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ManagementApp.Controllers
{
    public class TicketController : BaseController
    {
        public readonly ITicketRepository<Ticket> ticketRepository;

        public TicketController(ITicketRepository<Ticket> ticketRepository)
        {
            this.ticketRepository = ticketRepository;
        }

        [HttpGet]
        public async Task<IReadOnlyList<Ticket>> getTicket()
        {
            return await ticketRepository.ListAllAsync();
        }

        [HttpGet("{id}")]
        public async Task<Ticket> getTicketById(int id)
        {
            return await ticketRepository.GetbyIdAsync(id);
        }
    }
}
