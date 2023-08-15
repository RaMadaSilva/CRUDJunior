using Flunt.Validations;

namespace CRUDJunior.Domain.Models
{
    public class Assinatura : Model
    {
        public Assinatura()
        {
        }
        public Assinatura(Aluno aluno, DateTime inicio, DateTime termino)
        {
            AddNotifications(new Contract<Assinatura>()
                .Requires()
                .IsGreaterOrEqualsThan(inicio, DateTime.UtcNow,  "Não é possivel criar uma assinatura no passado")
                .IsGreaterThan(termino, inicio, "A data de termino deve superior a data actual")); 
            
            Aluno = aluno;
            DataCriacao = DateTime.UtcNow;
            Inicio = inicio;
            Termino = termino;
            Expirada = false;
        }
        public Aluno Aluno { get; private set; }
        public DateTime DataCriacao { get; private set; }
        public DateTime Inicio { get; private set; }
        public DateTime Termino { get; private set; }
        public bool Expirada { get; private set; }

        public void AssinaturaExpirada()
        {
            if(Termino>=DateTime.UtcNow)
                Expirada = true;    
        }
    }
}
