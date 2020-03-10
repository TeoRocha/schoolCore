using static System.Console;

namespace schoolCore.Util
{
    public static class Printer
    {
        public static void DrawLine(int size = 30)
        {
            WriteLine( "".PadRight(size, '=') );
        }

        public static void WriteTitle(string title)
        {
            DrawLine( title.Length );
            WriteLine( title );
            DrawLine( title.Length );
        }
    }
}