using app_teste.Models.Interfaces;
using app_teste.Repositories.Context;
using app_teste.Repositories.Repository;
using app_teste.Repositories.Repository.Marca;
using app_teste.Repositories.Repository.Proprietario;
using app_teste.Repositories.Repository.Veiculo;
using app_teste.Services.AutoMapper;
using app_teste.Services.RabbitMQ;
using app_teste.Services.Service;
using app_teste.Services.Service.Marca;
using app_teste.Services.Service.Proprietario;
using app_teste.Services.Service.Veiculo;
using AutoMapper;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using RabbitMqConfiguration;

namespace app_teste
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
            services.AddControllersWithViews();

            // String conexao
            services.AddDbContext<AppDbContext>(o => o.UseSqlServer(Configuration.GetConnectionString("Conexao")));

            // Injecao de dependencia das services
            StartDependencyInjectionAddTransient(services);

            // Auto Mapper Configurations
            var mappingConfig = new MapperConfiguration(mc =>
            {
                mc.AddProfile(new MappingProfile());
            });
            IMapper mapper = mappingConfig.CreateMapper();
            services.AddSingleton(mapper);

            services.Configure<RabbitConfiguration>(Configuration.GetSection("RabbitMq"));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }

        public void StartDependencyInjectionAddTransient(IServiceCollection services)
        {
            services.AddTransient<ProprietarioService>();
            services.AddTransient<ProprietarioRepository>();
            services.AddTransient<MarcaService>();
            services.AddTransient<MarcaRepository>();
            services.AddTransient<VeiculoService>();
            services.AddTransient<VeiculoRepository>();
            services.AddTransient<RabbitMqService>();
            services.AddScoped(typeof(IService<>), typeof(BaseService<>));
            services.AddScoped(typeof(IRepository<>), typeof(BaseRepository<>));

        }

    }
}
