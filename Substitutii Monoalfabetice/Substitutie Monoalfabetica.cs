using System;
using System.Collections.Generic;
using System.Text;

namespace Substitutii_Monoalfabetice
{
    class Substitutie_Monoalfabetica:IAlgoritmSimetric
    {
        public string Criptare(string text,int cheie)
        {
            StringBuilder textaux = new StringBuilder();
            foreach(char c in text)
            {
                if (char.IsLetter(c)) textaux.Append((char)Schimbare(c));
                else textaux.Append(c);
            }
            text = textaux.ToString();
            return text;
        }
        public string Decriptare(string textcriptat, int cheie)
        {
            StringBuilder textaux = new StringBuilder();
            foreach (char k in textcriptat)
            {
                if (char.IsLetter(k)) textaux.Append((char)Schimbare2(k));
                else textaux.Append(k);
            }
            textcriptat = textaux.ToString();
            return textcriptat;
        }
        private int Schimbare(char c)
        {
            switch(c)
            {
                case 'a':
                    c = 'v';
                    break;
                case 'b':
                    c = 'k';
                    break;
                case 'c':
                    c = 'p';
                    break;
                case 'd':
                    c = 'q';
                    break;
                case 'e':
                    c = 'y';
                    break;
                case 'f':
                    c = 'o';
                    break;
                case 'g':
                    c = 'l';
                    break;
                case 'h':
                    c = 'w';
                    break;
                case 'i':
                    c = 'z';
                    break;
                case 'j':
                    c = 'c';
                    break;
                case 'k':
                    c = 'i';
                    break;
                case 'l':
                    c = 'a';
                    break;
                case 'm':
                    c = 't';
                    break;
                case 'n':
                    c = 'b';
                    break;
                case 'o':
                    c = 's';
                    break;
                case 'p':
                    c = 'j';
                    break;
                case 'q':
                    c = 'x';
                    break;
                case 'r':
                    c = 'e';
                    break;
                case 's':
                    c = 'n';
                    break;
                case 't':
                    c = 'd';
                    break;
                case 'u':
                    c = 'f';
                    break;
                case 'v':
                    c = 'u';
                    break;
                case 'w':
                    c = 'h';
                    break;
                case 'x':
                    c = 'g';
                    break;
                case 'y':
                    c = 'm';
                    break;
                case 'z':
                    c = 'r';
                    break;
            }
            return c;

        }
        private int Schimbare2(char k)
        {
            
                switch (k)
                {
                    case 'v':
                        k = 'a';
                        break;
                    case 'k':
                        k = 'b';
                        break;
                    case 'p':
                        k = 'c';
                        break;
                    case 'q':
                        k = 'd';
                        break;
                    case 'y':
                        k = 'e';
                        break;
                    case 'o':
                        k = 'f';
                        break;
                    case 'l':
                        k = 'g';
                        break;
                    case 'w':
                        k = 'h';
                        break;
                    case 'z':
                        k = 'i';
                        break;
                    case 'c':
                        k = 'j';
                        break;
                    case 'i':
                        k = 'k';
                        break;
                    case 'a':
                        k = 'l';
                        break;
                    case 't':
                        k = 'm';
                        break;
                    case 'b':
                        k = 'n';
                        break;
                    case 's':
                        k = 'o';
                        break;
                    case 'j':
                        k = 'p';
                        break;
                    case 'x':
                        k = 'q';
                        break;
                    case 'e':
                        k = 'r';
                        break;
                    case 'n':
                        k = 's';
                        break;
                    case 'd':
                        k = 't';
                        break;
                    case 'f':
                        k = 'u';
                        break;
                    case 'u':
                        k = 'v';
                        break;
                    case 'h':
                        k = 'w';
                        break;
                    case 'g':
                        k = 'x';
                        break;
                    case 'm':
                        k = 'y';
                        break;
                    case 'r':
                        k = 'z';
                        break;
                }
                return k;
        }
    }
}
