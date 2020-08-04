using System;
using System.Collections.Generic;
using System.Text;

namespace MercadoEF.Dominio.Entidades
{
    public class Produto
    {
        public int Id { get; set; }

        public string NomeProduto { get; set; }

        public int Quantidade { get; set; }

        public decimal PrecoUnitario { get; set; }

        public ICollection<Venda> Vendas { get; set; }
    }
}
