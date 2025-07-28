using System.Collections.Generic;
using TodoApi.Entities;

namespace TodoApi.BusinessLayer
{
    public interface ITaskService
    {
        List<TaskItem> GetAll();
        TaskItem GetById(long id);
        void Add(TaskItem task);
        void Update(TaskItem task);
        void Delete(long id);
    }
}
