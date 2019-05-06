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
            loop();
        }

        [TestMethod]
        public void TestMethod2()
        {
            loop();
        }

        [TestMethod]
        public void TestMethod3()
        {
            loop();
        }

        [TestMethod]
        public void TestMethod4()
        {
            loop();
        }

        [TestMethod]
        public void TestMethod5()
        {
            loop();
        }

        [TestMethod]
        public void TestMethod6()
        {
            loop();
        }

        [TestMethod]
        public void TestMethod7()
        {
            loop();
        }

        [TestMethod]
        public void TestMethod8()
        {
            loop();
        }

                [TestMethod]
        public void TestMethod11()
        {
            loop();
        }

        [TestMethod]
        public void TestMethod12()
        {
            loop();
        }

        [TestMethod]
        public void TestMethod13()
        {
            loop();
        }

        [TestMethod]
        public void TestMethod14()
        {
            loop();
        }

        [TestMethod]
        public void TestMethod15()
        {
            loop();
        }

        [TestMethod]
        public void TestMethod16()
        {
            loop();
        }

        [TestMethod]
        public void TestMethod17()
        {
            loop();
        }

        [TestMethod]
        public void TestMethod18()
        {
            loop();
        }

        private void loop()
        {
            for (int i = 0; i < 1000000000; i++)
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
