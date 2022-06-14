
using ByteBank;
namespace ByteBank.SistemaAgencia
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            ContaCorrente conta = new ContaCorrente(1023, 456456456);
            Console.WriteLine(conta.Numero);
        }
    }

}