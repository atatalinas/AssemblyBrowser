using System;
using AssemblyGetInfoLib;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AssemblyGetInfoTest
{
    [TestClass]
    public class Tests
    {
        private Node Setup()
        {
            IGetInfo getter = new AssemblyGetInfo();
            return getter.GetInfoFromFile("TesterDll.dll");
        }

        [TestMethod]
        public void LoadingAssemblyTest()
        {
            Node actual = Setup();
            Assert.IsNotNull(actual);
        }

        [TestMethod]
        public void AssemblyNameTest()
        {
            Node actual = Setup();
            Assert.IsTrue(actual.Content.StartsWith("TesterDll"));
        }

        [TestMethod]
        public void TypeNameTest()
        {
            Node actual = Setup();
            Assert.AreEqual("Tester", actual.Nodes[0].Nodes[0].Content);
        }



    }
}
