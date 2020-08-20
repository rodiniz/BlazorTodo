using System.Collections.Generic;
using BazorTodo.Model;

namespace BazorTodo.Store
{
    public class TodoState : ITodoState
    {
        public List<Todo> Todos { get; }

        public  TodoState(List<Todo> _todos)
        {
            Todos = _todos;
        }
    }
}
