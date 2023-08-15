using CRUDJunior.Domain.Models;
using CRUDJunior.Domain.Models.ValueObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDJunior.Teste.TesteModels
{
    [TestClass]
    public class TesteAluno
    {
        private Nome nome = new Nome("Raul", "Silva");
        private Documento doc = new Documento("000565625LA032"); 
      
        [TestMethod]
        public void DadoUmAlunoAdicionaUmaAssinaturaInvalida()
        {
            var aluno = new Aluno(nome, doc, new DateTime(2000, 01, 01), "99999999", "imagem");
            var assin = new Assinatura(aluno, new DateTime(2023, 01, 01), new DateTime(2023, 07, 07)); 
            aluno.AddAssinaturas(assin);
            Assert.AreEqual(false, assin.IsValid);  
        }
    }
}
