namespace BazorTodo.Store
{
    public class MarkAsDoneAction
    {
        public int Index { get; set; }
        public MarkAsDoneAction(int index)
        {
            Index = index;
        }
    }
}
