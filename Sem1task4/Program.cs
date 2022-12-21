//  Вводим три числа  
string? num1Line = Console.ReadLine();
string? num2Line = Console.ReadLine();
string? num3Line = Console.ReadLine();
// Проверяем чтобы не были равнынулю
    if (num1Line != null && num2Line != null && num3Line != null)
// Парсим введеные числа
    {

        int num1 = int.Parse(num1Line);
        int num2 = int.Parse(num2Line);
        int num3 = int.Parse(num3Line);

    // заводим переменную для  хранения максимального числа 
     int max =0;
// Проверяем их между собой
        if (num1 > num2)
        max  = num1 ;
        else max = num2 ;
        if ( num3 > num1) 
        max = num3;

    // Выводим результат
     Console.WriteLine( max );
    }
