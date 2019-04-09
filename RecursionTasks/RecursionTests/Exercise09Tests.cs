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
	public class Exercise09Tests
	{
		[TestMethod]
		public void TestEmptyString()
		{
			var actualResult = Exercise09.Run(string.Empty);
			Assert.IsTrue(actualResult);
		}

		[TestMethod]
		public void TestEvenPolindrome()
		{
			var actualResult = Exercise09.Run("GoodDayyaDdooG");
			Assert.IsTrue(actualResult);
		}

		[TestMethod]
		public void TestOddPolindrome()
		{
			var actualResult = Exercise09.Run("GoodDayaDdooG");
			Assert.IsTrue(actualResult);
		}

		[TestMethod]
		public void TestEvenNotPolindrome()
		{
			var actualResult = Exercise09.Run("NiceDayyaDdooG");
			Assert.IsFalse(actualResult);
		}

		[TestMethod]
		public void TestOddNotPolindrome()
		{
			var actualResult = Exercise09.Run("BadDayyaDdooG");
			Assert.IsFalse(actualResult);
		}

		[TestMethod]
		public void TestOneSymbol()
		{
			var actualResult = Exercise09.Run("y");
			Assert.IsTrue(actualResult);
		}

		[TestMethod]
		public void TestcapitalEvenPolindrome()
		{
			var actualResult = Exercise09.Run("GOODDAYyaddoog");
			Assert.IsTrue(actualResult);
		}
	}
}
