using System;
using Xunit;

namespace UnitTest1
{
    public class Tests
    {
        private const string Five = "5";
        private const string Three = "3";
        [Fact]
        public void WhenPeopleWriteSomeWeirdThing()
        {
            Functions func = new Functions();
            var result = func.Sum(Five, Three);

        }
    }
}