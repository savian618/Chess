using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Program360
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void Test0()
        {
            char[,] letters = {
            };
            string[,] words = {
            };
            bool[] actual = cpsc360.Program.process(letters, words);
            bool[] expected = {
            };
            Assert.IsNotNull(actual);
            CollectionAssert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Test1()
        {
            char[,] letters = {
                { 'a','c' },
                { 'b','a' },
                { 'a','b' }
            };
            string[,] words = {
                { "aaa","abc" }
            };
            bool[] actual = cpsc360.Program.process(letters, words);
            bool[] expected = {
                true
            };
            Assert.IsNotNull(actual);
            CollectionAssert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Test2()
        {
            char[,] letters = {
                { 'a','c' },
                { 'b','a' },
                { 'a','b' }
            };
            string[,] words = {
                { "abc","aaa" }
            };
            bool[] actual = cpsc360.Program.process(letters, words);
            bool[] expected = {
                false
            };
            Assert.IsNotNull(actual);
            CollectionAssert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Test3()
        {
            char[,] letters = {
                { 'a','c' },
                { 'b','a' },
                { 'a','b' }
            };
            string[,] words = {
                { "acm","bcm" }
            };
            bool[] actual = cpsc360.Program.process(letters, words);
            bool[] expected = {
                true
            };
            Assert.IsNotNull(actual);
            CollectionAssert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Test4()
        {
            char[,] letters = {
                { 'a','i' },
                { 'a','t' },
                { 'a','u' },
                { 'i','r' },
                { 'i','b' },
                { 't','n' },
                { 'u','m' },
                { 'm','g' },
                { 'r','p' },
                { 'b','p' },
                { 'n','p' },
                { 'p','a' }
            };
            string[,] words = {
                { "tab","tabb" }
            };
            bool[] actual = cpsc360.Program.process(letters, words);
            bool[] expected = {
                false
            };
            Assert.IsNotNull(actual);
            CollectionAssert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Test5()
        {
            char[,] letters = {
                { 'a','i' },
                { 'a','t' },
                { 'a','u' },
                { 'i','r' },
                { 'i','b' },
                { 't','n' },
                { 'u','m' },
                { 'm','g' },
                { 'r','p' },
                { 'b','p' },
                { 'n','p' },
                { 'p','a' }
            };
            string[,] words = {
                { "ana","pat" },
                { "tab","bat" },
                { "tin","nii" },
                { "air","tug" }
            };
            bool[] actual = cpsc360.Program.process(letters, words);
            bool[] expected = {
                true,
                true,
                true,
                true };
            Assert.IsNotNull(actual);
            CollectionAssert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Test6()
        {
            char[,] letters = {
                { 'a','i' },
                { 'a','t' },
                { 'a','u' },
                { 'i','r' },
                { 'i','b' },
                { 't','n' },
                { 'u','m' },
                { 'm','g' },
                { 'r','p' },
                { 'b','p' },
                { 'n','p' },
                { 'p','a' }
            };
            string[,] words = {
                { "bum","bun" },
                { "ram","rat" },
                { "bum","bag" },
                { "tug","air" },
                { "bag","bum" }
            };
            bool[] actual = cpsc360.Program.process(letters, words);
            bool[] expected = {
                false,
                false,
                false,
                false,
                false };
            Assert.IsNotNull(actual);
            CollectionAssert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Test7()
        {
            char[,] letters = {
                { 'c','t' },
                { 'i','r' },
                { 'k','p' },
                { 'o','c' },
                { 'r','o' },
                { 't','e' },
                { 't','f' },
                { 'u','h' },
                { 'w','p' },
            };
            string[,] words = {
                { "yes", "wow" },
                { "we","we" },
                { "can","the" }
            };
            bool[] actual = cpsc360.Program.process(letters, words);
            bool[] expected = {
                false,
                true,
                false
            };
            Assert.IsNotNull(actual);
            CollectionAssert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Test8()
        {
            char[,] letters = {
                { 'c','t' },
                { 'i','r' },
                { 'k','p' },
                { 'o','c' },
                { 'r','o' },
                { 't','e' },
                { 't','f' },
                { 'u','h' },
                { 'w','p' }
            };
            string[,] words = {
                { "work","people" },
                { "it","of" },
                { "out","the" }
            };
            bool[] actual = cpsc360.Program.process(letters, words);
            bool[] expected = {
                false,
                true,
                true
            };
            Assert.IsNotNull(actual);
            CollectionAssert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Test9()
        {
            char[,] letters = {
                { 'x','q' },
                { 'i','l' },
                { 'h','l' },
                { 'v','x' },
                { 'n','s' },
                { 't','e' },
                { 'q','a' },
                { 'r','e' },
                { 'i','k' },
                { 'o','g' },
                { 'e','c' },
                { 'z','l' },
                { 'v','t' },
                { 'u','n' },
                { 'b','c' },
                { 'w','e' },
                { 'f','p' },
                { 'q','g' },
                { 'x','a' },
                { 'o','i' },
                { 'm','r' },
                { 't','b' },
                { 'j','f' },
                { 'p','b' },
                { 'g','j' },
                { 'n','i' },
                { 'r','x' },
                { 'g','a' },
                { 'r','q' },
                { 'i','u' },
                { 'n','v' },
                { 'x','c' },
                { 'm','e' },
                { 'a','x' },
                { 'k','c' },
                { 'd','f' },
                { 'j','a' },
                { 'b','l' },
                { 'd','u' },
                { 'l','c' }
            };
            string[,] words = {
                { "ujnifinuv","axfkfnugp" },
                { "dunj","qivx" },
                { "rig","nql" },
                { "mmmhuomaov","bxecctfxbf" },
                { "dfdo","fyta" },
                { "vu","tc" },
                { "rd","bl" },
                { "vgrvcwa","vlcbswj" },
                { "ljrducv","ccvnqcv" },
                { "av","fb" },
                { "iovnnirx","axljiecp" },
                { "moijmenu","joepjoie" },
                { "yvv","jlj" },
                { "ilby","klby" },
                { "dnmiikmnu","lafuqtcgl" },
                { "m","q" },
                { "gt","gp" },
                { "r","e" },
                { "jxt","clu" },
                { "tggoni","mqqglt" },
                { "gojf","jcll" },
                { "orfiumlm","tapszbcx" },
                { "vo","ak" },
                { "rq","ef" },
                { "gjmiddxiiv","qpffgpbful" },
                { "aadq","abec" },
                { "jxrnwso","jaqgbsq" },
                { "iirionufdv","cnlibjqbet" },
                { "hoonbv","hfoncn" },
                { "xo","jn" },
                { "xtvqnyeirv","ltpftzcgaq" },
                { "jrehaoznof","xphhbbzpxp" },
                { "nmjjrom","axmpxop" },
                { "jjxgmnpqw","blgajvbac" },
                { "q","t" },
                { "jnoijmmfb","cnbalfrbl" },
                { "urxf","hcxc" },
                { "dvqwnrdno","qbqtagdvv" },
                { "fgpvpigd","lxpjbgjk" },
                { "tj","li" },
                { "ijouzdbd","ifpszkbf" },
                { "j","a" },
                { "meprndm","colcgsq" },
                { "mfoa","fvia" },
                { "xl","bw" },
                { "xidcgujiu","aeicfvpkn" },
                { "ni","ef" },
                { "uuops","tgfbs" },
                { "ngniofdim","sctqfpssg" },
                { "w","u" }
            };
            bool[] actual = cpsc360.Program.process(letters, words);
            bool[] expected = {
                true,
                true,
                false,
                true,
                false,
                true,
                true,
                false,
                false,
                true,
                true,
                false,
                false,
                true,
                false,
                true,
                false,
                true,
                false,
                false,
                true,
                false,
                true,
                true,
                true,
                true,
                false,
                true,
                false,
                true,
                false,
                false,
                false,
                true,
                false,
                true,
                false,
                false,
                true,
                false,
                true,
                true,
                false,
                false,
                false,
                true,
                true,
                true,
                true,
                false
            };
            Assert.IsNotNull(actual);
            CollectionAssert.AreEqual(expected, actual);
        }
    }
}
