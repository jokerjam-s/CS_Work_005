/*
* Задача 34
  TODO: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
* [345, 897, 568, 234] -> 2

*/

// границы генерируемых чисел массива
const int lowNum = 100, highNum = 1000;

// запрос численного значения у пользователя
// параметры:
//      message - выводимое сообщение пользователю
// возврат:
//      число, введенное пользователем в консоли
int InputNumber(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}


// генерация целочисленного массива в диапазоне [lowNum, ..., highNum)
// параметры:
//      arrSize - размер генерируемого массива
// возврат:
//      одномерный массив, размерностю arrSize, заполненный случайными трехзначными числами
int[] GenerateArray(int arrSize)
{
    int[] array = new int[arrSize];

    Random randNum = new Random();

    for (int i = 0; i < arrSize; i++)
    {
        array[i] = randNum.Next(lowNum, highNum);
    }

    return array;
}

// подсчет количества четных чисел в массиве
// параметры:
//      array - массив для поиска 
// возврат:
//      количество положительных элементов
int CalcEvenNumder(int[] array)
{
    int evenCnt = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            evenCnt++;
        }
    }

    return evenCnt;
}

// вывод массива на консоль
// параметры:
//      array - массив для отображения
//      message - поясняющее сообщение
// возврат:
//      нет
void PrintArray(int[] array, string message)
{
    Console.WriteLine(message);

    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }

    Console.WriteLine();
}



// main body
Console.Clear();

int arraySize = InputNumber("Input size of array: ");
int[] array = GenerateArray(arraySize);
int result = CalcEvenNumder(array);

PrintArray(array, "Generated array: ");
Console.WriteLine($"This array has {result} even numbers.");