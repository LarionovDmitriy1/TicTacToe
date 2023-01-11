using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe;

public class Enemy
{
    public string nil;
    public Enemy()
    {
        nil = "0";
    }
    public void EnemyPlayer(string[,] game, string X)
    {
        Random selectedR = new Random();
        int selected = selectedR.Next(1, 10);

        Console.WriteLine("Ход врага");
        switch (selected)
        {
            case 1:
                if (game[0, 0] != X && game[0, 0] != nil)
                {
                    game[0, 0] = nil;
                }
                else
                {
                    EnemyPlayer(game, X);
                }
                break;
            case 2:
                if (game[0, 1] != X && game[0, 1] != nil)
                {
                    game[0, 1] = nil;
                }
                else
                {
                    EnemyPlayer(game, X);
                }
                break;
            case 3:
                if (game[0, 2] != X && game[0, 2] != nil)
                {
                    game[0, 2] = nil;
                }
                else
                {
                    EnemyPlayer(game, X);
                }
                break;
            case 4:
                if (game[1, 0] != X && game[1, 0] != nil)
                {
                    game[1, 0] = nil;
                }
                else
                {
                    EnemyPlayer(game, X);
                }
                break;
            case 5:
                if (game[1, 1] != X && game[1, 1] != nil)
                {
                    game[1, 1] = nil;
                }
                else
                {
                    EnemyPlayer(game, X);
                }
                break;
            case 6:
                if (game[1, 2] != X && game[1, 2] != nil)
                {
                    game[1, 2] = nil;
                }
                else
                {
                    EnemyPlayer(game, X);
                }
                break;
            case 7:
                if (game[2, 0] != X && game[2, 0] != nil)
                {
                    game[2, 0] = nil;
                }
                else
                {
                    EnemyPlayer(game, X);
                }
                break;
            case 8:
                if (game[2, 1] != X && game[2, 1] != nil)
                {
                    game[2, 1] = nil;
                }
                else
                {
                    EnemyPlayer(game, X);
                }
                break;
            case 9:
                if (game[2, 2] != X && game[2, 2] != nil)
                {
                    game[2, 2] = nil;
                }
                else
                {
                    EnemyPlayer(game, X);
                }
                break;
        }
    }
}
