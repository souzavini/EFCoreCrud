using MercadoEF.Dominio.Contratos;
using MercadoEF.Dominio.Entidades;
using MercadoEF.Repositorio.Contexto;
using System;
using System.Collections.Generic;
using System.Text;

namespace MercadoEF.Repositorio.Repositorio
{
    public class VendedorRepositorio : BaseRepositorio<Vendedor>,IVendedorRepositorio
    {
        public VendedorRepositorio(MercadoContext mercadoContext) : base(mercadoContext)
        {

        }


    }
}
