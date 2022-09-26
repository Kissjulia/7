// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 17 -> такого числа в массиве нет

int m = InputFunction("Введите позицию строки: ");
int n = InputFunction("Введите позицию столбца: ");
int[,] num = new int[3, 4];
FillArrayRandom2(num);
OutputArray2(num);

if (m < num.GetLength(0) && n < num.GetLength(1)) Console.WriteLine(num[m, n]);
else Console.WriteLine($"{m}{n} -> такого числа в массиве нет");


// Заполнение массива рандомными числами от 1 до 9
void FillArrayRandom2(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(1, 10);
        }
    }
}

//  Функция вывода массива 
void OutputArray2(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(arr[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

// Функция ввода 
int InputFunction(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

