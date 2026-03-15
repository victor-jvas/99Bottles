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
        return $"{bottleNumber.Quantity().Capitalize()} {bottleNumber.Container()} of beer on the wall, " +
               $"{bottleNumber.Quantity()} {bottleNumber.Container()} of beer.\n" +
               bottleNumber.Action() +
               $"{nextBottleNumber.Quantity()} {nextBottleNumber.Container()} of beer on the wall.\n";
    }
}