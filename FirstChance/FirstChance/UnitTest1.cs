using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FirstChance
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            for (int i = 0; i < 10000000; i++)
            {
                try
                {
                    throw new Exception("e");
                }
                catch
                {

                }
            }
        }
    }
}
