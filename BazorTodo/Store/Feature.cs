using System.Collections.Generic;
using Fluxor;

namespace BazorTodo.Store
{
    public class Feature : Feature<TodoState>
    {
        public override string GetName()
        {
            return "TODOS";
        }

        protected override TodoState GetInitialState() =>
        new TodoState(new List<Model.Todo>());
    }
}
