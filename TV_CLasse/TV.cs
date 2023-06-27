/*using System;

public class Televisao
{
    private bool ligada;
    private int volume;
    private int canal;

    public bool Ligada
    {
        get { return ligada; }
        set { ligada = value; }
    }

    public int Volume
    {
        get { return volume; }
        set
        {
            if (value >= 0 && value <= 100)
            {
                volume = value;
            }
        }
    }

    public int Canal
    {
        get { return canal; }
        set
        {
            if (value >= 1 && value <= 83)
            {
                canal = value;
            }
        }
    }

    public void Ligar()
    {
        Ligada = true;
    }

    public void Desligar()
    {
        Ligada = false;
    }

    public void AumentarVolume()
    {
        if (Ligada && Volume < 100)
        {
            Volume++;
        }
    }

    public void DiminuirVolume()
    {
        if (Ligada && Volume > 0)
        {
            Volume--;
        }
    }

    public void SubirCanal()
    {
        if (Ligada && Canal < 83)
        {
            Canal++;
        }
    }

    public void BaixarCanal()
    {
        if (Ligada && Canal > 1)
        {
            Canal--;
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Televisao tv = new Televisao();
        tv.Ligar();
        tv.AumentarVolume();
        tv.AumentarVolume();
        tv.SubirCanal();

        Console.WriteLine($"Televisão está ligada: {tv.Ligada}");
        Console.WriteLine($"Volume: {tv.Volume}");
        Console.WriteLine($"Canal: {tv.Canal}");
    }
}
*/