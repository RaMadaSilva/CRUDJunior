using CRUDJunior.Aplication.Commands;
using CRUDJunior.Aplication.Commands.Handlers;
using CRUDJunior.Domain.UniteOfWork;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CRUDJunior.Pages.Aluno
{
    public class EditarAlunoModel : PageModel
    {
        private readonly AlunoHandler _handler;
        private readonly IUniteOfWork _uniteOfWork;

        //public CRUDJunior.Domain.Models.Aluno Aluno { get; set; }
  
        public EditarAlunoModel(AlunoHandler handler, IUniteOfWork uniteOfWork) 
        { 
            _handler = handler; 
            _uniteOfWork = uniteOfWork;
        }

        [BindProperty]
        public EditarAlunoCommand Command { get; set; }
        public IActionResult OnGet(int id)
        {
            EditarAlunoCommand Command = _uniteOfWork.AlunoRepositorio.GetById(id);

            if (Command is null)
                return NotFound(); 
            return Page();
        }
        public IActionResult OnPost() 
        {
            if (!ModelState.IsValid)
                return Page();

            _handler.Handle(Command);
            return RedirectToPage("./ListaDeAlunos");
        }
    }
}
