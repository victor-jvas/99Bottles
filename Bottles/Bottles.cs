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
    
    public string Container(int number)
    {
        return new BottleNumber(number).Container();
    }

    public string Pronoun(int number)
    {
        return new BottleNumber(number).Pronoun();
    }

    public string Quantity(int number)
    {
        return new BottleNumber(number).Quantity();
    }

    public string Action(int number)
    {
        return new BottleNumber(number).Action();
    }

    public int Successor(int number)
    {
        return new BottleNumber(number).Successor();
    }
}