using System;

class Hayvan
{
    public string Ad { get; set; }
    public string Tur { get; set; }
    public int Yas { get; set; }

    public virtual void SesCikar()
    {
        Console.WriteLine("Hayvan ses çıkarıyor.");
    }
}

class Memeli : Hayvan
{
    public string TuyRengi { get; set; }

    public override void SesCikar()
    {
        Console.WriteLine("Memeli ses çıkarıyor: Mırr!");
    }
}

class Kus : Hayvan
{
    public double KanatGenisligi { get; set; }

    public override void SesCikar()
    {
        Console.WriteLine("Kuş ses çıkarıyor: Cik Cik!");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hayvan türünü seçin: (1 - Memeli, 2 - Kuş)");
        string secim = Console.ReadLine();

        if (secim == "1")
        {
            Memeli memeli = new Memeli();

            Console.Write("Ad: ");
            memeli.Ad = Console.ReadLine();

            Console.Write("Tür: ");
            memeli.Tur = Console.ReadLine();

            Console.Write("Yaş: ");
            memeli.Yas = Convert.ToInt32(Console.ReadLine());

            Console.Write("Tüy Rengi: ");
            memeli.TuyRengi = Console.ReadLine();

            Console.WriteLine("Bilgiler:");
            Console.WriteLine($"Ad: {memeli.Ad}, Tür: {memeli.Tur}, Yaş: {memeli.Yas}, Tüy Rengi: {memeli.TuyRengi}");
            memeli.SesCikar();
        }
        else if (secim == "2")
        {
            Kus kus = new Kus();

            Console.Write("Ad: ");
            kus.Ad = Console.ReadLine();

            Console.Write("Tür: ");
            kus.Tur = Console.ReadLine();

            Console.Write("Yaş: ");
            kus.Yas = Convert.ToInt32(Console.ReadLine());

            Console.Write("Kanat Genişliği (cm): ");
            kus.KanatGenisligi = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Bilgiler:");
            Console.WriteLine($"Ad: {kus.Ad}, Tür: {kus.Tur}, Yaş: {kus.Yas}, Kanat Genişliği: {kus.KanatGenisligi} cm");
            kus.SesCikar();
        }
        else
        {
            Console.WriteLine("Geçersiz seçim!");
        }
        Console.Read();
    }
}
