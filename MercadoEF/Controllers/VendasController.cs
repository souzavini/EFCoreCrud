using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MercadoEF.Dominio.Contratos;
using MercadoEF.Dominio.Contratos.Servicos;
using MercadoEF.Dominio.Entidades;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MercadoEF.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VendasController : ControllerBase
    {
        private readonly IVendaServico VendaServico;
        public VendasController(IVendaServico vendaServico)
        {
            VendaServico = vendaServico;
        }
        // GET: api/<VendasController>
        [HttpGet]
        public async Task<IActionResult> ObterTodasVendas()
        {
            try
            {
                var vendas = await VendaServico.ObterTodas();

                return Ok(vendas);
            }
            catch (Exception ex)
            {

                return BadRequest($"Erro: { ex }");
            }
        }

        // GET api/<VendasController>/5
        [HttpGet("{id}")]
        public async Task<IActionResult> ObterPorId(int id)
        {
            try
            {
                var venda = await VendaServico.ObterPorId(id);

                return Ok(venda);

            }
            catch (Exception ex)
            {

                return BadRequest($"Erro: { ex }");
            }
        }

        [HttpPost("data")]
        public async Task<IActionResult> ObterPorData(DateTime data)
        {
            try
            {
                var venda = await VendaServico.ObterPorData(data);

                return Ok(venda);

            }
            catch (Exception ex)
            {

                return BadRequest($"Erro: { ex }");
            }
        }

        // POST api/<VendasController>
        [HttpPost]
        public async Task<IActionResult> AdicionarVenda([FromBody] Venda venda)
        {
            try
            {
                VendaServico.Adicionar(venda);

                if (await VendaServico.SalvarAlteracoes())
                {
                    return Created("api/vendas", venda);
                }
                else
                {
                    return BadRequest("Não foi salvo");
                }


            }
            catch (Exception ex)
            {

                return BadRequest($"Erro: { ex }");
            }
        }

        // PUT api/<VendasController>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Atualizar(int id, [FromBody] Venda venda)
        {
            try
            {
                var vendas = await VendaServico.ObterPorId(id);
                if (vendas != null)
                {
                    VendaServico.Atualizar(venda);
                    if (await VendaServico.SalvarAlteracoes())
                    {
                        return Ok("A venda foi atualizada com sucesso");
                    }
                    else
                    {
                        return BadRequest("Erro ao atualizar , tente novamente");
                    }
                }
            }
            catch (Exception ex)
            {

                return BadRequest($"Erro: { ex }");
            }

            return BadRequest("Venda Não encontrada para o ID informado");
        }

        // DELETE api/<VendasController>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                var venda = await VendaServico.ObterPorId(id);
                if (venda != null)
                {
                    VendaServico.Remover(venda);
                    if (await VendaServico.SalvarAlteracoes())
                    {
                        return Ok("A Venda foi excluída");
                    }
                    else
                    {
                        return BadRequest("Erro ao deletar , tente novamente");
                    }
                }
            }
            catch (Exception ex)
            {

                return BadRequest($"Erro: { ex }");
            }

            return BadRequest("Venda Não encontrada");
        }
    }
    
}
