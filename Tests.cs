using System;
using Xunit;

namespace UnitTest1
{
    public class Tests
    {
        const string a1 = "A";
        const string b1 = "B";
        const string a2 = "a";
        const string b2 = "b";
        const string a3 = "ABHJFDPBOIUSBVAURHV";
        const string b3 = "FDJHVNJFLKDLKJFVNJJJFVKHBSKHV";
        Functions tests = new Functions();
        [Fact]
        public void TestStrings1()
        {
            Assert.Equal(tests.SumStrings(a1, b1), a1 + b1);
        }
        [Fact]
        public void TestStrings2()
        {
            Assert.Equal(tests.SumStrings(a2, b2), a2 + b2);
        }
        [Fact]
        public void TestStrings3()
        {
            Assert.Equal(tests.SumStrings(a3, b3), a3 + b3);
        }
    }
}