using TicTacToe.Classes;

//int[,] gameSpace = new int[3,3];
//Console.WriteLine("введите число");

Game game = new Game();
string[,] array = game.ArrayFill();
while (true)
{
    Console.WriteLine("Введите ряд, от 0 до 2");
    int a = int.Parse(Console.ReadLine());
    Console.WriteLine("Введите колонку, от 0 до 2");
    int b = int.Parse(Console.ReadLine());
    game.MyTurn(array,a,b);
    game.Print(array);
    Console.WriteLine();
    Console.WriteLine("Ход компьютера");
    game.CompTurn(array);
    game.Print(array);

    int counterOfFive = -1;
    for (int i = 0; i < array.GetLength(0);i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] == "5")
            {
                counterOfFive += 5;
            }
        }
    }

    if (counterOfFive == -1)
    {
        Console.ReadLine();
        return;
    }
}

Console.Read();