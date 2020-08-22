using BazorTodo.Model;
using BazorTodo.Store;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Forms;
using System.Linq;

namespace BazorTodo.Pages
{
    public partial class TodosList
    {
        public Todo EditedTodo { get; set; } = new Todo();


        [Inject]
        private ITodoState TodoState { get; set; }

        public void AddTodo()
        {
            TodoState.Todos.Add(EditedTodo);
            EditedTodo = new Todo();
        }
        public void MarkAsDone(int index)
        {
            TodoState.Todos[index].Done = true;
        }


        
    }
}
