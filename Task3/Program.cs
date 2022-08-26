Console.WriteLine("Введите число строк:");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число столбцов:");
int columns = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[rows, columns];
for (int i=0; i<rows; i++)
{
    for (int j=0; j<columns; j++)
    {
        array[i, j] = new Random().Next(1,10);
        Console.Write(array[i, j]+" ");
    }
    Console.WriteLine();
}
Console.Write("Среднее арифметическое каждого столбца: ");
double sum = 0;
double average;
for (int i=0; i<columns; i++)
{
    for (int j=0; j<rows; j++)
    {
        sum += array[j, i];
    }
    average = sum / rows;
    Console.Write(Math.Round(average, 2) + "  ");
    sum = 0;
}