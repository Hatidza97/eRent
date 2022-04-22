using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using eRent.Services;
using eRent.Model.Request;
using eRent.Interface;
using Microsoft.EntityFrameworkCore;
using eRent.Database;
using eRent.Model.Request.Drzava;

namespace eRent
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
          
            services.AddControllers().AddNewtonsoftJson(options => 
                options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore);
            
            services.AddControllers();
            services.AddSwaggerGen();
            services.AddDbContext<MobisContext>(c => c.UseSqlServer(Configuration.GetConnectionString("DefaultConnection"))
            .EnableSensitiveDataLogging());
            services.AddAutoMapper(typeof(Startup));
            services.AddScoped<IService<Model.Model.Drzava, DrzavaSearchRequest>, DrzavaService>();
            services.AddScoped<ICRUDService<Model.Model.Grad, Model.Request.Grad.GradSearchRequest, Model.Request.Grad.GradInsertRequest, Model.Request.Grad.GradInsertRequest>, GradService>();
            services.AddScoped<IKorisniciService, KorisniciService>();
            services.AddScoped<IUlogeService, UlogeService>();
            services.AddScoped<IObjekatService, ObjekatService>();
            services.AddScoped<IKategorijaService, KategorijaService>();
            services.AddScoped<ITipObjektumService, TipObjektumService>();
            services.AddScoped<IRezervacijaService, RezervacijaService>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint(url: "/swagger/v1/swagger.json", "My API V1");
            });
            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
