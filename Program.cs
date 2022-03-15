using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        //Anahtar Değer 

        //Not aynı anahtara 2 değer atama yapılamaz Unique olmalı

        Dictionary<int,string> kullanicilar = new Dictionary<int, string>();

        kullanicilar.Add(1 , "Hakki");
        kullanicilar.Add(11,"Deniz");
        kullanicilar.Add(15,"Cüneyt");

        //Dizinin Elemanlarına Erişim

        Console.WriteLine("***** Elemanlara Erişim *****");
        Console.WriteLine(kullanicilar[15]);
        foreach (var item in kullanicilar)
        {
            System.Console.WriteLine(item);            
        }

        //Count;
        //eleman sayısını yazdırır.
        Console.WriteLine("***** Count *****");
        System.Console.WriteLine(kullanicilar.Count);


        //Contains 
        // Verilen anahtar yada değerin olup olmadığını kontrol eder.(True-False değer döner)

        System.Console.WriteLine(kullanicilar.ContainsKey(11));
        System.Console.WriteLine(kullanicilar.ContainsValue("Arda"));


        //Remove
        Console.WriteLine("***** Remove *****");
        kullanicilar.Remove(11);
        foreach (var item in kullanicilar)
        {
            System.Console.WriteLine(item);
        }

        //Keys
        Console.WriteLine("***** Keys*****");
        foreach (var item in kullanicilar.Keys)
        {
            Console.WriteLine(item);
        }


        //Values
        Console.WriteLine("***** Values*****");
        foreach (var item in kullanicilar.Values)
        {
            Console.WriteLine(item);
        }
    }
}
