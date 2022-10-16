// Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0
void Main()
{
    Console.Clear();
    int[] array = new int[4];
    FillArray(array);
    WriteArray(array);
    int result = OddSum(array);
    Console.WriteLine($"Сумма нечетных чисел массива равна: {result}.");
}

void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-100,100);
    }
}

void WriteArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

int OddSum(int[] array)
{
    int result = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] % 2 != 0){
            result += array[i];
        }
    }
    return result;
}

Main();