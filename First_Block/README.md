# FinalTask of First Block
## Задача : 
Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решение не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами
## Алгоритм решения:
Исходный массив вводится пользователем в виде строки, в которой элементы массива резделены пробелом (можно использовать любой символ, который отсутствует в элементах массива). 

Далее - печатается входная строка в виде массива. 

Затем вызывается метод, который из входной строки создает временный массив и, перебирая его от начального элемента до конечного, формирует результат, путем конкатенации в отдельной строке элементов, длина которых меньше или равно 3 символам. Эта строка возвращается как результат работы метода

Далее - печатается данная строка в виде массива

Для печати строк в виде массива есть отдельный метод, в котором используется такой же способ работы с массивом строк - разбор общей строки на элементы массива, перебор массива с выводом поэлементно

## Блок-схема алгоритма
 - в файле BlockScheme.jpg. Более-менее подробно описана часть, касающаяся работы основного метода

## Программа на C#, реализующая данный алгоритм
 - в файле Program.cs