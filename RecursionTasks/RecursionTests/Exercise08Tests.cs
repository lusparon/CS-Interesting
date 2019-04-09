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
	public class Exercise08Tests
	{
		[TestMethod]
		public void TestZeroNumber()
		{
			var actualResult = Exercise08.Run(0);
			Assert.AreEqual("0", actualResult);
		}

		[TestMethod]
		public void TestТNormalNumber()
		{
			var actualResult = Exercise08.Run(1354626729);
			Assert.AreEqual("1 3 5 4 6 2 6 7 2 9", actualResult);
		}

		[TestMethod]
		public void TestТNegativeNumber()
		{
			var actualResult = Exercise08.Run(-1354626729);
			Assert.AreEqual("1 3 5 4 6 2 6 7 2 9", actualResult);
		}

		[TestMethod]
		public void TestТRoundedNumber()
		{
			var actualResult = Exercise08.Run(2000000000);
			Assert.AreEqual("2 0 0 0 0 0 0 0 0 0", actualResult);
		}

		[TestMethod]
		public void TestVeryBigNumberNumber()
		{
			var actualResult = Exercise08.Run(999999999999);
			Assert.AreEqual("9 9 9 9 9 9 9 9 9 9 9 9", actualResult);
		}
	}
}
