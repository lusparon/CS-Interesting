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
	public class Exercise12Tests
	{
		[TestMethod]
		public void TestSimpleFilter()
		{
			var actualResult = Exercise12.Flatten(new Filter());
			Assert.IsNotNull(actualResult);
			Assert.AreEqual(1, actualResult.Count);
			Assert.IsNotNull(actualResult.First());
			Assert.AreEqual(1, actualResult.First().Length);
		}

		[TestMethod]
		public void TestSingleCompositeAnyFilter()
		{
			var filters = new CompositeFilter(CompositeFilterOperation.Any, new Filter(), new Filter(), new Filter());
			var actualResult = Exercise12.Flatten(filters);
			Assert.IsNotNull(actualResult);
			Assert.AreEqual(3, actualResult.Count);
			foreach (var filterSet in actualResult)
			{
				Assert.IsNotNull(filterSet);
				Assert.AreEqual(1, filterSet.Length);
			}
		}

		[TestMethod]
		public void TestSingleCompositeAllFilter()
		{
			var filters = new CompositeFilter(CompositeFilterOperation.All, new Filter(), new Filter(), new Filter());
			var actualResult = Exercise12.Flatten(filters);
			Assert.IsNotNull(actualResult);
			Assert.AreEqual(1, actualResult.Count);
			Assert.IsNotNull(actualResult.First());
			Assert.AreEqual(3, actualResult.First().Length);
		}

		[TestMethod]
		public void TestNestedCompositeAllFilter()
		{
			var filters = new CompositeFilter(CompositeFilterOperation.All,
				new CompositeFilter(CompositeFilterOperation.Any, new Filter(), new Filter(), new Filter()),
				new CompositeFilter(CompositeFilterOperation.Any, new Filter(), new Filter(), new Filter()),
				new CompositeFilter(CompositeFilterOperation.All, new Filter(), new Filter()),
				new Filter());
			var actualResult = Exercise12.Flatten(filters);
			Assert.IsNotNull(actualResult);
			Assert.AreEqual(9, actualResult.Count);
			foreach (var filterSet in actualResult)
			{
				Assert.IsNotNull(filterSet);
				Assert.AreEqual(5, filterSet.Length);
			}
		}

		[TestMethod]
		public void TestNestedCompositeAnyFilter()
		{
			var filters = new CompositeFilter(CompositeFilterOperation.All,
				new CompositeFilter(CompositeFilterOperation.Any, new Filter(), new Filter(), new Filter()),
				new CompositeFilter(CompositeFilterOperation.Any, new Filter(), new Filter(), new Filter()),
				new CompositeFilter(CompositeFilterOperation.All, new Filter(), new Filter()),
				new Filter());
			var actualResult = Exercise12.Flatten(filters);
			Assert.IsNotNull(actualResult);
			Assert.AreEqual(8, actualResult.Count);
		}
	}
}
