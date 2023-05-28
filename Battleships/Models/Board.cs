using Battleships.Engine;
using Battleships.Utility;

namespace Battleships.Models
{
    public class Board
    {
        public string[,] Map { get; set; } = new string[Consts.BoardLenght, Consts.BoardLenght];
        public List<Ship> Ships { get; set; } = new List<Ship>();

        public Board()
        {
            FillBoard();
            _ = new Shipyard(this);
        }

        private void FillBoard()
        {
            for (var i = 0; i < Map.GetLength(0); i++)
            {
                Map[0, i] = Consts.ColumnLetters[i];
            }

            for (var i = 0; i < Map.GetLength(1); i++)
            {
                Map[i, 0] = Consts.RowNumbers[i];
            }
        }

        public void ShowBoard()
        {
            for (var i = 0; i < Map.GetLength(0); i++)
            {
                for (var j = 0; j < Map.GetLength(1); j++)
                {
                    if (string.IsNullOrEmpty(Map[i, j]))
                    {
                        Console.Write(Map[i, j] + "  ");
                    }
                    else
                    {
                        Console.Write(Map[i, j]);
                    }
                }
                Console.WriteLine();
            }
        }

        public void CheckIfThereIsMoreShipParts(ref bool isRunning, Ship ship)
        {
            if (ship.Coordinates.Count == 0)
            {
                RemoveShip(ref isRunning, ship);
            }
            else
            {
                Console.WriteLine(string.Format(Properties.Resources.ShipHit, ship.Name));
            }
        }

        private void RemoveShip(ref bool isRunning, Ship ship)
        {
            Console.WriteLine(string.Format(Properties.Resources.ShipSunk, ship.Name));
            Ships.Remove(ship);

            CheckIfThereIsNoShip(ref isRunning);
        }

        private void CheckIfThereIsNoShip(ref bool isRunning)
        {
            if (!Ships.Any())
            {
                if (!Console.IsOutputRedirected)
                {
                    Console.Clear();
                }
                Console.WriteLine(Properties.Resources.YouWon);
                isRunning = false;
            }
        }
    }
}