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
            var actualGrossIncome = _payslipGenerator.CalculateGrossIncome(annualSalary);

            // Assert
            Assert.AreEqual(expectedGrossIncome, actualGrossIncome);
        }
        
        [TestCase(0, 0)]
        [TestCase(10000, 0)]
        [TestCase(18200, 0)]
        [TestCase(18201, 0)]
        [TestCase(25000, 1292)]
        [TestCase(37000, 3572)]
        [TestCase(37001, 3572)]
        [TestCase(50000, 7797)]
        [TestCase(87000, 19822)]
        [TestCase(87001, 19822)]
        [TestCase(100000, 24632)]
        [TestCase(180000, 54232)]
        [TestCase(180001, 54232)]
        [TestCase(200000, 63232)]
        public void CorrectIncomeTaxIsReturned(int grossIncome, int expectedIncomeTax)
        {
            // Arrange
            
            // Act
            var actualIncomeTax = _payslipGenerator.CalculateIncomeTax(grossIncome);

            // Assert
            Assert.AreEqual(expectedIncomeTax, actualIncomeTax);
        }

        [TestCase(1517, 0, 1517)]
        [TestCase(5004, 922, 4082)]
        public void CorrectNetIncomeIsReturned(int grossIncome, int incomeTax, int expectedNetIncome)
        {
            // Arrange
            
            // Act
            var actualNetIncome = _payslipGenerator.CalculateNetIncome(grossIncome, incomeTax);

            // Assert
            Assert.AreEqual(expectedNetIncome, actualNetIncome);
        }

        [TestCase(5004, 9, 450)]
        public void CorrectSuperIsReturned(int grossIncome, float superRate, int expectedSuper)
        {
            // Arrange
            
            // Act
            var actualSuper = _payslipGenerator.CalculateSuper(grossIncome, superRate);

            Assert.AreEqual(expectedSuper, actualSuper);
        }
    }
}