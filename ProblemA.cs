/**
 * @file ProblemOne.cs
 * @author amir aghazadeh (cssu.ama@gmail.com)
 * @brief implement Queue with two Stacks
 * @version 0.1.0
 * @date 2022-07-28
 * @id 1code2
 *
 * @copyright Copyright (c) 2022
 *
 */
using System.Collections;

namespace Test
{
    class ProblemOne
    {
        // declare two stack to use them in implementaion of queue
        // تعریف کن پشته رو برای استفاده کردن تو پیاده سازی صف
        static Stack stackOne = new Stack();
        static Stack stackTwo = new Stack();

        static void Main(string[] args)
        {
            // test cases quantity
            // تعداد تست کیس‌ها
            int testCases = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < testCases; i++)
            {
                int queueSize = Convert.ToInt32(Console.ReadLine());

                // get queue elements from user and push to stack one
                // عناصر رو از ورودی بگیر و به پشته اول اضافه کن
                string[] temp = Console.ReadLine().Split();
                int[] inputs = Array.ConvertAll(temp, iterator => int.Parse(iterator));

                for (int j = 0; j < inputs.Count(); j++)
                {
                    stackOne.Push(inputs[j]);
                }

                // delete queue elements from stack one and add them to stack two
                // عناصر رو به ترتیب از پشته اول حذف کن و به پشته دوم اضافه کن
                while (stackOne.Count != 0)
                {
                    stackTwo.Push(stackOne.Pop());
                }

                // print queue elements
                // عناصر صف رو چاپ کن
                while (stackTwo.Count != 0)
                {
                    Console.Write(stackTwo.Pop() + " ");
                }

                Console.WriteLine();
            }
        }
    }
}