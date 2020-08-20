using BazorTodo.Model;
using BazorTodo.Store;
using Fluxor;
using Microsoft.AspNetCore.Components;

namespace BazorTodo.Pages
{
    public partial class TodosList
    {
        public string Description { get; set; }
        [Inject]
        private ITodoState TodoState { get; set; }

        public void AddTodo()
        {
            var action = new Todo() { Description = this.Description };
            TodoState.Todos.Add(action);
            this.Description = string.Empty;
        }
        public void MarkAsDone(int index)
        {
            TodoState.Todos[index].Done = true;
        }
    }
}
