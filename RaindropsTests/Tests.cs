using System;
using NUnit.Framework;
using Raindrops_CSharp;

namespace RaindropsTests
{
    [TestFixture]
    public class RaindropsTest
    {
        [Test]
        public void Numbers()
        {
            Raindrops test = new Raindrops();

            String pling = test.Numbers(3);
            Assert.AreEqual("Pling", pling);

            String plang = test.Numbers(10);
            Assert.AreEqual("Plang", plang);
            
            String plong = test.Numbers(14);
            Assert.AreEqual("Plong", plong);

            String number = test.Numbers(8);
            Assert.AreEqual("8", number);

            String plingplang = test.Numbers(15);
            Assert.AreEqual("PlingPlang", plingplang);

            String plingplong = test.Numbers(21);
            Assert.AreEqual("PlingPlong", plingplong);

            String plangplong = test.Numbers(35);
            Assert.AreEqual("PlangPlong", plangplong);

            String plingplangplong = test.Numbers(105);
            Assert.AreEqual("PlingPlangPlong", plingplangplong);
        }
    }
}