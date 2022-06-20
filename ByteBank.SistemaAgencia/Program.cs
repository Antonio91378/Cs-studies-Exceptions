
using ByteBank;
using Humanizer;

namespace ByteBank.SistemaAgencia
{
    //qnd n tem nenhum modificador de acesso, minha classe é internal
    class Program
    {
        private static void Main(string[] args)
        {
            string url = "http://www.bytebank.com/cambio?moedaOrigem=real&moedaDestino=dolar";

            StringManipulation extrator = new StringManipulation(url);
            System.Console.WriteLine("Valor de moedaDestino: " + extrator.GetValor("MOEDAorigem"));
        }

    }

}