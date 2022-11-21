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
        public void ValidarLetraCorrecta()
        {
            AhorcadoClase ahorcado = new AhorcadoClase("palabra", 7);

            Assert.AreEqual("Acierto", ahorcado.adivinarLetra('a'));
        }

        [Test]
        public void ValidarLetraMayusculaCorrecta()
        {
            AhorcadoClase ahorcado = new AhorcadoClase("palabra", 7);

            Assert.AreEqual("Acierto", ahorcado.adivinarLetra('A'));
        }

        [Test]
        public void ValidarLetraIncorrecta()
        {
            AhorcadoClase ahorcado = new AhorcadoClase("palabra", 7);

            Assert.AreEqual("Letra incorrecta", ahorcado.adivinarLetra('k'));
        }

        [Test]
        public void ValidarLetraIncorrectaMayuscula()
        {
            AhorcadoClase ahorcado = new AhorcadoClase("palabra", 7);

            Assert.AreEqual("Letra incorrecta", ahorcado.adivinarLetra('K'));
        }

        [Test]
        public void ValidarEspacioBlanco()
        {
            AhorcadoClase ahorcado = new AhorcadoClase("palabra", 7);
            Assert.AreEqual("Debe ingresar una letra valida", ahorcado.adivinarLetra(' '));
        }

        [Test]
        public void ValidarComa()
        {
            AhorcadoClase ahorcado = new AhorcadoClase("palabra", 7);
            Assert.AreEqual("Debe ingresar una letra valida", ahorcado.adivinarLetra(','));
        }

        [Test]
        public void ValidarEstadoPalabra()
        {
            AhorcadoClase ahorcado = new AhorcadoClase("palabra", 7);

            ahorcado.adivinarLetra('a');

            Assert.AreEqual("_a_a__a", ahorcado.estadoPalabra);
        }
        
        [Test]
        public void ValidarQuitarVida()
        {
            AhorcadoClase ahorcado = new AhorcadoClase("palabra", 7);
            ahorcado.adivinarLetra('e');
            Assert.AreEqual(6, ahorcado.getVida());
        }
        /*
        [Test]
        public void ValidarQuePerdio()
        {
            AhorcadoClase ahorcado = new AhorcadoClase();

            List<int> l;
            int testVida = 6;
            

            Assert.AreEqual(testVida, ahorcado.getVida());
        }
        */
    }
}