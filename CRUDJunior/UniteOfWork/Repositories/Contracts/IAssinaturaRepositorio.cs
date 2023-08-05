using CRUDJunior.Models;

namespace CRUDJunior.UniteOfWork.Repositories.Contracts
{
    public interface IAssinaturaRepositorio
    {
        IEnumerable<Assinatura> GetAll();
        Assinatura GetById(int id);
        void UpdateAssinatura(int id);
        void DeleteAssinatura(int id);
        void SaveAssinatura(Assinatura assinatura);
    }
}
