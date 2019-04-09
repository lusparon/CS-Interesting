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
	public class Exercise11Tests
	{
		[TestMethod]
		public void TestEvenNumber()
		{
			var actualResult = Exercise11.Run(1584);
			Assert.AreEqual(4851, actualResult);
		}

		[TestMethod]
		public void TestOddNumber()
		{
			var actualResult = Exercise11.Run(158);
			Assert.AreEqual(851, actualResult);
		}

		[TestMethod]
		public void TestZeroNumber()
		{
			var actualResult = Exercise11.Run(0);
			Assert.AreEqual(0, actualResult);
		}

		[TestMethod]
		public void TestPolindromeNumber()
		{
			var actualResult = Exercise11.Run(115511);
			Assert.AreEqual(115511, actualResult);
		}

		[TestMethod]
		public void TestVeryBigNumber()
		{
			var actualResult = Exercise11.Run(2147483647);
			Assert.AreEqual(7463847412, actualResult);
		}

		[TestMethod]
		public void TestNegativeNumber()
		{
			var actualResult = Exercise11.Run(-12);
			Assert.AreEqual(-11, actualResult);
		}
	}
}
