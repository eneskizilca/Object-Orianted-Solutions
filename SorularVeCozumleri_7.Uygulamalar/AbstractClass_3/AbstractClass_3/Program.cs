using System;
using System.Collections.Generic;

interface IYayinci
{
    void AboneEkle(IAbone abone);
    void AboneCikar(IAbone abone);
    void AbonelereBildirimGonder(string mesaj);
}

interface IAbone
{
    void BilgiAl(string mesaj);
}

class Yayinci : IYayinci
{
    private List<IAbone> aboneler = new List<IAbone>();

    public void AboneEkle(IAbone abone)
    {
        aboneler.Add(abone);
        Console.WriteLine("Abone eklendi.");
    }

    public void AboneCikar(IAbone abone)
    {
        aboneler.Remove(abone);
        Console.WriteLine("Abone çıkarıldı.");
    }

    public void AbonelereBildirimGonder(string mesaj)
    {
        foreach (var abone in aboneler)
        {
            abone.BilgiAl(mesaj);
        }
    }
}

class Abone : IAbone
{
    public string Ad { get; set; }

    public void BilgiAl(string mesaj)
    {
        Console.WriteLine($"{Ad} adlı aboneye mesaj: {mesaj}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Yayinci yayinci = new Yayinci();

        Abone abone1 = new Abone { Ad = "Aybars" };
        Abone abone2 = new Abone { Ad = "Berat" };

        yayinci.AboneEkle(abone1);
        yayinci.AboneEkle(abone2);

        yayinci.AbonelereBildirimGonder("Yeni bir ürün eklenmiştir.");

        yayinci.AboneCikar(abone1);

        yayinci.AbonelereBildirimGonder("İndirim kampanyası başladı.");

        Console.Read();
    }
}
