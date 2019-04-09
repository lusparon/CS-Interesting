using Microsoft.VisualStudio.TestTools.UnitTesting;
using RecursionTasks;

namespace RecursionTests
{
	[TestClass]
	public class Exercise01Tests
	{
		[TestMethod]
		public void TestMinValue()
		{
			var actualResult = Exercise01.Run(1);
			Assert.AreEqual("1", actualResult);
		}

		[TestMethod]
		public void TestTwoDigitsValue()
		{
			var actualResult = Exercise01.Run(11);
			Assert.AreEqual("1 2 3 4 5 6 7 8 9 10 11", actualResult);
		}

		[TestMethod]
		public void TestInvalidValue()
		{
			var actualResult = Exercise01.Run(0);
			Assert.AreEqual(string.Empty, actualResult);
		}

		[TestMethod]
		public void TestNegativeValue()
		{
			var actualResult = Exercise01.Run(-5);
			Assert.AreEqual(string.Empty, actualResult);
		}
	}
}
