namespace Exercices.UnitTests
{
    [TestClass]
    public class TwoSumTests
    {
        [TestMethod("Returns indexes of first sum found")]
        public void ReturnsIndexesOfFirstSumFound()
        {
            var container = new[] { 1, 2, 3, 4, 5, 6 };
            var twoSum = new TwoSum();

            var result = twoSum.FindSum(container, 7);
            CollectionAssert.AreEqual(new[] { 0, 5 }, result);
        }

        [TestMethod("Returns emty array if no sum found")]
        public void ReturnsEmtyArrayIfNoSumFound()
        {
            var container = new[] { 1, 2, 3, 4, 5, 6 };
            var twoSum = new TwoSum();

            var result = twoSum.FindSum(container, 70);
            Assert.AreEqual(Array.Empty<int>(), result);
        }
        
        [TestMethod("Returns emty array if container contains less than two items")]
        [DataRow(new int[] { })]
        [DataRow(new[] { 7 })]
        public void ReturnsEmtyArrayIfContainerContainsLessThanTwoItems(int[] container)
        {
            var twoSum = new TwoSum();

            var result = twoSum.FindSum(container, 70);
            Assert.AreEqual(Array.Empty<int>(), result);
        }
    }
}