using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Biblioteca;

namespace TestUnitario
{
    [TestClass]
    public class Test_Unitario
    {
        [TestMethod]
        public void Competencia_ListaVehiculos_NotNull()
        {
            //Arrange
            Competencia competencia;

            //Act
            competencia = new Competencia(2, 4, Competencia.TipoCompetencia.AutoF1);

            //Assert
            Assert.IsNotNull(competencia);
        }

        [TestMethod]
        [ExpectedException(typeof(CompetenciaNoDisponibleException))]
        public void Competencia_AutoEnCompetenciaMotocross_Excepcion()
        {
            //Arrange
            Competencia competencia = new Competencia(2, 3, Competencia.TipoCompetencia.MotoCross);
            AutoF1 autoF1 = new AutoF1(2, "Ferrari");

            //Act
            bool resultado = competencia + autoF1;
        }

        [TestMethod]
        [ExpectedException(typeof(CompetenciaNoDisponibleException))]
        public void Competencia_MotoEnCompetenciaMotocross_Excepcion()
        {
            //Arrange
            Competencia competencia = new Competencia(2, 3, Competencia.TipoCompetencia.MotoCross);
            Motocross motocross = new Motocross(2, "Ferrari", 150);

            //Act
            bool resultado = competencia + motocross;
        }

        [TestMethod]
        [ExpectedException(typeof(CompetenciaNoDisponibleException))]
        public void Competencia_AgregarVehiculoEnCompetencia_IsTrue()
        {
            //Arrange
            Competencia competencia = new Competencia(2, 6, Competencia.TipoCompetencia.AutoF1);
            Motocross motocross = new Motocross(2, "Ferrari", 150);

            //Act
            bool resultado = competencia + motocross;
            bool resultado2 = competencia == motocross;
            //Assert
            Assert.IsTrue(resultado2);
        }

        [TestMethod]
        public void Competencia_EliminarVehiculoEnCompetencia_IsTrue()
        {
            //Arrange
            Competencia competencia = new Competencia(2, 6, Competencia.TipoCompetencia.MotoCross);
            Motocross motocross = new Motocross(2, "Ferrari", 150);

            //Act
            bool resultado = competencia - motocross;
            bool resultado2 = competencia != motocross;

            //Assert
            Assert.IsTrue(resultado2);
        }
    }
}
