using Xunit;
using MathLibrary;
namespace MathLibrary.Tests;
 ///<summary>
/// تحتوي على اختبارات لدالة Multiply.
/// </summary>
public class CalculatorTests
{
    [Fact]
    public void Multiply_TwoPositiveNumbers_ReturnsCorrectResult()
    {
// Arrange 
 int a= 2, b = 3;
// Act
int result = Calculator.Multiply(a, b);
// Assert
Assert.Equal(6, result);
    }
[Fact]
public void Multiply_NumberWithZero_ReturnsZero()
{
// Arrange
int a = 0, b = 5;
// Act
int result = Calculator.Multiply(a, b);
// Assert
Assert.Equal(0, result);
}
[Fact]
public void Multiply_NegativeAndPositiveNumber_ReturnsNegative()
{
// Arrange
int a = -2, b = 3;
// Act
int result = Calculator.Multiply(a, b);
// Assert
Assert.Equal(-6, result);
}
[Fact]
public void Multiply_TwoNegativeNumbers_ReturnsPositive()
{
// Arrange
int a = -2, b = -3;
// Act
int result = Calculator.Multiply(a, b);
// Assert
Assert.Equal(6, result);
}
   // تحتوي على اختبارات لدالة Divide
[Fact]
public void Divide_TwoPositiveNumbers_ReturnsCorrectResult()
 {
// Arrange
 int a = 10, b = 2;
// Act
 int result = Calculator.Divide(a, b);
 // Assert
 Assert.Equal(5, result);
 }

[Fact]
 public void Divide_NegativeAndPositive_ReturnsNegative()
{
 // Arrangeint  // 
 int a= -6;int b = 2;
// Act
int result = Calculator.Divide(a, b);
// Assert
Assert.Equal(-3, result);
}

[Fact]
public void Divide_ByZero_ThrowsException()
{
// Arrange
int a = 7,b = 0;
// Act & Assert
Assert.Throws<DivideByZeroException>(() => Calculator.Divide(a, b));
}
// تحتوي على اختبارات لدالة IsEven
[Fact]
public void IsEven_EvenNumber_ReturnsTrue()
{
// Arrange
int a = 8;
// Act
bool result = Calculator.IsEven(a);
// Assert
Assert.True(result);
}

[Fact]
public void IsEven_OddNumber_ReturnsFalse()
{
 // Arrange
int a = 7;
  // Act
 bool result = Calculator.IsEven(a);
// Assert
 Assert.False(result);
 }

 [Fact]
 public void IsEven_Zero_ReturnsTrue()
 {
  // Arrange
  int a = 0;
  // Act
  bool result = Calculator.IsEven(a);
  // Assert
Assert.True(result);

        }
}
