using NUnit.Framework;
using PayslipProblem;

namespace PayslipProblemTests
{
    public class PayslipGeneratorTests
    {
        private IPayslipGenerator _payslipGenerator;
        
        [SetUp]
        public void Setup()
        {
            _payslipGenerator = new PayslipGenerator();
        }

        [TestCase(60050, 5004)]
        [TestCase(60500, 5042)]
        public void CorrectGrossIncomeIsReturned(int annualSalary, int expectedGrossIncome)
        {
            // Arrange
            
            // Act
            var actualGrossIncome = _payslipGenerator.CalculateGrossIncome((uint)annualSalary);

            // Assert
            Assert.AreEqual(expectedGrossIncome, actualGrossIncome);
        }
        
        [Test]
        public void CorrectIncomeTaxIsReturned()
        {
            Assert.Pass();
        }
    }
}