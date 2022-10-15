using System;

namespace ConsoleApp10
{
    class Program
    {
        static void Main(string[] args)
        { 
            // Sort 

            int[] sayidizisi = { 23, 12, 53, 75, 23, 6, 1, 4 };
            Console.WriteLine("************Sırasız Liste");
            foreach (var sayi in sayidizisi)
            {
                Console.WriteLine(sayi);
            }
            Console.WriteLine("************Sıralı Liste");

            Array.Sort(sayidizisi);
            foreach (var sayi in sayidizisi)
            {
                Console.WriteLine(sayi);
            }
            // Clear
            Console.WriteLine("************Array clear");
            // sayidizisindeki elemanlari kullanarak 2.indexten itibaren 2 tane elemani 0'lar
            Array.Clear(sayidizisi, 2, 2);
            foreach (var sayi in sayidizisi)
            {
                Console.WriteLine(sayi);
            }
            // Reverse aynalayarak tersine cevirir
            Console.WriteLine("************Array reverse");

            Array.Reverse(sayidizisi);
            foreach (var sayi in sayidizisi)
            {
                Console.WriteLine(sayi);
            }

            Console.WriteLine("************Array indexof");

           // IndexOf diziden bir eleman cagridiginda bize indexini yani adresini verirler.
            Console.WriteLine(Array.IndexOf(sayidizisi, 23));

            Console.WriteLine("************Array resize");
          // Resize metodu ile  dizinin boyutu degisitilir ve yeni bir eleman eklenir.
            Array.Resize<int>(ref sayidizisi, 9);
            sayidizisi[8] = 90;
            foreach (var sayi in sayidizisi)
            {
                Console.WriteLine(sayi);
            }
        }
    }
}
