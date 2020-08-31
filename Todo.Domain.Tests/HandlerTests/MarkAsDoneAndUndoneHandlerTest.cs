using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Todo.Domain.Commands;
using Todo.Domain.Entities;
using Todo.Domain.Handlers;
using Todo.Domain.Tests.Repositories;

namespace Todo.Domain.Tests.HandlerTests
{
    [TestClass]
    public class MarkAsDoneAndUndoneHandlerTest
    {
        private readonly MarkTodoAsDoneCommand _donecommand = new MarkTodoAsDoneCommand(Guid.NewGuid(), "usuario valido");
        private readonly MarkTodoAsUndoneCommand _undonecommand = new MarkTodoAsUndoneCommand(Guid.NewGuid(), "usuario valido");
        private readonly TodoHandler _handler = new TodoHandler(new FakeTodoRepository());
        private GenericCommandResult _result = new GenericCommandResult();

        [TestMethod]
        public void mark_as_done()
        {
            _result = (GenericCommandResult) _handler.Handle(_donecommand);
            Assert.AreEqual(_result.Success, true);
        }

        [TestMethod]
        public void mark_as_undone()
        {
            _result = (GenericCommandResult) _handler.Handle(_undonecommand);
            Assert.AreEqual(_result.Success, true);
        }

    }
}