using CRUDJunior.Aplication.Commands.Contracts;
using CRUDJunior.Aplication.Commands.Handlers.Contracts;
using CRUDJunior.Domain.Models;
using CRUDJunior.Domain.Models.ValueObject;
using CRUDJunior.Domain.UniteOfWork;
using Flunt.Notifications;

namespace CRUDJunior.Aplication.Commands.Handlers
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

        public ICommandResult Handle(EditarAlunoCommand command)
        {
            //Validar todas as Notificações 
            command.Validar(); 
            if (!command.IsValid)
                return new ResultadoGenericoCommand(false, "Aluno não pode ser actualizado", command.Notifications);
            var aluno = _uniteOfWork.AlunoRepositorio.GetById(command.Id);
            if (aluno is null)
                return new ResultadoGenericoCommand(false, "Aluno não Existe", string.Empty); 
            _uniteOfWork.AlunoRepositorio.UpdateAluno(command.Id);
            _uniteOfWork.Commit();

            return new ResultadoGenericoCommand(true, "Aluno actualizado com sucesso", aluno); 
        }
    }
}
