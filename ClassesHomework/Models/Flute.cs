using System;

public class Flute : Instrument
{
    public Flute(string model, int purchased) : base(model)
    {
        Purchased = purchased;
    }
    public int Purchased { get; set; }
    public override void Sound()
    {

        Console.WriteLine("Flute");
    }
}

