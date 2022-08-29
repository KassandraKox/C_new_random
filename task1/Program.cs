// See https://aka.ms/new-console-template for more information
Random rand = new Random();
int x = rand.Next(1000); // случайное число
int y = x / 10; // первые 2 цифры
int z = y / 10; // первая цифра
int two = y - z * 10; // вторая цифра
// Console.WriteLine(x);
// Console.WriteLine(y);
// Console.WriteLine(z);
Console.WriteLine(two);  // как проверить без вспомогательных выводов, что получилась верная цифра?