// Задача 35: Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, 
// значения которых лежат в отрезке [10,99]. 
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5

/* 
void NewArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(200);
}

string SearchNumberInArray(int[] array, int n)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 9 && array[i] < 100)
        return ("Ваше число " + count + " раз встречается в диапазоне 10 - 99");
    }
    return ("Числа " + number + " нет в массиве");
}

Console.Write("Укажите число для поиска в массиве: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[123];
NewArray(array);
Console.WriteLine("Начальный массив: [" + string.Join(", ", array) + "]");

 */

// Правильное решение с семинара: 

void NewArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(-100, 101);
}


int CountNumbers(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] >= 10 && array[i] <= 99)
            count++;
    }
    return count;
}


int[] array = new int[123];
NewArray(array);
Console.WriteLine("Начальный массив: [" + string.Join(", ", array) + "]");
Console.WriteLine("Кол-во чисел, которое лежит в интервале [10; 99]: " + CountNumbers(array));
 