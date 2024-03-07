using NUnit.Framework;
using InventoryLibrary;

namespace InventoryManagement.Tests
{
    public class ItemTests
    {
        [Test]
        public void Item_Price_RoundedToTwoDecimalPlaces()
        {
            // Arrange
            Item item = new Item("Test Item");

            // Act
            item.price = 10.123f;

            // Assert
            Assert.AreEqual(10.12f, item.price);
        }
    }
}
