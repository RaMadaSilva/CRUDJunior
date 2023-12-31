﻿using CRUDJunior.Aplication.Commands.Contracts;

namespace CRUDJunior.Aplication.Commands
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
