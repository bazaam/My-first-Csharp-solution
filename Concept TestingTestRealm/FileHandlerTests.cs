using Microsoft.VisualStudio.TestTools.UnitTesting;
using Concept_Testing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Concept_Testing.Tests
{
    [TestClass()]
    public class FileHandlerTests
    {
        [TestMethod()]
        public void GetDataTest()
        {
            FileHandler WrongTag = new FileHandler(@"..\Data\Test.txt");

            Assert.AreEqual(WrongTag.GetData("test"), 18.0);
        }
            



            
    }
}