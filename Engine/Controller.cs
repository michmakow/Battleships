using Battleships.Models;
using Battleships.Utility;
using static Battleships.Utility.Enums;

namespace Battleships.Engine
{
    public static class Controller
    {
        public static void HandleInput(ref bool isRunning, Board board)
        {
            Console.WriteLine(Properties.Resources.EnterCoordinates);
            var input = Console.ReadLine().ToUpper();

            switch (input)
            {
                case Consts.QuitLetter:
                    Console.Clear();
                    Console.WriteLine(Properties.Resources.ThanksForPlaying);
                    isRunning = false;
                    break;

                case var _ when Consts.InputRegex().IsMatch(input):
                    var x = input[0].ToString();
                    var y = input.Length == 3 ? input[1..] : input[1].ToString();

                    if (input.Length == 3 && int.Parse(y) > 10)
                    {
                        Console.Clear();
                        Console.WriteLine(Properties.Resources.WrongInput);
                        break;
                    }

                    Console.Clear();
                    Console.WriteLine(string.Format(Properties.Resources.Coordinates, x, y));
                    Console.WriteLine(Properties.Resources.Firing);

                    var ship = board.Ships.Find(s => s.Coordinates.Contains(input));
                    var mappedX = (int)Enum.Parse(typeof(LetterEnum), x);
                    var mappedY = int.Parse(y);

                    if (board.Map[mappedY, mappedX] == Consts.HitIcon || board.Map[mappedY, mappedX] == Consts.MissIcon)
                    {
                        Console.WriteLine(Properties.Resources.SameSpot);
                    }
                    else if (ship is not null)
                    {
                        ship.Coordinates.Remove(input);
                        board.Map[mappedY, mappedX] = Consts.HitIcon;

                        board.CheckIfThereIsMoreShipParts(ref isRunning, ship);
                    }
                    else
                    {
                        board.Map[mappedY, mappedX] = Consts.MissIcon;
                        Console.WriteLine(Properties.Resources.ShipMissed);
                    }
                    break;

                default:
                    Console.Clear();
                    Console.WriteLine(Properties.Resources.WrongInput);
                    break;
            }
        }
    }
}