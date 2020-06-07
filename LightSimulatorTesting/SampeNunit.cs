using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
namespace LightSimulatorTesting
{
    [TestFixture]
    class SampeNunit
    {
        [TestCase,Order(1)]
        public void WriteOnOffBri_10_1()
        {
            TestInterface.TestInterfaceClass OTestInterface = new TestInterface.TestInterfaceClass();
            OTestInterface.Init();
            OTestInterface.Send("[TH,WriteOnOffBri,10,1]");
            string szActualop = OTestInterface.Receive();
            Assert.AreEqual("[TH,WriteOnOffBri,0]", szActualop);
            
        }
        [TestCase, Order(2)]
        public void ReadOnOffBri_Negative()
        {
            TestInterface.TestInterfaceClass OTestInterface = new TestInterface.TestInterfaceClass();
            OTestInterface.Init();
            OTestInterface.Send("[TH,ReadOnOffBri]");
            string szActualop = OTestInterface.Receive();
            Assert.AreEqual("[TH,ReadOnOffBri,0,20,1]", szActualop);
           // System.Threading.Thread.Sleep(1000);
        }
        [TestCase, Order(3)]
        public void ReadOnOffBri_Positive()
        {
            TestInterface.TestInterfaceClass OTestInterface = new TestInterface.TestInterfaceClass();
            OTestInterface.Init();
            OTestInterface.Send("[TH,ReadOnOffBri]");
            string szActualop = OTestInterface.Receive();
            Assert.AreEqual("[TH,ReadOnOffBri,0,10,1]", szActualop);
           // System.Threading.Thread.Sleep(1000);
        }
        [TestCase, Order(4)]
        public void WriteOnOffBri_255_1_BrightnessOutOfRange()
        {
            TestInterface.TestInterfaceClass OTestInterface = new TestInterface.TestInterfaceClass();
            OTestInterface.Init();
            OTestInterface.Send("[TH,WriteOnOffBri,255,1]");
            string szActualop = OTestInterface.Receive();
            Assert.AreEqual("[TH,WriteOnOffBri,0]", szActualop);
           // System.Threading.Thread.Sleep(1000);
        }

        [TestCase, Order(5)]
        public void WriteOnOffBri_WrongFormat()
        {
            TestInterface.TestInterfaceClass OTestInterface = new TestInterface.TestInterfaceClass();
            OTestInterface.Init();
            OTestInterface.Send("[]");
            string szActualop = OTestInterface.Receive();
            Assert.AreEqual("[TH,WriteOnOffBri,0]", szActualop);
           // System.Threading.Thread.Sleep(1000);
        }

        [TestCase, Order(6)]
        public void WriteOnOffBri_10_Positive()
        {
            TestInterface.TestInterfaceClass OTestInterface = new TestInterface.TestInterfaceClass();
            OTestInterface.Init();
            OTestInterface.Send("[TH,WriteOnOffBri,10]");
            string szActualop = OTestInterface.Receive();
            Assert.AreEqual("[TH,WriteOnOffBri,0]", szActualop);
          
        }
        [TestCase, Order(7)]
        public void WriteOnOffBri_WrongFormat_2()
        {
            TestInterface.TestInterfaceClass OTestInterface = new TestInterface.TestInterfaceClass();
            OTestInterface.Init();
            OTestInterface.Send("[TH,WriteOnOffBri,10,]");
            string szActualop = OTestInterface.Receive();
            Assert.AreEqual("[TH,WriteOnOffBri,0]", szActualop);

        }
    }
}
