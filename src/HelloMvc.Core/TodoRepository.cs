using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HelloMvc.Core.Models;

namespace HelloMvc.Core
{
    public class TodoRepository : ITodoRepository
    {
        List<Todo> _todos = new List<Todo>();
        private static int _counter = 0;

        public void Add(Todo todo)
        {
            _todos.Add(todo);
            todo.Id = ++_counter;
        }

        public void Delete(int id)
        {
            var todo = _todos.FirstOrDefault(item => item.Id == id);
            if (todo == null)
            {
                return;
            }
            _todos.Remove(todo);
        }

        public IEnumerable<Todo> GetAll()
        {
            return _todos;
        }

        public IEnumerable<Todo> GetAllOverdue()
        {
            return _todos.Where(item => item.DueDate.Date < DateTime.Today);
        }

        public Todo GetById(int id)
        {
            return _todos.FirstOrDefault(item => item.Id == id);
        }
    }
}
