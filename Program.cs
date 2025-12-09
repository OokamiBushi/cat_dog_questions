Console.WriteLine("Что означает слово 'cat'?");
int sum = 0;
string questionNumberOne = Console.ReadLine();
if (questionNumberOne == "кошка" || questionNumberOne == "Кошка" || questionNumberOne == "КОШКА")
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
if (questionNumberTwo == "собака" || questionNumberTwo == "Собака" || questionNumberTwo == "СОБАКА")
{
    Console.WriteLine("Всё верно! 😎");
    sum += 10;
}
else
{
    Console.WriteLine("Нужно подумать ещё 🫣");
}
Console.WriteLine($"Счёт:" + sum);