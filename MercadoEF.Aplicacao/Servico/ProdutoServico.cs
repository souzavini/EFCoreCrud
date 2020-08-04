using MercadoEF.Dominio.Contratos;
using MercadoEF.Dominio.Contratos.Servicos;
using MercadoEF.Dominio.Entidades;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MercadoEF.Aplicacao.Servico
{
    public class ProdutoServico : IProdutoServico
    {
        private readonly IProdutoRepositorio ProdutoRepositorio;
        public ProdutoServico(IProdutoRepositorio produtoRepositorio)
        {
            ProdutoRepositorio = produtoRepositorio;
        }

        public Task<IEnumerable> MaiorProduto()
        {
            throw new NotImplementedException();
        }

        public Task<Produto> ObterPorId(int id, bool incluirVendas = false)
        {
            return ProdutoRepositorio.ObterPorId(id);
        }

        public Task<IEnumerable> ObterPorNome(string nome, bool incluirVendas = false)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable> ObterTodos(bool incluirVendas = false)
        {
            return await ProdutoRepositorio.ObterTodos();
        }

        public async Task Adicionar(Produto produto)
        {
              ProdutoRepositorio.Adicionar(produto);
        }

        public async Task<bool> SalvarAlteracoes()
        {
            return await ProdutoRepositorio.SalvarAlteracoes();
        }

        public void Atualizar(Produto produto)
        {
            ProdutoRepositorio.Atualizar(produto);
        }

        public void Remover(Produto produto)
        {
            ProdutoRepositorio.Remover(produto);
        }

        public IEnumerable ObterProdutos()
        {
            return ProdutoRepositorio.ObterProdutos();
        }
    }
}
