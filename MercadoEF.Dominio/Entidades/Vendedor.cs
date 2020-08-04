using System;
using System.Collections.Generic;
using System.Text;

namespace MercadoEF.Dominio.Entidades
{
    public class Vendedor
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        public virtual ICollection<Venda> Vendas { get; set; }

    }
}
