using System;


public abstract class Instrument
{
    public Instrument(string model)
    {
        Model = model;
    }
    public string Model { get; set; }
    public double Price { get; set; }
    public string Brand { get; set; }
    public int Year { get; set; }
    public abstract void Sound();

    public void PrintAllInstruments()
    {

        
    }
}










