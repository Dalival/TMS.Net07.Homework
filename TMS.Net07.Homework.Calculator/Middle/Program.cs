﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Middle
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
            double firstValue, secondValue;
            while (true)
            {
                Console.Clear();
                while (true)
                {
                    Console.Write("Input first value: ");
                    if (Double.TryParse(Console.ReadLine(), out firstValue))
                    {
                        Console.WriteLine($"Done{Environment.NewLine}");
                        break;
                    }
                    else
                    {
                        Console.WriteLine($"Please input the correct value.{Environment.NewLine}");
                    }
                }
                while (true)
                {
                    Console.Write("Input second value: ");
                    if(Double.TryParse(Console.ReadLine(), out secondValue))
                    {
                        Console.WriteLine($"Done{Environment.NewLine}");
                        break;
                    }
                    else
                    {
                        Console.WriteLine($"Please input the correct value.{Environment.NewLine}");
                    }
                }
                Console.Write("Press one of the keys [ + - * / % ]: ");
                while (true)
                {
                    switch (Console.ReadKey(true).KeyChar)
                    {
                        case '+':
                            Console.WriteLine($"+{Environment.NewLine}{Environment.NewLine}Your result: {firstValue + secondValue}");
                            break;
                        case '-':
                            Console.WriteLine($"-{Environment.NewLine}{Environment.NewLine}Your result: {firstValue - secondValue}");
                            break;
                        case '*':
                            Console.WriteLine($"*{Environment.NewLine}{Environment.NewLine}Your result: {firstValue * secondValue}");
                            break;
                        case '/':
                            Console.WriteLine($"/{Environment.NewLine}{Environment.NewLine}Your result: {firstValue / secondValue}");
                            break;
                        case '%':
                            Console.WriteLine($"%{Environment.NewLine}{Environment.NewLine}Your result: {firstValue % secondValue}");
                            break;
                        default:
                            continue;
                    }
                    break;
                }
                Console.WriteLine($"{Environment.NewLine}Do you want to count something else? Press Y or N.");
                string yesOrNo;
                while (true)
                {
                    yesOrNo = Console.ReadKey(true).Key.ToString().ToLower();
                    if (yesOrNo == "y" || yesOrNo == "n")
                    {
                        break;
                    }
                }
                if (yesOrNo == "n")
                {
                    Console.WriteLine($"{Environment.NewLine}Ok, good bye!");
                    break;
                }
            }
            Console.ReadKey();
        }
    }
}
