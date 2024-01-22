using System;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Security.Cryptography;
using System.Timers;
namespace PoPRefactoring;

public class PopProject
{
    public static void Main()
    {
        int day;
        int month;
        int year;
        bool validate;

        Console.WriteLine("Introdueix el dia, mes i any");
        day = Convert.ToInt32(Console.ReadLine());
        month = Convert.ToInt32(Console.ReadLine());
        year = Convert.ToInt32(Console.ReadLine());

        validate = validation(day, month, year);
        if (validation (day, month, year)) { Console.WriteLine("El format es correcte"); }
        else { Console.WriteLine("El format no es correcte!"); }

        if (anytraspas(month, year)) { Console.WriteLine($"Els dies del mes {month}, son " + daysMonthTras(month, year)); }
        else { Console.WriteLine($"Els dies del mes {month}, son " + daysMonth(month, year)); }

        
    }

    public static bool validation(int day, int month, int year)
    {

        if (day < 1 || day > 31) { return false; }

        if (month < 1 || month > 12) { return false; }

        if (year < 1900 || year > 2200) { return false; }

        return true;
    }

    public static int daysMonthTras(int month, int year)
    {
        int totalDaysMonth = 0;

        switch (month)
        {

            case 1: totalDaysMonth = 30;  return totalDaysMonth;
            case 2: totalDaysMonth = 28; return totalDaysMonth;


            case 3: totalDaysMonth = 30; return totalDaysMonth;

            case 4: totalDaysMonth = 31; return totalDaysMonth;

            case 5: totalDaysMonth = 30; return totalDaysMonth;

            case 6: totalDaysMonth = 31; return totalDaysMonth;

            case 7: totalDaysMonth = 30; return totalDaysMonth;

            case 8: totalDaysMonth = 30; return totalDaysMonth;

            case 9: totalDaysMonth = 31; return totalDaysMonth;

            case 10: totalDaysMonth = 30; return totalDaysMonth;

            case 11: totalDaysMonth = 31; return totalDaysMonth;

            case 12: totalDaysMonth = 30; return totalDaysMonth;

            default : return totalDaysMonth;     
       }

    }

    public static int daysMonth(int month, int year)
    {
        int totalDaysMonth = 0;

        switch (month)
        {

            case 1: totalDaysMonth = 31; return totalDaysMonth;
            case 2: totalDaysMonth = 29; return totalDaysMonth;

            case 3: totalDaysMonth = 31; return totalDaysMonth;

            case 4: totalDaysMonth = 30; return totalDaysMonth;

            case 5: totalDaysMonth = 31; return totalDaysMonth;

            case 6: totalDaysMonth = 30; return totalDaysMonth;

            case 7: totalDaysMonth = 31; return totalDaysMonth;

            case 8: totalDaysMonth = 31; return totalDaysMonth;

            case 9: totalDaysMonth = 30; return totalDaysMonth;

            case 10: totalDaysMonth = 31; return totalDaysMonth;

            case 11: totalDaysMonth = 30; return totalDaysMonth;

            case 12: totalDaysMonth = 31; return totalDaysMonth;

            default: return totalDaysMonth;
        }

    }

    public static bool anytraspas(int month, int year)
    {
        if ((year % 400 == 0) ||

            ((year % 4 == 0) && (year % 100 != 0)))
            return false; //29


        return true; //28

    }

}