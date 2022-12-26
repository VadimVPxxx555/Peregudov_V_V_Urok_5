// Задайте массив заполненный случайными положительными трехзначными
// числами. Напишите программу, которая покажет количество четных чисел в массиве.

Console.Clear();

Random rand = new Random();

//int numberSchet = rand.Next(5, 16);

int[] ArrayData(int arrNumber, int leftRange, int rightRange)
{
   int[] array = new int[arrNumber];
   int i = 0;
  for(i = 0; i < array.Length; i++)
  {
    array[i] = rand.Next(leftRange, rightRange);
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
    Console.Write($"Четных чисел в массиве -> {sumPozitiv} ");
}

int DataVvod(string str)
{
    Console.Write(str);
    int number = int.Parse(Console.ReadLine());
    return number;
}

int arrNumber = DataVvod("Введите размер массива ");
int leftRange = DataVvod("Введите min диапазон массива ");
int rightRange = DataVvod("Введите max диапазон массива ");
int[] array = ArrayData(arrNumber, leftRange, rightRange);
Console.WriteLine('[' + string.Join(",", array) + ']');
ArrayPozitivNumber(array);