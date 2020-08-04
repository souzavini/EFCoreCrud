using MercadoEF.Dominio.Contratos;
using MercadoEF.Repositorio.Contexto;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MercadoEF.Repositorio.Repositorio
{
    public class BaseRepositorio<TEntity> : IBaseRepositorio<TEntity> where TEntity : class
    {
        protected readonly MercadoContext MercadoContext;
        public BaseRepositorio(MercadoContext mercadoContext)
        {
            MercadoContext = mercadoContext;
        }

        public void Adicionar(TEntity entity)
        {
            MercadoContext.Add(entity);
        }

        public void Atualizar(TEntity entity)
        {
            MercadoContext.Update(entity);
        }

        public void Remover(TEntity entity)
        {
            MercadoContext.Remove(entity);
        }

        public async Task<bool> SalvarAlteracoes()
        {
           return (await MercadoContext.SaveChangesAsync()) > 0;
        }

        public void Dispose()
        {
            MercadoContext.Dispose();
        }
    }
}
