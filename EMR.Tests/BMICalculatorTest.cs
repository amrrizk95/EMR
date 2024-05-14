using EMR.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMR.Tests
{
	public class BMICalculatorTest
	{
		[Fact]
		// to name the function in unit testing (functionName_condition_expectedResult(not value except if result is bool))
		public void CalculateBMI_WhenHeightIsGreaterThanZeroAndWeightIsZero_ShouldReturnZero()
		{
			// Arrang
			var sut=new BMICalculator();
			//Act 
			var result = sut.CalculateBMI(1.78, 0);
			//Assert
			Assert.Equal(0, result);
		}
		[Fact]

		public void CalculateBMI_WhenWeightIsGreaterThanZeroAndHeightIsZero_ShouldReturnZero()
		{
			// Arrang
			var sut = new BMICalculator();
			//Act 
			var result = sut.CalculateBMI(0, 80);
			//Assert
			Assert.Equal(0, result);
		}

		[Fact]

		public void CalculateBMI_WhenWeightIsZeroAndHeightIsZero_ShouldReturnZero()
		{
			// Arrang
			var sut = new BMICalculator();
			//Act 
			var result = sut.CalculateBMI(0, 0);
			//Assert
			Assert.Equal(0, result);
		}
		[Fact]

		public void CalculateBMI_WhenWeightIsNotZeroAndHeightIsNotZero_ShouldCalculateConrrectly()
		{
			// Arrang
			var sut = new BMICalculator();
			//Act 
			var result =Math.Round( sut.CalculateBMI(1.78, 80),2);
			//Assert
			Assert.Equal(25.25, result);
		}
	}
}
