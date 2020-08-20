using BazorTodo.Model;
using System.Collections.Generic;

namespace BazorTodo.Store
{
    public interface ITodoState
    {
        List<Todo> Todos { get; }
    }
}