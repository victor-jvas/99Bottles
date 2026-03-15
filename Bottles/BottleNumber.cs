namespace BottlesOfBeer;

public class BottleNumber(int number)
{
    private int _number = number;

    public override string ToString()
    {
        return $"{Quantity()} {Container()}";
    }

    protected virtual string Container()
    {
        if (_number == 1)
        {
            return "bottle";
        }
        return "bottles";
    }

    protected virtual string Pronoun()
    {
        return "one";
    }

    protected virtual string Quantity()
    {
        return _number.ToString();
    }

    public virtual string Action()
    {
        return $"Take {Pronoun()} down and pass it around, ";
    }

    public virtual int Successor()
    {
        return _number-1;
    }
}