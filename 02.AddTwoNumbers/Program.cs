using System;

namespace _02.AddTwoNumbers
{


    class Program
    {
        //给你两个 非空 的链表，表示两个非负的整数。它们每位数字都是按照 逆序 的方式存储的，并且每个节点只能存储 一位 数字。
        //请你将两个数相加，并以相同形式返回一个表示和的链表。
        //你可以假设除了数字 0 之外，这两个数都不会以 0 开头。


        static void Main(string[] args)
        {
            //输入：l1 = [2, 4, 3], l2 = [5, 6, 4]
            //输出：[7,0,8]
            //解释：342 + 465 = 807.

            var l1 = new ListNode(2)
            {
                next = new ListNode(4)
                {
                    next = new ListNode(3)
                }
            };

            var l2 = new ListNode(5)
            {
                next = new ListNode(6)
                {
                    next = new ListNode(4)
                }
            };

            var ln = AddTwoNumbers(l1, l2);

            string str = "";
            while (ln != null)
            {
                str += ln.val;

                if (ln != null)
                    ln = ln.next;
            }

            Console.WriteLine(str);

            Console.WriteLine("02.AddTwoNumbers");
        }

        public static ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            int carry = 0;
            ListNode head = null, tail = null;
            while (l1 != null || l2 != null)
            {
                int n1 = l1 != null ? l1.val : 0;
                int n2 = l2 != null ? l2.val : 0;

                int sum = n1 + n2 + carry;
                if (head == null)
                {
                    //重点 head tail 指向同一个地址，tail改变head也改变
                    head = tail = new ListNode(sum % 10);
                }
                else
                {
                    tail.next = new ListNode(sum % 10);
                    tail = tail.next;
                }
                carry = sum / 10;

                if (l1 != null)
                    l1 = l1.next;
                if (l2 != null)
                    l2 = l2.next;
            }

            if (carry > 0)
                tail.next = new ListNode(1);

            return head;
        }
    }

    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
    }

}
