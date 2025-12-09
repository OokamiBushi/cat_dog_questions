Console.WriteLine("Что означает слово 'cat'?");
int sum = 0;
string questionNumberOne = Console.ReadLine();
if (questionNumberOne.ToLower().Trim() == "кошка")
{
    Console.WriteLine("Всё верно! 😎");
    sum += 10;
}
else
{
    Console.WriteLine("Нужно подумать ещё 🫣");
}
Console.WriteLine("Что означает слово 'dog'?");
string questionNumberTwo = Console.ReadLine();
if (questionNumberTwo.ToLower().Trim() == "собака")
{
    Console.WriteLine("Всё верно! 😎");
    sum += 10;
}
else
{
    Console.WriteLine("Нужно подумать ещё 🫣");
}
Console.WriteLine($"Счёт:" + sum);