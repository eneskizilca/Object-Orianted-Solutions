using System;

abstract class Hesap
{
    public string HesapNo { get; set; }
    public decimal Bakiye { get; set; }

    public abstract void ParaYatir(decimal miktar);
    public abstract void ParaCek(decimal miktar);
}

interface IBankaHesabi
{
    DateTime HesapAcilisTarihi { get; set; }
    void HesapOzeti();
}

class BirikimHesabi : Hesap, IBankaHesabi
{
    public decimal FaizOrani { get; set; }
    public DateTime HesapAcilisTarihi { get; set; }

    public override void ParaYatir(decimal miktar)
    {
        Bakiye += miktar + (miktar * FaizOrani / 100);
        Console.WriteLine($"Hesaba {miktar:C} yatırıldı. Yeni bakiye (faiz dahil): {Bakiye:C}");
    }

    public override void ParaCek(decimal miktar)
    {
        if (Bakiye >= miktar)
        {
            Bakiye -= miktar;
            Console.WriteLine($"Hesaptan {miktar:C} çekildi. Kalan bakiye: {Bakiye:C}");
        }
        else
        {
            Console.WriteLine("Yetersiz bakiye!");
        }
    }

    public void HesapOzeti()
    {
        Console.WriteLine($"Hesap No: {HesapNo}, Bakiye: {Bakiye:C}, Faiz Oranı: %{FaizOrani}, Açılış Tarihi: {HesapAcilisTarihi.ToShortDateString()}");
    }
}

class VadesizHesap : Hesap, IBankaHesabi
{
    public decimal IslemUcreti { get; set; }
    public DateTime HesapAcilisTarihi { get; set; }

    public override void ParaYatir(decimal miktar)
    {
        Bakiye += miktar;
        Console.WriteLine($"Hesaba {miktar:C} yatırıldı. Yeni bakiye: {Bakiye:C}");
    }

    public override void ParaCek(decimal miktar)
    {
        decimal toplamTutar = miktar + IslemUcreti;
        if (Bakiye >= toplamTutar)
        {
            Bakiye -= toplamTutar;
            Console.WriteLine($"Hesaptan {miktar:C} (işlem ücreti: {IslemUcreti:C}) çekildi. Kalan bakiye: {Bakiye:C}");
        }
        else
        {
            Console.WriteLine("Yetersiz bakiye!");
        }
    }

    public void HesapOzeti()
    {
        Console.WriteLine($"Hesap No: {HesapNo}, Bakiye: {Bakiye:C}, İşlem Ücreti: {IslemUcreti:C}, Açılış Tarihi: {HesapAcilisTarihi.ToShortDateString()}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        BirikimHesabi birikimHesabi = new BirikimHesabi
        {
            HesapNo = "123456",
            Bakiye = 1000,
            FaizOrani = 5,
            HesapAcilisTarihi = DateTime.Now
        };

        VadesizHesap vadesizHesap = new VadesizHesap
        {
            HesapNo = "654321",
            Bakiye = 500,
            IslemUcreti = 2,
            HesapAcilisTarihi = DateTime.Now
        };

        Console.WriteLine("Birikim Hesabı İşlemleri:");
        birikimHesabi.ParaYatir(200);
        birikimHesabi.ParaCek(100);
        birikimHesabi.HesapOzeti();

        Console.WriteLine("\nVadesiz Hesap İşlemleri:");
        vadesizHesap.ParaYatir(300);
        vadesizHesap.ParaCek(200);
        vadesizHesap.HesapOzeti();

        Console.Read();
    }
}
