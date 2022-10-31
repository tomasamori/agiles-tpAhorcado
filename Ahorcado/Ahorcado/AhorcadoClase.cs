namespace Ahorcado
{
    public class AhorcadoClase
    {
        public string palabra = "PALABRA";
        public int vida = 6;

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

            if (lugares.Count == 0)
            {
                this.vida = this.vida - 1;
            }

            return lugares;
        }

        public int getVida()
        {
            return this.vida;
        }

        public void adivinarPalabra(string palabra)
        {
            if (palabra != this.generarPalabra())
            {
                this.vida = 0;
            }
        }
    }
}