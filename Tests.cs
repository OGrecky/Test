using System;
using Xunit;

namespace UnitTest1
{
    public class Tests
    {
        private const string Five = "5";
        private const string Three = "3";
        Functions func = new Functions();
        [Fact]
        public void WhenPeopleWriteNormalThings()
        {
            var result = func.Sum(Five, Three);
            int correct = int.Parse(Five) + int.Parse(Three);
            Assert.Equal(correct, result); // Firat parameter in Assert.Equal is 'Expected', the second is 'Actual'
        }
        private const string t2_1 = "ABCD"; // Test2_1st string
        private const string t2_2 = "BHD";
        [Fact]
        public void WhenPeopleWriteWeirdThings()
        {
            var result = func.Sum(t2_1, t2_2);
            int correct = 0;
            Assert.Equal(correct, result);
        }
        private const string t3_1 = "10000000000";
        private const string t3_2 = "20000000000";

        public void WhenNumbersAreTooBig()
        {
            var result = func.Sum(t3_1, t3_2);
            long correct = long.Parse(t3_1) + long.Parse(t3_2);
            Assert.Equal(correct, result);
        }
    }
}