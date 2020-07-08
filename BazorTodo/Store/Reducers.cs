using System.Linq;
using Fluxor;

namespace BazorTodo.Store
{
    public static class Reducers
    {
        [ReducerMethod]
        public static TodoState AddTodoAction(TodoState state, AddTodoAction action)
        {
            int index = state.Todos.Count;
            state.Todos.Add(new Model.Todo { Description = action.Description, Index = index });
            return new TodoState(state.Todos);
        }

        [ReducerMethod]
        public static TodoState MarkAsDone(TodoState state, MarkAsDoneAction action)
        {
            state.Todos.Single(c => c.Index == action.Index).Done = true;
            return new TodoState(state.Todos);
        }

    }
}
