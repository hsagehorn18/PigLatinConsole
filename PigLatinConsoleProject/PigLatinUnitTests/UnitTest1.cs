// Unit tests used to test the program

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PigLatinConsoleProject;

namespace PigLatinUnitTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void BasicPigLatinTest()
        {
            PigLatin PigLatin = new PigLatin();
            string word = "hello";
            string actual = "";
            string expected = "ello-hay ";

            actual = PigLatin.PigLatinTranslator(word);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void BasicPigLatinTest2()
        {
            PigLatin PigLatin = new PigLatin();
            string word = "switch";
            string actual = "";
            string expected = "itch-sway ";

            actual = PigLatin.PigLatinTranslator(word);

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void BasicPigLatinTest3()
        {
            PigLatin PigLatin = new PigLatin();
            string word = "banana";
            string actual = "";
            string expected = "anana-bay ";

            actual = PigLatin.PigLatinTranslator(word);

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void BasicPigLatinTest4()
        {
            PigLatin PigLatin = new PigLatin();
            string word = "climb";
            string actual = "";
            string expected = "imb-clay ";

            actual = PigLatin.PigLatinTranslator(word);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void BasicPigLatinTest5()
        {
            PigLatin PigLatin = new PigLatin();
            string word = "it";
            string actual = "";
            string expected = "it-ay ";

            actual = PigLatin.PigLatinTranslator(word);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void BasicPigLatinTest6Sentence()
        {
            PigLatin PigLatin = new PigLatin();
            string word = "The quick brown fox jumps over the fence";
            string actual = "";
            string expected = "e-thay uick-qay own-bray ox-fay umps-jay over-ay e-thay ence-fay ";

            actual = PigLatin.PigLatinTranslator(word);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void BasicPigLatinTest7Sentence()
        {
            PigLatin PigLatin = new PigLatin();
            string word = "Mother wants her good silver back tomorrow";
            string actual = "";
            string expected = "other-may ants-way er-hay ood-gay ilver-say ack-bay omorrow-tay ";

            actual = PigLatin.PigLatinTranslator(word);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void BasicPigLatinTest8Sentence()
        {
            PigLatin PigLatin = new PigLatin();
            string word = "Sometimes I sit quietly at night and think about where my life has gone";
            string actual = "";
            string expected = "ometimes-say i-ay it-say uietly-qay at-ay ight-nay and-ay ink-thay about-ay ere-whay y-may ife-lay as-hay one-gay ";

            actual = PigLatin.PigLatinTranslator(word);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void BasicPigLatinTest9Sentence()
        {
            PigLatin PigLatin = new PigLatin();
            string word = "This test sentence contains the words zebra and xylophone";
            string actual = "";
            string expected = "is-thay est-tay entence-say ontains-cay e-thay ords-way ebra-zay and-ay ylophone-xay ";

            actual = PigLatin.PigLatinTranslator(word);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void BasicPigLatinTest10()
        {
            PigLatin PigLatin = new PigLatin();
            string word = "why";
            string actual = "";
            string expected = "y-whay ";

            actual = PigLatin.PigLatinTranslator(word);

            Assert.AreEqual(expected, actual);
        }
    }
}
