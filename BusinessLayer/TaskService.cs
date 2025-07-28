using System.Collections.Generic;
using TodoApi.DataAccess;
using TodoApi.Entities;

namespace TodoApi.BusinessLayer
{
    public class TaskService : ITaskService
    {
        private readonly ITaskRepository _taskRepository;

        public TaskService(ITaskRepository taskRepository)
        {
            _taskRepository = taskRepository;
        }

        public List<TaskItem> GetAll() => _taskRepository.GetAll();

        public TaskItem GetById(long id) => _taskRepository.GetById(id);

        public void Add(TaskItem task) => _taskRepository.Add(task);

        public void Update(TaskItem task) => _taskRepository.Update(task);

        public void Delete(long id) => _taskRepository.Delete(id);
    }
}
