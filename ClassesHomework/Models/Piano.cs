using System;

public class Piano : Instrument
{
    public Piano(string model, string owner) :base(model)
    {
        Owner = owner;

    }
    public string Owner { get; set; }

    public override void Sound()
    {

        Console.WriteLine("Piano");
    }
}


