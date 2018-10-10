using System;
using Xunit;
using LAB02_UnitTesting;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void CannotWithdrawMoreThanBalance()
        {
            //arrange
            Program.balance = 300.00;
            //act
            //assert
            Assert.Equal(300, Program.Withdraw(301));
        }

        [Fact]
        public void CanDeposit50Dollars()
        {
            //arrange
            Program.balance = 300.00;
            //act
            //assert
            Assert.Equal(350, Program.Deposit(50.00));
        }

        [Fact]
        public void CanWithdraw5Dollars()
        {
            //arrange
            Program.balance = 300.00;
            //act
            //assert
            Assert.Equal(295.00, Program.Withdraw(5.00));
        }

        [Fact]
        public void CannotDepositNegativeDollars()
        {
            //arrange
            Program.balance = 300.00;
            //act
            //assert
            Assert.Equal(300.00, Program.Deposit(-50.00));
        }
    }


}
