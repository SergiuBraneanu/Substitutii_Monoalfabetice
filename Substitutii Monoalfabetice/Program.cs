using System;

namespace Substitutii_Monoalfabetice
{
    class Program
    {
        static void Main(string[] args)
        {
            Cifrul_lui_Cezar c = new Cifrul_lui_Cezar();
            Cifrul_lui_Cezar_generalizat cg = new Cifrul_lui_Cezar_generalizat();
            ROT13 rot = new ROT13();
            Substitutie_Monoalfabetica sm = new Substitutie_Monoalfabetica();
            Console.Write("Introduceti textul:");
            string text = Console.ReadLine();
            Console.Write("Introduceti cheia pt cifrul generalizat:");
            int cheiecezargen = int.Parse(Console.ReadLine());
            int cheiecezar = 3;
            int cheierot = 13;
            

            Console.Write("Textul criptat cu cifrul lui Cezar:");
            c.Criptare(text, cheiecezar);
            Console.Write("Textul criptat cu cifrul lui Cezar generalizat:");
            cg.Criptare(text, cheiecezargen);
            Console.Write("Textul criptat cu cifrul ROT13:");
            rot.Criptare(text, cheierot);
            Console.Write("Textul criptat prin substitutie monoalfabetica:");
            sm.Criptare(text, 0);
        }
    }
}
