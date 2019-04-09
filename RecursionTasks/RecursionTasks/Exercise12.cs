using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecursionTasks
{
	public class Exercise12
	{
		// Есть сложно настраиваемый фильтр с вложенными условиями и 
		// возможностью задать соотношение между фильтрами (И, ИЛИ).
		// Необходимо по фильтру построить коллекцию запросов к БД 
		// с конкретными параметрами (каждый фильтр представляет собой 1 параметр).
		public static List<Filter[]> Flatten(Filter rootFilter)
		{
			throw new NotImplementedException();
		}
	}

	public class Filter { }
	public enum CompositeFilterOperation { All, Any }
	public class CompositeFilter : Filter
	{
		public CompositeFilterOperation Operation { get; }
		public Filter[] NestedFilters { get; }

		public CompositeFilter(CompositeFilterOperation operation, params Filter[] nestedFilters)
		{
			Operation = operation;
			NestedFilters = nestedFilters;
		}
	}
}
