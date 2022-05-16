class Program
{
    static void print2DimArr(int[,] arr)
    {
        string str = "";
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            for(int j = 0; j < arr.GetLength(1); j++)
            {
                str += arr[i,j].ToString() + " ";
            }
            str+="\n";
        }
        Console.WriteLine(str);
    }
    static void Main(string[] args)
    {
        int size = 10;
        int[,] matr = new int[size, size];
        for (int k = 0; k < size; k++)
        {
            for (int l = 0; l < size; l++)
            {
                matr[k, l] = 0;
            }
        }

        int x = 0, y = 0;
        bool positiveDirection = false;
        bool down = false;
        int n = 1;
        for (; n < size * size+1;)
        {
            if (down) { break; }
            if (positiveDirection)
            {
                while ((x != size)&& (y != -1)){
                    matr[y, x] = n;
                    n++;
                    x++;
                    y--;
                }
                
                positiveDirection = false;

                if (x == size) { 
                    x--;
                    down = true;
                }
                if (y == -1) { y++; }

            } else
            {
                while ((x != -1)&& (y != size))
                {
                    matr[y, x] = n;
                    n++;
                    x--;
                    y++;
                }
                positiveDirection= true;
                if (x == -1) { x++; }
                if (y == size) { 
                    y--;
                    down= true;
                }
                
            }
        }

        if (x == 0)
        {
            x++;
            positiveDirection = true;
        }
        else
        {
            positiveDirection = false;
            y++;
        }
        while (n < size * size+1)
        {
            if (positiveDirection)
            {
                while ((x != size) && (y != -1))
                {
                    matr[y, x] = n;
                    n++;
                    x++;
                    y--;
                }
                positiveDirection = false;
                if (x == size)
                {
                    x--;
                    y += 2;
                    //down = true;
                }
                if (y == -1) { y++; }
            } else
            {
                while ((x != -1) && (y != size))
                {
                    matr[y, x] = n;
                    n++;
                    x--;
                    y++;
                }
                positiveDirection = true;
                if (x == -1) { x++; }
                if (y == size)
                {
                    y--;
                    x += 2;
                    //down = true;
                }
            }
        }




        print2DimArr(matr);


    }
}
