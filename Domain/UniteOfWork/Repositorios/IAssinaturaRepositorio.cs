using CRUDJunior.Domain.Models;

namespace CRUDJunior.Domain.UniteOfWork.Repositorios
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
