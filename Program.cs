// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
Console.WriteLine("Введите количество строк: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов: ");
int m = Convert.ToInt32(Console.ReadLine());
int[,] num = new int[n, m];
FillArrayRandom2(num);
OutputArray2(num);
int [] sum  = new int [m];
float average = 0;

// Заполнение массива рандомными числами от 1 до 9
void FillArrayRandom2(int[,] num)
{
    for (int i = 0; i < num.GetLength(0); i++)
    {
        for (int j = 0; j < num.GetLength(1); j++)
        {
            num[i, j] = new Random().Next(1, 10);
        }
    }
}
//  Функция вывода массива 
void OutputArray2(int[,] num)
{
    for (int i = 0; i < num.GetLength(0); i++)
    {
        for (int j = 0; j < num.GetLength(1); j++)
        {
            Console.Write(num[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

for (int i=0; i<m; i++)
{
    for(int j=0; j<n; j++)
    {
       sum [i] = sum [i] + num[j, i];
    }
}
for (int i=0; i<m; i++)
{
    average = sum [i] / n;
    Console.Write($"{average} ");
}
      
 Console.ReadLine();
