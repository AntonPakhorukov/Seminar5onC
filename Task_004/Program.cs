/*
Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10,99]. 
Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
[5, 18, 123, 6, 2] -> 1
[1, 2, 3, 6, 2] -> 0
[10, 11, 12, 13, 14] -> 5

*/

Console.Clear();

int[] FillArray(int size, int min, int max)
{
    int[] filledArray = new int[size];
    for (int i = 0; i < filledArray.Length; i++)
    {
        filledArray[i] = new Random().Next(min, max + 1);
    }
    return filledArray;
}
int[] array = FillArray(123, 1, 125);
Console.WriteLine(String.Join(" ", array));
int digital = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i] > 10 && array[i] < 99) digital++;
}
int[] newArray = new int[digital];
String str = String.Join("", newArray);
int FindChar(String str)
{
    int count = 0;
    for (int i = 0; i < str.Length; i++)
    {
        count++;
    }
    return count;
}
Console.WriteLine(FindChar(str));

