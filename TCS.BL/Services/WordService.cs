using System.Linq;

namespace TCS.BL.Services
{
    public class WordService
    {
        /// <summary>
        /// Metodo para contar la repeticion de una palabra en una frase.
        /// </summary>
        /// <param name="text">Frase</param>
        /// <param name="word">Palabra a buscar</param>
        /// <returns>Cantidad de repeticiones</returns>
        public int WordsCount(string text, string word)
        {
            if (string.IsNullOrEmpty(text)) return 0;

            var separator = new char[] { ' ', ',', '.', ';', '(', ')' };

            text = Cast(text);
            word = Cast(word);

            string[] words = text.Split(separator); //Convierte la cadena en array
            int count = (from item in words
                         where (item == word)
                         select item).Count();

            return count;
        }

        /// <summary>
        /// Metodo encargado de remover caracteres especiales
        /// </summary>
        /// <param name="text">Texto de entrada</param>
        /// <returns>Texto en limpio</returns>
        private string Cast(string text)
        {
            return text.ToLower().Replace("á", "a")
                    .Replace("é", "e")
                    .Replace("í", "i")
                    .Replace("ó", "o")
                    .Replace("ú", "u")
                    .Replace("ü", "u");
        }
    }
}
