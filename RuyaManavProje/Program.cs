
using System;
using System.Collections.Generic;

// Meyveleri temsil eden enum tanımı
public enum Meyve
{
    Elma,
    Armut,
    Çilek,
    Muz,
    Diğer // Diğer bütün meyveler
}

class Program
{
    static void Main()
    {
        // Meyve fiyatlarını switch-case ile kontrol etmek için bir metot
        void MeyveFiyatiYazdir(Meyve secilenMeyve)
        {
            int fiyat;

            switch (secilenMeyve)
            {
                case Meyve.Elma:
                    fiyat = 2;
                    break;
                case Meyve.Armut:
                    fiyat = 3;
                    break;
                case Meyve.Çilek:
                    fiyat = 2;
                    break;
                case Meyve.Muz:
                    fiyat = 3;
                    break;
                case Meyve.Diğer:
                    fiyat = 4;
                    break;
                default:
                    Console.WriteLine("Geçersiz meyve seçimi!");
                    return;
            }

            Console.WriteLine($"{secilenMeyve} fiyatı: {fiyat} TL");
        }

        // Kullanıcıdan meyve seçimini alıyoruz
        Console.WriteLine("Meyve seçenekleri:");
        Console.WriteLine("1. Elma");
        Console.WriteLine("2. Armut");
        Console.WriteLine("3. Çilek");
        Console.WriteLine("4. Muz");
        Console.WriteLine("5. Diğer");

        Console.Write("Hangi meyveyi satın almak istersiniz? ");

        // Kullanıcının girdisini küçük harfe çevirerek alıyoruz
        string secilenMeyveStr = Console.ReadLine()?.ToLower();

        // Kullanıcının seçimine göre enum değerini belirliyoruz
        Meyve secilenEnumMeyve;

        switch (secilenMeyveStr)
        {
            case "elma":
                secilenEnumMeyve = Meyve.Elma;
                break;
            case "armut":
                secilenEnumMeyve = Meyve.Armut;
                break;
            case "çilek":
                secilenEnumMeyve = Meyve.Çilek;
                break;
            case "muz":
                secilenEnumMeyve = Meyve.Muz;
                break;
            default:
                secilenEnumMeyve = Meyve.Diğer; // Varsayılan olarak Diğer seçeneği
                break;
        }

        // Meyve fiyatını ekrana yazdırmak için metodu çağırıyoruz
        MeyveFiyatiYazdir(secilenEnumMeyve);
    }
}
