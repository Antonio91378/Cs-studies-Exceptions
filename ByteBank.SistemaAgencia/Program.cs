
using ByteBank;
namespace ByteBank.SistemaAgencia
{
    //qnd n tem nenhum modificador de acesso, minha classe é internal
    class Program
    {
        private static void Main(string[] args)
        {
            DateTime dataFimPagamento = new DateTime(2022, 7, 17);
            DateTime dataAtual = DateTime.Now;
            TimeSpan diferenca = dataFimPagamento - dataAtual;
            string mensagem = GetIntervaloDeTempoLegivel(diferenca);
            System.Console.WriteLine("Vencimento em : " + mensagem);
        }
        static string GetIntervaloDeTempoLegivel(TimeSpan timespan)
        {
            return timespan.Days + " dias";
        }
    }

}