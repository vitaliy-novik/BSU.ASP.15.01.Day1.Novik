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
            int[][] actual = new int[][] {
                new int[]{ 1, 2, 4 },  null, new int[]{ 3, 6}, null, new int[]{5} };
            int[][] sortedByMin = new int[][] { 
                new int[]{ 1, 2, 4 },  new int[]{ 3, 6}, new int[]{5}, null, null };
            int[][] sortedByMax = new int[][] {
                new int[]{ 1, 2, 4 }, new int[]{5},  new int[]{ 3, 6}, null, null };
            int[][] sortedBySum = new int[][] {
                new int[]{5}, new int[]{ 1, 2, 4 }, new int[]{ 3, 6}, null,  null };
            int[][] sortedBySumDescending = new int[][] {
                new int[] { 3, 6 }, new int[] { 1, 2, 4 }, new int[] { 5 }, null, null };

            BubbleSortDelToComp.Sort(actual, new SortByMin());
            CollectionAssert.AreEqual(actual, sortedByMin);
            
            BubbleSortDelToComp.Sort(actual, new SortByMax());
            CollectionAssert.AreEqual(actual, sortedByMax);

            BubbleSortDelToComp.Sort(actual, new SortBySum());
            CollectionAssert.AreEqual(actual, sortedBySum);

        }
    }

    
}
