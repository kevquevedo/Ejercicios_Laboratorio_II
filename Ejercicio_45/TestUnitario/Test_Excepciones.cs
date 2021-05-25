using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Ejercicio_42;

namespace TestUnitario
{
    [TestClass]
    public class Test_Excepciones
    {

        #region TEST_UNAEXCEPCION
        [TestMethod]
        public void UnaExcepcion_ConsGenerico_NotNull()
        {
            //Arrange
            UnaExcepcion unaExcepcion;

            //Act
            unaExcepcion = new UnaExcepcion();

            //Assert
            Assert.IsNotNull(unaExcepcion);
        }


        [TestMethod]
        public void UnaExcepcion_ConsMensaje_NotNull()
        {
            //Arrange
            UnaExcepcion unaExcepcion;

            //Act
            unaExcepcion = new UnaExcepcion("HOLA");

            //Assert
            Assert.IsNotNull(unaExcepcion);
        }

        [TestMethod]
        public void UnaExcepcion_ConsMensajeEInner_NotNull()
        {
            //Arrange
            UnaExcepcion unaExcepcion;
            Exception innerException = new Exception();

            //Act
            unaExcepcion = new UnaExcepcion("HOLA", innerException);

            //Assert
            Assert.IsNotNull(unaExcepcion);
        }

        #endregion

        #region TEST_MIEXCEPCION
        [TestMethod]
        public void MiExcepcion_ConsGenerico_NotNull()
        {
            //Arrange
            MiExcepcion miExcepcion;

            //Act
            miExcepcion = new MiExcepcion();

            //Assert
            Assert.IsNotNull(miExcepcion);
        }


        [TestMethod]
        public void MiExcepcion_ConsMensaje_NotNull()
        {
            //Arrange
            MiExcepcion miExcepcion;

            //Act
            miExcepcion = new MiExcepcion("HOLA");

            //Assert
            Assert.IsNotNull(miExcepcion);
        }

        [TestMethod]
        public void MiExcepcion_ConsMensajeEInner_NotNull()
        {
            //Arrange
            MiExcepcion miExcepcion;
            Exception innerException = new Exception();

            //Act
            miExcepcion = new MiExcepcion("HOLA", innerException);

            //Assert
            Assert.IsNotNull(miExcepcion);
        }

        #endregion

        #region MI_CLASE

        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public void MiClase_MetodoMiClase_Excepcion()
        {
            //Arrange //Act
            MiClase.MetodoMiClase();
        }

        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public void MiClase_Cons_MiClase_Excepcion()
        {
            //Arrange //Act
            MiClase miClase = new MiClase();
        }

        [TestMethod]
        [ExpectedException(typeof(UnaExcepcion))]
        public void MiClase_Cons_MiClaseInt_Excepcion()
        {
            //Arrange //Act
            MiClase miClase = new MiClase(2);
        }

        #endregion

        #region OTRA_CLASE

        [TestMethod]
        [ExpectedException(typeof(MiExcepcion))]
        public void OtraClase_Method_MetodoOtraClase_Excepcion()
        {
            //Arrange
            OtraClase otraClase = new OtraClase();

            //Act
            otraClase.MetodoOtraClase();
        }

        #endregion
    }
}
