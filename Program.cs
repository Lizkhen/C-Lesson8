/*Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой 
строки двумерного массива. (можно использовать готовую функцию)

Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с 
наименьшей суммой элементов. (можно использовать готовую функцию)

Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц. 

Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, 
которая будет построчно выводить массив, добавляя индексы каждого элемента. 
Массив размером 2 x 2 x 2 

Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.*/

Console.WriteLine ("Выберите номер задачи");
Console.WriteLine ("Задача 54. Упорядочим по убыванию элементы каждой строки 2d массива");
Console.WriteLine ("Задача 56. Найдём строку с наименьшей суммой элементов в 2d массиве");
Console.WriteLine ("Задача 58. Найдём произведение 2х матриц");
Console.WriteLine ("Задача 60. Создадим массив 3d, выведем его построчно, добавляя индексы");
Console.WriteLine ("Задача 62. Заполним спиральный массив 4х4");
int n = Convert.ToInt32(Console.ReadLine ());
switch (n)
{
    case 54:
        Task54();
        break;
    case 56:
        Task56();
        break;
    case 58:
        Task58();
        break;
    case 60:
        Task60();
        break;
    case 62:
        Task62();
        break;
    default:
        break;
}

void Task54()
{
    Console.WriteLine("Введите m и n");
    int m = Convert.ToInt32(Console.ReadLine());
    int n = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine();
    int [,] array2d = new int [m,n];
    int [] array = new int [n];
    Random random = new Random ();
    for (int i = 0; i < m; i++)
    {
        for(int j = 0; j < n; j++)
        {
        array2d [i,j] = random.Next(0,10);
        Console.Write(array2d[i,j] + " ");
        }
        Console.WriteLine(); 
    }
    Console.WriteLine(); 
    for (int i = 0; i < m; i++)
    {
        for(int j = 0; j < n; j++)
        {   
            array[j] = array2d[i,j];
        }
        Array.Sort(array);
        Array.Reverse(array);
        Console.WriteLine(string.Join(' ',array));
    }
    Console.WriteLine(); 
}

void Task56()
{
    Console.WriteLine("Чтобы задать прямоугольный массив, введите m и n, где m и n отличаются");
    int m = Convert.ToInt32(Console.ReadLine());
    int n = Convert.ToInt32(Console.ReadLine());
    if (n==m)
    {
        Console.WriteLine("Это квадратный массив, а в условии ПРЯМОУГОЛЬНЫЙ!!!");
        Console.WriteLine("Но всё же, решим задачу с квадратным массивом");
        Console.WriteLine();
    }
    int [,] array2d = new int [m,n];
    int [] array = new int [n];
    Random random = new Random ();
    for (int i = 0; i < m; i++)
    {
        for(int j = 0; j < n; j++)
        {
            array2d [i,j] = random.Next(-10,10);
            Console.Write(array2d[i,j] + " ");
        }
        Console.WriteLine(); 
    }
    Console.WriteLine();
    int index = 0;
    int minSum = 0;
    for (int i = 0; i < m; i++)
    {
        int sum = 0;
        for (int j = 0; j < n; j++)
        {
            array[j] = array2d [i,j];
            sum = array.Sum(); 
        }
        Console.WriteLine($"Сумма {i + 1} строки = {sum}");
        if (i == 0)
        {
            minSum = sum;
        }
        if (sum < minSum)
        {
            minSum = sum;
            index = i;
        }
    }
    Console.WriteLine($"Строка с минимальной суммой элементов № {index+1}. ");
}   

void Task58()
{
    Console.WriteLine("Введите число строк и столбцов для 1й матрицы");
    int m1 = Convert.ToInt32(Console.ReadLine());
    int n1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine();
    int [,]matrix1 = new int [m1,n1];
    Console.WriteLine("Введите число строк и столбцов для 2й матрицы");
    int m2 = Convert.ToInt32(Console.ReadLine());
    int n2 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine(); 
    int [,]matrix2 = new int [m2,n2];
    Random random = new Random ();
    for (int i = 0; i < m1; i++)
    {
        for(int j = 0; j < n1; j++)
        {
            matrix1 [i,j] = random.Next(-10,10);
            Console.Write(matrix1[i,j] + " ");
        }
        Console.WriteLine(); 
    }
    Console.WriteLine();
    for (int i = 0; i < m2; i++)
    {
        for(int j = 0; j < n2; j++)
        {
            matrix2 [i,j] = random.Next(-10,10);
            Console.Write(matrix2[i,j] + " ");
        }
        Console.WriteLine(); 
    }
    Console.WriteLine(); 
    if (n1==m2)
    {   
        Console.WriteLine ("Произведение двух матриц:");
        int [,] matrix3 = new int [m1,n2];
        for (int i = 0; i < m1; i++)
        {
            for (int j = 0; j < n2; j++)
            {
                for (int k = 0; k < m2; k++)
                {
                    matrix3[i,j] += matrix1[i,k] * matrix2[k,j];
                } Console.Write(matrix3[i,j] + " ");
            }Console.WriteLine();
        }Console.WriteLine();
    }
    else
    {
        Console.WriteLine("Эти матрицы невозможно умножить!");
    }
}
void Task60()
{
    Console.WriteLine("Трёхмерный массив размером 2х2х2");
    Random random = new Random();
    int min = 10;
    int[] array = new int[90];
    for(int i = 0; i < 90; i++)
    {
        array[i] = min;
        min++;
    }
    int [,,]array3d = new int [2,2,2];
    for (int x=0; x<2; x++)
    {
        for (int y=0; y<2; y++)
        {
            for (int z=0; z<2; z++)
            { 
                int n = random.Next(0,array.Length);
                array3d[x,y,z]= array[n];
                List<int> temp = array.ToList();// удаляю отработанный элемент из массива
                temp.RemoveAt(n);
                array = temp.ToArray();  
                Console.Write(array3d[x,y,z] + $" ({x},{y},{z})  " );
            }
            Console.WriteLine();
        }
    }
}
void Task62()
{
    int n = 4;
    int[,] array2d = new int[n, n];
    int number = 1;
    int i = 0;
    int j = 0;
    while (number <= array2d.GetLength(0) * array2d.GetLength(1))
    {
        array2d[i, j] = number;
        number++;
        if (i <= j + 1 && i + j < array2d.GetLength(1) - 1)
            j++;
        else 
            if (i < j && i + j >= array2d.GetLength(0) - 1)
                i++;
        else 
            if (i >= j && i + j > array2d.GetLength(1) - 1)
                j--;
        else
            i--;   
    }
    for (int x = 0; x < array2d.GetLength(0); x++)
    {
        for (int y = 0; y < array2d.GetLength(1); y++)
        {
            int v = array2d[x,y];
            Console.Write($"{v:D2}" + " ");// добавила 0 к однозначным числам
        }
        Console.WriteLine();
    }
}