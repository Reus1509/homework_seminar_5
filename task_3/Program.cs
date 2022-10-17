// Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76
void Main(){
    Console.Clear();
    double[] array = new double[10];
    FillArray(array);
    WriteArray(array);
    double result = FindMax(array) - FindMin(array);
    Console.WriteLine($"максисмальное: {FindMax(array)}");
    Console.WriteLine($"минимальное: {FindMin(array)}");
    Console.Write($"Разница большего элемента и меньшего равна: {result}.");
}

void FillArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0,100);
    }
}

void WriteArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

double FindMin(double[] array)
{   
    double min = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < min)
    {
        min = array[i];
    }
    }
    return min;
}

double FindMax(double[] array)
{   
    double max = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max)
    {
        max = array[i];
    }
    }
    return max;
}

Main();