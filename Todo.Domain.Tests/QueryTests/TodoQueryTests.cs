using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Todo.Domain.Entities;
using Todo.Domain.Queries;

namespace Todo.Domain.Tests.QueryTests
{
    [TestClass]
    public class TodoQueryTests
    {
        private List<TodoItem> _items;

        public TodoQueryTests()
        {
            _items = new List<TodoItem>();
            _items.Add(new TodoItem("Nova tarefa", DateTime.Now, "danielsr"));
            _items.Add(new TodoItem("Nova tarefa 1", DateTime.Now, "usuario1"));
            _items.Add(new TodoItem("Nova tarefa 2", DateTime.Now, "danielsr"));
            _items.Add(new TodoItem("Nova tarefa 3", DateTime.Now, "usuario3"));
        }

        [TestMethod]
        public void Dada_a_consulta_deve_retornar_tarefas_apenas_do_usuario_danielsr()
        {
            var result = _items.AsQueryable().Where(TodoQueries.GetAll("danielsr"));
            Assert.AreEqual(result.Count(), 2);
        }


    }
}