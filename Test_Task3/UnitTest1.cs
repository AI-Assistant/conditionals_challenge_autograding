using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using System;
using System.Diagnostics;
using System.Collections.Generic;


namespace Test_Task3
{
    [TestClass]
    public class UnitTest3
    {
        [TestMethod]
        [TestCategory("InOut")]
        [TestProperty("GSO-DevGroup", "Akinci")]
        [DataRow(false, false, 5)]
        [DataRow(false, true, 15)]
        [DataRow(true, false, 18)]
        [DataRow(true, true, 62)]
        public void TestMethod3(bool value_1, bool value_2, int result)
        {
            // Arrange
            var writer = new StringWriter();
            Console.SetOut(writer);


            var textReader = new StringReader(@$"{value_1}
{value_2}");
            Console.SetIn(textReader);

            // Act
            Task_3.Task3();

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

            Assert.AreEqual("Risk Of Heart Attack", lines_list[0]);
            Assert.AreEqual("Are you overweight?(true/false):", lines_list[1]);
            Assert.AreEqual("Do you have stress?(true/false):", lines_list[2]);
            Assert.AreEqual($"Your risk of heart attack is about: {result}%", lines_list[3]);

        }
    }
}