Console.Clear();
{
Console.Write("Введите пятизначное число: ");
    string number = Console.ReadLine()!;

if (number.Length != 5 || !int.TryParse(number, out _)) //
{
Console.WriteLine("Ошибкочка: Введите пятизначное число!");
}
else
{
    bool isPalindrome = true;
for (int i = 0; i < number.Length / 2; i++)
{
if (number[i] != number[number.Length - 1 - i])
{
    isPalindrome = false;
break;
}
}
if (isPalindrome)
{
Console.WriteLine("Да");
}
else
{
Console.WriteLine("Нет.");
}
}
}