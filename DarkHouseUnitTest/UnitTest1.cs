using NUnit.Framework;
using DarkHouse.Inventory.HouseHoldItem;

namespace DarkHouseUnitTest
{
    public class Tests
    {
        private Refrigerator rf;

        [SetUp]
        public void Setup()
        {
            rf = new Refrigerator("Sharp 1", "Refrigerator 1", "Sharp Refrigerator no. 1");
            rf.Close();
        }

        [Test]
        public void Test1()
        {
            if (!rf.IsOpen)
            {
                if (rf.Open())
                {
                    Assert.Pass($"Successfully opened {rf.Name}'s door.");
                }
                else
                {
                    Assert.Fail($"Fail to open {rf.Name}.");
                }    
            }
            else
            {
                Assert.Pass($"{rf.Name}'s door is already opened.");
            }
        }

        [Test]
        public void Test2()
        {
            if (rf.IsOpen)
            {
                if (rf.Close())
                {
                    Assert.Pass($"Successfully closed {rf.Name}'s door.");
                }
                else
                {
                    Assert.Fail($"Fail to close {rf.Name}.");
                }
            }
            else
            {
                Assert.Pass($"{rf.Name}'s door is already closed.");
            }
        }
    }
}
