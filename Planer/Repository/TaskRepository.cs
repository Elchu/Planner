using System.Collections.Generic;
using System.Linq;
using Planer.Models;

namespace Planer.Repository
{
    public class TaskRepository : ITaskRepository<Task>
    {
        private readonly ApplicationDbContext _db = new ApplicationDbContext();
        public IEnumerable<Task> Get()
        {
            return _db.Tasks.OrderBy(t=>t.StartDate);
        }

        public Task Get(int id)
        {
            return _db.Tasks.FirstOrDefault(t=>t.TaskId == id);
        }

        public Task Post(Task task)
        {
            _db.Tasks.Add(task);
            _db.SaveChanges();
            return task;
        }

        public void Remove(int id)
        {
            Task task = _db.Tasks.Find(id);
            _db.Tasks.Remove(task);
            _db.SaveChanges();
        }
    }
}