using MercadoEF.Dominio.Entidades;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MercadoEF.Dominio.Contratos.Servicos
{
    public interface IProdutoServico
    {
        Task<IEnumerable> ObterTodos(bool incluirVendas = false);

        Task<Produto> ObterPorId(int id, bool incluirVendas = false);

        Task<IEnumerable> ObterPorNome(string nome, bool incluirVendas = false);

        Task<IEnumerable> MaiorProduto();

        Task Adicionar(Produto produto);

        Task<bool> SalvarAlteracoes();

        void Atualizar(Produto produto);

        void Remover(Produto produto);

        IEnumerable ObterProdutos();
    }
}
