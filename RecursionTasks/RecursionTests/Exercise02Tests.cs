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
	public class Exercise02Tests
	{
		[TestMethod]
		public void TestEqualValues()
		{
			var actualResult = Exercise02.Run(10, 10);
			Assert.AreEqual("10", actualResult);
		}

		[TestMethod]
		public void TestNormalValues()
		{
			var actualResult = Exercise02.Run(15, 20);
			Assert.AreEqual("15 16 17 18 19 20", actualResult);
		}

		[TestMethod]
		public void TestFlippedValues()
		{
			var actualResult = Exercise02.Run(20, 15);
			Assert.AreEqual("20 19 18 17 16 15", actualResult);
		}

		[TestMethod]
		public void TestNegativeValues()
		{
			var actualResult = Exercise02.Run(-3, -1);
			Assert.AreEqual("-3 -2 -1", actualResult);
		}

		[TestMethod]
		public void TestFromPositiveToNegative()
		{
			var actualResult = Exercise02.Run(3, -1);
			Assert.AreEqual("3 2 1 0 -1", actualResult);
		}
	}
}
