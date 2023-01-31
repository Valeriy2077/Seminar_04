// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

// 6, 1, 33 -> [6, 1, 33]

Random rand = new Random();

int [] numbers = new int[8];
Console.Write("");

int[] array = new int[8];

for (int i = 0; i <= 7; i++)
{
    int num = rand.Next(0,11);
    array[i] = num;
}

foreach( var i in array)
{
    Console.Write(i+ " ");
}
