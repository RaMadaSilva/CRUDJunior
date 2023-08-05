using CRUDJunior.UniteOfWork.Repositories.Contracts;

namespace CRUDJunior.UniteOfWork.Contracts
{
    public interface IUniteOfWork
    {
        IAlunoRepositorio AlunoRepositorio { get; }
        IAssinaturaRepositorio AssinaturaRepositorio { get; }

        void Commit(); 
    }
}
