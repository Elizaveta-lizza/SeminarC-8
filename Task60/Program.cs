int[,,] Create3DArray(int x, int y, int z)
{
    return new int[x, y, z];
}

void Fill3DArray(int[,,] array3D)
{
    int Iter = 10;
    for (int x = 0; x < array3D.GetLength(0); x++)
    {
        for (int y = 0; y < array3D.GetLength(1); y++)
        {
            for (int z = 0; z < array3D.GetLength(2); z++)
            {
                Iter++;
                array3D[x, y, z] = Iter;
            }
        }
    }
}

void Print3DArray(int[,,] array3D)
{
    for (int x = 0; x < array3D.GetLength(0); x++)
    {
        for (int y = 0; y < array3D.GetLength(1); y++)
        {
            for (int z = 0; z < array3D.GetLength(2); z++)
            {
                Console.Write($"{array3D[x, y, z]}({x},{y},{z})");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}

int[,,] arr3D = Create3DArray(2, 2, 2);
Fill3DArray(arr3D);
Print3DArray(arr3D);