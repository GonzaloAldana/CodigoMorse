using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodigoMorse
{
    class ControladorMorse
    {
        string letras = "";
        string letra = "";
        string caracter = "";

        #region Caracteres
        string a = "O-";
        string b = "-OOO";
        string c = "-O-O";
        string d = "-OO";
        string e = "O";
        string f = "OO-O";
        string g = "--O";
        string h = "OOOO";
        string i = "OO";
        string j = "O---";
        string k = "-O-";
        string l = "O-OO";
        string m = "--";
        string n = "-O";
        string o = "---";
        string p = "O--O";
        string q = "--O-";
        string r = "O-O";
        string s = "OOO";
        string t = "-";
        string u = "OO-";
        string v = "OOO-";
        string w = "O--";
        string x = "-OO-";
        string y = "-O--";
        string z = "--OO";

        // Numeros
        string uno = "O----";
        string dos = "OO---";
        string tres = "OOO--";
        string cuatro = "OOOO-";
        string cinco = "OOOOO";
        string seis = "-OOOO";
        string siete = "--OOO";
        string ocho = "---OO";
        string nueve = "----O";
        string cero = "-----";

        // Faltan los signos de puntuacion
        #endregion

        
        public void NuevoCaracter() // Borra de la memoria el codigo morse 
        {
            caracter = "";
        }
        public void NuevaLetra() // Borra de la memoria la letra traducida del codigo morse
        {
            letra = "";
        }
        public void NuevaPalabra() // Borra de la memoria la palabra
        {
            letras = "";
        }

        public void AgregarCaracter(string ca) // Crea el codigo morse
        {
            caracter += ca;
        }
        public void AgregarLetra() // Agrega el caracter a la palabra
        {
            letras += letra;
        }

        public string ObterCaracter() // Devuelve el codigo Morse
        {
            return caracter;
        }
        public string ObterLetras() // Devuelve la palabra
        {
            return letras;
        }
        public string ObterLetra() // Devuelve la letra
        {
            return letra;
        }

        // Traduce el codigo morse del arduino comparando, uno por uno, con cada caracter morse
        public void DescifrarCaracter()
        {
            if (caracter.Equals(a))
            {
                letra = "a";
                return;
            }
            if (caracter.Equals(b))
            {
                letra = "b";
                return;
            }
            if (caracter.Equals(c))
            {
                letra = "c";
                return;
            }
            if (caracter.Equals(d))
            {
                letra = "d";
                return;
            }
            if (caracter.Equals(e))
            {
                letra = "e";
                return;
            }
            if (caracter.Equals(f))
            {
                letra = "f";
                return;
            }
            if (caracter.Equals(g))
            {
                letra = "g";
                return;
            }
            if (caracter.Equals(h))
            {
                letra = "h";
                return;
            }
            if (caracter.Equals(i))
            {
                letra = "i";
                return;
            }
            if (caracter.Equals(j))
            {
                letra = "j";
                return;
            }
            if (caracter.Equals(k))
            {
                letra = "k";
                return;
            }
            if (caracter.Equals(l))
            {
                letra = "l";
                return;
            }
            if (caracter.Equals(m))
            {
                letra = "m";
                return;
            }
            if (caracter.Equals(n))
            {
                letra = "n";
                return;
            }
            if (caracter.Equals(o))
            {
                letra = "o";
                return;
            }
            if (caracter.Equals(p))
            {
                letra = "p";
                return;
            }
            if (caracter.Equals(q))
            {
                letra = "q";
                return;
            }
            if (caracter.Equals(r))
            {
                letra = "r";
                return;
            }
            if (caracter.Equals(s))
            {
                letra = "s";
                return;
            }
            if (caracter.Equals(t))
            {
                letra = "t";
                return;
            }
            if (caracter.Equals(u))
            {
                letra = "u";
                return;
            }
            if (caracter.Equals(v))
            {
                letra = "v";
                return;
            }
            if (caracter.Equals(w))
            {
                letra = "w";
                return;
            }
            if (caracter.Equals(x))
            {
                letra = "x";
                return;
            }
            if (caracter.Equals(y))
            {
                letra = "y";
                return;
            }
            if (caracter.Equals(z))
            {
                letra = "z";
                return;
            }


            // Numeros
            if (caracter.Equals(uno))
            {
                letra = "1";
                return;
            }
            if (caracter.Equals(dos))
            {
                letra = "2";
                return;
            }
            if (caracter.Equals(tres))
            {
                letra = "3";
                return;
            }
            if (caracter.Equals(cuatro))
            {
                letra = "4";
                return;
            }
            if (caracter.Equals(cinco))
            {
                letra = "5";
                return;
            }
            if (caracter.Equals(seis))
            {
                letra = "6";
                return;
            }
            if (caracter.Equals(siete))
            {
                letra = "7";
                return;
            }
            if (caracter.Equals(ocho))
            {
                letra = "8";
                return;
            }
            if (caracter.Equals(nueve))
            {
                letra = "9";
                return;
            }
            if (caracter.Equals(cero))
            {
                letra = "0";
                return;
            }


        }
    }
}
