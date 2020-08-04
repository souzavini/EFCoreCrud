using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MercadoEF.Aplicacao.Servico;
using MercadoEF.Dominio.Contratos;
using MercadoEF.Dominio.Contratos.Servicos;
using MercadoEF.Repositorio.Contexto;
using MercadoEF.Repositorio.Repositorio;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Microsoft.OpenApi.Models;


namespace MercadoEF
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;

            
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {

            services.AddDbContext<MercadoContext>(options =>
            options.UseMySql(Configuration.GetConnectionString("ConexaoPadrao")));

            services.AddMvc().AddJsonOptions(opt =>
            opt.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore);

            services.AddScoped<IVendaRepositorio, VendasRepositorio>();
            services.AddScoped<IVendedorRepositorio, VendedorRepositorio>();
            services.AddScoped<IProdutoRepositorio, ProdutoRepositorio>();
            services.AddScoped<IProdutoServico, ProdutoServico>();
            services.AddScoped<IVendaServico, VendaServico>();

            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);



            

        }

        

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            app.UseCors(x => x.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader());

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseMvc();

            

        }
    }
}
