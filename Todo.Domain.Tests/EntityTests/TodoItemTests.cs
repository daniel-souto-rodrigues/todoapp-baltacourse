using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Todo.Domain.Entities;

namespace Todo.Domain.Tests.EntityTests
{
    [TestClass]
    public class TodoItemTests
    {
        private readonly TodoItem _todo = new TodoItem("Titulo",DateTime.Now, "usuarioteste");

        public TodoItemTests()
        {

        }

        [TestMethod]
        public void Dado_um_novo_todo_done_tem_que_ser_falso()
        {
            Assert.AreEqual(_todo.Done, false);
        }
    }
}