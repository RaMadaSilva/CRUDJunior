using CRUDJunior.Commands.Contracts;
using Flunt.Notifications;
using Flunt.Validations;

namespace CRUDJunior.Commands
{
    public class CriarAlunoCommand : Notifiable<Notification>, ICommand
    {
        public CriarAlunoCommand()
        {
            
        }
        public CriarAlunoCommand(string primeiroNome, 
                string ultimoNome, 
                string documento, 
                DateTime dataNascimento, 
                string telefone, 
                string imagem)
        {
            PrimeiroNome = primeiroNome;
            UltimoNome = ultimoNome;
            Documento = documento;
            DataNascimento = dataNascimento;
            Telefone = telefone;
            Imagem = imagem;
        }

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
    }
}
