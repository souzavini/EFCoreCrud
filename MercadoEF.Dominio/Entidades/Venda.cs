using System;
using System.Collections.Generic;
using System.Text;

namespace MercadoEF.Dominio.Entidades
{
    public class Venda
    {
        public int Id { get; set; }

        public DateTime DataPedido { get; set; }

        public int Quantidade { get; set; }

        public int ProdutoId { get; set; }
        public Produto Produto { get; set; }

        public int VendedorId { get; set; }
        public Vendedor Vendedor { get; set; }

    }
}
