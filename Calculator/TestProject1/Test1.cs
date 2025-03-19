using calc;
namespace TestCalc {
    [TestClass]
    public sealed class Test1 {
        [TestMethod]
        public void TestAdd() {
            Calculator calculator = new Calculator();
            int result = calculator.add(2, 2);
            Assert.AreEqual(4, result);
        }
        [TestMethod]
        public void TestSubtract()
        {
            Calculator calculator = new Calculator();
            int result = calculator.subtract(5, 2);
            Assert.AreEqual(3, result);
        }
        [TestMethod]
        public void TestMultiply()
        {
            Calculator calculator = new Calculator();
            int result = calculator.multiply(4, 3);
            Assert.AreEqual(12, result);
        }
        [TestMethod]
        public void TestDivide()
        {
            Calculator calculator = new Calculator();
            float result = calculator.divide(5, 2);
            Assert.AreEqual(2.5f, result);
        }
        [TestMethod]
        public void TestSquare()
        {
            Calculator calculator = new Calculator();
            int result = calculator.square(3);
            Assert.AreEqual(9, result);
        }
    }
}
