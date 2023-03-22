namespace TicTacToe.Classes;

public class Game
{
    public string[,] ArrayFill()
    {
        string[,] array = new string[3, 3];
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                array[i, j] = "5";
            }
        }

        return array;
    }

    public void Print(string[,] array)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                string tmp = array[i, j];
                Console.Write($"{tmp} ");
            }

            Console.WriteLine();
        }
    }

    public string[,] FillX(string[,] array, int a, int b)
    {
        array[a, b] = "X";
        return array;
    }

    public string[,] FillZero(string[,] array)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                if (array[i, j] == "5")
                {
                    Random rnd = new Random();
                    int firstValueOfArray = rnd.Next(array.GetLength(0));
                    int secondValueOfArray = rnd.Next(array.GetLength(1));
                    if ((i == 0 || array[i, j] == array[i - 1, j])
                        && (i == array.GetLength(0) - 1 || array[i, j] == array[i + 1, j])
                        && (j == 0 || array[i, j] == array[i, j - 1])
                        && (j >= array.GetLength(1) - 1 || array[i, j] == array[i, j + 1]))
                    {
                        if (array[i, j] != "X")
                        {
                            array[i, j] = "0";
                        }
                    }
                    if(array[i,j] == "5")
                    {
                        array[firstValueOfArray, secondValueOfArray] = "0";
                    }
                    return array;
                }
            }
        }

        return array;
    }

    public string[,] MyTurn(string[,] array, int a, int b)
    {
        if (array[a, b] == "5")
        {
            FillX(array, a, b);
        }
        else
        {
            Console.WriteLine("Попробуйте другую комбинацию");
        }

        return array;
    }

    public string[,] CompTurn(string[,] array)
    {
        FillZero(array);
        return array;
    }
    public bool CheckDraw(string[,] array){
        int checkFive = -1;
        bool draw = false;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                if (array[i, j] == "5")
                {
                    checkFive += 5;
                }
            }
        }
        if (checkFive == -1)
        {
            Console.WriteLine("Ничья");
            draw = true;
            
            return draw;
        }
        
        return draw;
    }
    public bool CheckWinner(string[,] array)
    {
        bool win = false;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                if(array[0,0] == "X" && array[1,0] == "X" && array[2,0] == "X" ||
                   array[0,1] == "X" && array[1,1] == "X" && array[2,1] == "X" ||
                   array[0,2] == "X" && array[1,2] == "X" && array[2,2] == "X" ||
                   array[0,0] == "X" && array[1,1] == "X" && array[2,2] == "X" ||
                   array[0,2] == "X" && array[1,1] == "X" && array[2,0] == "X"
                  )
                {
                    Console.WriteLine("Вы победили");
                    win = true;
                    
                    return win;
                } else if (array[0,0] == "0" && array[1,0] == "0" && array[2,0] == "0" ||
                           array[0,1] == "0" && array[1,1] == "0" && array[2,1] == "0" ||
                           array[0,2] == "0" && array[1,2] == "0" && array[2,2] == "0" ||
                           array[0,0] == "0" && array[1,1] == "0" && array[2,2] == "0" ||
                           array[0,2] == "0" && array[1,1] == "0" && array[2,0] == "0"
                          )
                { 
                    Console.WriteLine("Комп победил");
                    win = true;
                    return win;
                }
            }
        }

        return win;
    }
}