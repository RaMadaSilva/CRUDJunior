using CRUDJunior.Context;
using CRUDJunior.Domain.UniteOfWork;
using CRUDJunior.Domain.UniteOfWork.Repositorios;
using CRUDJunior.UniteOfWork.Repositories;

namespace CRUDJunior.Infrastruture.UniteOfWork
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
