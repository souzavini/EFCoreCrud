using System;
using System.Collections;
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
    public class ProdutoController : ControllerBase
    {
        private readonly IProdutoServico ProdutoServico;
        public ProdutoController(IProdutoServico produtoRepositorio)
        {
            ProdutoServico = produtoRepositorio;
        }



        // GET: api/<ProdutoController>
        [HttpGet]
        public async Task<IActionResult> ObterTodos()
        {
            try
            {
                var produtos = await ProdutoServico.ObterTodos(true);

                return Ok(produtos);
            }
            catch (Exception ex)
            {

                return BadRequest($"Erro: { ex }");
            }
        }

        [HttpGet("obterProdutos")]
        public IEnumerable ObterProdutps()
        {
            
                var produtos = ProdutoServico.ObterProdutos();

                return produtos;
           
        }

        // GET api/<ProdutoController>/5
        [HttpGet("{id}")]
        public async Task<IActionResult> ObterPorId(int id)
        {
            try
            {
                var produto = await ProdutoServico.ObterPorId(id);

                return Ok(produto);

            }
            catch (Exception ex)
            {

                return BadRequest($"Erro: { ex }");
            }
        }

        // POST api/<ProdutoController>
        [HttpPost]
        public async Task<IActionResult> AdicionarProduto([FromBody] Produto produto)
        {
            try
            {
                await ProdutoServico.Adicionar(produto);

                if (await ProdutoServico.SalvarAlteracoes())
                {
                    return Created("api/produto", produto);
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

        // PUT api/<ProdutoController>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Atualizar(int id, [FromBody] Produto produto)
        {
            try
            {
                var produtos = await ProdutoServico.ObterPorId(id);
                if (produtos != null)
                {
                    ProdutoServico.Atualizar(produto);
                    if (await ProdutoServico.SalvarAlteracoes())
                    {
                        return Ok("O Produto foi atualizado com sucesso");
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

            return BadRequest("Usuario Não encontrado para o ID informado");
        }


        // DELETE api/<ProdutoController>/5
        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            try
            {
                var produto = await ProdutoServico.ObterPorId(id);
                if (produto != null)
                {
                    ProdutoServico.Remover(produto);
                    if (await ProdutoServico.SalvarAlteracoes())
                    {
                        return Ok("O Produto foi excluído");
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

            return BadRequest("Usuario Não encontrado");
        }
    }
}
