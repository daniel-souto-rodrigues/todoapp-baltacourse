using Todo.Domain.Commands.Contracts;

namespace Todo.Domain.Commands
{
    public class GenericCommandResult : ICommandResult
    {
        public bool Success { get; set; }
        public string Message { get; set; }
        public object Data { get; set; }

        public GenericCommandResult() { }

        public GenericCommandResult(bool success, string message, object data)
        {
            this.Success = success;
            this.Message = message;
            this.Data = data;

        }
    }
}