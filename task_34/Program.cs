//  Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2
int [] GetArray(int size, int leftRange, int rightRange)
{
    int [] array = new int [size];
    for (int i = 0; i < size; i++)
    {
        array [i] = new Random().Next (leftRange,rightRange);
    }
    return array;
} 
int FindChet(int[]array)
{
    int size= array.Length;
    int count=0;
    for (int i = 0; i < size; i++)
    {
        count += array[i]%2==0?1:0;
    }
    return count;
}

int [] resultArray = GetArray(5,100,1000);
Console.WriteLine($"[{String.Join(";",resultArray)}]");
int amount = FindChet(resultArray);
Console.WriteLine($"Количество четных чисел в массиве: {amount}");