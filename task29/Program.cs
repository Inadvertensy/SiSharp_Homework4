// Задача 29: Напишите программу, которая задаёт массив 
// из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19] 
// 6, 1, 33 -> [6, 1, 33]
Console.WriteLine("Please enter array size");
int A = int.Parse(Console.ReadLine());
int [] array=new int[8]; 


for (int i=0;i<A;i++)
{
    array[i]=new Random().Next(0,100);
    Console.Write($"{array[i]} ");
}