using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnalyserProject;

namespace MoodAnalyserTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestCase1_1()
        {
            string message = "I am in a sad mood";
            MoodAnalyser moodAnalyser = new MoodAnalyser(message);

            string result = moodAnalyser.AnalyseMood();

            Assert.AreEqual("SAD", result);
        }
        [TestMethod]
        public void TestCase1_2()
        {
            string message = "I am in a happy mood";
            MoodAnalyser moodAnalyser = new MoodAnalyser(message);

            string result = moodAnalyser.AnalyseMood();

            Assert.AreEqual("HAPPY", result);
        }
    }
}