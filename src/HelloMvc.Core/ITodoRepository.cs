using HelloMvc.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloMvc.Core
{
    public interface ITodoRepository
    {
        IEnumerable<Todo> GetAll();
        Todo GetById(int id);

        IEnumerable<Todo> GetAllOverdue();

        void Add(Todo todo);

        void Delete(int id);
    }
}
