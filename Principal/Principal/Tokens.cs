using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Principal
{
    class Tokens
    {
        public string token(int edo)
        {
            switch (edo)
            {
                case 1: // se ajusta el token
                case 100: return "\n 100:Identificador";
                case 2: // se austa el token
                case 101: return "\n 101:Identificador";
                case 3: // se ajusta el token
                case 102: return "\n 102:Constante numerica";
                case 5: //se ajusta el token
                case 103: return "\n 103:Constante numerica (REALES)";
                case 8:// se ajusta el token
                case 104: return "\n 104:Constante numerica (N.C)";
                case 105: return "\n 105:Comilla de cierre";
                case 106: return "\n 106:Amperson";
                case 107: return "\n 107:Pleca";
                case 108: return "\n 108:Negacion\n";
                case 109: return "\n 109:Diferente de\n";
                case 110: return "\n 110:Comparacion de equivalencia\n";
                case 111: return "\n 111:Asignacion\n";
                case 112: return "\n 112:Comilla doble que cierra\n";
                case 113: return "\n 113:Menor que\n";
                case 115: return "\n 115:Mayor o igual que\n";
                case 116: return "\n 116:mayor que\n";
                case 117: return "\n 117:Menor o igual que\n";
                case 118: return "\n 118:Parentesis que abre\n";
                case 119: return "\n 119:Parentesis que cierra\n";
                case 120: return "\n 120:Corchete que cierra\n";
                case 121: return "\n 121:Corchete que abre\n";
                case 122: return "\n 122:Llave que cierra\n";
                case 123: return "\n 123:Llave que abre\n";
                case 124: return "\n 124:Suma\n";
                case 125: return "\n 125:Resta\n";
                case 126: return "\n 126:Division\n";
                case 127: return "\n 127:Multiplicacion\n";
                case 128: return "\n 128:Porsentaje\n";
                case 18: //Se ajusta token
                case 129: return "\n 139:Comentario\n";
                case 130: return "\n 130:Coma\n";
                case 131: return "\n 131:Punto y coma\n";
                case 132: return "\n 132:Dos puntos\n";
                case 133: return "\n 133:Punto\n";
            }
            return "";
        }

    }
}
