// Задайте массив заполненный случайными положительными трехзначными
// числами. Напишите программу, которая покажет количество четных чисел в массиве.

Console.Clear();

int numberSchet = new Random().Next(5, 16);

int[] ArrayData(int number)
{
   int[] array = new int[number];
   int i = 0;
  for(i = 0; i < array.Length; i++)
  {
    array[i] = new Random().Next(100, 1000);
  } 
  return array;
}

void ArrayPozitivNumber(int[] arrayP)
{
    int sumPozitiv = 0;
    for(int i = 0; i < arrayP.Length; i++)
    {
        if(arrayP[i] % 2 == 0)
        {
           sumPozitiv += 1; 
        }
    }
    Console.Write($"{sumPozitiv} ");
}


int[] array = ArrayData(numberSchet);
Console.WriteLine('[' + string.Join(",", array) + ']');
ArrayPozitivNumber(array);