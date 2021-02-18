using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ManagementApp.Model;
using Microsoft.EntityFrameworkCore;

namespace ManagementApp.DataAccess
{
    public class ManagementContext : DbContext
    {
        public ManagementContext( DbContextOptions options) : base(options)
        {
        }

        public DbSet<Board> Boards { get; set; }
        public DbSet<Column> Columns { get; set; }
        public DbSet<Ticket> Tickets { get; set; }
        public DbSet<Model.Task> Tasks { get; set; }

    }
}
