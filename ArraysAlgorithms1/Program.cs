using System;

namespace ArraysAlgorithms1
{
    class Program
    {
        static void Main(string[] args)
        {

            int size = GetFromConsole("Eleman sayısı giriniz :");
            int[] a = new int[size];

            for (int i = 0; i < size; i++)
            {
                // string message = string.Format("dizinin {0}. elemanını girin", i);
                string message = $"dizinin {i}. elemanını girin";
                a[i] = GetFromConsole(message);
            }

            //a = DiziCarp(a, 2);
            //DiziYazdir(a);

            while (true)
            {
                int s1 = GetFromConsole("Tahmininizi yazınız :");
                if (Tahmin(a, s1))

                    Console.WriteLine("Tahmin edilen değer dizide vardır.");

                else
                    Console.WriteLine("Tahmin edilen değer dizide yoktur.");

            }

            Console.ReadLine();
        }
        public static int GetFromConsole(string message)
        {
            Console.WriteLine(message);
            int size = 0;
            while (true)
            {
                if (!int.TryParse(Console.ReadLine(), out size))
                {
                    Console.WriteLine("Girilen Değer hatalı");
                    Console.WriteLine(message);
                }
                else
                {
                    break;
                }
            }
            return size;
        }

        public static void DiziYazdir(int[] dizi)
        {
            string val = "";
            for (int i = 0; i < dizi.Length; i++)
            {
                val += $"{dizi[i]},";

                //if (i < dizi.Length -1)
                //{
                //    Console.WriteLine(i + ",");
                //}
                //else
                //{
                //    Console.WriteLine(i);
                //}
            }
            val = val.Substring(0, val.Length - 1);
            Console.WriteLine(val);
        }

        public static int[] DiziCarp(int[] dizi, int deger)
        {
            for (int i = 0; i < dizi.Length; i++)
            {
                //dizi[i] = dizi[i] * deger;
                dizi[i] *= deger;
            }
            return dizi;
        }

        public static bool Tahmin(int[] dizi, int tahmin)
        {
            for (int i = 0; i < dizi.Length; i++)
            {
                if (dizi[i] == tahmin)
                {
                    return true;
                }
            }
            return false;
        }

    }
}
