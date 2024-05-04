﻿// Задача 1: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа
// в промежутке от M до N. Использовать рекурсию, не использовать циклы.
// Пример
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 5, 6, 7, 8"

   void Main() 
    { 
        System.Console.Write("Введите значение M: "); 
        int M = int.Parse(Console.ReadLine()); 
 
        System.Console.Write("Введите значение N: "); 
        int N = int.Parse(Console.ReadLine()); 
 
        PrintNumbers(M, N); 
    } 
 
    void PrintNumbers(int number, int N) 
    { 
        if (number <= N) 
        { 
            System.Console.Write(number + " "); 
            PrintNumbers(number + 1, N); 
        } 
    } 
    
    Main();