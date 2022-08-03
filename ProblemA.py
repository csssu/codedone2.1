# @file ProblemOne.py
# @author amir aghazadeh (cssu.ama@gmail.com)
# @brief implement Queue with two Stacks
# @version 0.1.0
# @date 2022-07-29
# @id 1code2
# @copyright Copyright (c) 2022

from queue import LifoQueue

# declare two stack to use them in implementaion of queue
# تعریف کن پشته رو برای استفاده کردن تو پیاده سازی صف
stackOne = LifoQueue()
stackTwo = LifoQueue()

# test cases quantity
# تعداد تست کیس‌ها
testCases = int(input())

for i in range(0, testCases):
    queueSize = int(input())

    # get queue elements from user and push to stack one
    # عناصر رو از ورودی بگیر و به پشته اول اضافه کن
    temp = input()
    inputs = [int(iterator) for iterator in temp.split()]

    for j in range(0, queueSize):
        stackOne.put(inputs[j])

    # delete queue elements from stack one and add them to stack two
    # عناصر رو به ترتیب از پشته اول حذف کن و به پشته دوم اضافه کن
    while (not stackOne.empty()):
        stackTwo.put(stackOne.get())

    # print queue elements
    # عناصر صف رو چاپ کن
    while (not stackTwo.empty()):
        print(str(stackTwo.get()), end=" ")

    print()