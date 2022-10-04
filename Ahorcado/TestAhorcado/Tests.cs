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

            Assert.AreEqual("palabra", ahorcado.generarPalabra());
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
    }
}