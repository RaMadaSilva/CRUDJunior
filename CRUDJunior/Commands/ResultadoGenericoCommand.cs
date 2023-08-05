using CRUDJunior.Commands.Contracts;

namespace CRUDJunior.Commands
{
    public class ResultadoGenericoCommand : ICommandResult
    {
        public ResultadoGenericoCommand()
        {
            
        }
        public ResultadoGenericoCommand(bool sucesso, string mensagem, object objecto)
        {
            Sucesso = sucesso;
            Mensagem = mensagem;
            Objecto = objecto;
        }

        public bool Sucesso { get; set; }
        public string Mensagem { get; set; }
        public Object Objecto { get; set; }
    }
}
