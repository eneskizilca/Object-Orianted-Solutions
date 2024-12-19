using System;
using System.Collections.Generic;

abstract class Urun
{
    public string Ad { get; set; }
    public decimal Fiyat { get; set; }

    public abstract decimal HesaplaOdeme();
    public abstract void BilgiYazdir();
}

class Kitap : Urun
{
    public string Yazar { get; set; }

    public override decimal HesaplaOdeme()
    {
        return Fiyat + (Fiyat * 0.10m);
    }

    public override void BilgiYazdir()
    {
        Console.WriteLine($"Kitap: {Ad}, Yazar: {Yazar}, Fiyat: {Fiyat:C}, Ödenecek Tutar: {HesaplaOdeme():C}");
    }
}

class Elektronik : Urun
{
    public string Marka { get; set; }

    public override decimal HesaplaOdeme()
    {
        return Fiyat + (Fiyat * 0.25m);
    }

    public override void BilgiYazdir()
    {
        Console.WriteLine($"Elektronik: {Ad}, Marka: {Marka}, Fiyat: {Fiyat:C}, Ödenecek Tutar: {HesaplaOdeme():C}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        List<Urun> urunler = new List<Urun>
        {
            new Kitap { Ad = "C# Programlama", Fiyat = 50, Yazar = "John Doe" },
            new Elektronik { Ad = "Akıllı Telefon", Fiyat = 2000, Marka = "TechBrand" }
        };

        foreach (var urun in urunler)
        {
            urun.BilgiYazdir();
        }
        Console.Read();
    }
}
