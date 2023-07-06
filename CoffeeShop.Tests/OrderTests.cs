using CoffeeShop.Model;
namespace CoffeeShop.Tests
{
    public class OrderTests
    {
        [Fact]
        public void Order_Constructor_CreatesEmptyItemList()
        {
            var testOrder = new Order();

            Assert.Empty(testOrder.Items);
            Assert.IsType<List<Item>>(testOrder.Items);
        }

        [Fact]
        public void Order_AddItem_AddsGivenItemToItems()
        {
            var itemName = "Cappuccino";
            var itemPriceInCents = 400;

            var item = new Item(itemName, itemPriceInCents);

            var testOrder = new Order();

            testOrder.AddItem(item);
            Assert.Single(testOrder.Items);
            Assert.Equal(item, testOrder.Items.First());
        }

        [Fact]
        public void Order_Total_ReturnsTotalCostInDollarsAsDouble()
        {
            var testOrder = new Order();

            var itemName = "Cappuccino";
            var itemPriceInCents = 400;

            var item = new Item(itemName, itemPriceInCents);

            testOrder.AddItem(item);

            itemName = "Frappuccino";
            itemPriceInCents = 550;

            item = new Item(itemName, itemPriceInCents);

            testOrder.AddItem(item);

            Assert.Equal(9.50D, testOrder.Total());
        }
    }
}