using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Principal
{
    class Matriz_caracteres
    {
        public int relacion(int x)
        {
            if (x >= 65 && x <= 90 || x >= 97 && x <= 122)
            { // A - Z
                return 0;
            }
            else if (x >= 48 && x <= 57)
            { // a - z
                return 1;
            }
            else if (x == 36 || x == 63 || x == 94 || x == 64 || x == 124 || x >= 126 && x <= 255)
            {
                return 32;
            }
            else
            {
                switch (x)
                {
                    case 9: // TAB
                        return 30;
                    case 69: // E
                        return 3;
                    case 101: // e
                        return 4;
                    case 46: // .
                        return 27;
                    case 43: // +
                        return 5;
                    case 45: // -
                        return 6;
                    case 42: // *
                        return 9;
                    case 47: // /
                        return 10;
                    case 95: // _
                        return 2;
                    case 32: // SPACE
                        return 29;
                    case 10: // Salto de linea
                        return 11;
                    case 40: // (
                        return 18;
                    case 41: // )
                        return 19;
                    case 37: // %
                        return 11;
                    case 34: // "
                        return 8;
                    case 39: // '
                        return 7;
                    case 38: // &
                        return 12;
                    case 44: // ,
                        return 24;
                    case 58: // :
                        return 26;
                    case 59: // ;
                        return 25;
                    case 60: // <
                        return 17;
                    case 61: // =
                        return 15;
                    case 62: // > 
                        return 16;
                    case 91: // [
                        return 20;
                    case 93: // ]
                        return 21;
                    case 123: // {
                        return 22;
                    case 125: // }
                        return 23;
                    case 124: // |
                        return 13;
                    case 35: // #
                        return 28;
                    case 33: // !
                        return 14;
                }
            }
            return -1;
        }
    }
}
