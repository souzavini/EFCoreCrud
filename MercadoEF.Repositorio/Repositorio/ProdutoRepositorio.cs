using MercadoEF.Dominio.Contratos;
using MercadoEF.Dominio.Entidades;
using MercadoEF.Repositorio.Contexto;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MercadoEF.Repositorio.Repositorio
{
    public class ProdutoRepositorio: BaseRepositorio<Produto>,IProdutoRepositorio
    {
        public ProdutoRepositorio(MercadoContext mercadoContext): base(mercadoContext)
        {

        }

        public Task<IEnumerable> MaiorProduto()
        {
            throw new NotImplementedException();
        }

        //public Task<IEnumerable> MaiorProduto()
        //{
        //    IQueryable<Produto> query = MercadoContext.Produtos
        //        .AsNoTracking()
        //        .

        //}

        public async Task<Produto> ObterPorId(int id, bool incluirVendas = false)
        {
            IQueryable<Produto> query = MercadoContext.Produtos
                .AsNoTracking()
                .OrderBy(p => p.Id);

            if (incluirVendas)
            {
                query = query.Include(p => p.Vendas)
                    .AsNoTracking()
                    .OrderBy(p => p.Id);
            }

            return await query.FirstOrDefaultAsync(p=>p.Id == id);
        }



        public async Task<IEnumerable> ObterPorNome(string nome, bool incluirVendas = false)
        {
            IQueryable<Produto> query = MercadoContext.Produtos
               .AsNoTracking()
               .Where(p=>p.NomeProduto.Contains(nome))
               .OrderBy(p => p.Id);

            if (incluirVendas)
            {
                query = query.Include(p => p.Vendas)
                    .AsNoTracking()
                    .OrderBy(p => p.Id);
            }

            return await query.ToArrayAsync();
        }

        public IEnumerable ObterProdutos()
        {
            var query = (from p in MercadoContext.Produtos
                         select new
                         {
                             p.Id,
                             p.NomeProduto

                         }).ToList();

            return query;
                
        }

        public async Task<IEnumerable> ObterTodos(bool incluirVendas = false)
        {
            IQueryable<Produto> query = MercadoContext.Produtos
                .AsNoTracking()
                .OrderBy(p => p.Id);

            if (incluirVendas)
            {
                query = query.Include(p => p.Vendas)
                    .AsNoTracking()
                    .OrderBy(p => p.Id);
            }

            return await query.ToArrayAsync();

        }
    }
}
