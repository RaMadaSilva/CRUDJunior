using CRUDJunior.Models.ValueObject;
using Flunt.Notifications;

namespace CRUDJunior.Models
{
    public class Aluno : Model
    {
        private List<Assinatura> _assinaturas;

        public Aluno()
        {
        }
        public Aluno(Nome nomeCompleto,
                      Documento cpf,
                      DateTime dataNascimento,
                      string telefone,
                      string imagem)
        {
            AddNotifications(nomeCompleto.Notifications); 

            NomeCompleto = nomeCompleto;
            CPF = cpf;
            DataNascimento = dataNascimento;
            Telefone = telefone;
            Imagem = imagem;
            _assinaturas = new List<Assinatura>();
        }

        public Nome NomeCompleto { get; private set; }
        public Documento CPF { get; private set; }
        public DateTime DataNascimento { get; private set; }
        public string Telefone { get; private set; }
        public string Imagem { get; private set; }
        public IReadOnlyCollection<Assinatura> Assinaturas { get { return _assinaturas; } }

        public bool AddAssinaturas(Assinatura novaAssinatura)
        {
            if (!IsValid)
                return false;

            _assinaturas.Add(novaAssinatura);
            return true;

        }

        public Assinatura AssinaturaActual {
            get {
                return Assinaturas.FirstOrDefault(x => x.Expirada == false);
            }
        }

        public bool AssinaturaValida()
        {
            var assinatura = this.AssinaturaActual;
            if (assinatura == null)
                return false;
            return true;
        }

    }
}
