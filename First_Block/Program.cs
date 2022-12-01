/* Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк,
	длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры,
	либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями,
	лучше обойтись исключительно массивами.
	[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
	[“1234”, “1567”, “-2”, “computer science”] → [“-2”]
	[“Russia”, “Denmark”, “Kazan”] → [] */


// Метод ArrayOf3
//    - получает исходную строку   
//    - создаюет массив из полученной строки
//    - выбирает в отдельную строку (через пробел) все элементы массива с длиной <= 3
//    - возвращает, полученную строку  
string ArrayOf3(string inString)
{
    var result = "";
    string[] tempArray;
    tempArray = inString.Split(" ");
    int first = 1;

    for (int i = 0; i < tempArray.Length; i++)
    {
        if(tempArray[i].Length <= 3)
        {
            if(first == 1)
            {
                result =  result + tempArray[i];
                first = 0;
            }
            else
            {
                result =  result + " " + tempArray[i];
            }
        }
    }
    return result;
}

// Метод OutputStringAsArray
//    - получает исходную строку   
//    - создаюет массив из полученной строки
//    - выводит (на консоль) полученный массив
void PrintStringAsArray(string inString)
{
    string[] tempArray;
    tempArray = inString.Split(" ");

    
    if(inString != "")
    {
        Console.WriteLine($" Массив из {tempArray.Length} элементов:");
        Console.Write("[");
        for (int i = 0; i < tempArray.Length; i++)
        {
            Console.Write(tempArray[i] + " ");
        }
    }
    else
    {
        Console.Write(" Массив пустой:\n[ ");
    }
    Console.Write("\b]");
    Console.WriteLine();
}

// Основная программа
Console.WriteLine();
Console.WriteLine("Введите массив строк в виде одной строки, разделяя элементы массива пробелом");
Console.WriteLine("например: при вводе 'что это такое там' получится массив из 4 элементов ['что', 'это', 'такое', 'там']");
string stringInput = Console.ReadLine();
Console.WriteLine();
Console.WriteLine("На входе");
PrintStringAsArray(stringInput);
Console.WriteLine();
string stringOutput = ArrayOf3(stringInput);
Console.WriteLine("На выходе");
PrintStringAsArray(stringOutput);
Console.WriteLine();

// Hello 2 world :-)     → [“2”, “:-)”]
// 1234 1567 -2 computer science → [“-2”]
// Russia Denmark Kazan   → [] */
//
// Что это такое - стыд и срам. Быстро расходитесь по домам - 11 элементов
// на выходе - 5 элементов [Что это - и по]
