using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ManagementApp.Interface
{
    public interface ITaskRepository<Task>
    {
        Task<Model.Task> AddTask(int colID,string title) ;
        Task<Model.Task> EditTaskTitle(int taskId, string title);
        Task<Model.Task> EditTaskStatus(int taskId, bool status);
        void DeleteTask(int taskId);
        
    }
}
