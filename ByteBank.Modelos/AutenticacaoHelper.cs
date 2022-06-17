namespace ByteBank.Modelos
{
    internal class AutenticacaoHelper
    {
        public bool CompararSenhas(string senhaVerdadeira, string senhaTentativa)
        {
            return senhaTentativa == senhaVerdadeira;
        }
    }
}