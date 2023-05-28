using Battleships.Utility;
using static Battleships.Utility.Enums;

namespace Battleships.Models
{
    public class Ship
    {
        public ShipEnum Name { get; set; }
        public int Lenght { get; set; }
        public List<string> Coordinates { get; set; }

        public Ship(ShipEnum name)
        {
            Name = name;
            Lenght = name switch
            {
                ShipEnum.Battleship => Consts.BattleshipLenght,
                ShipEnum.Destroyer => Consts.DestroyerLenght,
                _ => Consts.DefaultLenght
            };
            Coordinates = new();
        }
    }
}