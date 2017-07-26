using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Practica7;

namespace TestUnitario
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void testMascota()
        {
            Mascota m3 = (Mascota)2; // tortuga.
            Assert.IsInstanceOfType(m3, typeof(Mascota));
        }
        
        [TestMethod]
        public void testMascota2()
        {
            Mascota m3 = (Mascota)2; // tortuga.
            Assert.IsInstanceOfType(m3, typeof(ConsoleColor));
        }
    }
}
