using System;

namespace BlazorTestTodo
{
    public class TodoItem
    {
        public string Title { get; set; }
        public bool IsDone { get; set; }

        public TodoItem()
        {
            this.Title = Title;
            this.IsDone = IsDone;
        }

    }
}
