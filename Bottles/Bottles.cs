namespace BottlesOfBeer;

public class Bottles
{
    private string verse = "99 bottles of beer on the wall, " +
                           "99 bottles of beer.\n" +
                           "Take one down and pass it around, " +
                           "98 bottles of beer on the wall.\n";
    

    public string Verse(int number)
    {
        bool hasBeerLeft = number != 0;
        bool hasMoreThanOneBeer = hasBeerLeft && number != 1;
        
        string line1 = hasMoreThanOneBeer ? $"{number} bottles of beer on the wall, " : hasBeerLeft ? $"{number} bottle of beer on the wall, " : "No more bottles of beer on the wall, ";
        string line2 = hasMoreThanOneBeer ? $"{number} bottles of beer.\n" : hasBeerLeft ? $"{number} bottle of beer.\n" : "no more bottles of beer.\n";
        
        string line3 = hasMoreThanOneBeer ? "Take one down and pass it around, " : hasBeerLeft ? "Take it down and pass it around, " : "Go to the store and buy some more, ";
        
        hasBeerLeft = --number > 0;
        hasMoreThanOneBeer = hasBeerLeft && number > 1;
        
        string line4 = hasMoreThanOneBeer ? $"{number} bottles of beer on the wall.\n" : hasBeerLeft ? $"{number} bottle of beer on the wall.\n" : "no more bottles of beer on the wall.\n";

        string result = line1 + line2 + line3 + line4;
                         
        
        return result;
    }
}