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
        [TestCase(25000, 108)]
        [TestCase(37000, 298)]
        [TestCase(37001, 298)]
        [TestCase(60050, 922)]
        [TestCase(87000, 1652)]
        [TestCase(87001, 1652)]
        [TestCase(100000, 2053)]
        [TestCase(180000, 4519)]
        [TestCase(180001, 4519)]
        [TestCase(200000, 5269)]
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