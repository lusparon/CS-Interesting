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
	public class Exercise05Tests
	{
		[TestMethod]
		public void TestNegativeNumber()
		{
			var actualResult = Exercise05.Run(-2);
			Assert.IsFalse(actualResult);
		}

		[TestMethod]
		public void TestZeroNumber()
		{
			var actualResult = Exercise05.Run(0);
			Assert.IsFalse(actualResult);
		}

		[TestMethod]
		public void TestCorrectPowers()
		{
			for (int i = 1; i < 30; i++)
			{
				var actualResult = Exercise05.Run((int) Math.Pow(2, i));
				Assert.IsTrue(actualResult);
			}
		}

		[TestMethod]
		public void TestIncorrectPowers()
		{
			for (int i = 1; i < 30; i++)
			{
				var actualResult = Exercise05.Run((int)Math.Pow(2, i) + 1);
				Assert.IsFalse(actualResult);
			}
		}
	}
}
