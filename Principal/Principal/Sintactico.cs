using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Principal
{
    class Sintactico
    {
        Tokens_palabra_reservada tkpl = new Tokens_palabra_reservada();


        public string sintactico_metodo(string palabra)
        {
            string plr = tkpl.palabrasreservadas(palabra);
            return plr;
        }
    }
}
