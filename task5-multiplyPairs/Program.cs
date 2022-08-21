// Задача 37: Найдите произведение пар чисел в одномерном массиве. 
//Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

/* void NewArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(10);
}

int Multiply (int[] array, int result)
{
    count = 0;
    while (array[i] < array.Length + 1)
    {
        result = array[0] * array.Length - 
    }
}

Console.WriteLine("Введите длину массива");
int limit = int.Parse(Console.ReadLine()!);

int[] array = new int[limit];
NewArray(array);
Console.WriteLine("Начальный массив: [" + string.Join(", ", array) + "]");

 */

// верное решение с семинара: 

void NewArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(-10, 10);
}

int[] PairsMultuplicationInArray(int[] array)
{
    int newlen;
    if (array.Length % 2 == 0)
        newlen = array.Length / 2;
    else
        newlen = array.Length / 2 + 1;

    int[] arr2 = new int[newlen];
    for (int i = 0; i < newlen; i++)
    {
        arr2[i] = array[i] * array[array.Length - i - 1];
    }
    return arr2;
}


Console.Write("Количесто элементов в массиве: ");
int n = Convert.ToInt32(Console.ReadLine()!);
int[] array = new int[n];
NewArray(array);
Console.WriteLine("Исходный массив: [" + string.Join(", ", array) + "]");
Console.WriteLine("Результат: " + string.Join(" ", PairsMultuplicationInArray(array)));
