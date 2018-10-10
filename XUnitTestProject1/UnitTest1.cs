using System;
using Xunit;
using LAB02_UnitTesting;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void CanWithdrawMoreThanBalance()
        {
            //arrange
            //act
            //assert
            Assert.Equal(300, Program.Withdraw(301));
        }
    }

    public class UnitTest2
    {
        [Fact]
        public void CanWithdraw5Dollars()
        {
            //arrange
            //act
            //assert
            Assert.Equal(295.00, Program.Withdraw(5.00));
        }
    }
}
