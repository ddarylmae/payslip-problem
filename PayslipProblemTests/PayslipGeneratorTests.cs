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
        
        [TestCase(0, 0)]
        [TestCase(10000, 0)]
        [TestCase(18200, 0)]
        [TestCase(18201, 0)]
        [TestCase(25000, 4864)]
        [TestCase(37000, 3572)]
        [TestCase(37001, 3572)]
        [TestCase(50000, 7797)]
        [TestCase(87000, 19822)]
        [TestCase(87001, 19822)]
        [TestCase(100000, 24632)]
        [TestCase(180000, 54232)]
        [TestCase(180001, 54232)]
        [TestCase(200000, 63232)]
        public void CorrectIncomeTaxIsReturned(int grossIncome, int expectedNetIncome)
        {
            // Arrange
            
            // Act
            var actualNetIncome = _payslipGenerator.CalculateIncomeTax((uint)grossIncome);

            // Assert
            Assert.AreEqual(expectedNetIncome, actualNetIncome);
        }
    }
}