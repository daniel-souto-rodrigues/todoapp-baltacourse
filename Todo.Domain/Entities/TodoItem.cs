using System;

namespace Todo.Domain.Entities
{
    public class TodoItem : Entity
    {
        public string Title { get; private set; }
        public bool Done { get; private set; }
        public DateTime Date { get; private set; }
        public string User { get; private set; }

        public TodoItem(string title, DateTime date, string user)
        {
            this.Title = title;
            this.Done = false;
            this.Date = date;
            this.User = user;
        }

        public void MarkAsDone()
        {
            Done = true;
        }

        public void MarkAsUndone()
        {
            Done = false;
        }

        public void UpdateTitle(string title)
        {
            Title = title;
        }
    }
}