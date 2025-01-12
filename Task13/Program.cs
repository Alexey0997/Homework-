﻿// Задача 13: Напишите программу, которая выводит третью цифру заданного числа 
// или сообщает, что третьей цифры нет.
Console.Clear();
Console.WriteLine("Уважаемый пользователь, введите целое число: ");
int number = int.Parse(Console.ReadLine());
// Определим количество цифр в числе, введенном пользователем. 
int count = 0;
int num = number;
while (num > 0)
{
    num = num/10;
    count++;
}
if(count < 3) // Если число двузначное, то сообщим об отсутствии третьей цифры. 
{
    Console.WriteLine("Введенное Вами число не содержит третьей цифры.");
}
else          // Создадим и заполним массив от максимального элемента к минимальному. 
{
    int[] array = new int [count]; // Созданим массив array, имеющий count элементов.
    int index = array.Length - 1;  // Найдем индекс последнего элемента.
    while(number > 0)              // Цикл по заполнению массива. 
    {
        array [index] = number%10; // Значение элемента равно остатку после деления. 
        number = number/10;        // Переход к следующей цифре числа. 
        index--;                   // Уменьшение индекса (справа на лево).
    }
Console.WriteLine($"Третья цифра в данном числе {array[2]}.");
}
