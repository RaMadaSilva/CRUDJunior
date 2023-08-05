using CRUDJunior.Context;
using CRUDJunior.Models;
using CRUDJunior.UniteOfWork.Repositories.Contracts;
using Microsoft.EntityFrameworkCore;

namespace CRUDJunior.UniteOfWork.Repositories
{
    public class AssinaturaRepositorio : IAssinaturaRepositorio
    {
        private readonly CrudeContext _context;

        public AssinaturaRepositorio(CrudeContext context)
        {
            _context = context;
        }

        public void DeleteAssinatura(int id)
        {
            var assinatura = GetById(id);
            _context.Remove(assinatura);     
        }

        public IEnumerable<Assinatura> GetAll()
        {
            return _context.Assinaturas.AsNoTracking().ToList();
        }

        public Assinatura GetById(int id)
        {
            return (Assinatura) _context.Assinaturas.Where(x => x.Id == id); 
        }

        public void SaveAssinatura(Assinatura assinatura)
        {
            _context.Add(assinatura);
        }

        public void UpdateAssinatura(int id)
        {
            var assinatura = GetById(id);
            _context.Entry(assinatura).State = EntityState.Modified; 
        }
    }
}
