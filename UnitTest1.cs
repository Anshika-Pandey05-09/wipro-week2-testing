// The error CS0246 indicates that the namespace 'Assignment1_Day8' cannot be found.
// To fix this, ensure that the project containing the 'Calculator' class is referenced by your test project.
// If the reference is missing, add a project reference to 'Assignment1_Day8' in your test project's dependencies.
// If the reference exists, verify that the namespace and class name are correct and that the 'Calculator' class is public and accessible.

// No code changes are needed in this file unless the namespace or class name is incorrect.
// If the namespace is actually different, update the using directive accordingly.
// For example, if the correct namespace is 'Assignment1.Day8', change the using directive to:

// using Assignment1.Day8;

// If you are unsure of the correct namespace, please provide the file containing the 'Calculator' class for further assistance.
using CalculatorLibrary;

namespace CalculatorTests
{
    public class CalculatorTests
    {
        private Calculator calculator;

        [SetUp]
        public void Setup()
        {
            calculator = new Calculator();
        }

        [Test]
        public void Add_ValidInputs_ReturnsCorrectResult()
        {
            Assert.That(calculator.Add(2, 3), Is.EqualTo(5));
            Assert.That(calculator.Add(-2, 1), Is.EqualTo(-1));
            Assert.That(calculator.Add(0, 0), Is.EqualTo(0));
        }

    }

}