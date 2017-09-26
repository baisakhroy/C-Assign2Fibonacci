using System;
using C_assignment2_b;
using Xunit;

namespace FibinocciTestFolder
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            //Arrange
            Fibonacci obj =  new Fibonacci();
            //Act
            var x = obj.letsgetitstarted(5);
            //Assert
            Assert.IsType<int>(x);
            Assert.Equal(7,x);
        }
    }
}
