int[,] array = { {3,7,-3,6 }, {10 ,1,2,55}, {100,4,99,8 } };

int max = array[0,0], min = array[0,0];
double d = 0;
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        if (max < array[i, j])
        {
            max = array[i, j];
        }
        if (min > array[i, j])
        {
            min = array[i, j];
        }
        d += array[i, j];
        Console.Write($"\t{array[i,j]}");
    }
    Console.WriteLine();
    
}
int k = 1;
foreach(var i in array)
{
    Console.Write($"\t{i}");
    if (k % 4 == 0)
    {
        Console.WriteLine();
        k= 0;
    }
    k++;
}
Console.WriteLine($"\n Max = {max} , Min = {min} , Durchschnitt {d/(array.GetLength(0)*array.GetLength(1))}");
Console.ReadKey();
