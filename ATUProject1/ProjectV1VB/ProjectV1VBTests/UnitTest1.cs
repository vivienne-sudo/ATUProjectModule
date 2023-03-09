namespace ProjectV1VBTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            // Arrange
            int x = 1;
            int y = 2;

            // Act
            int result = x + y;

            // Assert
            Assert.AreEqual(3, result);
        }
    }
}