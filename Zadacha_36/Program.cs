// Задайте одномерный массив, заполненный случайными числами. 
//найдите сумму элементов, стоящих на нечетных позициях.

Console.Clear();

Random rand = new Random();

int[] ArrayData(int arrNumber, int leftRange, int rightRange)
{
   int[] array = new int[arrNumber];
   int i = 0;
  for(i = 0; i < array.Length; i++)
  {
    array[i] = rand.Next(leftRange, rightRange + 1);
  } 
  return array;
}

void SumEvenNumberArray(int[] arrayEN)
{
    int sumEven = 0;
    for(int i = 0; i < arrayEN.Length; i++)
    {
        if(i % 2 == 0 && i != 0)
        {
           sumEven += arrayEN[i]; 
        }
    }
    Console.Write($"Сумма чисел с четным индексом в массиве -> {sumEven} ");
}

int DataEnyer(string str)
{
    Console.Write(str);
    int number = int.Parse(Console.ReadLine());
    return number;
}

int arrNumber = DataEnyer("Введите размер массива ");
int leftRange = DataEnyer("Введите min диапазон массива ");
int rightRange = DataEnyer("Введите max диапазон массива ");
int[] array = ArrayData(arrNumber, leftRange, rightRange);
Console.WriteLine('[' + string.Join(",", array) + ']');
SumEvenNumberArray(array);