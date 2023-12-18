Begin:
Console.WriteLine("Введите 4 числа A, B, C, D от 1 до 100 через пробел.");
string chisla = Console.ReadLine();
string[] numbers = chisla.Split(' ');
foreach (string number in numbers) {
    if (Convert.ToInt32(number) < 1 || Convert.ToInt32(number) > 100)
    {
        Console.WriteLine("Введены неправильные параметры");
        goto Begin;
    }
}
if (numbers.Length == 4)
{
    if (Convert.ToInt32(numbers[3]) <= Convert.ToInt32(numbers[1])) Console.WriteLine(Convert.ToInt32(numbers[0]));
    else Console.WriteLine(Convert.ToInt32(numbers[0]) + (Convert.ToInt32(numbers[3]) - Convert.ToInt32(numbers[1])) * Convert.ToInt32(numbers[2]));
}
else
{
    Console.WriteLine("Введены неправильные параметры");
    goto Begin;
}
