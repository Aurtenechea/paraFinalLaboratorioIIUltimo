using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Testeando_25_10_16;

namespace Testeando
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void InstanciaEstacionamiento()
        {
            //instanciar un estacionamiento
            Estacionamiento unEst = new Estacionamiento();
            Assert.IsNotNull(unEst);
         }


        [TestMethod]
        public void ListadoInstanciado()
        {
            Estacionamiento unEst = new Estacionamiento();
            Assert.IsNotNull(unEst.lsVehiculos);
        }
    }
}
