using System;
using System.Collections.Generic;
using System.Text;

namespace Substitutii_Monoalfabetice
{
    interface IAlgoritmSimetric
    {
         string Criptare(string text,int cheie);
         string Decriptare(string textcriptat, int cheie);

    }
}
