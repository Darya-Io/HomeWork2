// Напишите программу, которая выводит третью цифру заданного числа или сообщает,
//  что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine("Введите число >");
string? volume = Console.ReadLine();

int findIndex = 2;
if(volume.Length > findIndex)
{
    Console.WriteLine($"Третья цифра {volume[findIndex]}");
}

else if (volume.Length <= findIndex)
 {
Console.WriteLine($"Третьей цифры нет");
}

