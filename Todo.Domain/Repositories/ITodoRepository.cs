using System;
using Todo.Domain.Entities;

namespace Todo.Domain.Repositories
{
    public interface ITodoRepository
    {
        void Create(TodoItem todo);
        void Uptade(TodoItem todo);
        TodoItem GetById(Guid id, string user);
    }
}