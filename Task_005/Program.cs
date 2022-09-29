/*
Задача 37: Найдите произведение пар чисел в одномерном массиве. 
Парой считаем первый и последний элемент, второй и предпоследний и т.д. 
Результат запишите в новом массиве.
[1 2 3 4 5] -> 5 8 3
[6 7 3 6] -> 36 21
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
Console.Write("Введите размер массива: ");
int size = int.Parse(Console.ReadLine());
int[] array = FillArray(size, 1, 10);
Console.WriteLine("[" + String.Join(", ", array) + "]");
int[] GetMultiplication(int[] array) {
    int[] newArray = new int[((array.Length + 1) / 2)];
    if (array.Length % 2 > 0) newArray[array.Length / 2] = array[(array.Length / 2)];
    for (int i = 0; i < array.Length / 2; i++){
        newArray[i] = array[i] * array[(array.Length -1) - i];
    }

    return newArray;
}
Console.WriteLine("[" + String.Join(", ", GetMultiplication(array)) + "]");