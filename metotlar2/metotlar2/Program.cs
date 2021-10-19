using System;

namespace metotlar2
{
    class Program
    {
        /*   static void Main(string[] args)
           {
               Console.Write("Sayı Giriniz: ");
               int sayi = Convert.ToInt32(Console.ReadLine());
               Console.Write("Sonuç:{0} ", kupu(sayi));
               Console.Read();
           }


           public static int kupu(int sayi)

           {
               int kup = sayi * sayi * sayi;
               return kup; 
           } */

        //--------------------------------------------------

        static void Main(string[] args)
        {
            Console.Write("Uzun Kenar: ");
            int uk = Convert.ToInt32(Console.ReadLine());
            Console.Write("Kısa Kenar: ");
            int kk = Convert.ToInt32(Console.ReadLine());
            int dikdörtgenalan = alancevre.alanhesap(kk, uk);
            int dikdörtgencevre = alancevre.cevrehesap(kk, uk);
            Console.WriteLine("Dikdörtgen Alan: {0} Dikdörtgen Çevre: {1}", dikdörtgenalan, dikdörtgencevre);
            Console.Read();

        }
        class alancevre
        {
            public static int alanhesap(int uzunkenar, int kisakenar)
            {
                int alan = uzunkenar * kisakenar;
                return (alan);
            }

            public static int cevrehesap(int uzunkenar, int kisakenar)
            {
                int cevre = 2 * (uzunkenar + kisakenar);
                return (cevre);
            }

        }

    }
}
