using System;


public class Violin : Instrument
{
    public Violin(string model, int quan): base(model)
    {
        Quantity = quan;
    }
    public int Quantity { get; set; }

    public override void Sound()
    {

        Console.WriteLine("Violin");
    }

}

