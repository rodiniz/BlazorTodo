using BazorTodo.Store;
using Fluxor;
using Microsoft.AspNetCore.Components;

namespace BazorTodo.Pages
{
    public partial class TodosList
    {
        public string Description { get; set; }
        [Inject]
        private IState<TodoState> TodoState { get; set; }

        [Inject]
        public IDispatcher Dispatcher { get; set; }
        public void AddTodo()
        {
            var action = new AddTodoAction(Description);
            Dispatcher.Dispatch(action);
            this.Description = string.Empty;
        }
        public void MarkAsDone(int index)
        {
            var action = new MarkAsDoneAction(index);
            Dispatcher.Dispatch(action);
        }
    }
}
