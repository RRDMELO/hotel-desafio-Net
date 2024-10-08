using Xunit;
using DesafioProjetoHospedagem.Models;

namespace DesafioProjetoHospedagem.Tests
{
    public class PessoaTests
    {
        [Fact]
        public void TestNomeCompletoSemSobrenome()
        {
            // Arrange
            var pessoa = new Pessoa("Nome");

            // Act
            var nomeCompleto = pessoa.NomeCompleto;

            // Assert
            Assert.Equal("NOME ", nomeCompleto);
        }

        [Fact]
        public void TestNomeCompletoComSobrenome()
        {
            // Arrange
            var pessoa = new Pessoa("Nome", "Sobrenome");

            // Act
            var nomeCompleto = pessoa.NomeCompleto;

            // Assert
            Assert.Equal("NOME SOBRENOME", nomeCompleto);
        }

        [Fact]
        public void TestPropriedades()
        {
            // Arrange
            var pessoa = new Pessoa
            {
                Nome = "João",
                Sobrenome = "Silva"
            };

            // Act & Assert
            Assert.Equal("João", pessoa.Nome);
            Assert.Equal("Silva", pessoa.Sobrenome);
        }
    }
}
