// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

int[] getNewArray(int lengthArr)
{
    int[] array = new int[8];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next();
    }
    return (array);
}
foreach (int item in getNewArray(8)) Console.Write(item + " ");