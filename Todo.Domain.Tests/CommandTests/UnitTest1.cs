using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Todo.Domain.Commands;

namespace Todo.Domain.Tests.CommandTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Dado_um_comando_invalido()
        {
            var command = new CreateTodoCommand("", "", DateTime.UtcNow);
            command.Validate();
            Assert.AreEqual(command.Valid, false);
        }

        [TestMethod]
        public void Dado_um_comando_valido()
        {
            var command = new CreateTodoCommand("Titulo da tarefa", "usuario", DateTime.UtcNow);
            command.Validate();
            Assert.AreEqual(command.Valid, true);
        }

        
    }
}
