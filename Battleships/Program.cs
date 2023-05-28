using Battleships.Engine;
using Battleships.Models;

var isRunning = true;
var board = new Board();

while (isRunning)
{
    board.ShowBoard();
    Controller.HandleInput(ref isRunning, board);
}