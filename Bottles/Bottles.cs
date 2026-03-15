namespace BottlesOfBeer;

public class Bottles
{

    private static BottleNumber BottleNumberGiven(int number)
    {
        return number switch
        {
            0 => new BottleNumber0(number),
            1 => new BottleNumber1(number),
            _ => new BottleNumber(number)
        };
    }

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
        BottleNumber bottleNumber = BottleNumberGiven(number);
        BottleNumber nextBottleNumber = BottleNumberGiven(bottleNumber.Successor());
        
        return $"{bottleNumber}".Capitalize() + " of beer on the wall, " +
               $"{bottleNumber} of beer.\n" +
               bottleNumber.Action() +
               $"{nextBottleNumber} of beer on the wall.\n";
    }
}