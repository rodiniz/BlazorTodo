using System;

namespace BazorTodo.Model
{
    public class Todo
    {
        [Obsolete]
        public int Index { get; set; }
        public string Description { get; set; }
        public bool Done { get; set; }
    }
}
