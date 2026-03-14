namespace BottlesOfBeer;

public static class Utils
{
    public static string Capitalize(this string input)
    {
        return char.ToUpper(input[0]) + input[1..];
    }
}