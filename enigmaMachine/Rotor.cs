using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace enigmaMachine
{
    class Rotor
    {
        public char[] alfabeto;
        char[] alfabetoInterno;
        char letraTope;
        public Rotor(char[] alfabetoInterno, char letraTope)
        {
            this.alfabetoInterno = alfabetoInterno;
            alfabeto = new char[]
            {
                'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z'
            };

            int topeIndex = Array.IndexOf(alfabeto, letraTope) + 1;
            this.letraTope = alfabeto[topeIndex];
        }

        public void rotarArriba()
        {
            char primerCharAlfab = alfabeto[0];
            char primerCharAlfabInter = alfabetoInterno[0];

            for (int i = 0; i <= 24; i++)
            {
                alfabeto[i] = alfabeto[i + 1];
                alfabetoInterno[i] = alfabetoInterno[i + 1];
            }

            alfabeto[25] = primerCharAlfab;
            alfabetoInterno[25] = primerCharAlfabInter;
        }

        public void rotarAbajo()
        {
            char ultimCharAlfab = alfabeto[25];
            char ultimCharAlfabInter = alfabetoInterno[25];

            for (int i = 25; i >= 1 ; i--)
            {
                alfabeto[i] = alfabeto[i - 1];
                alfabetoInterno[i] = alfabetoInterno[i - 1];
            }

            alfabeto[0] = ultimCharAlfab;
            alfabetoInterno[0] = ultimCharAlfabInter;
        }

        public int obtenerSustituto(int posicion, string sentido)
        {
            int posicionSalida = 0;

            if (sentido == "ida")
            {
                posicionSalida = Array.IndexOf(alfabeto, alfabetoInterno[posicion]);
            }
            else
            {
                posicionSalida = Array.IndexOf(alfabetoInterno, alfabeto[posicion]);
            }

            return posicionSalida;
        }

        public bool verificarTope( string sentido )
        {
            if( sentido == "arriba")
            {
                if( alfabeto[0] == letraTope)
                {
                    return true;
                }
                return false;
            } else
            {
                if( alfabeto[1] == letraTope)
                {
                    return true;
                }
                return false;
            }
        }
    }
}
