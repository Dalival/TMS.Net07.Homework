﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Middle
{
    class Program
    {
        static void Main(string[] args)
        {
            string dateFormat = @"[0-3]\d\.[0-1]\d\.\d{4}"; //doesn't check 100% adequacy
            while (true)
            {
                Console.WriteLine("Enter date in format DD.MM.YYYY:");
                string input = Console.ReadLine();
                if (input.ToLower() == "exit")
                {
                    Console.WriteLine($"{Environment.NewLine}This command finish the program. Good bye!");
                    break;
                }
                if (Regex.IsMatch(input, dateFormat))
                {
                    //I can use Parse instead of TryParse because of regex above
                    int day = int.Parse(input.Substring(0,2));
                    int month = int.Parse(input.Substring(3, 2));
                    int year = int.Parse(input.Substring(6));
                    //regex doesn't work perfectly, for example user still can enter 39.10.2020. It'll cause exception. 
                    try
                    {
                        DateTime date = new DateTime(year, month, day);
                        Console.WriteLine($"{Environment.NewLine}It's {date.DayOfWeek}. Enter another date or \"exit\" to exit.{Environment.NewLine}");
                    }
                    catch
                    {
                        Console.WriteLine($"Incorrect input. Such date doesn't exist. If you want to exit enter \"exit\".{Environment.NewLine}");
                        continue;
                    }
                }
                else
                    Console.WriteLine($"Incorrect input. Please follow the DD.MM.YYYY format. If you want to exit enter \"exit\".{Environment.NewLine}");
            }
            Console.ReadKey();
        }
    }
}