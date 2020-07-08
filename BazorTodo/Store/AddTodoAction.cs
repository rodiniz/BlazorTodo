namespace BazorTodo.Store
{
    public class AddTodoAction
    {
        public string Description { get; set; }
        public AddTodoAction(string todo)
        {
            this.Description = todo;
        }
    }
}
