using TicTacToe;

PlayingField pf = new();
Player player = new();
Enemy enemy = new();
pf.CreatePlayngField();
while (true)
{
    pf.Game();
    Console.WriteLine();
    if (!pf.CheckWin(player.X, enemy.nil))
    {
        if (player.count == 0)
        {
            player.Select(pf.game, enemy.nil);
        }
        else if (player.count == 1)
        {
            enemy.EnemyPlayer(pf.game, player.X);
            player.count = 0;
        }
    }
    else
    {
        break;
    }
}