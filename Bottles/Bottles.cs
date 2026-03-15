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
        BottleNumber bottleNumber = new(number);
        BottleNumber nextBottleNumber = new(bottleNumber.Successor());
        
        return $"{bottleNumber}".Capitalize() + " of beer on the wall, " +
               $"{bottleNumber} of beer.\n" +
               bottleNumber.Action() +
               $"{nextBottleNumber} of beer on the wall.\n";
    }
}