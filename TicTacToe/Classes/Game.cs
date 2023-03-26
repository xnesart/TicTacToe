
namespace TicTacToe.Classes;

public class Game
{
    private string[,] _array;

    public Game()
    {
        _array = ArrayFill();
    }

private string[,] ArrayFill()
    {
         _array = new string[3, 3];
        for (int i = 0; i < _array.GetLength(0); i++)
        {
            for (int j = 0; j < _array.GetLength(1); j++)
            {
                _array[i, j] = "5";
            }
        }

        return _array;
    }

    public void Print()
    {
        for (int i = 0; i < _array.GetLength(0); i++)
        {
            for (int j = 0; j < _array.GetLength(1); j++)
            {
                string tmp = _array[i, j];
                Console.Write($"{tmp} ");
            }

            Console.WriteLine();
        }
    }

    public string[,] FillX( int a, int b)
    {
        _array[a, b] = "X";
        
        return _array;
    }
    
    public string[,] FillZero()
    {
        while (true)
        {
            int x, y;
            Random rnd = new Random();
            x = rnd.Next(0, 3);
            y = rnd.Next(0, 3);
            if (_array[x, y] == "5")
            {
                _array[x, y] = "0";
                
                return _array;
            }
        }
    }

    public void MyTurn(int a, int b)
    {
        if (_array[a, b] == "5")
        {
            FillX( a, b);
        }
        else
        {
            Console.WriteLine("Попробуйте другую комбинацию");
        }
    }

    public void CompTurn()
    {
         FillZero();
    }
    public bool CheckDraw(){
        int checkFive = -1;
        bool draw = false;
        for (int i = 0; i < _array.GetLength(0); i++)
        {
            for (int j = 0; j < _array.GetLength(1); j++)
            {
                if (_array[i, j] == "5")
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
    public bool CheckWinner()
    {
        bool win = false;
        for (int i = 0; i < _array.GetLength(0); i++)
        {
            for (int j = 0; j < _array.GetLength(1); j++)
            {
                if(_array[0,0] == "X" && _array[1,0] == "X" && _array[2,0] == "X" ||
                   _array[0,0] == "X" && _array[0,1] == "X" && _array[0,2] == "X" ||
                   _array[1,0] == "X" && _array[1,1] == "X" && _array[1,2] == "X" ||
                   _array[2,0] == "X" && _array[2,1] == "X" && _array[2,2] == "X" ||
                   _array[0,1] == "X" && _array[1,1] == "X" && _array[2,1] == "X" ||
                   _array[0,2] == "X" && _array[1,2] == "X" && _array[2,2] == "X" ||
                   _array[0,0] == "X" && _array[1,1] == "X" && _array[2,2] == "X" ||
                   _array[0,2] == "X" && _array[1,1] == "X" && _array[2,0] == "X"
                  )
                {
                    Console.WriteLine("Вы победили");
                    win = true;
                    
                    return win;
                } else if (_array[0,0] == "0" && _array[1,0] == "0" && _array[2,0] == "0" ||
                           _array[0,0] == "0" && _array[0,1] == "0" && _array[0,2] == "0" ||
                           _array[1,0] == "0" && _array[1,1] == "0" && _array[1,2] == "0" ||
                           _array[2,0] == "0" && _array[2,1] == "0" && _array[2,2] == "0" ||
                           _array[0,1] == "0" && _array[1,1] == "0" && _array[2,1] == "0" ||
                           _array[0,2] == "0" && _array[1,2] == "0" && _array[2,2] == "0" ||
                           _array[0,0] == "0" && _array[1,1] == "0" && _array[2,2] == "0" ||
                           _array[0,2] == "0" && _array[1,1] == "0" && _array[2,0] == "0"
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