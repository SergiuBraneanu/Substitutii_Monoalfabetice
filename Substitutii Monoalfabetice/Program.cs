using System;

namespace Substitutii_Monoalfabetice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introduceti textul:");
            string text = Console.ReadLine();
            int cheiecezar = 3;
            Cifrul_lui_Cezar c = new Cifrul_lui_Cezar();
            c.Criptare(text, cheiecezar);
        }
    }
}
