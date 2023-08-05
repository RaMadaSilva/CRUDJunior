using CRUDJunior.Models;

namespace CRUDJunior.UniteOfWork.Repositories.Contracts
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
