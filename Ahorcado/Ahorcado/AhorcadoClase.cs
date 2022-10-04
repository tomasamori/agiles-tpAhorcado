namespace Ahorcado
{
    public class AhorcadoClase
    {
        private string palabra = "palabra";

        public string generarPalabra()
        {
            return palabra;
        }

        public List<int> adivinarLetra(char letra)
        {
            List<int> lugares = new List<int>();

            for (int i = 0; i < palabra.Length; i++)
            {
                if (palabra[i] == letra)
                {
                    lugares.Add(i);
                }

            }

            return lugares;
        }
    }
}