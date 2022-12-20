using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moq;
using SimpleProject.Entities;

namespace TestProject1
{
    public class PowerServiceTests
    {
        [Test]
        public void AddPowerToNumber_PositiveNumberPositivePower()
        {
            var mock = new Mock<MultiplierService>();

            mock.Setup(multiplier => multiplier.MultiplyTwoNumbers(1, 5)).Returns(5);
            mock.Setup(multiplier => multiplier.MultiplyTwoNumbers(5, 5)).Returns(25);
            mock.Setup(multiplier => multiplier.MultiplyTwoNumbers(25, 5)).Returns(125);
            mock.Setup(multiplier => multiplier.MultiplyTwoNumbers(125, 5)).Returns(625);


            var service = new PowerService(mock.Object);

            int number = 5;
            int power = 4;

            int total = service.AddPowerToNumber(number, power);

            Assert.AreEqual(625, total);
        }

        
        [Test]
        public void AddPowerToNumber_ZeroNumberPositiveNumber()
        {
            var mock = new Mock<MultiplierService>();
            mock.Setup(multiplier => multiplier.MultiplyTwoNumbers(0, 0)).Returns(0);

            var service = new PowerService(mock.Object);

            int number = 0;
            int power = 6;

            int total = service.AddPowerToNumber(number, power);

            Assert.AreEqual(0, total);
        }


        [Test]
        public void AddPowerToNumber_PositiveNumberPowerZero()
        {
            var mock = new Mock<MultiplierService>();
            mock.Setup(multiplier => multiplier.MultiplyTwoNumbers(1, 6)).Returns(6);


            var service = new PowerService(mock.Object);

            int number = 6;
            int power = 0;

            int total = service.AddPowerToNumber(number, power);

            Assert.AreEqual(1, total);
        }

        [Test]
        public void AddPowerToNumber_OneNumberPositivePower()
        {
            var mock = new Mock<MultiplierService>();

            mock.Setup(multiplier => multiplier.MultiplyTwoNumbers(1, 1)).Returns(1);


            var service = new PowerService(mock.Object);

            int number = 1;
            int power = 6;

            int total = service.AddPowerToNumber(number, power);

            Assert.AreEqual(1, total);
        }


        [Test]
        public void AddPowerToNumber_PositiveNumber_PowerOfOne()
        {
            var mock = new Mock<MultiplierService>();

            mock.Setup(multiplier => multiplier.MultiplyTwoNumbers(1, 6)).Returns(6);


            var service = new PowerService(mock.Object);

            int number = 6;
            int power = 1;

            int total = service.AddPowerToNumber(number, power);

            Assert.AreEqual(6, total);
        }


    }
}
