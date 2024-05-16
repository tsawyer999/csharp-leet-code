namespace Exercices.UnitTests
{
    [TestClass]
    public class BracketValidatorTests
    {
        [TestMethod]
        public void ReturnFalseWhenInputIsNull()
        {
            var validator = new BracketValidator();
            var result = validator.IsValid(null);

            Assert.IsFalse(result);
        }

        [TestMethod]
        [DataRow("")]
        [DataRow(" ")]
        public void ReturnTrueWhenInputIsEmptyOrSpace(string input)
        {
            var validator = new BracketValidator();
            var result = validator.IsValid(input);

            Assert.IsTrue(result);
        }

        [TestMethod]
        [DataRow("()")]
        [DataRow("[]")]
        [DataRow("{}")]
        public void ReturnTrueWhenInputIsClosed(string input)
        {
            var validator = new BracketValidator();
            var result = validator.IsValid(input);

            Assert.IsTrue(result);
        }

        [TestMethod]
        [DataRow("(")]
        [DataRow("[")]
        [DataRow("{")]
        public void ReturnFalseWhenInputIsOpen(string input)
        {
            var validator = new BracketValidator();
            var result = validator.IsValid(input);

            Assert.IsFalse(result);
        }

        [TestMethod]
        [DataRow("([{}])")]
        [DataRow("[]{}()")]
        [DataRow("(((())))")]
        public void ReturnTrueWhenNestedIsClosed(string input)
        {
            var validator = new BracketValidator();
            var result = validator.IsValid(input);

            Assert.IsTrue(result);
        }

        [TestMethod]
        [DataRow("({)}")]
        [DataRow("[{}()")]
        [DataRow("(((()))")]
        public void ReturnFalseWhenNestedIsOpened(string input)
        {
            var validator = new BracketValidator();
            var result = validator.IsValid(input);

            Assert.IsFalse(result);
        }
    }
}
