using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.SistemaAgencia
{
    public class StringManipulation
    {
        public string Url { get; }
        public StringManipulation(string url)
        {
            if (url == null)
            {
                throw new ArgumentNullException(nameof(url));
            }
            if (url == "")
            {
                throw new ArgumentException("o argumento não pode ser uma string vazia", nameof(url));
            }
            Url = url;
        }
    }
}
