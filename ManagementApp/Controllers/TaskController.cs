using ManagementApp.DataAccess.Repository;
using ManagementApp.Interface;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ManagementApp.Controllers
{
    public class TaskController: BaseController
    {
        private ITaskRepository<Model.Task> taskRepository;

        public TaskController(ITaskRepository<Model.Task> taskRepository)
        {
            this.taskRepository = taskRepository;
        }

        [HttpPost("Add/ticketId={ticketId},title='{title}'")]
        public async Task<Model.Task> AddTaskTitle(int ticketId, String title)
        {
            return await taskRepository.AddTask(ticketId, title);
        }

        [HttpPut("Edit/taskId={taskId},title='{title}'")]
        public async Task<Model.Task> EditTaskTitle(int taskId, string title)
        {
            return await taskRepository.EditTaskTitle(taskId, title);
        }

        [HttpPut("Edit/taskId={taskId},status={status}")]
        public async Task<Model.Task> EditTaskStatus(int taskId, bool status)
        {
            return await taskRepository.EditTaskStatus(taskId, status);
        }

        [HttpDelete("Delete/taskId={taskId}")]
        public void DeleteTask(int taskId)
        {
            taskRepository.DeleteTask(taskId);
        }
    }
}
