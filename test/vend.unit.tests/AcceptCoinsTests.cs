using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;
using vend.cli;

namespace vend.unit.tests
{
    public class AcceptCoinsTests
    {
        private IList<Coin> _coins; 
        private VendingMachine _vendingMachine;
        
        public AcceptCoinsTests()
        {
            given_a_valid_coin();
            when_accepting_coins();
        }
        
        void given_a_valid_coin()
        {
            _coins = new List<Coin>{new Coin(Size.Large, Weight.Large)};
        }
        
        void when_accepting_coins()
        {
            _vendingMachine = new VendingMachine(new TextPrinter());
            _vendingMachine.Accept(_coins.First());
        }
        
        [Fact]
        public void then_the_amount_is_displayed()
        {
            Assert.Equal("0.50 Pence", _vendingMachine.Display());
        }
    }
}

