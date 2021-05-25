using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using CentralitaHerencia;

namespace Test_Centralita
{
    [TestClass]
    public class Test_Centralita
    {
        [TestMethod]
        public void Centralita_ValidarLista_NotNull()
        {
            //Arrange
            Centralita centralita;

            //Act
            centralita = new Centralita();

            //Assert
            Assert.IsNotNull(centralita.Llamadas);
        }

        [TestMethod]
        [ExpectedException(typeof(CentralitaException))]
        public void Centralita_LlamadaLocalRepetida_Exception()
        {
            //Arrange
            Centralita centralita = new Centralita("KEVIN");
            Local local1 = new Local("Rosario", 2.4f, "San Martin", 35.45f);
            Local local2 = new Local("Rosario", 4.5f, "San Martin", 26.34f);

            //Act
            bool resultado1 = centralita + local1;
            bool resultado2 = centralita + local2;
        }

        [TestMethod]
        [ExpectedException(typeof(CentralitaException))]
        public void Centralita_LlamadaProvincialRepetida_Exception()
        {
            //Arrange
            Centralita centralita = new Centralita("KEVIN");
            Provincial provincial1 = new Provincial("Mar del Plata", Provincial.Franja.Franja_1, 3.34f, "Buenos Aires");
            Provincial provincial2 = new Provincial("Mar del Plata", Provincial.Franja.Franja_2, 4.55f, "Buenos Aires");

            //Act
            bool resultado1 = centralita + provincial1;
            bool resultado2 = centralita + provincial2;
        }

        [TestMethod]
        public void Centralita_LlamadasGenerales_Exception()
        {
            //Arrange
            Centralita centralita = new Centralita("KEVIN");
            Provincial provincial1;
            Provincial provincial2;
            Local local1;
            Local local2;

            //Act
            provincial1 = new Provincial("Rosario", Provincial.Franja.Franja_1, 3.34f, "Buenos Aires");
            provincial2 = new Provincial("Rosario", Provincial.Franja.Franja_2, 4.55f, "Buenos Aires");
            local1 = new Local("Rosario", 2.4f, "Buenos Aires", 35.45f);
            local2 = new Local("Rosario", 4.5f, "Buenos Aires", 26.34f);

            //Assert
            Assert.AreEqual(local1, local2);
            Assert.AreEqual(provincial1, provincial2);
            Assert.AreNotEqual(local1, provincial1);
            Assert.AreNotEqual(local1, provincial2);
            Assert.AreNotEqual(local2, provincial1);
            Assert.AreNotEqual(local2, provincial2);
        }
    }
}
