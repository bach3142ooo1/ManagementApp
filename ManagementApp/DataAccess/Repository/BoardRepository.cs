using ManagementApp.Interface;
using ManagementApp.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ManagementApp.DataAccess.Repository
{
    public class BoardRepository<T> : IBoardRepository<Board>
    {
        private readonly ManagementContext context;
        public BoardRepository(ManagementContext context)
        {
            this.context = context;
        }

        public async Task<Board> GetbyIdAsync(int id)
        {
            return await context.Boards
                .Include(p => p.Columns)
                .ThenInclude(p => p.Tickets)
                .FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<IReadOnlyList<Board>> ListAllAsync()
        {
            return await context.Boards.Include(p => p.Columns).
                ToListAsync();
        }
    }
}
