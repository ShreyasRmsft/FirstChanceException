﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FirstChance
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
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
        
        [TestMethod]
        public void TestMethod2()
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
        
        [TestMethod]
        public void TestMethod3()
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
