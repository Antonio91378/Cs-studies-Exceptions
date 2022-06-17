using ByteBank.Modelos;
using bytebank_ADM.SistemaInterno;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank_ADM.Utilitario
{
    public class ParceiroComercial : IAutenticavel
    {
        private AutenticacaoHelper _autenticacaoHelper = new AutenticacaoHelper();
        public string Senha { get; set; }
        public bool Autenticar(string senha)
        {
            return _autenticacaoHelper.CompararSenhas(Senha, senha);
        }
    }
}
