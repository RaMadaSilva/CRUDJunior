using CRUDJunior.Models.ValueObject;

namespace CRUDJunior.Teste.TesteModels.TesteValueObject
{
    [TestClass]
    public class TesteNome
    {
        private Nome nome1 = new Nome("Raul", "Silva");
        private Nome nome2 = new Nome("Raul", "Silva");
        [TestMethod]
        public void PrimeiroNomeComMenosDeTresCaracteres()
        {
            var nome = new Nome("", "marcos");
            Assert.AreEqual(false, nome.IsValid);
        }
        [TestMethod]
        public void UltimoNomeComMenosDeTresCaracteres()
        {
            var nome = new Nome("marcos", "");
            Assert.AreEqual(false, nome.IsValid);
        }
        [TestMethod]
        public void PrimeiroNomeComMenosComCaracteresValidos()
        {
            var nome = new Nome("Mateus", "");
            Assert.AreEqual(false, nome.IsValid);
        }
        [TestMethod]
        public void UltimoNomeComMenosComCaracteresValidos()
        {
            var nome = new Nome("", "marcos");
            Assert.AreEqual(false, nome.IsValid);
        }
        [TestMethod]
        public void NomeCompletoValido()
        {
            var nome = new Nome("Maurico", "marcos");
            Assert.AreEqual(true, nome.IsValid);
        }

        [TestMethod]
        public void DadoDoisNomesVeridicarIgualdade()
        {
            Assert.AreEqual(true, nome1.Equals(nome2));
        }
    }
}
