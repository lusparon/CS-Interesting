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
	public class Exercise06Tests
	{
		[TestMethod]
		public void TestZeroNumber()
		{
			var actualResult = Exercise06.Run(0);
			Assert.AreEqual(0, actualResult);
		}

		[TestMethod]
		public void TestТNormalNumber()
		{
			var actualResult = Exercise06.Run(1354626729);
			Assert.AreEqual(45, actualResult);
		}

		[TestMethod]
		public void TestТNegativeNumber()
		{
			var actualResult = Exercise06.Run(-1354626729);
			Assert.AreEqual(45, actualResult);
		}

		[TestMethod]
		public void TestТRoundedNumber()
		{
			var actualResult = Exercise06.Run(2000000000);
			Assert.AreEqual(2, actualResult);
		}

		[TestMethod]
		public void TestVeryBigNumberNumber()
		{
			var actualResult = Exercise06.Run(999999999999);
			Assert.AreEqual(108, actualResult);
		}
	}
}
