using System;

namespace Karakter_Tersten_Yazdırma
{
    class Program
    {
        static void Main(string[] args)
        {
            string giriş = "Bugün 17 Mayıs 2024 Cuma";
            char[] karakterler = giriş.ToCharArray();

            for (int i = 1; i < karakterler.Length; i++)
            {
                char temp = karakterler[i];
                karakterler[i] = karakterler[i - 1];
                karakterler[i - 1] = temp;
            }
            string çıktı = new string(karakterler);
            Console.WriteLine(çıktı);
            Console.ReadKey();
        }
    }
}
