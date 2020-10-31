using System;
using System.Collections.Generic;
using System.Text;

namespace Substitutii_Monoalfabetice
{
    class Cifrul_lui_Cezar_generalizat:IAlgoritmSimetric
    {
        public string Criptare(string text, int cheie)
        {
            StringBuilder textaux = new StringBuilder();
            foreach (char c in text)
            {
                if (char.IsLetter(c))
                {
                    int aux = c + cheie;
                    if (aux > 122) aux = aux - 122 + 96;
                    textaux.Append((char)aux);
                }
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
                if (char.IsLetter(k))
                {
                    int aux = k - cheie;
                    if (aux < 97) aux = 123 - (97 - aux);
                    textaux.Append((char)aux);
                }
                else textaux.Append(k);
            }
            textcriptat = textaux.ToString();
            return textcriptat;
        }
    }
}
