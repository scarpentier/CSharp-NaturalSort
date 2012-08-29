C# Natural Sort
==============
Sorting for Humans : Natural Sort Order.
Supports decimals and exponents.

Usage
--------------
For simple lists:

	list.Sort(new NaturalSortComparer<string>());

For list of complex objects:

	list = list.OrderByNatural("Value").ToList();

See UnitTest.cs for more detailed exemples.
	
Credits
--------------
Justin Jones http://www.codeproject.com/Articles/22517/Natural-Sort-Comparer

James McCormack http://zootfroot.blogspot.ca/2009/09/natural-sort-compare-with-linq-orderby.html

Jeff Atwood http://www.codinghorror.com/blog/2007/12/sorting-for-humans-natural-sort-order.html