namespace ExchangeRates;

public class ConvertInDollars : Converter
{
    public int CountDollars;
    public ConvertInDollars()
    {
        Course = 60;
    }
    public override void Convert(int Dollars)
    {
        CountDollars = Dollars / Course;
    }
}