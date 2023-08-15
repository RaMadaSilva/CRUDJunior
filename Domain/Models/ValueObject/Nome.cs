using Flunt.Notifications;
using Flunt.Validations;

namespace CRUDJunior.Domain.Models.ValueObject
{
    public class Nome : ValueObject, IEquatable<Nome>
    {
        public Nome()
        {
        }
        public Nome(string primeiroNome, string ultimoNome)
        {
            AddNotifications(new Contract<Nome>()
                                .Requires()
                                .IsGreaterThan(primeiroNome, 3, "O nome deve conter no minimo 3 caracteres")
                                .IsGreaterThan(ultimoNome, 3, "O apelido deve conter no minimo 3 caracteres")); 
            PrimeiroNome = primeiroNome;
            UltimoNome = ultimoNome;
        }

        public string PrimeiroNome { get; private set; }
        public string UltimoNome { get; private set; }

        public bool Equals(Nome? other)
        {
           return  PrimeiroNome == other.PrimeiroNome 
                    && UltimoNome == other.UltimoNome; 
        }

        public override string ToString()
        {
            return $"{PrimeiroNome} {UltimoNome}";
        }
    }
}
