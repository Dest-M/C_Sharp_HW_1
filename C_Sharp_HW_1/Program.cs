
using System;
using  System.Collections.Generic;
using System.ComponentModel;
using  System.Text;
using  System.Threading.Tasks;


namespace HW_Lesson_1
{
    class Program {

        static void q1()
        {
            Console.WriteLine("QUESTION 1 -------- Fizz Buzz\nEnter number between 1 and 100: ");
            int num = Convert.ToInt32(Console.ReadLine());
            if(num <= 100 && num >= 1)
            {
                if(num%3 == 0)
                {
                    if (num % 5 == 0)
                    {
                        Console.WriteLine("Fizz Buzz\n");
                    }
                    else
                    {
                        Console.WriteLine("Fizz\n");
                    }
                }
                else if(num % 5 == 0)
                {
                    Console.WriteLine("Buzz\n");
                }
                else
                {
                    Console.WriteLine(Convert.ToString(num));
                }
            }
            else
            {
                Console.WriteLine("Out of range ERROR");
            }

        }
        static void q2()
        {
            Console.WriteLine("\n\nQUESTION 2 -------- Percentages\nEnter number: ");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nEnter percentage: ");
            int per = Convert.ToInt32(Console.ReadLine());
            double ans;
            ans = (Convert.ToDouble(num) / 100)* per;
            Console.WriteLine(Convert.ToString(ans));

        }
        static int sizecheck(int num)
        {
            int check = 10;
            while (num > check)
            {
                check = check * 10;
            }
            return check;
        }
        static void q3()
        {
            Console.WriteLine("\n\nQUESTION 3 -------- Combine 4 numbers\nEnter number one: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nEnter number two: ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nEnter number three: ");
            int num3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nEnter number four: ");
            int num4 = Convert.ToInt32(Console.ReadLine());
            int ans = 0;
            ans = (ans + num1) * sizecheck(num2);
            ans = (ans + num2) * sizecheck(num3);
            ans = (ans + num3) * sizecheck(num4);
            ans = ans + num4;
            Console.WriteLine(Convert.ToString(ans));


        }
        static void q4()
        {
            Console.WriteLine("\n\nQUESTION 4 -------- Reverse a number\nEnter a 6-digit number: ");
            int num = Convert.ToInt32(Console.ReadLine());
            int ans = 0;
            if(num < 100000 || num > 999999)
            {
            Console.WriteLine("ERROR! Number out of range!\n");

            }
            else
            {
                for(int i = 0; i < 6; i++)
                {
                    ans = ans * 10;
                    ans = ans+(num % 10);
                    num = num / 10;
                }
            };

            Console.WriteLine(Convert.ToString(ans));


        }
        static void q5()
        {
            Console.WriteLine("\n\nQUESTION 4 -------- Date\nEnter a mm.dd.yyyy date: ");
            DateTime dat = Convert.ToDateTime(Console.ReadLine());

            int day = Convert.ToInt32(dat.DayOfWeek);
            int month = Convert.ToInt32(dat.Month);
            string dayStr = "error";
            string seasonStr = "error";
            switch (day)
            {
                case (1):
                    dayStr = "Monday";
                    break;
                case (2):
                    dayStr = "Tuesday";
                    break;
                case (3):
                    dayStr = "Wednesday";
                    break;
                case (4):
                    dayStr = "Thursday";
                    break;
                case (5):
                    dayStr = "Friday";
                    break;
                case (6):
                    dayStr = "Saturday";
                    break;
                case (7):
                    dayStr = "Sunday";
                    break;
                default:
                    Console.WriteLine("ENTRY ERROR\n");
                    break;
            }
            if (month == 12 || month <= 2)
            {
                seasonStr = "Winter";
            }
            else if (month >= 3 && month <= 5)
            {
                seasonStr = "Spring";

            }
            else if (month >= 6 && month <= 8)
            {
                seasonStr = "Summer";
            }
            else if (month >= 9 && month <= 11)
            {
                seasonStr = "Autumn";
            }
            else
            {
                Console.WriteLine("ENTRY ERROR\n");
            }
            

            Console.WriteLine(seasonStr + " " + dayStr + "\n");
         

        }
        static void q6()
        {
            int choice= 0;
            double num;
            double ans= 0;
            bool dum = true;
            while(dum){
                Console.WriteLine("\n\nQUESTION 6 -------- Temperature Converter\nEnter 1 or 2 to pick:\n 1 - F to C\n 2 - C to F ");
                choice = Convert.ToInt32(Console.ReadLine());
                if(choice != 1 && choice != 2 ){
                      Console.WriteLine("Wrong input ERROR. Try Again\n");

                }
                else
                {
                    dum = false;
                }
            }
            Console.WriteLine("Enter temperature\n");
            num = Convert.ToInt32(Console.ReadLine());
            if (choice == 1)
            {
                ans = 5.0 / 9 * (num - 32);
            }
            if (choice == 2)
            {
                ans = num * (9/5.0)+32;
            }

            Console.WriteLine(Convert.ToString(ans));


        }
        static void q7()
        {
            int start;
            int end;

                Console.WriteLine("\n\nQUESTION 7 -------- Even numbers in range\nEnter start of range: ");
                start = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("\nEnter end of range: ");
                end = Convert.ToInt32(Console.ReadLine());
                if (start > end)
                {
                    int temp = start;
                    start = end;
                    end = temp;

                }

            for(int i = start; i <= end; i++)
            {
                if(i%2 == 0)
                {
                    Console.WriteLine(Convert.ToString(i));
                }
            }



        }
        static void Main()
        {
            q1();
            q2();
            q3();
            q4();
            q5();
            q6();
            q7();
        }
     }
}

