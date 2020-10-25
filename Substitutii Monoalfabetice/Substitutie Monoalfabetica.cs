using System;
using System.Collections.Generic;
using System.Text;

namespace Substitutii_Monoalfabetice
{
    class Substitutie_Monoalfabetica:IAlgoritmSimetric
    {
        public void Criptare(string text,int cheie)
        {
            StringBuilder textaux = new StringBuilder();
            foreach(char c in text)
            {
                if (char.IsLetter(c)) textaux.Append((char)Schimbare(c));
                else textaux.Append(c);
            }
            Console.WriteLine(textaux);
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
                    c = 'a';
                    break;
            }
            return c;

        }
    }
}
