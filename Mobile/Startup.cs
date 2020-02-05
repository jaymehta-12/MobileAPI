using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.FileProviders;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Mobile.DL.Interface;
using Mobile.DL.Entity;
using Mobile.DL.Repository;
using Mobile.Interface;
using Mobile.MobileRepoAPI;
using Mobile.BL.Interface;
using Mobile.BL.Repository;
using AutoMapper;
using Mobile.AutoMapper;

namespace Mobile
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        
        public void ConfigureServices(IServiceCollection services)
        {
           // services.AddTransient<Class>().AddTransient<IMobileAPI, Class>(a=>a.GetService<Class>());
           
            services.AddTransient<IMobileAPI, Class>();
            services.AddTransient<IMobileBL, MobileRepoBL>();
            services.AddTransient<IMobileRepository, MobileRepository>();
            
            services.AddCors(opt => opt.AddPolicy("_Allowed", builder => builder.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod()));
            services.AddControllers();

            services.AddDbContext<MobileContext>(opt =>
               opt.UseSqlServer(Configuration.GetConnectionString("MobileStore")));

            var mappingConfig = new MapperConfiguration(mc =>
            {
                mc.AddProfile(new Automapper());
            });
            IMapper mapper = mappingConfig.CreateMapper();
            services.AddSingleton(mapper);


            // services.AddCors();
        }

        
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseCors("_Allowed");
            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });

            app.UseStaticFiles();
            
        }
    }
}
