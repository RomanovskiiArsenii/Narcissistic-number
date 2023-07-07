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
        if (value < 10) { Console.WriteLine("Positive number >= 10 required"); return false; }

        string numbers = value.ToString();
        double result = 0;

        for (int i = 0; i < numbers.Length; i++)
        {
            double digit = Math.Pow(int.Parse(numbers[i].ToString()), numbers.Length);
            result += digit;
        }

        if (result == value) { Console.WriteLine("Number is Narcissistic"); return true; }
        else { Console.WriteLine("Number is not Narcissistic"); return false; }
    }
    static void Main(string[] args)
    {
        //positive numbers >= 10 only
        //1^3 + 5^3 + 3^3 = 1 + 125 + 27 = 153
        Console.WriteLine(Narcissistic(153));
    }
}