using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using System;
using System.Diagnostics;
using System.Collections.Generic;


namespace Test_Task1
{
    [TestClass]

    public class UnitTest1
    {
        [TestMethod]
        [TestCategory("InOut")]
        [TestProperty("GSO-DevGroup", "Kander")]
        [DataRow("Köln", "Berlin", 477.67, 7.96)]
        [DataRow("Bonn", "Köln", 24.56, 0.41)]

        public void Test_InOut(string value_1, string value_2, double dist, double result)
        {
            // Arrange
            var writer = new StringWriter();
            Console.SetOut(writer);


            var textReader = new StringReader(@$"{value_1}
{value_2}
{dist}");
            Console.SetIn(textReader);

            // Act
            Task_1.Task1();

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




            Assert.AreEqual("Calculate Trip Duration", lines_list[0]);
            Assert.AreEqual("Enter the starting location:", lines_list[1]);
            Assert.AreEqual("Enter the ending location:", lines_list[2]);
            Assert.AreEqual("Enter the distance between the location:", lines_list[3]);
            Assert.AreEqual("Details", lines_list[4]);
            Assert.AreEqual($"{"Start:",-10}{value_1}", lines_list[5]);
            Assert.AreEqual($"{"End:",-10}{value_2}", lines_list[6]);
            Assert.AreEqual($"{"Distance:",-10}{dist:F2} [km]", lines_list[7]);
            Assert.AreEqual($"{"Duration:",-10}{result:F2} [h]", lines_list[8]);

        }
    }
}
