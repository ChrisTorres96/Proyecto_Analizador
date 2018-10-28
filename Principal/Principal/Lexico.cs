using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Principal
{
    class Lexico
    {
        Matriz_corridas Corrida = new Matriz_corridas();
        Matriz_caracteres Caracteres = new Matriz_caracteres();
        Tokens tok = new Tokens();
        Matriz_errores error = new Matriz_errores();
        Sintactico sn = new Sintactico();


        public string[] Lexico_metodo(string nombre_archivo)
        {
            StreamReader leer = new StreamReader(nombre_archivo);
            int edo = 0, col;
            int car, i = 0;
            char letra;
            string palabra = "";
            string[] tokens = new string[10];

            while (edo <= 19 && !leer.EndOfStream)
            {

                car = leer.Read();
                if (car == 32) goto salto2;
                letra = Convert.ToChar(car);
                palabra += letra;
            salto2:
                tokens[i] = sn.sintactico_metodo(palabra);

                /*
                salto:
                car = leer.Read();
                if (car == 32 ) goto salto;

                col = Caracteres.relacion(car);
                edo = Corrida.Matriz(edo, col);
                if (edo >= 100 && edo <= 133 || edo == 3 || edo == 2 || edo == 1 || edo == 5 || edo == 8 || edo == 18) { tokens[i] += tok.token(edo); }
                else { tokens[i] += error.Error(edo); }
                edo = 0;
                i++;*/
            }
            return tokens;
        }
    }
}
