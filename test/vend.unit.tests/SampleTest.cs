using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;
using vend.cli;

namespace vend.unit.tests
{
    // see example explanation on xUnit.net website:
    // https://xunit.github.io/docs/getting-started-dnx.html
    public class SampleTest
    {
        [Fact]
        public void should_have_a_value_of_ten_pence_when_size_and_weight_are_small()
        {
            var smallCoin = new Coin(Size.Small, Weight.Small);
            Assert.Equal(0.10m, smallCoin.Value());
        }
        
        [Fact]
        public void should_have_a_value_of_twenty_pence_when_size_and_weight_are_medium()
        {
            var smallCoin = new Coin(Size.Medium, Weight.Medium);
            Assert.Equal(0.20m, smallCoin.Value());
        } 
        
        [Fact]
        public void should_have_a_value_of_fifty_pence_when_size_and_weight_are_large()
        {
            var smallCoin = new Coin(Size.Large, Weight.Large);
            Assert.Equal(0.50m, smallCoin.Value());
        } 
        

    }
}
