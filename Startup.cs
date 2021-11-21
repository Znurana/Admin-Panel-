using FluentValidation.AspNetCore;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using Test_AdminPanel.Data;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.Authorization;
using Microsoft.AspNetCore.Http;
using ElmahCore.Sql;
using ElmahCore.Mvc;

namespace Test_AdminPanel
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
            services.AddMvc(config =>
            {
                var policy = new AuthorizationPolicyBuilder().
                                         RequireAuthenticatedUser().
                                          Build();

                config.Filters.Add(new AuthorizeFilter(policy));
            });

            services.AddMvc();

            services.AddElmah<SqlErrorLog>(options =>
            {
                options.ConnectionString = "Server=DESKTOP-LD6PVLC;Database=Admin_Panel;Trusted_Connection=True;MultipleActiveResultSets=true";
            });


            services.AddElmahIo(o =>
            {
                o.ApiKey = "17382270ea044b069ee8107c19c4f542";
                o.LogId = new Guid("aa56091a-b203-4456-bca5-f6b49e4f9d9a");
            });
            services.Configure<CookiePolicyOptions>(options =>
            {
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });

            services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
                .AddCookie(x =>
                 {
                     x.LoginPath = "/Login/Index";
                     x.AccessDeniedPath = "/Main/AccessDenied";
                 });


            services.AddControllersWithViews().AddFluentValidation(x => x.RegisterValidatorsFromAssemblyContaining<Startup>());



            services.AddDbContext<Context>(options =>
            {
                options.UseSqlServer(Configuration["ConnectionString:Default"]);
            });
           


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
            app.UseElmah();
            app.UseElmahIo();
           
            app.UseStatusCodePagesWithReExecute("/ErrorPage/Error1", "?code={0}");

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();
            app.UseCookiePolicy();
            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Login}/{action=Index}/{id?}");
            });
        }
    }
}
