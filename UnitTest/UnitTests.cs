using System;
using AppVeyorTest;
using Xunit;

namespace UnitTest
{
    public class UnitTests
    {
        [Fact]
        public void IsCredentialsValid_ShouldReturnFalse()
        {
            var service = new UserService();
            var result = service.IsCredentialsValid("admin", "123");
            Assert.False(result);
        }
        
        [Fact]
        public void IsCredentialsValid_ShouldReturnTrue()
        {
            var service = new UserService();
            var result = service.IsCredentialsValid("admin", "admin");
            Assert.False(result);
        }
    }
}