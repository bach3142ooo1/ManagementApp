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

        [HttpPost("Add/colId={colId},title='{title}',description='{description}'")]
        public async Task<Ticket> AddTicket(int colId, string title, string description)
        {
            return await ticketRepository.AddTicket(colId, title, description);
        }

        [HttpPut("Edit/ticketId={ticketId},title='{title}'") ]
        public async Task<Ticket> EditTicket(int ticketId, string title)
        {
            return await ticketRepository.EditTicket(ticketId, title);
        }

        [HttpPut("Edit/ticketId={ticketId},description='{description}'")]
        public async Task<Ticket> EditTicketDescription(int ticketId, string description)
        {
            return await ticketRepository.EditTicketDescription(ticketId, description);
        }

        [HttpDelete("Delete/ticketId={ticketId}")]
        public void DeleteTicket(int ticketId)
        {
            ticketRepository.DeleteTicket(ticketId);
        }

    }
}
