// считываем данные с консоли

string? numAline = Console.ReadLine();
string?numBline = Console.ReadLine() ;
// Поверяем чтобы чило не было равно 0

if(numAline !=null && numBline !=null)
// Парсим введенные числа
{
    int num1 = int.Parse(numAline);
    int num2 = int.Parse(numBline);

    // сравниваем между собой 
if (num1> num2)
{
    Console.WriteLine ("Перввое число max");

}
else


{
    // Выводим ответ в консоль
    Console.WriteLine ("Второе число max");
}
}