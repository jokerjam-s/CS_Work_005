/*

*   Задача 38: 
    todo: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

*   [3 7 22 2 78] -> 76

*/

// границы генерируемых чисел массива
// для удобства проверки результата ограничим диапазон генерации промежутком [-10.00, ..., 10.00]
// целочисленные значения будут приведены к double и для получения дробной части разделены на 100
const int lowNum = -1000, highNum = 1001;

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
//      одномерный массив, размерностю arrSize, заполненный случайными числами согласно диапазона
double[] GenerateArray(int arrSize)
{
    double[] array = new double[arrSize];

    Random randNum = new Random();

    for (int i = 0; i < arrSize; i++)
    {
        array[i] = Convert.ToDouble(randNum.Next(lowNum, highNum)) / 100;
    }

    return array;
}


// вывод массива на консоль
// параметры:
//      array - массив для отображения
//      message - поясняющее сообщение
// возврат:
//      нет
void PrintArray(double[] array, string message)
{
    Console.WriteLine(message);

    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }

    Console.WriteLine();
}

// поиск максимального элемента
// параметры:
//      array - массив для поиска
// возврат:
//      значение наибольшего элемента в массиве
double MaxOfArray(double[] array)
{
    double result = array[0];

    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] > result)
        {
            result = array[i];
        }
    }

    return result;
}

// поиск минимального элемента
// параметры:
//      array - массив для поиска
// возврат:
//      значение наибольшего элемента в массиве
double MinOfArray(double[] array)
{
    double result = array[0];

    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] < result)
        {
            result = array[i];
        }
    }

    return result;
}



// main body

Console.Clear();

int arrSize = InputNumber("Input size of array: ");
double[] array = GenerateArray(arrSize);
PrintArray(array, "Initialized array: ");

double minValue = MinOfArray(array);
double maxValue = MaxOfArray(array);

Console.WriteLine($"Minimum: {minValue}");
Console.WriteLine($"Maximum: {maxValue}");
Console.WriteLine($"Difference between minimum and maximum: {maxValue - minValue}");
