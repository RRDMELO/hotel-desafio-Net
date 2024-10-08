using Xunit;
using DesafioProjetoHospedagem.Models;
using System.Collections.Generic;

namespace Calculadora.Tests
{
    public class ReservaTests
    {
        private List<Pessoa> hospedes;
        private Suite suite;
        private Reserva reserva;

        public ReservaTests()
        {
            hospedes = new List<Pessoa>
            {
                new Pessoa("Hóspede 1"),
                new Pessoa("Hóspede 2"),
                new Pessoa("Hóspede 3"),
                new Pessoa("Hóspede 4"),
                new Pessoa("Hóspede 5")
            };

            suite = new Suite("Premium", 7, 75);
            reserva = new Reserva(11);
            reserva.CadastrarSuite(suite);
            reserva.CadastrarHospedes(hospedes);
        }

        [Fact]
        public void TestObterQuantidadeHospedes()
        {
            int quantidadeHospedes = reserva.ObterQuantidadeHospedes();
            Assert.Equal(5, quantidadeHospedes);
        }

        [Fact]
        public void TestCalcularValorDiaria()
        {
            Assert.Equal(75 * 11 * 0.9M, reserva.CalcularValorDiaria());
        }

        [Fact]
        public void TestExibirSuite()
        {
            Assert.Equal("Premium", reserva.Suite.TipoSuite);
            Assert.Equal(7, reserva.Suite.Capacidade);
            Assert.Equal(75, reserva.Suite.ValorDiaria);
        }
    }
}