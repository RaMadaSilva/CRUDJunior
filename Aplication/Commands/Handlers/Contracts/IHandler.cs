using CRUDJunior.Aplication.Commands.Contracts;

namespace CRUDJunior.Aplication.Commands.Handlers.Contracts
{
    public interface IHandler<T> where T : ICommand
    {
        ICommandResult Handle(T command);
    }
}
