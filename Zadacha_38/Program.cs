// Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементом массива.
Console.Clear();

double[] array = {1.2, 5.4, 10.9, 50.4, 108.7};

void DifferenceNumberArray(double[] arrayEN)
{
    double max = arrayEN[0];
    double min = arrayEN[0];
    for(int i = 0; i < arrayEN.Length; i++)
    {
        if(arrayEN[i] > max)  
        {
           max = arrayEN[i]; 
        }

        if(arrayEN[i] < min)  
        {
           min = arrayEN[i]; 
        }
    }
    
    Console.Write($"max -> {max} ");
    Console.WriteLine($"min -> {min} ");
    double difference = max - min;
    Console.Write($"разницу между max и min элементом массива -> {difference} ");
}

Console.WriteLine('[' + string.Join(";", array) + ']');
DifferenceNumberArray(array);