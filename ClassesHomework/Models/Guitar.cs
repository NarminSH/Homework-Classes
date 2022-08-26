using System;

public class Guitar : Instrument
{
    public Guitar(string model, string quality): base(model)
    {
        Quality = quality;
    }
    public string Quality { get; set; }

    public override void Sound()
    {

        Console.WriteLine("Guitar");
    }

}

