namespace BottlesOfBeer;

public class BottleNumber0(int number) : BottleNumber(number)
{
    protected override string Quantity()
    {
        return "no more";
    }
    
    public override string Action()
    {
        return "Go to the store and buy some more, ";
    }
    
    public override int Successor()
    {
        return 99;
    }
}