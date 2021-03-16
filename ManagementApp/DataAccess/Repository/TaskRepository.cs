using ManagementApp.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ManagementApp.DataAccess.Repository
{
    public class TaskRepository<T> : ITaskRepository<Model.Task>
    {
        public readonly ManagementContext context;

        public TaskRepository(ManagementContext context)
        {
            this.context = context;
        }

        public async Task<Model.Task> AddTask(int ticketId, string title)
        {
            Model.Task task = new Model.Task()
            {
                Title = title,
                Status = false,
                ticketId = ticketId
            };
            context.Tasks.Add(task);
            await context.SaveChangesAsync();
            return task;
        }

        public void DeleteTask(int taskId)
        {
            var result = context.Tasks.SingleOrDefault<Model.Task>(x => x.Id == taskId);
            if(result != null)
            {
                context.Remove(result);
                context.SaveChanges();
            }
            return;
        }

        public async Task<Model.Task> EditTaskStatus(int taskId, bool status)
        {
            var result = context.Tasks.SingleOrDefault<Model.Task>(x => x.Id == taskId);
            if (result != null)
            {
                result.Status = status;
                await context.SaveChangesAsync();
            }
            return context.Tasks.SingleOrDefault<Model.Task>(x => x.Id == taskId);
        }

        public async Task<Model.Task> EditTaskTitle(int taskId, string title)
        {
            var result = context.Tasks.SingleOrDefault<Model.Task>(x => x.Id == taskId);
            if (result != null)
            {
                result.Title = title;
                await context.SaveChangesAsync();
            }
            return context.Tasks.SingleOrDefault<Model.Task>(x => x.Id == taskId);
        }
    }
}
