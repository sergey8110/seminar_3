﻿// Считываем данные с консоли
string? inputLine= Console.ReadLine();

// Проверяем, чтобы данные были не  пустыми
if(inputLine!=null)
{
    // Парсим введенное число
    int inputNumber = int.Parse(inputLine);

    int startNumber = inputNumber*(-1);

    // Выводим значение
    string outline =string.Empty;
    while(startNumber<inputNumber)
    {
        outline =outline +startNumber + "," ;
        startNumber++;

    }
outline =outline + inputNumber;

// Выводим данные в консоль
Console.WriteLine(outline);


}