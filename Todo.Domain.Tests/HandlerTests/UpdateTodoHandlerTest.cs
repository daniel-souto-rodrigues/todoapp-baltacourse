using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Todo.Domain.Commands;
using Todo.Domain.Handlers;
using Todo.Domain.Tests.Repositories;

namespace Todo.Domain.Tests.HandlerTests
{
    [TestClass]
    public class UpdateTodoHandlerTest
    {
        private readonly UpdateTodoCommand _commandUpdate = new UpdateTodoCommand(Guid.NewGuid(), "Titulo att", "usuario valido");
        private readonly TodoHandler _handler = new TodoHandler(new FakeTodoRepository());
        private GenericCommandResult _result = new GenericCommandResult();

        [TestMethod]
        public void Atualiza_o_titulo_de_um_todo_criado_para_titulo_atualizado()
        {
            _handler.Handle(_commandUpdate);
            Assert.AreEqual(_commandUpdate.Title, "Titulo att");
        }

        [TestMethod]
        public void Ao_atualizar_valida_o_titulo_e_usuario()
        {
            _result = (GenericCommandResult)_handler.Handle(_commandUpdate);
            Assert.AreEqual(_result.Success, true);
        }

        [TestMethod]
        public void mostra_na_tela_as_notificacoes()
        {
            _result = (GenericCommandResult)_handler.Handle(_commandUpdate);
            Assert.AreEqual(_commandUpdate.Notifications.Count, 0);
        }
    }
}