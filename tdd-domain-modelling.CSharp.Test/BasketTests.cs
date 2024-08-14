using NUnit.Framework;
using System.Diagnostics.CodeAnalysis;
using System.Numerics;
using tdd_domain_modelling.CSharp.Main;

namespace tdd_domain_modelling.CSharp.Test
{
    [TestFixture]
    public class Basketest
    {
        // arrange
        [TestCase("Cucumber", 22)]
        public void TestAddToBasket(string product, int price)
        {
            //arrange
            bool expected = true;
            //act
            Basket basket = new Basket();
            if(basket.GetItems().Keys.Contains(product))
            {
                expected = false;
            }

            bool result = basket.Add(product, price);
            //assert
            Assert.That(result == expected);

        }



        [Test]
        public void TestTotalCost()
        {
            //arrange

            int cost = 37;
            string product = "meat";


            //act 
            Basket basket = new Basket();
            basket.Add(product, cost);

            Assert.That(basket.Total() == cost);
        }
    }
}