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
    public class VendasRepositorio:BaseRepositorio<Venda>,IVendaRepositorio
    {
        public VendasRepositorio(MercadoContext mercadoContext) : base(mercadoContext)
        {

        }

        public async Task<Venda> ObterPorId(int id, bool incluirTodosItens = false)
        {
            IQueryable<Venda> query = MercadoContext.Vendas
               .AsNoTracking()
               .OrderBy(p => p.Id);

            if (incluirTodosItens)
            {
                query = query.Include(v=> v.Vendedor)
                    .Include(p=>p.Produto)
                    .AsNoTracking()
                    .OrderBy(p => p.Id);
            }

            return await query.FirstOrDefaultAsync(p=> p.Id == id);
        }

        public async Task<IEnumerable> ObterPorData(DateTime data, bool incluirTodosItens = false)
        {
            IQueryable<Venda> query = MercadoContext.Vendas
              .AsNoTracking()
              .Where(p => p.DataPedido == data)
              .OrderBy(p => p.Id);

            if (incluirTodosItens)
            {
                query = query.Include(v => v.Vendedor)
                    .Include(p => p.Produto)
                    .AsNoTracking()
                    .OrderBy(p => p.Id);
            }

            return await query.ToArrayAsync();
        }

        public async Task<IEnumerable> ObterTodas(bool incluirTodosItens = false)
        {
            IQueryable<Venda> query = MercadoContext.Vendas
                .AsNoTracking()
                .OrderBy(p => p.Id);

            if (incluirTodosItens)
            {
                query = query.Include(v => v.Vendedor)
                   .Include(p => p.Produto)
                   .AsNoTracking()
                   .OrderBy(p => p.Id);
            }

            return await query.ToArrayAsync();
        }

        Task<Venda> IVendaRepositorio.ObterPorData(DateTime data, bool incluirTodosItens)
        {
            throw new NotImplementedException();
        }
    }
}
