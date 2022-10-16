// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2
void Main(){
    Console.Clear();
    int[] array = new int[4];
    FillArray(array);
    WriteArray(array);
    int evenCount = EvenNumbers(array);
    Console.WriteLine($"Количество четных числе в массиве равно: {evenCount}.");
}

void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(100,1000);
    }
}

void WriteArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}

int EvenNumbers(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] % 2 == 0){
            count += 1;
        }
    }
    return count;
}

Main();


