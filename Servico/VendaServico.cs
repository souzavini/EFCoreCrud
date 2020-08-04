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
    public class VendaServico : IVendaServico
    {
        private readonly IVendaRepositorio VendaRepositorio;
        public VendaServico(IVendaRepositorio vendaRepositorio)
        {
            VendaRepositorio = vendaRepositorio;
        }

        public void Adicionar(Venda venda)
        {
            VendaRepositorio.Adicionar(venda);
        }

        public void Atualizar(Venda venda)
        {
            VendaRepositorio.Atualizar(venda);
        }

        public async Task<Venda> ObterPorData(DateTime data, bool incluirTodosItens = false)
        {
           return await VendaRepositorio.ObterPorData(data);
        }

        public async Task<Venda> ObterPorId(int id, bool incluirTodosItens = false)
        {
            return await VendaRepositorio.ObterPorId(id);
        }

        public async Task<IEnumerable> ObterTodas(bool incluirTodosItens = false)
        {
            return await VendaRepositorio.ObterTodas();
        }

        public void Remover(Venda venda)
        {
            VendaRepositorio.Remover(venda);
        }

        public async Task<bool> SalvarAlteracoes()
        {
            return await VendaRepositorio.SalvarAlteracoes();
        }
    }
}
