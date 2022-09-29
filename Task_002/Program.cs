/*
Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
[-4, -8, 8, 2] -> [4, 8, -8, -2] 

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
int[] array = FillArray(4, -10, 10);
Console.WriteLine("[" + String.Join(", ", array) + "]");
int[] ChengeArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            array[i] = -array[i];
        }
        else if (array[i] < 0)
        {
            array[i] = array[i] * (-1);
        }
    }
    return array;
}
int[] change = ChengeArray(array);
Console.WriteLine("[" + string.Join(", ", change) + "]");