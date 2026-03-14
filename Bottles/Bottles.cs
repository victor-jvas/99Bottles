namespace BottlesOfBeer;

public class Bottles
{
    public string Song()
    {
        return Verses(99, 0);
    }
    
    public string Verses(int upperVerse, int lowerVerse)
    {
        List<string> result = [];
        for (int i = upperVerse; i >= lowerVerse; i--)
        {
            result.Add(Verse(i));
        }
       
        return string.Join("\n", result);        
    }
    
    public string Verse(int number)
    {
        return $"{Quantity(number).Capitalize()} {Container(number)} of beer on the wall, " +
               $"{Quantity(number)} {Container(number)} of beer.\n" +
               Action(number) +
               $"{Quantity(Successor(number))} {Container(Successor(number))} of beer on the wall.\n";
    }

    private string Container(int number)
    {
        if (number == 1)
        {
            return "bottle";
        }
        return "bottles";
    }

    private string Pronoun(int number)
    {
        if (number == 1)
        {
            return "it";
        }
        return "one";
    }

    private string Quantity(int number)
    {
        if (number == 0)
        {
            return "no more";
        }
        return number.ToString();
    }

    private string Action(int number)
    {
        if (number == 0)
        {
            return "Go to the store and buy some more, ";
        }
        return $"Take {Pronoun(number)} down and pass it around, ";
    }

    private int Successor(int number)
    {
        if (number == 0)
        {
            return 99;
        }
        return number-1;
    }
    
}