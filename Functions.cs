using System;
namespace UnitTest1
{
    public class Functions
    {
        public int Sum(string x, string y)
        {
            int a, b;
            bool p = int.TryParse(x, out a);
            bool q = int.TryParse(y, out b);
            if (!(p && q)) return 0;
            return a + b;
        }
    }
}