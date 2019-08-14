using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Microsoft.EntityFrameworkCore;

namespace MyWebRecruit.Api
{
    public class Startup
    {
        public IConfigurationRoot Configuration { get; set; }
        public static string ConnectionString { get; private set; }

        /*
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        */
        //public IConfiguration Configuration { get; }

        public Startup(IHostingEnvironment environment)
        {
            Configuration = new ConfigurationBuilder().SetBasePath(environment.ContentRootPath).AddJsonFile("appSettings.json").Build();
        }

        // This method gets called by the runtime. Use this method to add services to the container.

        public void ConfigureServices(IServiceCollection services)
        {
            //string connection = Configuration.GetConnectionString("DefaultConnection");
            //services.AddDbContext<MyWebRecruitDataBaseContext>(options => options.UseSqlServer(connection));
            services.AddMvc();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            ConnectionString = Configuration["ConnectionStrings:DefaultConnection"];


            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }

            app.UseStaticFiles();
            app.UseHttpsRedirection();
            app.UseMvc(routes =>
            {
                routes.MapRoute(name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
