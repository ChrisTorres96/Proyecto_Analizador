using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Principal
{
    class Leer_archivo
    {
        // LEER EL ARCHIVO
        public string[] Read_file(string nombre_archivo)
        {
            string[] lines = System.IO.File.ReadAllLines(nombre_archivo);
            return lines;
        }
    }
}
