namespace Ahorcado
{
    public class AhorcadoClase
    {
        public string palabra = "PALABRA";

        public string generarPalabra()
        {
            return palabra.ToLower();
        }

        public List<int> adivinarLetra(char letra)
        {
            List<int> lugares = new List<int>();

            string palabraLowerCase = palabra.ToLower();

            for (int i = 0; i < palabraLowerCase.Length; i++)
            {
                if (palabraLowerCase[i] == letra)
                {
                    lugares.Add(i);
                }

            }

            return lugares;
        }
    }
}