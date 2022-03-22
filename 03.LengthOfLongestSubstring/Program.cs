using System;
using System.Collections.Generic;

namespace _03.LengthOfLongestSubstring
{
    class Program
    {

        static void Main(string[] args)
        {
            //给定一个字符串 s ，请你找出其中不含有重复字符的 最长子串 的长度。

            //输入: s = "abcabcbb"
            //输出: 3
            //解释: 因为无重复字符的最长子串是 "abc"，所以其长度为 3。

            string s = "abcabcbb";

            var len = LengthOfLongestSubstring(s);
            Console.WriteLine("最大长度：" + len);

            Console.WriteLine("03.LengthOfLongestSubstring");
        }

        public static int LengthOfLongestSubstring(string s)
        {
            List<char> ls = new List<char>();
            int n = s.Length;
            int intMaxLength = 0;

            for (int i = 0; i < n; i++)
            {
                if (ls.Contains(s[i]))
                {
                    //移除掉
                    ls.RemoveRange(0, ls.IndexOf(s[i]) + 1);
                }
                ls.Add(s[i]);
                intMaxLength = ls.Count > intMaxLength ? ls.Count : intMaxLength;
            }
            return intMaxLength;
        }
    }
}
