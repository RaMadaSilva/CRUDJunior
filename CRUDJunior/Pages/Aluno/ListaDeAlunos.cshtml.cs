using CRUDJunior.Domain.UniteOfWork;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CRUDJunior.Pages.Aluno
{
    public class ListaDeAlunosModel : PageModel
    {
        private readonly IUniteOfWork _uow;

        public ListaDeAlunosModel(IUniteOfWork uow)
        {
            _uow = uow;
        }
        public IEnumerable<CRUDJunior.Domain.Models.Aluno> Alunos { get; private set; }
        public void OnGet()
        {
            Alunos = _uow.AlunoRepositorio.GetAll(); 
        }
    }
}
