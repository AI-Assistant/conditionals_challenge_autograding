using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using System;
using System.Diagnostics;
using System.Collections.Generic;



namespace Test_Task4
{
    [TestClass]
    public class UnitTest4
    {



        #region TestMethode1
        [TestMethod]
        [TestCategory("InOut")]
        [TestProperty("GSO-DevGroup", "Akinci")]
        [DataRow(0, 10.23, "4", 0)]
        [DataRow(0, 0, "4", double.NaN)]
        [DataRow(10, 2.5, "4", 4)]
        [DataRow(2, 5, "1", 7)]
        [DataRow(-2, 5, "1", 3)]
        [DataRow(-1, -5, "2", 4)]
        [DataRow(-1.5, 4, "3", -6)]
        [DataRow(-1, -5, "3", 5)]
        [DataRow(2, 2, "5", 4)]
        [DataRow(-1, 0, "5", 1)]
        [DataRow(1.5, 2, "5", 2.25)]

        public void TestMethod1(double value_1, double value_2, string choice, double result)
        {
            var textReader = new StringReader(@$"{value_1}
{value_2}
{choice}");
            TestMehod1_Body(textReader, result.ToString());
        }

        [TestMethod]
        [TestCategory("InOut")]
        [TestProperty("GSO-DevGroup", "Akinci")]
        [DataRow(0, 10.23, 4, 0)]
        [DataRow(0, 0, 4, double.NaN)]
        [DataRow(10, 2.5, 4, 4)]
        [DataRow(2, 5, 1, 7)]
        [DataRow(-2, 5, 1, 3)]
        [DataRow(-1, -5, 2, 4)]
        [DataRow(-1.5, 4, 3, -6)]
        [DataRow(-1, -5, 3, 5)]
        [DataRow(2, 2, 5, 4)]
        [DataRow(-1, 0, 5, 1)]
        [DataRow(1.5, 2, 5, 2.25)]
        public void TestMethod1(double value_1, double value_2, int choice, double result)
        {
            var textReader = new StringReader(@$"{value_1}
{value_2}
{choice}");
            TestMehod1_Body(textReader, result.ToString());

        }


        [TestMethod]
        [TestCategory("InOut")]
        [TestProperty("GSO-DevGroup", "Akinci")]
        [DataRow(-12, 0, "4", "-∞")]
        [DataRow(2.2, 0, "4", "∞")]
        public void TestMethod1(double value_1, double value_2, string choice, string result)
        {
            var textReader = new StringReader(@$"{value_1}
{value_2}
{choice}");
            TestMehod1_Body(textReader, result.ToString());

        }

        [TestMethod]
        [TestCategory("InOut")]
        [TestProperty("GSO-DevGroup", "Akinci")]
        [DataRow(-12, 0, 4, "-∞")]
        [DataRow(2.2, 0, 4, "∞")]
        public void TestMethod1(double value_1, double value_2, int choice, string result)
        {
            var textReader = new StringReader(@$"{value_1}
{value_2}
{choice}");
            TestMehod1_Body(textReader, result.ToString());

        }

        private void TestMehod1_Body(StringReader textReader, string result)
        {
            // Arrange
            var writer = new StringWriter();
            Console.SetOut(writer);
            Console.SetIn(textReader);

            // Act
            Task_4.Task4();


            // Assert

            var sb = writer.GetStringBuilder();
            var lines = sb.ToString().Split(Environment.NewLine, StringSplitOptions.TrimEntries);

            List<string> lines_list = new List<string>();

            //Bedingung nötig da 'Enviroment.NewLine' in Git Actions nicht funktioniert.
            for (int i = 0; i < lines.Length; i++)
            {
                if (lines[i] != "")
                {
                    lines_list.Add(lines[i]);
                    Debug.WriteLine($"{lines[i]}");
                }
            }

            Assert.AreEqual("Calculator", lines_list[0]);
            Assert.AreEqual("Enter the first value:", lines_list[1]);
            Assert.AreEqual("Enter the second value:", lines_list[2]);
            Assert.AreEqual("1 Addition", lines_list[3]);
            Assert.AreEqual("2 Subtraction", lines_list[4]);
            Assert.AreEqual("3 Multiplication", lines_list[5]);
            Assert.AreEqual("4 Divison", lines_list[6]);
            Assert.AreEqual("5 Potency", lines_list[7]);
            Assert.AreEqual("Your choice:", lines_list[8]);
            Assert.AreEqual($"Your result is: {result}", lines_list[9]);

        }
        #endregion
    }

}