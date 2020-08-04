using MercadoEF.Dominio.Entidades;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MercadoEF.Dominio.Contratos.Servicos
{
    public interface IVendaServico
    {
        Task<IEnumerable> ObterTodas(bool incluirTodosItens = false);

        Task<Venda> ObterPorId(int id, bool incluirTodosItens = false);

        Task<Venda> ObterPorData(DateTime data, bool incluirTodosItens = false);

        void Adicionar(Venda venda);

        void Atualizar(Venda venda);

        void Remover(Venda venda);

        Task<bool> SalvarAlteracoes();
    }
}
