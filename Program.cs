// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12


int Sum (int N)
{
    int sum = 0;

    while (N > 0)
        {
            int dig = N % 10;
            sum = sum + dig;
            N = N/10;
        }
    return sum;
}
try
{
    System.Console.Write("Введите число ");
    int a = Convert.ToInt32 (Console.ReadLine());
    System.Console.WriteLine($"Сумма цифр в числе {a} равна {Sum(a)}");

}
catch
{
    System.Console.WriteLine("Необходимо ввести число цифрами!");
}
