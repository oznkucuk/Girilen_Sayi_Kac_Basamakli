using System;

namespace girilen_sayi_kac_basamakli
{
    class Program
    {
        static void Main(string[] args)
        {
             // Girilen sayının kaç basamaklı olduğunu bulan program
            Console.Write("bir sayı girin: ");
            int sayi = Convert.ToInt32(Console.ReadLine());
            int basamak = 0;
            while (sayi > 0)
            {
                basamak++;
                sayi = sayi / 10;
            }
            Console.WriteLine("girdiğiniz sayı " + basamak.ToString() + " basamaklıdır");
        }
    }
}
