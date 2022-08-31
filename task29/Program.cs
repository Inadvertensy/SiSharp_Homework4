// Напишите программу, которая задаёт массив из 
// введенного числа и выводит их на экран.
// пользователь вводит число элементов в массиве и 
// минимальное, и максимальное значение . надо заполнить 
// массив рандоными данными от минимального до максимального 
// значение .И важное уточнениее , делать все в методе который возвращает массив
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

Console.WriteLine("Please enter array size");
int arraySize = int.Parse(Console.ReadLine());

Console.WriteLine("Please enter minimum value");
int minValue = int.Parse(Console.ReadLine());

Console.WriteLine("Please enter maximum value");
int maxValue = int.Parse(Console.ReadLine());

int[] array = new int[arraySize];

void PrintArray(int[] array)
{
    for (int i = 0; i < arraySize; i++)
    {
        array[i] = new Random().Next(minValue, maxValue);
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

PrintArray(array);