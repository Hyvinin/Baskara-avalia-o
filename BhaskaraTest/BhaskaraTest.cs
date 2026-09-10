using BhaskaraApp;

namespace BhaskaraAppUnitTest
{
    [TestClass]
    public sealed class BhaskaraTest
    {
        private Bhaskara calc;

        [TestInitialize]
        public void Inicializar()
        {
            // Criando instância para a propriedade calc
            calc = new Bhaskara(1, -5, 6);
        }

        /* -------- Teste de condição normal -------- */

        [TestMethod]
        public void recebeParametros_DeveRetornarRaizesReais()
        {
            // Act - Invoca o artefato a ser testado
            bool obtido = calc.TemRaizesReais();

            // Assert - Compara os valores
            Assert.IsTrue(obtido);
        }

        /* -------- Teste do cálculo das raízes -------- */

        [TestMethod]
        public void recebeParametros_DeveCalcularRaizes()
        {
            // Act - Invoca o artefato a ser testado
            var obtido = calc.CalcularRaizes();

            // Assert - Compara os valores
            Assert.AreEqual(3, obtido.Item1);
            Assert.AreEqual(2, obtido.Item2);
        }

        /* -------- Teste de Delta igual a zero -------- */

        [TestMethod]
        public void deltaZero_DeveRetornarUmaRaizReal()
        {
            // Arrange
            calc = new Bhaskara(1, -4, 4);

            // Act
            bool obtido = calc.TemRaizesReais();

            // Assert
            Assert.IsTrue(obtido);
        }

        /* -------- Teste de Delta negativo -------- */

        [TestMethod]
        public void deltaNegativo_DeveRetornarFalse()
        {
            // Arrange
            calc = new Bhaskara(1, 2, 5);

            // Act
            bool obtido = calc.TemRaizesReais();

            // Assert
            Assert.IsFalse(obtido);
        }

        /* -------- Teste de raízes nulas -------- */

        [TestMethod]
        public void deltaNegativo_DeveRetornarRaizesNulas()
        {
            // Arrange
            calc = new Bhaskara(1, 2, 5);

            // Act
            var obtido = calc.CalcularRaizes();

            // Assert
            Assert.IsNull(obtido.Item1);
            Assert.IsNull(obtido.Item2);
        }

        /* -------- Teste de A igual a zero -------- */

        [TestMethod]
        public void recebeAZero_DeveLancarArgumentException()
        {
            // Act + Assert
            Assert.ThrowsExactly<ArgumentException>(() => new Bhaskara(0, 5, 6));
        }
    }
}