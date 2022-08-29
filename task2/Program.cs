// Напишите программу, которая выводит третью цифру случайно 
// сгенерированного числа (от 1 до 65536) или сообщает, что 
// третьей цифры нет.
Random rand = new Random();
int x = rand.Next(65536 + 1); // случайное число

if (x > 99)
{
    Console.WriteLine(x);
    while (x > 999)
    {
        x /= 10;
        //Console.WriteLine(x);
    }
    int z = x / 100; // первая цифра
    int y = (x - z * 100) % 10; // третья цифра
        
    //Console.WriteLine(z);
    Console.WriteLine(y); 
}
else
{
   Console.WriteLine("Третьей цифры нет"); 
}

