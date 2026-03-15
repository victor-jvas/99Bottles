namespace BottlesOfBeer;

public class BottleNumber1(int number) : BottleNumber(number)
{
    protected override string Container()
    {
        return "bottle";
    }
    
    protected override string Pronoun()
    {
        return "it";
    }
}