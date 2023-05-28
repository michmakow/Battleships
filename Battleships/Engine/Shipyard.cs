using Battleships.Models;
using Battleships.Utility;
using System.Text;
using static Battleships.Utility.Enums;

namespace Battleships.Engine
{
    public class Shipyard
    {
        private StringBuilder _stringBuilder = new();
        private Random _random { get; set; }

        public Shipyard(Board board)
        {
            _random = new Random();
            FillBoardWithShips(board);
        }

        private void FillBoardWithShips(Board board)
        {
            AddShipsToCollection(Consts.EachShipCount, board.Ships);
            PlaceShips(board);
        }

        private void PlaceShips(Board board)
        {
            for (var i = 0; i < board.Ships.Count; i++)
            {
                var ship = board.Ships[i];
                var x = _random.Next(1, board.Map.GetLength(0));
                var y = _random.Next(1, board.Map.GetLength(1));
                var direction = _random.Next(0, 3);

                switch (direction)
                {
                    case 0 when CanBePlacedNorth(x, y, ship.Lenght, board.Map, board.Ships):
                        PlaceShipNorth(x, y, ship);
                        break;

                    case 1 when CanBePlacedEast(x, y, ship.Lenght, board.Map, board.Ships):
                        PlaceShipEast(x, y, ship);
                        break;

                    case 2 when CanBePlacedSouth(x, y, ship.Lenght, board.Map, board.Ships):
                        PlaceShipSouth(x, y, ship);
                        break;

                    case 3 when CanBePlacedWest(x, y, ship.Lenght, board.Map, board.Ships):
                        PlaceShipWest(x, y, ship);
                        break;

                    default:
                        i--;
                        break;
                }
            }
        }

        private void AddShipsToCollection(int eachShipCount, IList<Ship> ships)
        {
            AddBattleshipsToCollection(eachShipCount, ships);
            AddDestroyersToCollection(eachShipCount, ships);
        }

        private void AddBattleshipsToCollection(int shipsNumber, IList<Ship> ships)
        {
            for (int i = 1; i <= shipsNumber; i++)
            {
                ships.Add(new Ship(ShipEnum.Battleship));
            }
        }

        private void AddDestroyersToCollection(int shipsNumber, IList<Ship> ships)
        {
            for (int i = 1; i <= shipsNumber; i++)
            {
                ships.Add(new Ship(ShipEnum.Destroyer));
            }
        }

        private void PlaceShipNorth(int x, int y, Ship ship)
        {
            for (var i = 0; i < ship.Lenght; i++)
            {
                var clearedStringBuidler = _stringBuilder.Clear();
                ship.Coordinates.Add(clearedStringBuidler.Append((LetterEnum)y - i).Append(x).ToString());
            }
        }

        private void PlaceShipEast(int x, int y, Ship ship)
        {
            for (var i = 0; i < ship.Lenght; i++)
            {
                var clearedStringBuidler = _stringBuilder.Clear();
                ship.Coordinates.Add(clearedStringBuidler.Append((LetterEnum)y).Append(x + i).ToString());
            }
        }

        private void PlaceShipSouth(int x, int y, Ship ship)
        {
            for (var i = 0; i < ship.Lenght; i++)
            {
                var clearedStringBuidler = _stringBuilder.Clear();
                ship.Coordinates.Add(clearedStringBuidler.Append((LetterEnum)y + i).Append(x).ToString());
            }
        }

        private void PlaceShipWest(int x, int y, Ship ship)
        {
            for (var i = 0; i < ship.Lenght; i++)
            {
                var clearedStringBuidler = _stringBuilder.Clear();
                ship.Coordinates.Add(clearedStringBuidler.Append((LetterEnum)y).Append(x - i).ToString());
            }
        }

        private bool CanBePlacedNorth(int x, int y, int shipLenght, string[,] map, List<Ship> ships)
        {
            for (var i = 0; i < shipLenght; i++)
            {
                var clearedStringBuidler = _stringBuilder.Clear();
                var searchedCoordinates = clearedStringBuidler.Append((LetterEnum)y - i).Append(x).ToString();
                if (ships.Find(s => s.Coordinates.Contains(searchedCoordinates)) is not null
                    || !string.IsNullOrEmpty(map[y - i, x]))
                {
                    return false;
                }
            }

            return true;
        }

        private bool CanBePlacedEast(int x, int y, int shipLenght, string[,] map, List<Ship> ships)
        {
            for (var i = 0; i < shipLenght; i++)
            {
                var clearedStringBuidler = _stringBuilder.Clear();
                var searchedCoordinates = clearedStringBuidler.Append((LetterEnum)y).Append(x + i).ToString();
                if (x + i > 10 || ships.Find(s => s.Coordinates.Contains(searchedCoordinates)) is not null
                    || !string.IsNullOrEmpty(map[y, x + i]))
                {
                    return false;
                }
            }
            return true;
        }

        private bool CanBePlacedSouth(int x, int y, int shipLenght, string[,] map, List<Ship> ships)
        {
            for (var i = 0; i < shipLenght; i++)
            {
                var clearedStringBuidler = _stringBuilder.Clear();
                var searchedCoordinates = clearedStringBuidler.Append((LetterEnum)y + i).Append(x).ToString();
                if (y + i > 10 || ships.Find(s => s.Coordinates.Contains(searchedCoordinates)) is not null
                    || !string.IsNullOrEmpty(map[y + i, x]))
                {
                    return false;
                }
            }
            return true;
        }

        private bool CanBePlacedWest(int x, int y, int shipLenght, string[,] map, List<Ship> ships)
        {
            for (var i = 0; i < shipLenght; i++)
            {
                var clearedStringBuidler = _stringBuilder.Clear();
                var searchedCoordinates = clearedStringBuidler.Append((LetterEnum)y).Append(x - i).ToString();
                if (ships.Find(s => s.Coordinates.Contains(searchedCoordinates)) is not null
                    || !string.IsNullOrEmpty(map[y, x - i]))
                {
                    return false;
                }
            }
            return true;
        }
    }
}