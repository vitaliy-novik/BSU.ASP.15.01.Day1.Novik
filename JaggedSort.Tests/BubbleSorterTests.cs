using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace JaggedSort.Tests
{
    [TestFixture]
    public class BubbleSorterTests
    {

        [Test]
        public void BubbleSortTest()
        {
            int[][] actual = new int[][] 
                { new int[]{ 1, 2, 4 },  null, new int[]{ 3, 6}, null, new int[]{5} };
            int[][] SortedByMin = new int[][] 
                { new int[]{ 1, 2, 4 },  new int[]{ 3, 6}, new int[]{5}, null, null };
            int[][] SortedByMax = new int[][] 
                { new int[]{ 1, 2, 4 }, new int[]{5},  new int[]{ 3, 6}, null, null };
            int[][] SortedBySum = new int[][] 
                { new int[]{5}, new int[]{ 1, 2, 4 }, new int[]{ 3, 6}, null,  null };

            BubbleSorter bs = new BubbleSorter(new SortByMin());
            bs.Sort(actual);
            CollectionAssert.AreEqual(actual, SortedByMin);

            bs.SortMethod = new SortByMax();
            bs.Sort(actual);
            CollectionAssert.AreEqual(actual, SortedByMax);

            bs.SortMethod = new SortBySum();
            bs.Sort(actual);
            CollectionAssert.AreEqual(actual, SortedBySum);
        }
    }

    
}
