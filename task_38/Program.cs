//  Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

double [] GetArray(int size, double rightRange)
{
    double [] array = new double [size];
    for (int i = 0; i < size; i++)
    {
        array [i] =Math.Round( new Random().NextDouble() * rightRange,2);
    }
    return array;
} 
double FidnMax(double[] array)
{
    double max = array[0];
    int size = array.Length;
    for (int i = 1; i < size; i++)
    {
        max = max<array[i]?array[i]:max;
    }
    return max;
}

double FidnMin(double[] array)
{
    double min = array[0];
    int size = array.Length;
    for (int i = 1; i < size; i++)
    {
        min = min>array[i]?array[i]:min;
    }
    return min;
}

double [] resultArray = GetArray(5,10);
Console.WriteLine($"[{String.Join("; ",resultArray)}]");
double result = Math.Round(FidnMax(resultArray)-FidnMin(resultArray),2);
Console.WriteLine($"Разница между минимумом и максимумом: {result}");