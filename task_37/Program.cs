// int resultPositive=0;
// int resultNegative=0;

// for (int i = 0; i < resultArray.Length; i++)
// {
// resultPositive+=resultArray[i]>0?resultArray[i]:0;
// resultNegative+=resultArray[i]<0?resultArray[i]:0;
// }

// // for (int i = 0; i < resultArray.Length; i++)
// // {
// //  if (resultArray[i]>0)
// //  {
// //     resultPositive+=resultArray[i] ;
// //     }
// //     else  resultNegative+=resultArray[i];
// // }
// Console.WriteLine($"Сумма отр. чисел: {resultNegative}, Сумма полож.чисел: {resultPositive}");

//Задача 32: Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2]
//
// int[] TurnArray(int[]array){
//    int size=array.Length;
//     for (int i = 0; i < size; i++)
//     {
//         array[i]*=(-1);
//     }
//     return array ;
// }
//     Console.WriteLine($"Reverse array[{String.Join(";",TurnArray(resultArray))}]");

//Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, 3] -> да
// int number = new Random().Next(0,5);
// void SearchNumber(int [] array,int numb)
// {
//    int size=array.Length;
//    String result="нет";
//     for (int i = 0; i < size; i++)
//     {
//         if (array[i]==numb)
//         {
//            result="да";
//         break;
//         }
//     }
//     Console.WriteLine(result);
// }
// Console.WriteLine($"Число: {number}");
// SearchNumber(resultArray,number);
// Задача 35: Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10,99].
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5

// int FindCollection(int[] array, int minNumber, int maxNumber)
// {
//     int size=array.Length;
//     int findNumber=0;
//     for (int i = 0; i < size; i++)
//     {
//         findNumber+= array[i]>=minNumber && array[i]<= maxNumber?1:0;

//     }
//   return findNumber;
// }

// int result= FindCollection(resultArray,10,100);
// Console.WriteLine(result);



// Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(minValue, maxValue + 1);
    }
    return array;
}

int[] GetMultArray(int[] array)
{
    int size = array.Length;
    int sizeNew = size % 2 == 0 ? size / 2 : size / 2 + 1;
    int[] resultArray = new int[sizeNew];
    for (int i = 0; i < sizeNew; i++)
    {
        if (i == (size - i - 1))
        {
            resultArray[i] = array[i];
        }
        else
            resultArray[i] = array[i] * array[Convert.ToInt32(size) - 1 - i];
    }
    return resultArray;
}

int[] resultArray = GetArray(7, 0, 5);
Console.WriteLine($"[{String.Join("; ", resultArray)}]");
int[] newResultArray = GetMultArray(resultArray);
Console.WriteLine($"[{String.Join(";" , newResultArray)}]");
