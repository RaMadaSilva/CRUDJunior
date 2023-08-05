using CRUDJunior.Context;
using CRUDJunior.UniteOfWork.Contracts;
using CRUDJunior.UniteOfWork.Repositories;
using CRUDJunior.UniteOfWork.Repositories.Contracts;

namespace CRUDJunior.UniteOfWork
{
    public class UniteOfWork : IUniteOfWork
    {
        private readonly CrudeContext _context;
        private IAlunoRepositorio alunoRepositorio;
        private IAssinaturaRepositorio assinaturaRepositorio;

        public UniteOfWork(CrudeContext context)
        {
            _context = context;
        }

        public IAlunoRepositorio AlunoRepositorio
        {
            get { return alunoRepositorio ?? new AlunoRepositorio(_context); }
        }

        public IAssinaturaRepositorio AssinaturaRepositorio
        {
            get { return assinaturaRepositorio ?? new AssinaturaRepositorio(_context); }
        }

        public void Commit()
        {
            _context.SaveChanges();
        }
    }
}
