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
	public class Exercise04Tests
	{
		[TestMethod]
		public void TestZeroValues()
		{
			var actualResult = Exercise04.Run(0, 0);
			Assert.AreEqual(1, actualResult);
		}

		[TestMethod]
		public void TestEqualValues()
		{
			int[] expectedValues = {3, 7, 61, 5, 13, 65533};
			for (int i = 1; i < 4; i++)
			{
				var actualResult = Exercise04.Run(i, i);
				Assert.AreEqual(expectedValues[i - 1], actualResult);
			}
		}

		[TestMethod]
		public void TestZeroN()
		{
			int[] expectedValues = {1, 2, 3, 5, 13};
			for (int i = 0; i < 5; i++)
			{
				var actualResult = Exercise04.Run(i, 0);
				Assert.AreEqual(expectedValues[i], actualResult);
			}
		}

		[TestMethod]
		public void TestMatrix()
		{
			int[,] expectedValues =
			{
				{1, 2, 3, 4, 5, 6},
				{2, 3, 4, 5, 6, 7},
				{3, 5, 7, 9, 11, 13},
				{5, 13, 29, 61, 125, 253}
			};
			for (int i = 0; i < expectedValues.GetLength(0); i++)
			{
				for (int j = 0; j < expectedValues.GetLength(1); j++)
				{
					var actualResult = Exercise04.Run(i, j);
					Assert.AreEqual(expectedValues[i, j], actualResult);
				}
			}
			{
				
			}
		}

		[TestMethod]
		public void TestConstantM()
		{
			int[] expectedValues = { 1, 2, 3, 4, 13 };
			for (int i = 0; i < 20; i++)
			{
				var actualResult = Exercise04.Run(0, i);
				Assert.AreEqual(i + 1, actualResult);
			}
		}
	}
}
