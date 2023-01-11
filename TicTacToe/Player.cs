using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe;

public class Player
{
    public string X;
    public int count; // The player's turn is 0, the enemy's 1.
    public Player()
    {
        count = 0;
        X = "X";
    }
    public void Select(string[,] game, string nil)
    {
        Console.WriteLine();
        Console.WriteLine("Куда хотите поставить X? Ввод от 1 до 9, n = пустота.");
        string select = Console.ReadLine();
        bool parse = int.TryParse(select, out var selected);
        if (parse)
        {
            switch (selected)
            {
                case 1:
                    if (game[0, 0] != X && game[0, 0] != nil)
                    {
                        game[0, 0] = X;
                        count++;
                    }
                    else
                    {
                        Console.WriteLine();
                        Console.WriteLine("Место уже занято");

                    }
                    break;
                case 2:
                    if (game[0, 1] != X && game[0, 1] != nil)
                    {
                        game[0, 1] = X;
                        count++;
                    }
                    else
                    {
                        Console.WriteLine();
                        Console.WriteLine("Место уже занято");
                        Select(game, nil);
                    }
                    break;
                case 3:
                    if (game[0, 2] != X && game[0, 2] != nil)
                    {
                        game[0, 2] = X;
                        count++;
                    }
                    else
                    {
                        Console.WriteLine();
                        Console.WriteLine("Место уже занято");
                        Select(game, nil);
                    }
                    break;
                case 4:
                    if (game[1, 0] != X && game[1, 0] != nil)
                    {
                        game[1, 0] = X;
                        count++;
                    }
                    else
                    {
                        Console.WriteLine();
                        Console.WriteLine("Место уже занято");
                        Select(game, nil);
                    }
                    break;
                case 5:
                    if (game[1, 1] != X && game[1, 1] != nil)
                    {
                        game[1, 1] = X;
                        count++;
                    }
                    else
                    {
                        Console.WriteLine();
                        Console.WriteLine("Место уже занято");
                        Select(game, nil);
                    }
                    break;
                case 6:
                    if (game[1, 2] != X && game[1, 2] != nil)
                    {
                        game[1, 2] = X;
                        count++;
                    }
                    else
                    {
                        Console.WriteLine();
                        Console.WriteLine("Место уже занято");
                        Select(game, nil);
                    }
                    break;
                case 7:
                    if (game[2, 0] != X && game[2, 0] != nil)
                    {
                        game[2, 0] = X;
                        count++;
                    }
                    else
                    {
                        Console.WriteLine();
                        Console.WriteLine("Место уже занято");
                        Select(game, nil);
                    }
                    break;
                case 8:
                    if (game[2, 1] != X && game[2, 1] != nil)
                    {
                        game[2, 1] = X;
                        count++;
                    }
                    else
                    {
                        Console.WriteLine();
                        Console.WriteLine("Место уже занято");
                        Select(game, nil);
                    }
                    break;
                case 9:
                    if (game[2, 2] != X && game[2, 2] != nil)
                    {
                        game[2, 2] = X;
                        count++;
                    }
                    else
                    {
                        Console.WriteLine();
                        Console.WriteLine("Место уже занято");
                        Select(game, nil);
                    }
                    break;
                default:
                    Console.WriteLine();
                    Console.WriteLine("Введите верное значение");
                    Console.WriteLine();
                    break;
            }
        }
    }
}
