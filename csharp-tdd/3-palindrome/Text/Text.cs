using System.Collections.Generic;
using System.Collections;
using System;

namespace Text
{
    
    public class Str
    {
        /// <summary>
        /// if string is palidrome
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static bool IsPalindrome(string s)
        {
            if (s == string.Empty || s == " ")
            {
                return true;
            }
            
            string orignal = s.ToLower();
            IEnumerable<char> reverseOriginal = s.Reverse();
            string OriginalLast = null;
            string OriginalFirst = null;
            
           
            foreach (char l in reverseOriginal)
            {
                if (l == ' ')
                {
                    continue;
                }
                OriginalLast += l;
            }

            foreach (char f in orignal)
            {
                if (f == ' ')
                {
                    continue;
                }
                else
                {
                    OriginalFirst += f;
                }
            }

            if (OriginalFirst == OriginalLast.ToLower())
            {
                return true;
            }

            return false;
        }
    }
}

