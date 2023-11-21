using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using PorjetPSI_Romain_Eve_Form;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Test_offsetSize()
        {
            MyImage test = new MyImage("C:/Users/rpaup/OneDrive - De Vinci/A2'/S2/Projet PSI/ProjetPSI_Romain_Eve/ProjetPSI_Romain_Eve/bin/Debug");

            int res = 54;
            int offset = test.Convert_Endian_To_Int(ReductionTab(imageByte, 10, 13));

            Assert.AreEqual(res, offset);
        }
        [TestMethod]

    }
}
