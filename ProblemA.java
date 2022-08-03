/**
 * @file ProblemOne.java
 * @author amir aghazadeh (cssu.ama@gmail.com)
 * @brief implement Queue with two Stacks
 * @version 0.1.0
 * @date 2022-07-25
 * @id 1code2
 *
 * @copyright Copyright (c) 2022
 *
 */

import java.util.Stack;
import java.util.Scanner;

public class ProblemOne {

  // declare two stack to use them in implementaion of queue
  // تعریف کن پشته رو برای استفاده کردن تو پیاده سازی صف
  static Stack<Integer> stackOne = new Stack<Integer>();
  static Stack<Integer> stackTwo = new Stack<Integer>();

  public static void main(String[] args) {
    var scanner = new Scanner(System.in);

    // test cases quantity
    // تعداد تست کیس‌ها
    int testCases = scanner.nextInt();

    for (int i = 0; i < testCases; i++) {
      int queueSize = scanner.nextInt();

      // get queue elements from user and push to stack one
      // عناصر رو از ورودی بگیر و به پشته اول اضافه کن
      for (int j = 0; j < queueSize; j++) {
        int newQueueInput = scanner.nextInt();
        stackOne.push(newQueueInput);
      }

      // delete queue elements from stack one and add them to stack two
      // عناصر رو به ترتیب از پشته اول حذف کن و به پشته دوم اضافه کن
      while (!stackOne.empty()) {
        stackTwo.push((int) stackOne.pop());
      }

      // print queue elements
      // عناصر صف رو چاپ کن
      while (!stackTwo.empty()) {
        System.out.print(stackTwo.pop() + " ");
      }

      System.out.println();
    }

    scanner.close();
  }
}