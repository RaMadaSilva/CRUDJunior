using CRUDJunior.Aplication.Commands.Contracts;
using CRUDJunior.Domain.Models;
using Flunt.Notifications;
using Flunt.Validations;

namespace CRUDJunior.Aplication.Commands
{
    public class EditarAlunoCommand :  Notifiable<Notification>, ICommand
    {
        public EditarAlunoCommand()
        {  
        }
        public EditarAlunoCommand(int id, 
                string primeiroNome, 
                string ultimoNome, 
                string documento, 
                DateTime dataNascimento, 
                string telefone, 
                string imagem)
        {
            Id = id;
            PrimeiroNome = primeiroNome;
            UltimoNome = ultimoNome;
            Documento = documento;
            DataNascimento = dataNascimento;
            Telefone = telefone;
            Imagem = imagem;
        }

        public int Id { get; set; }
        public string PrimeiroNome { get; set; }
        public string UltimoNome { get; set; }
        public string Documento { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Telefone { get; set; }
        public string Imagem { get; set; }
        public void Validar()
        {
            AddNotifications(new Contract<CriarAlunoCommand>()
                        .Requires()
                        .IsGreaterThan(PrimeiroNome, 3, "O nome deve conter no minimo 3 caracteres")
                        .IsGreaterThan(UltimoNome, 3, "O apelido deve conter no minimo 3 caracteres"));
        }

        public static implicit operator EditarAlunoCommand(Aluno aluno)
        {
            return new EditarAlunoCommand(aluno.Id,
                    aluno.NomeCompleto.PrimeiroNome,
                    aluno.NomeCompleto.UltimoNome,
                    aluno.CPF.Numero,
                    aluno.DataNascimento,
                    aluno.Telefone, aluno.Imagem);
        }  
    }
}
