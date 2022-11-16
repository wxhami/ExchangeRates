namespace ExchangeRates;

public class ConvertInEuro : Converter
{
    public int CountEuro;

    public ConvertInEuro()
    {
        Course = 65;
    }
    
    public override void Convert(int Euro)
    {
        CountEuro = Euro / Course;
    }
}