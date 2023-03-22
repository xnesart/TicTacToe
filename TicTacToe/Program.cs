using TicTacToe.Classes;

Game game = new Game();
string[,] array = game.ArrayFill();
while (true)
{
    Console.WriteLine("Введите ряд, от 0 до 2");
    int a = int.Parse(Console.ReadLine());
    Console.WriteLine("Введите колонку, от 0 до 2");
    int b = int.Parse(Console.ReadLine());
    game.MyTurn(array,a,b);
    bool win = game.CheckWinner(array);
    if (win == true)
    {
        break;
    }
    bool draw = game.CheckDraw(array);
    if (draw == true)
    {
        break;
    }
    game.Print(array);
    Console.WriteLine();
    Console.WriteLine("Ход компьютера");
    game.CompTurn(array);
    win = game.CheckWinner(array);
    if (win == true)
    {
        break;
    }
    draw = game.CheckDraw(array);
    if (draw == true)
    {
        break;
    }
    game.Print(array);
}

Console.Read();