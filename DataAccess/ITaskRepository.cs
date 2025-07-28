
using System.Collections.Generic;
using TodoApi.Entities;

namespace TodoApi.DataAccess
{
    public interface ITaskRepository
    {
        List<TaskItem> GetAll();
        TaskItem GetById(long id);
        void Add(TaskItem task);
        void Update(TaskItem task);
        void Delete(long id);
    }
}
