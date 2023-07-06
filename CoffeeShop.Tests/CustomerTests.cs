using CoffeeShop.Model;
namespace CoffeeShop.Tests
{
    public class CustomerTests
    {
        [Fact]
        public void Customer_Constructor_CreatesCustomerObjectWithCorrectNameProperty()
        {
            var customerName = "Taylor";

            var testCustomer = new Customer(customerName);

            Assert.Equal(customerName, testCustomer.Name);
        }

        [Fact]
        public void Customer_Constructor_CreatesCustomerObjectWithEmptyOrdersList()
        {
            var customerName = "Taylor";

            var testCustomer = new Customer(customerName);

            Assert.Empty(testCustomer.Orders);
            Assert.IsType<List<Order>>(testCustomer.Orders);
        }

        [Fact]
        public void Customer_AddOrder_AddsGivenOrderToOrdersList()
        {
            var order = new Order();

            var itemName = "Cappuccino";
            var itemPriceInCents = 400;

            var item = new Item(itemName, itemPriceInCents);

            order.AddItem(item);

            itemName = "Frappuccino";
            itemPriceInCents = 550;

            item = new Item(itemName, itemPriceInCents);

            order.AddItem(item);

            var customerName = "Taylor";

            var testCustomer = new Customer(customerName);

            testCustomer.AddOrder(order);

            Assert.Single(testCustomer.Orders);
            Assert.Equal(order, testCustomer.Orders.First());
        }

        [Fact]
        public void Customer_TotalSpent_ReturnsSumOfTotalsForEachOrderAsADouble()
        {
            var order = new Order();

            var itemName = "Cappuccino";
            var itemPriceInCents = 400;

            var item = new Item(itemName, itemPriceInCents);

            order.AddItem(item);

            itemName = "Frappuccino";
            itemPriceInCents = 550;

            item = new Item(itemName, itemPriceInCents);

            order.AddItem(item);

            var customerName = "Taylor";

            var testCustomer = new Customer(customerName);

            testCustomer.AddOrder(order);

            order = new Order();

            itemName = "Snappuccino";
            itemPriceInCents = 386;

            item = new Item(itemName, itemPriceInCents);

            order.AddItem(item);

            itemName = "Cappuccino";
            itemPriceInCents = 720;

            item = new Item(itemName, itemPriceInCents);

            order.AddItem(item);

            testCustomer.AddOrder(order);

            Assert.Equal(20.56D, testCustomer.TotalSpent());
        }

        [Fact]
        public void Customer_ItemsOrdered_ReturnsListOfUniqueItemNamesFromAllOrders()
        {
            var order = new Order();

            var itemName = "Cappuccino";
            var itemPriceInCents = 400;

            var item = new Item(itemName, itemPriceInCents);

            order.AddItem(item);

            itemName = "Frappuccino";
            itemPriceInCents = 550;

            item = new Item(itemName, itemPriceInCents);

            order.AddItem(item);

            var customerName = "Taylor";

            var testCustomer = new Customer(customerName);

            testCustomer.AddOrder(order);

            order = new Order();

            itemName = "Snappuccino";
            itemPriceInCents = 386;

            item = new Item(itemName, itemPriceInCents);

            order.AddItem(item);

            itemName = "Cappuccino";
            itemPriceInCents = 720;

            item = new Item(itemName, itemPriceInCents);

            order.AddItem(item);

            testCustomer.AddOrder(order);

            var expectedList = new List<string> { "Cappuccino", "Frappuccino", "Snappuccino" };

            Assert.Equal(expectedList, testCustomer.ItemsOrdered());
        }
    }
}