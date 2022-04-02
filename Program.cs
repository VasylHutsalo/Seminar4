
// Домашнее задание №4

// Напишите цикл, который принимает на вход два числа (A и B)
// и возводит число A в натуральную степень B.
/*
int Stepen(int a, int b)
{
    int rez = 1;
    if (b < 0)
    {
        b = Math.Abs(b);
    }
    for (int i = 0; i < b; i++)
    {
        rez = rez * a;
    }
    return rez;
}
Console.Write(" Введите число ");
int volA = Convert.ToInt32(Console.ReadLine());
Console.Write(" Введите число ");
int volB = Convert.ToInt32(Console.ReadLine());
int count = Stepen(volA, volB);
Console.Write(" результат А в степени В  " + count);
*/

//Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
/*
int Sum(int n)
{
    int summa = 0;

    while (n > 0)
    {
        summa = summa + n % 10;
        n = n / 10;
    }
    return summa;
}
Console.Write(" Введите число  ");
int volN = Convert.ToInt32(Console.ReadLine());
int S = Sum(volN);
Console.WriteLine(" Сумма цифр числа  " + volN + " равна " + S);
*/

//Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
/*
void Newarray(int[] mass)
{
    int length = mass.Length;
    int index = 0;
    while (index < length)
    {
        mass[index] = new Random().Next(1, 40);
        index++;
    }
}

void PrintArray(int[] massiv)
{
    int size = massiv.Length;
    int pos = 0;
    while (pos < size)
    {

        Console.Write(massiv[pos] + ", ");
        pos++;
    }
}
int[] array = new int[8];
Newarray(array);
PrintArray(array);
*/

// Домашнее задание № 5


//Задать массив заполненный положительными 3х значными числами.написать программу 
//показывающую кол-во положительных чиселю/

 void Newarray(int[] mass)
{
for(int i = 0; i < mass.Length; i++ )
{
mass[i] = new Random().Next(100, 1000);
Console.WriteLine(mass[i]);
}
}

 void CountPol(int[] mass)
{
  int count = 0;
  for(int i = 0; i < mass.Length; i++)
  {
    if( mass[i] % 2 == 0)
    {
      count++;
    }
  }
  Console.WriteLine(" Количество четных чисел " + count);
}
int[] array = new int [8];// Код задания одномерного массива
Newarray(array);
CountPol(array);


    

//Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.
/*
void Newarray(int[] mass)
{
    for (int i = 0; i < mass.Length; i++)
    {
        mass[i] = new Random().Next(1, 9);
        Console.WriteLine(mass[i]);
    }
}

void SumNechet(int[] mass)
{
    int summa = 0;
    for (int i = 1; i < mass.Length; i = i + 2)
    {
        summa = summa + mass[i];
    }
    Console.WriteLine(" Сумма чисел стоящих на нечетных позициях " + summa);
}

int[] array = new int[7];
Console.WriteLine();
Newarray(array);
SumNechet(array);
*/

//  Задайте массив вещественных чисел.
//Найдите разницу между максимальным и минимальным элементов массива.
/*

void Filarray(double[] massiv)
{
    for (int i = 0; i < massiv.Length; i++)
    {
        massiv[i] = new Random().Next(0, 10);
        Console.Write(massiv[i] + " ");
    }
}

void RezMaxMin(double[] massiv)
{
    double min = massiv[0];
    double max = massiv[0];

    for (int i = 1; i < (massiv.Length); i++)
    {
        if (massiv[i] < min)
        {
            min = massiv[i];
        }
    }
    for (int j = 1; j < massiv.Length; j++)
    {
        if (massiv[j] > max)
        {
            max = massiv[j];
        }
    }
    double rezalt = max - min;

    Console.WriteLine($"Разность { rezalt} = {max} - {min}");
}

double[] Mass = new double[5];
Console.WriteLine();

Filarray(Mass);
RezMaxMin(Mass);
*/

//Домашнее задание №6

// Задача № 1.Пользователь вводит с клавиатуры M чисел.
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
/*
Console.Write(" Задайте колличество элементов М =  ");
int m = Convert.ToInt32(Console.ReadLine());
int[] array = new int[m];
for (int i = 0; i < m; i++)
{
    array[i] = new Random().Next(-10, 10);
    Console.Write(array[i] + " ");
}
void Positiv(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            count++;
        }
    }
    Console.Write(" Колличество положительных элементов = " + count);
}
Positiv(array);
*/

// Задача № 2.  Пользователь вводит с клавиатуры кол-во строк и столбцов для массива. 
//Вывести массив в виде матрицы, создав "рамку" 
//из единиц, а внутреннюю зону матрицы заполнить нулями.
/*
void Filarray(int[,] matr)
{
    int lengthI = matr.GetLength(0);
    int lengthJ = matr.GetLength(1);
    for (int i = 0; i < lengthI; i++)
    {
        matr[i, 0] = 1;
        matr[i, lengthJ - 1] = 1;

        for (int j = 0; j < lengthJ; j++)
        {
            matr[0, j] = 1;
            matr[lengthI - 1, j] = 1;

            Console.Write(matr[i, j] + " ");
        }
        Console.WriteLine();
    }
}
Console.Write(" Введите число строк n =  ");
int n =Convert.ToInt32(Console.ReadLine());
Console.Write(" Введите число столбцов m =  ");
int m =Convert.ToInt32(Console.ReadLine());

int[,] matrix = new int[n, m];
Filarray(matrix);
*/









