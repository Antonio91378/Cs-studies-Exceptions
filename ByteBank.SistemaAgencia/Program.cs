
using System.Text.RegularExpressions;
using ByteBank;
using Humanizer;

namespace ByteBank.SistemaAgencia
{
    //qnd n tem nenhum modificador de acesso, minha classe é internal
    class Program
    {
        private static void Main(string[] args)
        {
            //Usando expressoões regulares
            string padrao = "[0-9]{4,5}[-]{0,1}[0-9]{4}";
            string textoDeTeste = "Meu nome é Naruto, me ligue em 1234-4321";
            System.Console.WriteLine(Regex.IsMatch(textoDeTeste, padrao)); ;

        }

    }

}