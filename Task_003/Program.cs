/*
Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
4; массив [6, 7, 19, 345, 3] -> нет
3; массив [6, 7, 19, 345, 3] -> да
*/
Console.Clear();
Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int[] FillArray(int size, int min, int max)
{
    int[] filledArray = new int[size];
    for (int i = 0; i < filledArray.Length; i++)
    {
        filledArray[i] = new Random().Next(min, max + 1);
    }
    return filledArray;
}
int[] array = FillArray(10, 1, 10);
Console.WriteLine("[" + String.Join(", ", array) + "]");
bool SearchNum(int number, int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == number)
        {
            return true;
        }

    }
    return false;
}
Console.WriteLine(SearchNum(number, array) ? "\n Да" : "\n Нет");
// int[] FindNumber(int number, int[] array) {
//     for (int i = 0; i < array.Length; i++) {
//         if (array[i] == number) {
//             return Console.WriteLine("да");
//         }
//     }
//     return Console.WriteLine("Нет");
// }
// FindNumber(array);
