using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.SpirinIS.Sprint0.Task0.V0.Lib;

namespace Tyuiu.SpirinIS.Sprint0.Task0.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCulc()
        {
            DataService ds = new DataService();

            var res = ds.Culc(5, 5);

            Assert.AreEqual(10, res);
        }
    }
}
