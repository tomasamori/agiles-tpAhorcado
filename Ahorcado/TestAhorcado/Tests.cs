using Ahorcado;

namespace TestAhorcado
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void ValidarPalabra()
        {
            AhorcadoClase ahorcado = new AhorcadoClase();

            Assert.AreEqual(ahorcado.palabra.ToLower(), ahorcado.generarPalabra());
        }

        [Test]
        public void ValidarLetra()
        {
            AhorcadoClase ahorcado = new AhorcadoClase();
            List<int> l = new List<int>();
            l.Add(1);
            l.Add(3);
            l.Add(6);
            
            Assert.AreEqual(l, ahorcado.adivinarLetra('a'));
        }

        [Test]
        public void ValidarQuitarVida()
        {
            AhorcadoClase ahorcado = new AhorcadoClase();

            List<int> l;
            int testVida = 6;

            l = ahorcado.adivinarLetra('e');

            if (l.Count == 0)
            {
                testVida = testVida - 1;
            }

            Assert.AreEqual(testVida, ahorcado.getVida());
        }
    }
}