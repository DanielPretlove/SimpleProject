using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moq;
using SimpleProject.Entities;

namespace TestProject1
{
	public class MultiplerServiceTests
	{
		[Test]
		public void MultiplyTwoNumbers_PositiveAndPositive()
		{
			// ARRANGE
			var mock = new Mock<AdderService>();

			mock.Setup(adder => adder.AddTwoNumbers(0, 2)).Returns(2);
			mock.Setup(adder => adder.AddTwoNumbers(2, 2)).Returns(4);
			mock.Setup(adder => adder.AddTwoNumbers(4, 2)).Returns(6);
			mock.Setup(adder => adder.AddTwoNumbers(6, 2)).Returns(8);

            var service = new MultiplierService(mock.Object);

			int num1 = 2;
			int num2 = 4;


			// ACT
			int total = service.MultiplyTwoNumbers(num1, num2);

			Assert.AreEqual(8, total);

		}

		[Test]
		public void MultiplyTwoNumbers_PositiveAndNegative()
		{
            var mock = new Mock<AdderService>();


            mock.Setup(adder => adder.AddTwoNumbers(0, 2)).Returns(2);
            mock.Setup(adder => adder.AddTwoNumbers(2, 2)).Returns(4);
            mock.Setup(adder => adder.AddTwoNumbers(4, 2)).Returns(6);
            mock.Setup(adder => adder.AddTwoNumbers(6, 2)).Returns(8);
            mock.Setup(adder => adder.AddTwoNumbers(8, 2)).Returns(10);

            var service = new MultiplierService(mock.Object);

			int num1 = 2;
			int num2 = -5;

			int total = service.MultiplyTwoNumbers(num1, num2);

			Assert.AreEqual(-10, total);
		}

		[Test]
		public void MultiplyTwoNumbers_NegativeAndPositive()
		{
			var mock = new Mock<AdderService>();
			
			mock.Setup(adder => adder.AddTwoNumbers(0, -3)).Returns(-3);
			mock.Setup(adder => adder.AddTwoNumbers(-3, -3)).Returns(-6);
            mock.Setup(adder => adder.AddTwoNumbers(-6, -3)).Returns(-9);
            mock.Setup(adder => adder.AddTwoNumbers(-9, -3)).Returns(-12);

            var service = new MultiplierService(mock.Object);

			int num1 = -3;
			int num2 = 4;

			int total = service.MultiplyTwoNumbers(num1, num2);

			Assert.AreEqual(-12, total);
		}

		[Test]
		public void MultiplyTwoNumbers_NegativeAndNegative()
		{
			var mock = new Mock<AdderService>();

			mock.Setup(adder => adder.AddTwoNumbers(0, -3)).Returns(-3);
			mock.Setup(adder => adder.AddTwoNumbers(-3, -3)).Returns(-6);
			mock.Setup(adder => adder.AddTwoNumbers(-6, -3)).Returns(-9);
			mock.Setup(adder => adder.AddTwoNumbers(-9, -3)).Returns(-12);
			mock.Setup(adder => adder.AddTwoNumbers(-12, -3)).Returns(-15);


            var service = new MultiplierService(mock.Object);

			int num1 = -3;
			int num2 = -5;

			int total = service.MultiplyTwoNumbers(num1, num2);


			Assert.AreEqual(15, total);
		}

		[Test]
		public void MultiplyTwoNumbers_ZeroAndPositive()
		{
			var mock = new Mock<AdderService>();

            mock.Setup(adder => adder.AddTwoNumbers(0, 0)).Returns(0);


            var service = new MultiplierService(mock.Object);

			int num1 = 0;
			int num2 = 2;

			int total = service.MultiplyTwoNumbers(num1, num2);


			Assert.AreEqual(0, total);
		}

		[Test]
		public void MultiplyTwoNumbers_ZeroAndNegative()
		{
			var mock = new Mock<AdderService>();
            mock.Setup(adder => adder.AddTwoNumbers(0, 0)).Returns(0);

            var service = new MultiplierService(mock.Object);

			int num1 = 0;
			int num2 = -3;

			int total = service.MultiplyTwoNumbers(num1, num2);


			Assert.AreEqual(0, total);
		}

		[Test]
		public void MultiplyTwoNumbers_Positive_ZeroReverse()
		{
            var mock = new Mock<AdderService>();

            var service = new MultiplierService(mock.Object);

			int num1 = 3;
			int num2 = 0;

			int total = service.MultiplyTwoNumbers(num1, num2);


			Assert.AreEqual(0, total);
		}
	}
}
