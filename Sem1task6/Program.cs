//
string? num1 = Console.ReadLine() ;
if(num1!= null) 

{

  int num = int.Parse(num1);
  
int c=num %2;
 if (  c == 0)

{
    Console.WriteLine("Число четное");
}
else
{
    Console.WriteLine("Число не четное");

}
}