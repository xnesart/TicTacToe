using TicTacToe.Classes;

Game game = new Game();

while (true)
{
    Console.WriteLine("Введите ряд, от 0 до 2");
    int a = int.Parse(Console.ReadLine());
    Console.WriteLine("Введите колонку, от 0 до 2");
    int b = int.Parse(Console.ReadLine());
    game.MyTurn(a,b);
    bool win = game.CheckWinner();
    if (win == true)
    {
        break;
    }
    bool draw = game.CheckDraw();
    if (draw == true)
    {
        break;
    }
    game.Print();
    Console.WriteLine();
    Console.WriteLine("Ход компьютера");
    game.CompTurn();
    win = game.CheckWinner();
    if (win == true)
    {
        break;
    }
    draw = game.CheckDraw();
    if (draw == true)
    {
        break;
    }
    game.Print();
}

Console.Read();