namespace TicTacToe.Classes;

public class Game
{
    public string[,] ArrayFill()
    {
        string[,] array = new string[3,3];
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                array[i,j] = "5";
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
        
        for(int i = 0; i < array.GetLength(0);i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                if (array[i, j] == "5")
                {
                    // if (array[i, j] == "0" && array[i + 1, j] == "0")
                    // {
                    //     
                    // }
                    array[i, j] = "0";
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
}