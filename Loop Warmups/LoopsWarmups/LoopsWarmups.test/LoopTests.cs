using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopsWarmups.test
{
    class LoopTests
    {
        [TestCase("Hi", 2, "HiHi")]
        [TestCase("Hi", 3, "HiHiHi")]
        [TestCase("Hi", 1, "Hi")]
        public void StringTimesTest(string str, int n, string expected)
        {
            Loops lw = new Loops();
            string result = lw.StringTimes(str, n);
            Assert.AreEqual(expected, result);
        }
        [TestCase("Chocolate", 2, "ChoCho")]
        [TestCase("Chocolate", 3, "ChoChoCho")]
        [TestCase("Abc", 3, "AbcAbcAbc")]
        public void FrontTimesTest(string str, int n, string expected)
        {
            Loops lw = new Loops();
            string result = lw.FrontTimes(str, n);
            Assert.AreEqual(expected, result);
        }
        [TestCase("abcxx", 1)]
        [TestCase("xxx", 2)]
        [TestCase("xxxx", 3)]
        public void CountXXTest(string str, int expected)
        {
            Loops lw = new Loops();
            int result = lw.CountXX(str);
            Assert.AreEqual(expected, result);
        }
        [TestCase("axxbb", true)]
        [TestCase("axaxxax", false)]
        [TestCase("xxxxx", true)]
        public void DoubleXTest(string str, bool expected)
        {
            Loops lw = new Loops();
            bool result = lw.DoubleX(str);
            Assert.AreEqual(expected, result);
        }
        [TestCase("Hello", "Hlo")]
        [TestCase("Hi", "H")]
        [TestCase("Heeololeo", "Hello")]
        public void EveryOtherTest(string str, string expected)
        {
            Loops lw = new Loops();
            string result = lw.EveryOther(str);
            Assert.AreEqual(expected, result);
        }
        [TestCase("Code", "CCoCodCode")]
        [TestCase("abc", "aababc")]
        [TestCase("ab", "aab")]
        public void StringSplosionTest(string str, string expected)
        {
            Loops lw = new Loops();
            string result = lw.StringSplosion(str);
            Assert.AreEqual(expected, result);
        }
        [TestCase("hixxhi", 1)]
        [TestCase("xaxxaxaxx", 1)]
        [TestCase("axxxaaxx", 2)]
        public void CountLast2Test(string str, int expected)
        {
            Loops lw = new Loops();
            int result = lw.CountLast2(str);
            Assert.AreEqual(expected, result);
        }
        [TestCase(new int[]{1, 2, 9}, 1)]
        [TestCase(new int[]{ 1, 9, 9 }, 2)]
        [TestCase(new int[] { 1, 9, 9, 3, 9 }, 3)]

        public void Count9Test(int[] numbers, int expected)
        {
            Loops lw = new Loops();
            int result = lw.Count9(numbers);
            Assert.AreEqual(expected, result);
        }

        [TestCase(new int[] { 1, 2, 9, 3, 4}, true)]
        [TestCase(new int[] { 1, 2, 3, 4, 9}, false)]
        [TestCase(new int[] { 1, 2, 3, 4, 5}, false)]

        public void ArrayFront9Test(int[] numbers, bool expected)
        {
            Loops lw = new Loops();
            bool result = lw.ArrayFront9(numbers);
            Assert.AreEqual(expected, result);
        }

        [TestCase(new int[] {1, 1, 2, 3, 1 }, true)]
        [TestCase(new int[] { 1, 1, 2, 4, 1 }, false)]
        [TestCase(new int[] { 1, 1, 2, 1, 2, 3 }, true)]

        public void Array123Test(int[] numbers, bool expected)
        {
            Loops lw = new Loops();
            bool result = lw.Array123(numbers);
            Assert.AreEqual(expected, result);
        }

        [TestCase("xxcaazz", "xxbaaz", 3)]
        [TestCase("abc", "abc", 2)]
        [TestCase("abc", "axc", 0)]

        public void SubStringMatchTest(string a, string b, int expected)
        {
            Loops lw = new Loops();
            int result = lw.SubStringMatch(a, b);
            Assert.AreEqual(expected, result);
        }

        [TestCase("xxHxix", "xHix")]
        [TestCase("abxxxcd", "abcd")]
        [TestCase("xabxxxcdx", "xabcdx")]

        public void StringX(string str, string expected)
        {
            Loops lw = new Loops();
            string result = lw.StringX(str);
            Assert.AreEqual(expected, result);
        }
        [TestCase("kitten", "kien")]
        [TestCase("Chocolate", "Chole")]
        [TestCase("CodingHorror", "Congrr")]

        public void AltPairsTest(string str, string expected)
        {
            Loops lw = new Loops();
            string result = lw.AltPairs(str);
            Assert.AreEqual(expected, result);
        }

        [TestCase("yakpak", "pak")]
        [TestCase("pakyak", "pak")]
        [TestCase("yak123ya", "123ya")]

        public void DoNotYakTest(string str, string expected)
        {
            Loops lw = new Loops();
            string result = lw.DoNotYak(str);
            Assert.AreEqual(expected, result);
        }

        [TestCase(new int[]{6,6,2}, 1)]
        [TestCase(new int[] { 6, 6, 2, 6 }, 1)]
        [TestCase(new int[] { 6, 7, 2, 6}, 1)]

        public void Array667Test(int[] numbers, int expected)
        {
            Loops lw = new Loops();
            int result = lw.Array667(numbers);
            Assert.AreEqual(expected, result);
        }

        [TestCase(new int[] { 1, 1, 2, 2, 1}, true)]
        [TestCase(new int[] { 1, 1, 2, 2, 2, 1}, false)]
        [TestCase(new int[] { 1, 1, 1, 2, 2, 2, 1,}, false)]

        public void NoTriplesTest(int [] numbers, bool expected)
        {
            Loops lw = new Loops();
            bool result = lw.NoTriples(numbers);
            Assert.AreEqual(expected, result);
        }

        [TestCase(new int[] { 1, 2, 7, 1}, true)]
        [TestCase(new int[] { 1, 2, 8, 1}, false)]
        [TestCase(new int[] { 2, 7, 1}, true)]

        public void Pattern51test(int [] numbers, bool expected)
        {
            Loops lw = new Loops();
            bool result = lw.Pattern51(numbers);
            Assert.AreEqual(expected, result);
        }
    }
}
