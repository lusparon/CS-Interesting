using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RecursionTasks;

namespace RecursionTests
{
	[TestClass]
	public class Exercise03Tests
	{
		[TestMethod]
		public void TestEqualValues()
		{
			var actualResult = Exercise03.Run(10, 10);
			Assert.AreEqual("10", actualResult);
		}

		[TestMethod]
		public void TestNormalValues()
		{
			var actualResult = Exercise03.Run(15, 20);
			Assert.AreEqual("15 16 17 18 19 20", actualResult);
		}

		[TestMethod]
		public void TestFlippedValues()
		{
			var actualResult = Exercise03.Run(20, 15);
			Assert.AreEqual("15 16 17 18 19 20", actualResult);
		}

		[TestMethod]
		public void TestNegativeValues()
		{
			var actualResult = Exercise03.Run(-3, -1);
			Assert.AreEqual("-3 -2 -1", actualResult);
		}

		[TestMethod]
		public void TestFromPositiveToNegative()
		{
			var actualResult = Exercise03.Run(3, -1);
			Assert.AreEqual("-1 0 1 2 3", actualResult);
		}
	}
}
