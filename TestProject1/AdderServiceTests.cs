using SimpleProject.Entities;

namespace TestProject1
{
	public class AdderServiceTests
	{
		[SetUp]
		public void Setup()
		{
		}

		// Arrage, Act and Assert
		// Arrange set it all up 
		// Act 
		// Assert testing or asserting the values

		[Test]
		public void AddTwoNumbers_Postive()
		{
			int val1 = 2;
			int val2 = 4;
			var service = new AdderService();
			int total = service.AddTwoNumbers(val1, val2);

			Assert.AreEqual(6, total);
		}

		[Test]
		public void AddTwoNumbers_Negative()
		{
			int val1 = -2;
			int val2 = -4;
			var service = new AdderService();
			int total = service.AddTwoNumbers(val1, val2);

			Assert.AreEqual(-6, total);
		}

		[Test]
		public void AddTwoNumbers_PositveAndNegative()
		{
			int val1 = -2;
			int val2 = 4;
			var service = new AdderService();
			int total = service.AddTwoNumbers(val1, val2);

			Assert.AreEqual(2, total);
		}
	}
}