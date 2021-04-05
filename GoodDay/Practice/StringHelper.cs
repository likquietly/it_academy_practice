using System;

namespace Practice
{
    static class StringHelper
    {
        public static string NewString(this String str)
        {
            if (str.Length > 5)
            {
                str = str.Substring(0, 5);
                str += "...";
            }
            return str;
        }
    }
}
