using Flunt.Notifications;

namespace CRUDJunior.Domain.Models.ValueObject
{
    public class Documento : ValueObject, IEquatable<Documento>
    {
        public Documento()
        {
            
        }
        public Documento(string numero)
        {
            Numero = numero;
        }

        public string Numero { get; private set; }

        public bool Equals(Documento? other)
        {
            return Numero == other.Numero; 
        }
    }
}
