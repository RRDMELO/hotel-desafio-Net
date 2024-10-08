using Xunit;
using DesafioProjetoHospedagem.Models;

namespace DesafioProjetoHospedagem.Tests
{
    public class SuiteTests
    {
        [Fact]
        public void TestSuitePropriedades()
        {
            // Arrange
            var suite = new Suite("Premium", 7, 100.50m);

            // Act & Assert
            Assert.Equal("Premium", suite.TipoSuite);
            Assert.Equal(7, suite.Capacidade);
            Assert.Equal(100.50m, suite.ValorDiaria);
        }

        [Fact]
        public void TestSuiteConstrutorSemParametros()
        {
            // Arrange
            var suite = new Suite();

            // Act & Assert
            Assert.Null(suite.TipoSuite);
            Assert.Equal(0, suite.Capacidade);
            Assert.Equal(0m, suite.ValorDiaria);
        }

        [Fact]
        public void TestSuiteConstrutorComParametros()
        {
            // Arrange
            var suite = new Suite("Luxo", 4, 200.75m);

            // Act & Assert
            Assert.Equal("Luxo", suite.TipoSuite);
            Assert.Equal(4, suite.Capacidade);
            Assert.Equal(200.75m, suite.ValorDiaria);
        }
    }
}
