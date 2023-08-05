using CRUDJunior.Commands;
using CRUDJunior.Commands.Handlers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CRUDJunior.Pages.Aluno
{
    public class CadastroAlunoModel : PageModel
    {
        private readonly AlunoHandler _handler;

        public CadastroAlunoModel(AlunoHandler handler)
        {
            _handler = handler;
        }
        [BindProperty]
        public CriarAlunoCommand Model { get; set; }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
                return Page();
            _handler.Handle(Model);

            return RedirectToPage("ListaDeAlunos"); 
        }
        public void OnGet()
        {
        }
    }
}
