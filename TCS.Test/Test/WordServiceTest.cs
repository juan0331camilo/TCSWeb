using Microsoft.VisualStudio.TestTools.UnitTesting;
using TCS.BL.Services;

namespace TCS.Test
{
    [TestClass]
    public class WordServiceTest
    {
        [TestMethod]
        public void WordsCountTest()
        {
            // Arrange
            var text = "Go es un lenguaje de programaci�n concurrente y compilado inspirado en la sintaxis de C. Ha sido desarrollado por Google, y sus dise�adores iniciales son Robert Griesemer, Rob Pike y Ken Thompson. Actualmente est� disponible en formato binario para los sistemas operativos Windows, GNU/Linux, FreeBSD y Mac OS X, pudiendo tambi�n ser instalado en estos y en otros sistemas con el c�digo fuente. Go es un lenguaje de programaci�n compilado, concurrente, imperativo, estructurado, orientado a objetos y con recolector de basura que de momento est� soportado en diferentes tipos de sistemas UNIX, incluidos Linux, FreeBSD, Mac OS X y Plan 9 (puesto que parte del compilador est� basado en un trabajo previo sobre el sistema operativo Inferno). Las arquitecturas soportadas son i386, amd64 y ARM.";
            var word = "programacion";
            var wordService = new WordService();

            // Act
            var count = wordService.WordsCount(text, word);

            // Assert 
            Assert.AreEqual(2, count);
        }
    }
}
