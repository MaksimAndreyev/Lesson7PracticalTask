Console.WriteLine("Введите число m:");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число n:");
int n = Convert.ToInt32(Console.ReadLine());
double[,] array = new double[m, n];
for (int i=0; i<m; i++)
{
    for (int j=0; j<n; j++)
    {
        array[i, j] = new Random().NextDouble() + new Random().Next(1,10);
    }
}
for (int i=0; i<m; i++)
{
    for (int j=0; j<n; j++)
    {
        Console.Write(Math.Round(array[i, j], 2)+" ");
    }
    Console.WriteLine();
}