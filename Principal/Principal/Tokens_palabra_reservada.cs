using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Principal
{
    class Tokens_palabra_reservada
    {
        public string palabrasreservadas(string pr)
        {
            string pal;
            switch (pr)
            {
                case "constructor":
                    return pal = "134:CONSTRUCTOR";
                case "commit":
                    return pal = "135:COMMIT";
                case "if":
                    return pal = "136:IF";
                case "end":
                    return pal = "137:END";
                case "while":
                    return pal = "138:WHILE";
                case "endwhile":
                    return pal = "139:ENDWHILE";
                case "endif":
                    return pal = "140:ENDIF";
                case "do":
                    return pal = "141:DO";
                case "dowhile":
                    return pal = "142:DOWHILE";
                case "enddo":
                    return pal = "143:ENDDO";
                case "read":
                    return pal = "144:READ";
                case "write":
                    return pal = "145:WRITE";
                case "int":
                    return pal = "146:INT";
                case "float":
                    return pal = "147:FLOAT";
                case "string":
                    return pal = "148:STRING";
                case "char":
                    return pal = "149:CHAR";
            }
            return "";
        }

    }
}
