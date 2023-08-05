using CRUDJunior.Commands.Contracts;
using CRUDJunior.Commands.Handlers.Contracts;
using CRUDJunior.Models;
using CRUDJunior.Models.ValueObject;
using CRUDJunior.UniteOfWork.Contracts;
using Flunt.Notifications;

namespace CRUDJunior.Commands.Handlers
{
    public class AlunoHandler : Notifiable<Notification>, IHandler<CriarAlunoCommand>
    {
        private readonly IUniteOfWork _uniteOfWork;

        public AlunoHandler(IUniteOfWork uniteOfWork)
        {
            _uniteOfWork = uniteOfWork;
        }

        public ICommandResult Handle(CriarAlunoCommand command)
        {
            //validar todas as notificações
            command.Validar();
            if (!command.IsValid)
                return new ResultadoGenericoCommand(false, "Dados Invalidos", command.Notifications);

            //Criar os VOs
            var nome = new Nome(command.PrimeiroNome, command.UltimoNome);
            var doc = new Documento(command.Documento);

            //Criar o Aluno

            var aluno = new Aluno(nome, doc, command.DataNascimento, command.Telefone, command.Imagem);

            //Salva no Banco de dados 
            _uniteOfWork.AlunoRepositorio.SaveAluno(aluno);
            _uniteOfWork.Commit();

            //Retorna o Resultado

            return new ResultadoGenericoCommand(true, "Aluno Salvo", aluno); 
        }
    }
}
