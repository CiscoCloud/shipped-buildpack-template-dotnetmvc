using System.Collections.Generic;
using HelloMvc.Core;
using Microsoft.AspNet.Mvc;
using HelloMvc.Core.Models;

namespace HelloMvc.Controllers.Api
{
    [Route("api/[controller]")]
    public class TodoController : Controller
    {
        private ITodoRepository _todos;

        public TodoController(ITodoRepository todos)
        {
            _todos = todos;
        }

        // GET: api/todo
        [HttpGet]
        public IEnumerable<Todo> Get()
        {
            return _todos.GetAll();
        }

        // GET api/todo/5
        [HttpGet("{id}")]
        public Todo Get(int id)
        {
            return _todos.GetById(id);
        }

        // POST api/todo
        [HttpPost]
        public void Post([FromBody]Todo todo)
        {
            if (!ModelState.IsValid)
            {
                Context.Response.StatusCode = 400;
                return;
            }

            _todos.Add(todo);
        }

        // DELETE api/todo/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {

        }
    }
}
