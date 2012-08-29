# C# Natural Sort
Sorting for Humans : Natural Sort Order.
Supports decimals and exponents.

Uses ordinal comparaison for strings (can easily be changed).

## Usage
For simple lists:

	list.Sort(new NaturalSortComparer<string>());

For lists of complex objects:

	list = list.OrderByNatural("Value").ToList();

See UnitTest.cs for more detailed exemples.

## Example
**Input**
* 0.12
* 12
* Potato
* a0.012
* 10
* potato
* b1.2
* a1
* 1.2E-4
* 0.0012

**Output**
* 1.2E-4
* 0.0012
* 0.12
* 10
* 12
* Potato
* a0.012
* a1
* b1.2
* potato
	
## Credits
Justin Jones http://www.codeproject.com/Articles/22517/Natural-Sort-Comparer

James McCormack http://zootfroot.blogspot.ca/2009/09/natural-sort-compare-with-linq-orderby.html

Jeff Atwood http://www.codinghorror.com/blog/2007/12/sorting-for-humans-natural-sort-order.html