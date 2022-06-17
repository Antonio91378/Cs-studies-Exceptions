
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
        static string GetIntervaloDeTempoLegivel(TimeSpan timeSpan)
        {
            if (timeSpan.Days > 30)
            {
                int quantidadeMeses = timeSpan.Days / 30;
                int quantidadeDias = timeSpan.Days % 30;
                if (quantidadeDias > 7)
                {
                    int diasRestantes = quantidadeDias % 7;
                    int quantidadeSemanas = quantidadeDias / 7;
                    return quantidadeMeses + " meses e " + quantidadeSemanas + " Semanas e " + diasRestantes + " dias.";
                }
                return quantidadeMeses + " meses e " + quantidadeDias + " dias.";
            }
            if (timeSpan.Days > 7)
            {
                int quantidadeSemanas = timeSpan.Days / 7;
                int quantidadeDias = timeSpan.Days % 7;
                return quantidadeSemanas + " Semanas e " + quantidadeDias + " dias.";
            }
            return timeSpan.Days + " dias";
        }

    }

}