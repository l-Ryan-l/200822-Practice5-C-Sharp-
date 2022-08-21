// Задача 32: Напишите программу замена элементов массива: положительные элементы 
// замените на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2] 


void NewArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(-10, 11);
}


void znak(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] *= (-1);
}


int[] array = new int[10];
NewArray(array);
Console.WriteLine("Начальный массив: [" + string.Join(", ", array) + "]");
znak(array);
Console.WriteLine("Конечный массив: [" + string.Join(", ", array) + "]");



/* 2. Вариант с вводом каждого эл-та:

 void NewArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write("Введите значение элемента массива: ");
        int x = Convert.ToInt32(Console.ReadLine());
        array[i] = x;
    }
}


void znak(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] *= (-1);
}

Console.Write("Укажите кол-во элементов в массиве: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
NewArray(array);
Console.WriteLine("Начальный массив: [" + string.Join(", ", array) + "]");
znak(array);
Console.WriteLine("Конечный массив: [" + string.Join(", ", array) + "]");


// 3. Вариант с вводом диапазона:

void NewArray(int[] array)
{
    Console.Write("Введите начальное значение диапазона: ");
    int begin = Convert.ToInt32(Console.ReadLine());;
    Console.Write("Введите начальное значение диапазона: ");
    int end = Convert.ToInt32(Console.ReadLine());;
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(begin, end + 1);
}


void znak(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] *= (-1);
}

Console.Write("Укажите кол-во элементов в массиве: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
NewArray(array);
Console.WriteLine("Начальный массив: [" + string.Join(", ", array) + "]");
znak(array);
Console.WriteLine("Конечный массив: [" + string.Join(", ", array) + "]");
 */