using System.IO;
using System.Reflection;

namespace Utils
{
    public static class ReadFileUtil
    {
        public const char DefaultBreakLine = '|';
        
        public static string GetStringFileToInlineText(string filename, char breakLine = DefaultBreakLine)
        {
            string path = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) ?? string.Empty, filename);
            string[] lines = File.ReadAllLines(path);
            return string.Join(breakLine, lines);
        }
    }
}