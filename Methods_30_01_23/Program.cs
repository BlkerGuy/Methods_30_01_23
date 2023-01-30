using System;
using System.Threading.Tasks;

namespace Methods_30_01_23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // TASK 1   Verilmiş iki ədədi toplayıb qaytaran metod:<>

            //Console.WriteLine(Sum(5, 10)); 

            // Task 2   Veirlmiş iki ədədi toplayıb console - a yazdıran metod:<><>

            //SumShow(10, 20);

            // Task 3   Verilmiş ədədlər siyahısındaki ədədlərini cəmini qaytaran metod:<><><>

            //int[] nums = new int[] { 12, 5, 23, 27 };
            //Console.WriteLine(ArrSum(nums)); 

            // Task 4   Verilmiş ədədlər siyahısındaki ədədlərin cəmini console-a yazdıran metod:<><><><>

            //int[] nums = new int[] { 54, 5, 23, 27 };
            //ArraySum(nums);

            // Task 5   Verilmiş ədədlər siyahısındaki ən böyük ədədi qaytaran metod:<><><><><>

            //int[] nums = new int[] { 54, 5, 23, 27 };
            //Console.WriteLine(ArrBigDigit(nums));

            // Task 6   Verilmiş 3 ədəddən ən böyüyünü tapan proqram:<><><><><><>

            //int num1 = 5;
            //int num2 = 3;
            //int num3 = -1;
            //BigDigit(num1,num2,num3);

            // Task 7   Verilmiş yazını əks şəkildə qaytaran metod:<><><><><><><>

            //Console.WriteLine(Reverse("Hikmet"));


            // Task 8   Verilmiş ədədin rəqəmləri cəmini qaytaran metod:<><><><><><><><>

            //Console.WriteLine(sumDigitsInNum(523));
            

        }

        // Method of Task 1 
        //static int Sum(int a, int b)
        //{
        //    return a + b;
        //}

        // Method of Task 2
        //static void SumShow(int a, int b)
        //{
        //    Console.WriteLine(a+b);
        //}

        // Method of Task 3
        //static int ArrSum(int[] nums)
        //{
        //    int sum = 0;
        //    for (int i = 0; i < nums.Length; i++)
        //    {
        //        sum += nums[i];
        //    }
        //    return sum;
        //}

        // Method of Task 4 
        //static void ArraySum(int[] nums)
        //{
        //    int sum = 0;
        //    for (int i = 0; i < nums.Length; i++)
        //    {
        //        sum += nums[i];
        //    }
        //    Console.WriteLine(sum);
        //}

        // Method of Task 5
        //static int ArrBigDigit(int[] nums)
        //{
        //    int bigNum = nums[0];
        //    for (int i = 1; i < nums.Length; i++)
        //    {
        //        if (nums[i] > bigNum)
        //        {
        //            bigNum = nums[i];
        //        }
        //    }
        //    return bigNum;
        //}

        // Method of Task 6
        //static void BigDigit(int num1, int num2, int num3)
        //{
        //    if (num1>num2 && num1>num3)
        //    {
        //        Console.WriteLine($"{num1}. Boyukdur");
        //    }
        //    else if (num2>num1 && num2>num3)
        //    {
        //        Console.WriteLine($"{num2}. Boyukdur");
        //    }
        //    else if (num3 > num1 && num3 > num2)
        //    {
        //        Console.WriteLine($"{num3}. Boyukdur");
        //    }
        //    else
        //    {
        //        if (num1==num2 && num1>num3)
        //        {
        //            Console.WriteLine($"(num2: {num1}) ve (num3: {num2}) Beraberdir ve Boyukdur");
        //        }
        //        else if (num1==num3 && num1>num2)
        //        {
        //            Console.WriteLine($"(num1: {num1}) ve (num3: {num3}) Beraberdir ve Boyukdur");
        //        }
        //        else if (num2 == num3 && num3>num1)
        //        {
        //            Console.WriteLine($"(num2: {num2}) ve (num3: {num3}) Beraberdir ve Boyukdur");
        //        }
        //        else
        //        {
        //            Console.WriteLine("Ededlerin beraberliyi coxdur.");
        //        }
        //    }
        //}

        // Method of Task 7
        //static string Reverse(string word)
        //{
        //    string emptyWord = "";
        //    for (int i = word.Length-1; i >=0; i--)
        //    {
        //        emptyWord += word[i];
        //    }
        //    return emptyWord.ToLower();
        //}

        // Method of Task 8
        //static int sumDigitsInNum(int num)
        //{
        //    int sumDigit = 0;
        //    while (num!=0)
        //    {
        //        sumDigit += num % 10;
        //        num /= 10;
        //    }
        //    return sumDigit;
        //}


    }
}
