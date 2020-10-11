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
            //Write here now
        }
    }
}