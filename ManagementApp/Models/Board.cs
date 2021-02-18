using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ManagementApp.Model
{
    public class Board
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public IReadOnlyList<Column> Columns  { get; set; } 
    }
}
