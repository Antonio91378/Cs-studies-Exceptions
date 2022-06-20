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
            string.IsNullOrEmpty(url);
            Url = url;
        }
    }
}
