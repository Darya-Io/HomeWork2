// Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введите цифру, обозначающую день недели > ");
string? volue = Console.ReadLine();
int dayOfWeek = Convert.ToInt32(volue);
if (dayOfWeek < 6)
{
Console.WriteLine($"Нет");
} 
else if (dayOfWeek < 8)
{
Console.WriteLine($"Да");
}

