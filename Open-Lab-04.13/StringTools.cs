using System;

namespace Open_Lab_04._13
{
    public class StringTools
    {
        public string GetLongestCommonSequence(string str1, string str2)
        {
            string ret = "";
            string compare = "";
            for (int i = 0; i < str1.Length; i++)
            {
                for (int y = 0; y < str1.Length - i; y++)
                {
                    compare = str1.Substring(i, y);
                    if (str2.Contains(compare))
                    {
                        if (compare.Length > ret.Length)
                            ret = compare;
                    }
                }
            }

            return ret;
        }
    }
}
