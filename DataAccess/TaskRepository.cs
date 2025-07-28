using System.Collections.Generic;
using System.Linq;
using TodoApi.Entities;

namespace TodoApi.DataAccess
{
    public class TaskRepository : ITaskRepository
    {
        private readonly AppDbContext _context;

        public TaskRepository(AppDbContext context)
        {
            _context = context;
        }

        public List<TaskItem> GetAll()
        {
            return _context.Gorevler.OrderByDescending(t => t.CreatedAt).ToList();
        }

        public TaskItem GetById(long id)
        {
            return _context.Gorevler.Find(id);
        }

        public void Add(TaskItem task)
        {
            _context.Gorevler.Add(task);
            _context.SaveChanges();
        }

        public void Update(TaskItem task)
        {
            _context.Gorevler.Update(task);
            _context.SaveChanges();
        }

        public void Delete(long id)
        {
            var task = _context.Gorevler.Find(id);
            if (task != null)
            {
                _context.Gorevler.Remove(task);
                _context.SaveChanges();
            }
        }
    }
}
