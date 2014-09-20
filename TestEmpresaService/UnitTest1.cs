using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SCTServiceWCF.Dominio;

namespace TestEmpresaService
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Test1_CrearEmpresa()
        {
            SCTServiceWCF.Servicios.Empresas EmpresaWS = new SCTServiceWCF.Servicios.Empresas();
            Empresa resultado = EmpresaWS.CrearEmpresa("Transporte Cholo", "104343234432", "5643232", "su casa en donde no se");
            Assert.AreEqual("Transporte Cholo", resultado.EMPRESA);            
        }

        [TestMethod]
        public void Test2_ModificarEmpresa()
        {
            SCTServiceWCF.Servicios.Empresas EmpresaWS = new SCTServiceWCF.Servicios.Empresas();
            Empresa resultado = EmpresaWS.ModificarEmpresa(25, "Empresa el Ande", "343234565675", "453212", "su domicilio");
            Assert.AreEqual("Empresa el Ande", resultado.EMPRESA);
        }
        [TestMethod]
        public void Test3_EliminarEmpresa()
        {
            SCTServiceWCF.Servicios.Empresas EmpresaWS = new SCTServiceWCF.Servicios.Empresas();
            EmpresaWS.EliminarEmpresa(24);
            Empresa resultado = EmpresaWS.ObtenerEmpresa(27);
            Assert.AreEqual(null, resultado);
        }
        [TestMethod]
        public void Test4_ListarEmpresa()
        {
            SCTServiceWCF.Servicios.Empresas EmpresaWS = new SCTServiceWCF.Servicios.Empresas();
            List<Empresa> resultado = EmpresaWS.ListarEmpresa();
            Assert.AreEqual(18, resultado.Count);
        }

    }
}
