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
	public class Exercise10Tests
	{
		[TestMethod]
		public void TestZeroNumbers()
		{
			var actualResult = Exercise10.Run(0, 0);
			Assert.AreEqual(1, actualResult);
		}

		[TestMethod]
		public void TestZeroA()
		{
			var actualResult = Exercise10.Run(0, 8);
			Assert.AreEqual(1, actualResult);
		}

		[TestMethod]
		public void TestZeroB()
		{
			var actualResult = Exercise10.Run(8, 0);
			Assert.AreEqual(0, actualResult);
		}

		[TestMethod]
		public void TestNormalNumbers()
		{
			var actualResult = Exercise10.Run(5, 8);
			Assert.AreEqual(126, actualResult);
		}
	}
}
