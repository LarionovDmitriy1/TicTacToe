using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe;

public class PlayingField
{
    public string[,] game;
    public PlayingField()
    {
        game = new string[3, 3];
    }
    public void CreatePlayngField()
    {
        game[0, 0] = "n";
        game[0, 1] = "n";
        game[0, 2] = "n";
        game[1, 0] = "n";
        game[1, 1] = "n";
        game[1, 2] = "n";
        game[2, 0] = "n";
        game[2, 1] = "n";
        game[2, 2] = "n";
    }
    public bool CheckWin(string X, string nil)
    {
        int counter = 0; // How many moves completed.
        if (counter == 9) { Console.WriteLine("Ничья"); return true; }
        if (game[0, 0] == X && game[0, 1] == X && game[0, 2] == X || game[1, 0] == X && game[1, 1] == X && game[1, 2] == X || game[2, 0] == X && game[2, 1] == X && game[2, 2] == X || game[0, 0] == X && game[1, 1] == X && game[2, 2] == X || game[2, 0] == X && game[1, 1] == X && game[0, 2] == X || game[0, 0] == X && game[1, 1] == X && game[2, 2] == X || game[0, 0] == X && game[1, 0] == X && game[2, 0] == X || game[0, 1] == X && game[1, 1] == X && game[2, 1] == X || game[0, 2] == X && game[1, 2] == X && game[2, 2] == X)
        {
            Console.WriteLine($"Победа за {X}");
            game[0, 0] = "n";
            game[0, 1] = "n";
            game[0, 2] = "n";
            game[1, 0] = "n";
            game[1, 1] = "n";
            game[1, 2] = "n";
            game[2, 0] = "n";
            game[2, 1] = "n";
            game[2, 2] = "n";
            return true;
        }
        else if (game[0, 0] == nil && game[0, 1] == nil && game[0, 2] == nil || game[1, 0] == nil && game[1, 1] == nil && game[1, 2] == nil || game[2, 0] == nil && game[2, 1] == nil && game[2, 2] == nil || game[0, 0] == nil && game[1, 1] == nil && game[2, 2] == nil || game[2, 0] == nil && game[1, 1] == nil && game[0, 2] == nil || game[0, 0] == nil && game[1, 1] == nil && game[2, 2] == nil || game[0, 0] == nil && game[1, 0] == nil && game[2, 0] == nil || game[0, 1] == nil && game[1, 1] == nil && game[2, 1] == nil || game[0, 2] == nil && game[1, 2] == nil && game[2, 2] == nil)
        {
            Console.WriteLine($"Победа за {nil}");
            game[0, 0] = "n";
            game[0, 1] = "n";
            game[0, 2] = "n";
            game[1, 0] = "n";
            game[1, 1] = "n";
            game[1, 2] = "n";
            game[2, 0] = "n";
            game[2, 1] = "n";
            game[2, 2] = "n";
            return true;
        }
        counter++;
        return false;
    }
    public void Game()
    {
        Console.WriteLine($"{game[0, 0]} {game[0, 1]} {game[0, 2]}");
        Console.WriteLine($"{game[1, 0]} {game[1, 1]} {game[1, 2]}");
        Console.WriteLine($"{game[2, 0]} {game[2, 1]} {game[2, 2]}");
    }
}
