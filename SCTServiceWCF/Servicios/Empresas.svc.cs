﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using SCTServiceWCF.Persistencia;
using SCTServiceWCF.Dominio;

namespace SCTServiceWCF.Servicios
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Empresas" en el código, en svc y en el archivo de configuración a la vez.
    public class Empresas : IEmpresas
    {

        #region Miembros de IEmpresas

                   private EmpresaDAO empresaDAO= null;
                    private EmpresaDAO EmpresaDAO
                    {
                        get
                        {
                            if (empresaDAO == null)
                                empresaDAO = new EmpresaDAO();
                            return empresaDAO;
                        }
                    }

        

        public Dominio.Empresa CrearEmpresa(string empresa, string ruc, string telefono, string direccion)
        
        {
            Empresa EmpresaACrear = new Empresa()
            {

                    EMPRESA =empresa ,
                    RUC =ruc,
                    DIRECCION =direccion ,
                    TELEFONO =telefono 
            };

            return EmpresaDAO.Crear(EmpresaACrear);
        }


        public Dominio.Empresa ObtenerEmpresa(int codigo, string empresa, string ruc, string telefono, string direccion)
        {
            return EmpresaDAO.Obtener(codigo);
        }

        public Dominio.Empresa ModificarEmpresa(int codigo, string empresa, string ruc, string telefono, string direccion)
        {
            Empresa empresaAModificar = new Empresa()
            {
                ID_EMPRESA = codigo,
                EMPRESA = empresa,
                RUC = ruc,
                DIRECCION = direccion,
                TELEFONO = telefono 
            };

            return EmpresaDAO.Modificar(empresaAModificar);
        }

        public void EliminarEmpresa(int codigo)
        {
            Empresa empresaExistente = EmpresaDAO.Obtener(codigo);
            EmpresaDAO.Eliminar(empresaExistente);
        }

        public List<Empresa> ListarEmpresa()
        {
            return EmpresaDAO.ListarTodos().ToList();
        }

        public Empresa ObtenerEmpresa(int p)
        {
            throw new NotImplementedException();
        }
    }

        #endregion
    }

