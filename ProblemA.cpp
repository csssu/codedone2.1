/**
 * @file ProblemOne.cpp
 * @author amir aghazadeh (cssu.ama@gmail.com)
 * @brief implement Queue with two Stacks
 * @version 0.1.1
 * @date 2022-07-25
 * @id 1code2
 *
 * @copyright Copyright (c) 2022
 *
 */

#include <bits/stdc++.h>

using namespace std;

// declare two stack to use them in implementaion of queue
// تعریف کن پشته رو برای استفاده کردن تو پیاده سازی صف
stack<int> stackOne;
stack<int> stackTwo;

int main()
{
  // test cases quantity
  // تعداد تست کیس‌ها
  int testCases;
  cin >> testCases;

  while (testCases--)
  {
    int queueSize;
    cin >> queueSize;

    // get queue elements from user and push to stack one
    // عناصر رو از ورودی بگیر و به پشته اول اضافه کن
    while (queueSize--)
    {
      int newQueueInput;
      cin >> newQueueInput;

      stackOne.push(newQueueInput);
    }

    // delete queue elements from stack one and add them to stack two
    // عناصر رو به ترتیب از پشته اول حذف کن و به پشته دوم اضافه کن
    while (!stackOne.empty())
    {
      stackTwo.push(stackOne.top());
      stackOne.pop();
    }

    // print queue elements
    // عناصر صف رو چاپ کن
    while (!stackTwo.empty())
    {
      cout << stackTwo.top() << " ";
      stackTwo.pop();
    }

    cout << endl;
  }

  return 0;
}