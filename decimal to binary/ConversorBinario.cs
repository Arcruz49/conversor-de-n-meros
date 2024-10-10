using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace decimal_to_binary
{
    public class ConversorBinario : IConversor
    {
        public string Resultado { get; set; }
        public List<string> listResultado = new List<string>();
        public string Converter(int n)
        {
            if (n == 0) return "0";
            if (n == 1) return "1";
            return Converter(n / 2) + (n % 2).ToString();
        }

    }
}
