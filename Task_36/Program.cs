/*
* Задача 36: 
  todo: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

* [3, 7, 23, 12] -> 19
* [-4, -6, 89, 6] -> 0

*/

// границы генерируемых чисел массива
// для удобства проверки результата ограничим диапазон генерации промежутком [-100, ..., 100]
const int lowNum = -100, highNum = 101;

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
//      одномерный массив, размерностю arrSize, заполненный случайными числами согласно диапазона.
//      ограниченного lowNum и highNum;
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


// расчет суммы значений элементов массива стоящих на нечётных позициях
// расчет ведется с точки зрения человеческого восприятия, т.е. 
// первым считается элемент с 0-м машинным индексом
// параметры:
//      array - массив для расчета искомой суммы
// возврат:
//      сумма значений элементов на нечетных позициях
int SumUneventArray(int[] array)
{
    int summ = 0;
    // четные пропустим
    for (int i = 0; i < array.Length; i += 2)
    {
        summ += array[i];
    }

    return summ;
}


// main body
Console.Clear();

int arrSize = InputNumber("Input size of array: ");
int[] array = GenerateArray(arrSize);
PrintArray(array, "Generated array:");
Console.WriteLine($"Summa: {SumUneventArray(array)}");


