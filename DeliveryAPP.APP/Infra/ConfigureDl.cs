using AutoMapper;
using DeliveryAPP.APP.Cadastros;
using DeliveryAPP.APP.Model;
using DeliveryAPP.Domain.Base;
using DeliveryAPP.Domain.Entities;
using DeliveryAPP.Repository.Context;
using DeliveryAPP.Repository.Repository;
using DeliveryAPP.Service.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;


namespace DeliveryAPP.APP.Infra
{
    public static class ConfigureDl
    {
        public static ServiceCollection? Services;

        public static ServiceProvider? ServicesProvider;

        public static void ConfiguraServices()
        {
            Services = new ServiceCollection();
            var strCon = File.ReadAllText("Config/DatabaseSettings.txt");
            Services.AddDbContext<MySqlContext>(options =>
            {
                options.LogTo(Console.WriteLine)
                    .EnableSensitiveDataLogging();
                //options.UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);
                //options.EnableSensitiveDataLogging();


                options.UseMySql(strCon, ServerVersion.AutoDetect(strCon), opt =>
                {
                    opt.CommandTimeout(180);
                    opt.EnableRetryOnFailure(5);
                });
            });

            // Repositories
            Services.AddScoped<IBaseRepository<Restaurante>, BaseRepository<Restaurante>>();
            Services.AddScoped<IBaseRepository<Cidade>, BaseRepository<Cidade>>();
            Services.AddScoped<IBaseRepository<Cliente>, BaseRepository<Cliente>>();
            Services.AddScoped<IBaseRepository<Categoria>, BaseRepository<Categoria>>();
            Services.AddScoped<IBaseRepository<Produto>, BaseRepository<Produto>>();
            Services.AddScoped<IBaseRepository<Pedido>, BaseRepository<Pedido>>();

            // Services
            Services.AddScoped<IBaseService<Restaurante>, BaseService<Restaurante>>();
            Services.AddScoped<IBaseService<Cidade>, BaseService<Cidade>>();
            Services.AddScoped<IBaseService<Cliente>, BaseService<Cliente>>();
            Services.AddScoped<IBaseService<Categoria>, BaseService<Categoria>>();
            Services.AddScoped<IBaseService<Produto>, BaseService<Produto>>();
            Services.AddScoped<IBaseService<Pedido>, BaseService<Pedido>>();

            // Formulários
            Services.AddTransient<CadastroRestaurante, CadastroRestaurante>();
            Services.AddTransient<CadastroCategoria, CadastroCategoria>();
            Services.AddTransient<CadastroProduto, CadastroProduto>();
            Services.AddTransient<CadastroCidade, CadastroCidade>();
            Services.AddTransient<CadastroCliente, CadastroCliente>();
            Services.AddTransient<CadastroPedido, CadastroPedido>();

            // Mapping
            Services.AddSingleton(new MapperConfiguration(config =>
            {
                config.CreateMap<Restaurante, RestauranteModel>();
                config.CreateMap<Cidade, CidadeModel>()
                    .ForMember(d => d.Nome, d => d.MapFrom(x => $"{x.Nome}/{x.Estado}"));
                config.CreateMap<Cliente, ClienteModel>()
                    .ForMember(d => d.Cidade, d => d.MapFrom(x => $"{x.Cidade!.Nome}/{x.Cidade!.Estado}"))
                    .ForMember(d => d.IdCidade, d => d.MapFrom(x => x.Cidade!.Id));
                config.CreateMap<Categoria, CategoriaModel>();
                config.CreateMap<Produto, ProdutoModel>()
                    .ForMember(d => d.Categoria, d => d.MapFrom(x => x.Categoria!.Nome))
                    .ForMember(d => d.IdCategoria, d => d.MapFrom(x => x.Categoria!.Id));
                config.CreateMap<Pedido, PedidoModel>()
                    .ForMember(d => d.IdCliente, d => d.MapFrom(x => x.Cliente!.Id))
                    .ForMember(d => d.Cliente, d => d.MapFrom(x => x.Cliente!.Nome))
                    .ForMember(d => d.IdRestaurante, d => d.MapFrom(x => x.Restaurante!.Id))
                    .ForMember(d => d.Restaurante, d => d.MapFrom(x => x.Restaurante!.Nome));

                config.CreateMap<ItemPedido, ItemPedidoModel>()
                    .ForMember(d => d.IdProduto, d => d.MapFrom(x => x.Produto!.Id))
                    .ForMember(d => d.Produto, d => d.MapFrom(x => x.Produto!.Nome));

            }).CreateMapper());

            ServicesProvider = Services.BuildServiceProvider();
        }
    }
}
