using System;
using System.Collections.Generic;
using System.Text;

namespace Substitutii_Monoalfabetice
{
    class Cifrul_lui_Cezar:IAlgoritmSimetric
    {
        public void Criptare(string text,int cheie)
        {
            StringBuilder textaux = new StringBuilder();
            foreach(char c in text)
            {
                if (char.IsLetter(c))
                {
                    int aux = c + cheie;
                    if (aux > 122) aux = aux - 122 + 96;
                    textaux.Append((char)aux);
                }
                else textaux.Append(c); 
            }
            Console.WriteLine(textaux);
        }
    }
}
