//Найти количество элементов массива, значения которых лежат в отрезке [20,90]

// int [] array = new int[10];
// int count = 0;

// for( int i=0; i<array.Length; i++)
// {
//     array[i] = new Random().Next(1,101);
//     Console.Write(array[i]+" ");

//     if(array[i]>19 && array[i]<91)
//     {
//         count++;
//     }
// }
// Console.WriteLine();
// Console.Write(count);

// Напишите программу, которая определяет количество четных чисел в массиве
// int[] array = new int[10];
// int count = 0;
// bool isFind = false;
// for(int i=0; i<array.Length; i++)
// {
//     array[i] = new Random().Next(1,20);
//     Console.Write(array[i]+" ");

//         if (array[i]%2 == 0)
//     {
//         count++;
//         isFind = true;
//     }
// }
// if(isFind == true)
// {
//     Console.WriteLine();
//     Console.Write(count);
// }
// else
// {
//     Console.WriteLine();
//     Console.Write("Четных чисел нет");
// }
// Задайте массив из вещественных чисел с ненулевой
// дробной частью. Найдите разницу между максимальным и минимальным элементов массива.
double[] array = new double [5];
for(int i=0; i<array.Length; i++ )
{
    array[i] = new Random().NextDouble();
    Console.Write(array[i].ToString("F2")+" ");

}
double min = array[0];
double max = array[0];
for(int i=0; i<array.Length; i++ )
{
    if (array[i] < min)
    {
        min = array[i];
    }
    if(array[i]>max)
    {
        max = array[i];
    }
}
Console.WriteLine();
Console.Write((max-min).ToString("F2"));






