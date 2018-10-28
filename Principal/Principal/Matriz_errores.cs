using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Principal
{
    class Matriz_errores
    {
        public string Error(int edo)
        {
            switch (edo)
            {
                case 500: return "ERROR 500: Se espera digito";
                case 501: return "ERROR 501: Se espera comilla simple de cierre";
                case 502: return "ERROR 502: Se espera un amper";
                case 4: // se ajusta token
                case 503: return "ERROR 503: Se espera digito (N.R)";
                case 7: // se ajusta el token
                case 504: return "ERROR 504: Se espera digito (N.C)";
                case 6: // se ajusta el token
                case 505: return "ERROR 505: Se espera signo (- o +) o digito";
                case 506: return "ERROR 506: Caracter no reconocido por el lenguaje";
                case 507: return "ERROR 507: Se espera una pleca";
            }
            return "";
        }
    }
}
