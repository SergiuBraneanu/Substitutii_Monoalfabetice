using System;

namespace Substitutii_Monoalfabetice
{
    class Program
    {
        static void Main(string[] args)
        {
            Cifrul_lui_Cezar cc = new Cifrul_lui_Cezar();
            Cifrul_lui_Cezar_generalizat cg = new Cifrul_lui_Cezar_generalizat();
            ROT13 rot = new ROT13();
            Substitutie_Monoalfabetica sm = new Substitutie_Monoalfabetica();
            Console.Write("Introduceti textul:");
            string text = Console.ReadLine();
            Console.Write("Introduceti cheia pt cifrul generalizat:");
            int cheiecezargen = int.Parse(Console.ReadLine());
            int cheiecezar = 3;
            int cheierot = 13;
            
            string a= cc.Criptare(text, cheiecezar);
            string b= cg.Criptare(text, cheiecezargen);
            string c= rot.Criptare(text, cheierot); ;
            string d= sm.Criptare(text, 0);
            Console.WriteLine("Textul criptat cu cifrul lui Cezar:{0}",a);
            Console.WriteLine("Textul decriptat:{0}", cc.Decriptare(a, cheiecezar));

            Console.WriteLine("Textul criptat cu cifrul lui Cezar generalizat:{0}",b);
            Console.WriteLine("Textul decriptat:{0}", cg.Decriptare(b, cheiecezargen));

            Console.WriteLine("Textul criptat cu cifrul ROT13:{0}",c);
            Console.WriteLine("Textul decriptat:{0}", rot.Decriptare(c, cheierot));

            Console.WriteLine("Textul criptat prin substitutie monoalfabetica:{0}",d);
            Console.WriteLine("Textul decriptat:{0}", sm.Decriptare(d, cheiecezar));
        }
    }
}
