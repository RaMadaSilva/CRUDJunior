using CRUDJunior.Domain.UniteOfWork.Repositorios;

namespace CRUDJunior.Domain.UniteOfWork
{
    public interface IUniteOfWork
    {
        IAlunoRepositorio AlunoRepositorio { get; }
        IAssinaturaRepositorio AssinaturaRepositorio { get; }

        void Commit();
    }
}
