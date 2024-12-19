using System;

class Hesap
{
    public string HesapNumarasi { get; set; }
    public decimal Bakiye { get; set; }
    public string HesapSahibi { get; set; }

    public virtual void ParaYatir(decimal miktar)
    {
        Bakiye += miktar;
        Console.WriteLine($"Hesaba {miktar:C} yatırıldı. Yeni bakiye: {Bakiye:C}");
    }

    public virtual void ParaCek(decimal miktar)
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

    public virtual void BilgiYazdir()
    {
        Console.WriteLine($"Hesap Numarası: {HesapNumarasi}, Hesap Sahibi: {HesapSahibi}, Bakiye: {Bakiye:C}");
    }
}

class VadesizHesap : Hesap
{
    public decimal EkHesapLimiti { get; set; }

    public override void ParaCek(decimal miktar)
    {
        if (Bakiye + EkHesapLimiti >= miktar)
        {
            Bakiye -= miktar;
            Console.WriteLine($"Hesaptan {miktar:C} çekildi. Kalan bakiye: {Bakiye:C}");
        }
        else
        {
            Console.WriteLine("Yetersiz bakiye ve ek hesap limiti!");
        }
    }

    public override void BilgiYazdir()
    {
        base.BilgiYazdir();
        Console.WriteLine($"Ek Hesap Limiti: {EkHesapLimiti:C}");
    }
}

class VadeliHesap : Hesap
{
    public int VadeSuresi { get; set; }
    public decimal FaizOrani { get; set; }

    public override void ParaCek(decimal miktar)
    {
        if (VadeSuresi > 0)
        {
            Console.WriteLine("Vade dolmadan para çekemezsiniz!");
        }
        else if (Bakiye >= miktar)
        {
            Bakiye -= miktar;
            Console.WriteLine($"Hesaptan {miktar:C} çekildi. Kalan bakiye: {Bakiye:C}");
        }
        else
        {
            Console.WriteLine("Yetersiz bakiye!");
        }
    }

    public override void BilgiYazdir()
    {
        base.BilgiYazdir();
        Console.WriteLine($"Vade Süresi: {VadeSuresi} gün, Faiz Oranı: %{FaizOrani}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hesap türünü seçin: (1 - Vadesiz Hesap, 2 - Vadeli Hesap)");
        string secim = Console.ReadLine();

        if (secim == "1")
        {
            VadesizHesap vadesizHesap = new VadesizHesap();

            Console.Write("Hesap Numarası: ");
            vadesizHesap.HesapNumarasi = Console.ReadLine();

            Console.Write("Hesap Sahibi: ");
            vadesizHesap.HesapSahibi = Console.ReadLine();

            Console.Write("Bakiye: ");
            vadesizHesap.Bakiye = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Ek Hesap Limiti: ");
            vadesizHesap.EkHesapLimiti = Convert.ToDecimal(Console.ReadLine());

            vadesizHesap.BilgiYazdir();
            vadesizHesap.ParaYatir(500);
            vadesizHesap.ParaCek(200);
        }
        else if (secim == "2")
        {
            VadeliHesap vadeliHesap = new VadeliHesap();

            Console.Write("Hesap Numarası: ");
            vadeliHesap.HesapNumarasi = Console.ReadLine();

            Console.Write("Hesap Sahibi: ");
            vadeliHesap.HesapSahibi = Console.ReadLine();

            Console.Write("Bakiye: ");
            vadeliHesap.Bakiye = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Vade Süresi (gün): ");
            vadeliHesap.VadeSuresi = Convert.ToInt32(Console.ReadLine());

            Console.Write("Faiz Oranı: ");
            vadeliHesap.FaizOrani = Convert.ToDecimal(Console.ReadLine());

            vadeliHesap.BilgiYazdir();
            vadeliHesap.ParaYatir(1000);
            vadeliHesap.ParaCek(500);
        }
        else
        {
            Console.WriteLine("Geçersiz seçim!");
        }
        Console.Read();
    }
}
