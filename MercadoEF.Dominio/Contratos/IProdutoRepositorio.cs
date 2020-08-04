using MercadoEF.Dominio.Entidades;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MercadoEF.Dominio.Contratos
{
    public interface IProdutoRepositorio: IBaseRepositorio<Produto>
    {
        Task<IEnumerable> ObterTodos(bool incluirVendas = false);

        Task<Produto> ObterPorId(int id, bool incluirVendas = false);

        Task<IEnumerable> ObterPorNome(string nome, bool incluirVendas = false);

        Task<IEnumerable> MaiorProduto();

        IEnumerable ObterProdutos();
    }
}
