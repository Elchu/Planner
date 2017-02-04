using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Planer.Repository
{
    interface ITaskRepository<T>
    {
        /// <summary>
        /// return Task list
        /// </summary>
        /// <returns>return Task list</returns>
        IEnumerable<T> Get();

        /// <summary>
        /// return Task list at ID
        /// </summary>
        /// <param name="id">Task ID</param>
        /// <returns>Task list</returns>
        T Get(int id);

        /// <summary>
        /// Adding Task
        /// </summary>
        /// <param name="task">Add task</param>
        /// <returns>Task</returns>
        T Post(T task);

        /// <summary>
        /// Removing Task
        /// </summary>
        /// <param name="id">Task ID</param>
        void Remove(int id);
    }
}
