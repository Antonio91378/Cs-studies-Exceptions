
using ByteBank;
using Humanizer;

namespace ByteBank.SistemaAgencia
{
    //qnd n tem nenhum modificador de acesso, minha classe é internal
    class Program
    {
        private static void Main(string[] args)
        {
            string url = "pagina?argumentos";
            int questionMark = url.IndexOf('?');
            string argumentos = url.Substring(questionMark + 1);
            Console.WriteLine(argumentos);
        }

    }

}