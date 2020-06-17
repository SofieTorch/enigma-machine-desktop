using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace enigmaMachine
{
    class Encriptador
    {
        public Rotor rotor1, rotor2, rotor3;
        char[] alfabeto = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M',
                            'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };
        char[] reflector = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'D' ,'I', 'J', 'K', 'G', 'M',
                             'K', 'M', 'I', 'E', 'B', 'F', 'T', 'C', 'V', 'V', 'J', 'A', 'T' };
        char[] alfabetIntern1 = { 'E', 'K', 'M', 'F', 'L', 'G', 'D', 'Q', 'V', 'Z', 'N', 'T', 'O',
                                  'W', 'Y', 'H', 'X', 'U', 'S', 'P', 'A', 'I', 'B', 'R', 'C', 'J' };
        char[] alfabetIntern2 = { 'A', 'J', 'D', 'K', 'S', 'I', 'R', 'U', 'X', 'B', 'L', 'H', 'W',
                                  'T', 'M', 'C', 'Q', 'G', 'Z', 'N', 'P', 'Y', 'F', 'V', 'O', 'E' };
        char[] alfabetIntern3 = { 'B', 'D', 'F', 'H', 'J', 'L', 'C', 'P', 'R', 'T', 'X', 'V', 'Z',
                                  'N', 'Y', 'E', 'I', 'W', 'G', 'A', 'K', 'M', 'U', 'S', 'Q', 'O' };
        public Encriptador()
        {
            rotor1 = new Rotor( alfabetIntern1, 'Q' );
            rotor2 = new Rotor( alfabetIntern2, 'E' );
            rotor3 = new Rotor( alfabetIntern3, 'V' );
        }

        public void rotarRotor( int numRotor, string sentido)
        {
            Rotor rotor;

            switch (numRotor)
            {
                case 1:
                    rotor = rotor1;
                    break;
                case 2:
                    rotor = rotor2;
                    break;
                default:
                    rotor = rotor3;
                    break;
            }

            if(sentido == "arriba")
            {
                rotor.rotarArriba();
            } else
            {
                rotor.rotarAbajo();
            }
        }

        public char encriptar( char caracter )
        {
            int posicion = Array.IndexOf(alfabeto, caracter);
            rotor3.rotarArriba();
            posicion = rotor3.obtenerSustituto(posicion, "ida");

            if ( rotor3.verificarTope("arriba"))
            {
                rotor2.rotarArriba();
                if( rotor2.verificarTope("arriba"))
                {
                    rotor1.rotarArriba();
                }
            }

            posicion = rotor2.obtenerSustituto(posicion, "ida");
            posicion = rotor1.obtenerSustituto(posicion, "ida");
            char letraReflector = reflector[posicion];
            int posicionReflector = 0;

            for( int i = 0; i < reflector.Length; i++)
            {
                if( letraReflector == reflector[i] && i != posicion)
                {
                    posicionReflector = i;
                    break;
                }
            }

            posicion = rotor1.obtenerSustituto(posicionReflector, "vuelta");
            posicion = rotor2.obtenerSustituto(posicion, "vuelta");
            posicion = rotor3.obtenerSustituto(posicion, "vuelta");
            
            return alfabeto[posicion];
        }

        public void borrarCaracter()
        {
            rotor3.rotarAbajo();
            if (rotor3.verificarTope("abajo"))
            {
                rotor2.rotarAbajo();
                if (rotor2.verificarTope("abajo"))
                {
                    rotor1.rotarAbajo();
                }
            }
        }

    }
}
