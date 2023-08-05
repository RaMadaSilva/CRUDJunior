using CRUDJunior.Commands.Contracts;

namespace CRUDJunior.Commands.Handlers.Contracts
{
    public interface IHandler<T> where T : ICommand
    {
        ICommandResult Handle(T command);
    }
}
