using ManagementApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ManagementApp.Interface
{
    public interface IColumnRepository
    {
        Task<Column> GetbyIdAsync(int id);
        Task<IReadOnlyList<Column>> ListAllAsync();
    }
}
