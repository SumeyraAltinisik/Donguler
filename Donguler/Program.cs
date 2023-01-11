namespace Donguler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int i;
            //for (i = 1; i <= 10; i++)
            //{
            //    Console.WriteLine("Merhaba Dünya");
            //}

            //int i;
            //for (i = 1; i < 11; i++)
            //{
            //    Console.WriteLine(i);
            //}

            //int j;
            //for (j = 0; j <= 20; j += 2)
            //{
            //    Console.WriteLine(j);
            //}

            //int k;
            //for (k = 1; k <= 100; k += 1)
            //{
            //    Console.WriteLine(k + " Merhaba İstanbul");
            //}

            //DONGU ICINDE KARAR YAPISI KULLANIMI
            //int sayi = 24 % 9;
            //Console.Write(sayi);

            //int sayi;
            //Console.Write("Sayıyı girin: ");
            //sayi = Convert.ToInt16(Console.ReadLine());
            //if(sayi % 2 == 0)
            //{
            //    Console.Write("sayı çifttir");
            //}
            //else
            //{
            //    Console.Write("sayı tektir");
            //}

            //for(int i=1; i <= 20; i++)
            //{
            //    if (i % 3 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}

            //tam bölenleri bulma
            //30 --> 1 2 3 5 6 10 15 30
            //int sayi;
            //Console.Write("sayıyı giriniz: ");
            //sayi= Convert.ToInt16(Console.ReadLine());
            //for(int i=1; i <= sayi; i++)
            //{
            //    if (sayi % i == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}

            int bakteri = 1;
            for (int i = 1; i <= 24; i++)
            {
                bakteri = bakteri * 2;
                Console.WriteLine(bakteri);
            }
            Console.Read();
        }
    }
}