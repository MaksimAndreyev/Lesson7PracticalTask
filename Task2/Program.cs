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
Console.WriteLine("Введите номер позиции:");
int position = Convert.ToInt32(Console.ReadLine());
int row = position / 10;
int column = position % 10;
if (row > rows-1 || column > columns-1) Console.WriteLine("Числа с такой позицией в массиве нет.");
else Console.WriteLine(array[row, column]);