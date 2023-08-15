using CRUDJunior.Domain.Models;

namespace CRUDJunior.Domain.UniteOfWork.Repositorios
{
    public interface IAlunoRepositorio
    {
        IEnumerable<Aluno> GetAll();
        Aluno GetById(int id);
        void UpdateAluno(int id);
        void DeleteAluno(int id);
        void SaveAluno(Aluno aluno);

    }
}
