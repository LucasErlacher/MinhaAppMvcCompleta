using DevIO.App.Extensions;
using DevIO.Business.Interfaces;
using DevIO.Business.Notificacoes;
using DevIO.Business.Services;
using DevIO.Data.Context;
using DevIO.Data.Repositories;
using Microsoft.AspNetCore.Mvc.DataAnnotations;
using Microsoft.Extensions.DependencyInjection;

namespace DevIO.App.Configurations
{
    public static class DependencyInjectionConfig
    {
        public static IServiceCollection ResolveDependencies(this IServiceCollection services)
        {
            //Context
            services.AddScoped<MeuDbContext>();

            //Repository
            services.AddScoped<IProdutoRepository, ProdutoRepository>();
            services.AddScoped<IFornecedorRepository, FornecedorRepository>();
            services.AddScoped<IEnderecoRepository, EnderecoRepository>();

            //Attributes
            services.AddSingleton<IValidationAttributeAdapterProvider, MoedaValidationAttruibuteAdapterProvider>();

            //Services
            services.AddScoped<IProdutoService, ProdutoService>();
            services.AddScoped<IFornecedorService, FornecedorService>();

            //Notification
            services.AddScoped<INotificador, Notificador>();

            return services;
        }
    }
}
