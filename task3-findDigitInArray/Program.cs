// Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, 3] -> да


void NewArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(-10, 11);
}


string SearchNumberInArray(int[] array, int number)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == number)
            return ("Число " + number + " есть в массиве");
    }
    return ("Числа " + number + " нет в массиве");
}

Console.Write("Укажите кол-во элементов в массиве: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
NewArray(array);
Console.WriteLine("Начальный массив: [" + string.Join(", ", array) + "]");
Console.Write("Укажите число, которое Вы хотите найти в массиве: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(SearchNumberInArray(array, number));



/* Вариант с foreach

void NewArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(-10, 11);
}


string SearchNumberInArray(int[] array, int number)
{
    foreach (int i in array)
    {
        if (i == number)
            return ("Число " + number + " есть в массиве");
    }
    return ("Числа " + number + " нет в массиве");
}

Console.Write("Укажите кол-во элементов в массиве: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
NewArray(array);
Console.WriteLine("Начальный массив: [" + string.Join(", ", array) + "]");
Console.Write("Укажите число, которое Вы хотите найти в массиве: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(SearchNumberInArray(array, number));

 */
