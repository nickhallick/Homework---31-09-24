using System;
using System.ComponentModel.Design;

namespace Selection
{
    class Program
    {
        static void Main(string[] args)
        {
            Grade();
             DayFormat();
             Converter();
        }


        static void Grade()
        {  
            //Exam Grade Problem
            Console.WriteLine("Enter the exam mark you received");
            int Mark = int.Parse(Console.ReadLine());
            if (Mark < 2)
            {
                Console.WriteLine("A mark of {0} is a U", Mark);
            }
            else if (Mark < 4)
            {
                Console.WriteLine($"A mark of {Mark} is a 1 ");
            }
            else if (Mark < 13)
            {
                Console.WriteLine("A mark of " + Mark + " is a 2");
            }
            else if (Mark < 22)
            {
                Console.WriteLine($"A mark of {Mark} is a 3");
            }
            else if (Mark < 31)
            {
                Console.WriteLine($"A mark of {Mark} is a 4");
            }
            else if (Mark < 41)
            {
                Console.WriteLine($"A mark of {Mark} is a 5");
            }
            else if (Mark < 54)
            {
                Console.WriteLine($"A mark of {Mark} is a 6");
            }
            else if (Mark < 67)
            {
                Console.WriteLine($"A mark of {Mark} is a 7");
            }
            else if (Mark < 80)
            {
                Console.WriteLine($"A mark of {Mark} is a 8");
            }
            else
            {
                Console.WriteLine($"A mark of {Mark} is a 9");
            }
        
        static string DayFormat(int dayNum, string format)
            {
                //Day Format Problem
                string[] days = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
                string[] shortday = { "Mon", "Tue", "Wed", "Thu", "Fri", "Sat", "Sun" };
                string[] chara = { "M", "Tu", "W", "Th", "F", "Sa", "Su" };


                if (format == "days")
                {
                    return days[dayNum];
                }
                else if (format == "shortday")
                {
                    return shortday[dayNum];
                }
                else
                {
                    return chara[dayNum];
                }

                static float Converter(float Pounds, string Currency)
                {
                    if (Currency == "Euros")
                    {
                        return Pounds * 1.20f;
                    }
                    else if (Currency == "USD")
                    {
                        return Pounds * 1.33f;
                    }
                    else if (Currency == "Yen")
                    {
                        return Pounds * 191.69f;
                    }
                    else
                    {
                        return Pounds * 9.37f;



                    }
                }
            }
        }
    }       
}