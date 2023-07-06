using CoffeeShop.Model;
namespace CoffeeShop.Tests
{
    public class ItemTests
    {
        [Fact]
        public void Item_Constructor_CreatesCorrectNameProperty()
        {
            var itemName = "Cappuccino";
            var itemPriceInCents = 400;

            var testItem = new Item(itemName, itemPriceInCents);

            Assert.Equal(itemName, testItem.Name);
        }
        [Fact]
        public void Item_Constructor_CreatesCorrectPropPriceInCentserty()
        {
            var itemName = "Cappuccino";
            var itemPriceInCents = 400;

            var testItem = new Item(itemName, itemPriceInCents);

            Assert.Equal(itemPriceInCents, testItem.PriceInCents);
        }
        [Fact]
        public void Item_PriceInDollars_ReturnsCorrectDouble()
        {
            var itemName = "Cappuccino";
            var itemPriceInCents = 400;

            var testItem = new Item(itemName, itemPriceInCents);

            Assert.Equal(4.00D, testItem.PriceInDollars());
        }
    }
}