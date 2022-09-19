//Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

int[,] FillArray(int m, int n)
{
	int[,] array = new int[m, n];
	for (int i = 0; i < m; i++)
	{
		for (int j = 0; j < n; j++)
		{
			array[i, j] = new Random().Next(0, 10);
		}
	}
	return array;
}

void PrintArray(int[,] array)
{
	for (int i = 0; i < array.GetLength(0); i++)
	{
		for (int j = 0; j < array.GetLength(1); j++)
		{
			Console.Write(array[i, j] + " ");
		}
		Console.WriteLine();
	}
}

int[,] SortArray(int[,] array)
{
    int temp = 0;
    for(int n = 0; n < array.GetLength(1); n++)
    {
	    for (int i = 0; i < array.GetLength(0); i++)
	    {
		    for (int j = 0; j < array.GetLength(1) - 1; j++)
		    {
			    if (array[i, j] < array[i, j + 1])
			    {
				temp = array[i, j];
                array[i, j] = array[i, j + 1];
                array[i, j + 1] = temp;
			    }  
		    }
	    }
    }return array;
}

Console.WriteLine("Введите колличество строк: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите колличество столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] array = FillArray(m, n);
PrintArray(array);
Console.WriteLine();
PrintArray(SortArray(array));
