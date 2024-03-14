using NUnit.Framework;

namespace MyDevOpsProject.Tests
{
    [TestFixture]
    public class CalculatorTests
    {
      
       
            [Test]
            public static void Add_twopositive()
            {
                // arrange

                Calculator c1 = new Calculator();
                // act
                int result = c1.Add(2, 3);
                //Assert

                Assert.That(result, Is.EqualTo(5));
            }


            [Test]

            public static void Divide_Zero()
            {
                // Arrange
                Calculator c1 = new Calculator();

                // Act and Assert combined
                Assert.That(() => c1.Divide(2, 0), Throws.TypeOf<DivideByZeroException>());

            }
            [Test]
            public static void FillArray_ExpectedTrue()
            {

                Calculator c1 = new Calculator();
                int[] x = new int[6];
                c1.FillArray(x);
                Assert.That(x, Is.EqualTo(new int[] { 8, 9, 9, 9, 9, 9 }));
            }
        }
}