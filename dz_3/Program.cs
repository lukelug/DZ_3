using System;
class Program
{
    static void Main()
    {
        Console.Write("Введите число от 1 до 365: ");
        int dayOfYear = int.Parse(Console.ReadLine());
        if (dayOfYear < 1 || dayOfYear > 365)
{
            Console.WriteLine(" Введенное число должно быть от 1 до 365. ");
        }
else
        {
            int[] daysInMonth = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            int month = 0;
            int day = 0;
            for (int i = 0; i < daysInMonth.Length; i++)
{
                if (dayOfYear <= daysInMonth[i])
{
                    month = i + 1;
                    day = dayOfYear;
                    break;
                }
                dayOfYear -= daysInMonth[i];
            }
            Console.WriteLine($" Число { dayOfYear} соответствует { day}{ GetMonthName(month)}.");
        }
    }
    static string GetMonthName(int month)
    {
        switch (month)
        {
            case 1: return " января " ;
            case 2: return " февраля " ;
            case 3: return " марта ";
            case 4: return " апреля "  ;
            case 5: return " мая " ;
            case 6: return " июня " ;
            case 7: return " июля " ;
            case 8: return " августа " ;
            case 9: return " сентября " ;
            case 10: return " октября " ;

            case 11: return " ноября " ;
            case 12: return " декабря " ;
            default: return " " ;
        }
    }
}
