// Напишите программу, которая принимает на вход цифру, обозначающую день недели,
//и проверяет, является ли этот день выходным.
Random rand = new Random();
int x = rand.Next(1, 8); // случайное число
Console.WriteLine(x);
if (x > 5)
{
   Console.WriteLine("Выходной"); 
}
else
{
    Console.WriteLine("Будний день"); 
}