using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ManagementApp.Interface
{
    public interface IBoardRepository<Board> 
    {
        Task<Board> GetbyIdAsync(int id);
        Task<IReadOnlyList<Board>> ListAllAsync();
    }
}
