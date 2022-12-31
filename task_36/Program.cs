//  Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int [] GetArray(int size, int leftRange, int rightRange)
{
    int [] array = new int [size];
    for (int i = 0; i < size; i++)
    {
        array [i] = new Random().Next (leftRange,rightRange);
    }
    return array;
} 
int SumEven(int[]array)
{
    int size= array.Length;
    int sum=0;
    for (int i = 0; i < size; i+=2)
    {
        sum += array[i];
    }
    return sum;
}
int [] resultArray = GetArray(5,1,10);
Console.WriteLine($"[{String.Join(";",resultArray)}]");
int sum = SumEven(resultArray);
Console.WriteLine($"Сумма чисел четных позиций: {sum}");