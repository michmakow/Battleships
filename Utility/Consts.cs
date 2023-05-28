using System.Text.RegularExpressions;

namespace Battleships.Utility
{
    public static partial class Consts
    {
        public static readonly string[] ColumnLetters = { " ", " A", " B", " C", " D", " E", " F", " G", " H", " I", " J" };
        public static readonly string[] RowNumbers = { " ", " 1", " 2", " 3", " 4", " 5", " 6", " 7", " 8", " 9", "10" };

        public const string HitIcon = "X ";
        public const string MissIcon = "O ";
        public const string QuitLetter = "Q";
        public const int BoardLenght = 11;
        public const int EachShipCount = 2;

        public const int BattleshipLenght = 5;
        public const int DestroyerLenght = 4;
        public const int DefaultLenght = 0;

        [GeneratedRegex("^[A-J]\\d{1,2}$")]
        public static partial Regex InputRegex();
    }
}