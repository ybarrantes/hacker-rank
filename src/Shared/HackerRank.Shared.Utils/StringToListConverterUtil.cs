namespace HackerRank.Shared.Utils;

public static class StringToListConverterUtil
{
    public const char DefaultSeparator = ' ';
    public const char DefaultBreakLine = '|';
        
    public static List<int> GetIntList(string str, char separator = DefaultSeparator) =>
        str.Split(separator).Select(int.Parse).ToList();

    public static List<List<int>> GetInt2DList(string str, char separator = DefaultSeparator, char breakLine = DefaultBreakLine) =>
        str.Split(breakLine)
            .Select(x => 
                GetIntList(x, separator)
            ).ToList();
}