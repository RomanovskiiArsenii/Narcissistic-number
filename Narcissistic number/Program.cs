/*
A Narcissistic Number (or Armstrong Number) is a positive number which is 
the sum of its own digits, each raised to the power of the number of digits 
in a given base. In this Kata, we will restrict ourselves to decimal (base 10).
For example, take 153 (3 digits), which is narcissistic:
1^3 + 5^3 + 3^3 = 1 + 125 + 27 = 153
*/

class Program
{
    public static bool Narcissistic(int value)
    {
        //только положительные числа
        if (value <= 0) { Console.WriteLine("Positive number required"); return false; }                        
        //получение строкового представления числа
        string numbers = value.ToString();
        double result = 0;
        //каждая цифра в степени значения базы числа суммируется с локальной переменной result
        foreach (var number in numbers) { result += Math.Pow(int.Parse(number.ToString()), numbers.Length); }
        //сравнение результата с изначальным значением 
        return result == value;
    }
    static void Main(string[] args)
    {
        //1^3 + 5^3 + 3^3 = 1 + 125 + 27 = 153
        Console.WriteLine(Narcissistic(153));
    }
}