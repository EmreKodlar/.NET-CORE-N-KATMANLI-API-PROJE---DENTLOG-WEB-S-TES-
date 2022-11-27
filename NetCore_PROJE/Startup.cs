using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc.Authorization;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetCore_PROJE
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

            services.AddSession(); // biz ekledik

            //-- buray� da biz ekledik ---
            services.AddMvc(config =>
            {
                var policy = new AuthorizationPolicyBuilder()
                .RequireAuthenticatedUser()
                .Build();
                config.Filters.Add(new AuthorizeFilter(policy));
            });

            services.AddMvc();

            services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme).AddCookie(

                x =>
                {
                    x.LoginPath = "/Register/IndexSignIn"; // authentication olmayanalar� y�nlendirece�imiz sayfa.
                }
                );

            //------------------------


            ////--- jwt i�in ekledi�imiz configirasy�onlar-------
            //services.AddAuthentication(x =>
            //{
            //    x.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
            //    x.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            //}).AddJwtBearer(x =>
            //{
            //    x.RequireHttpsMetadata = true; //https laz�m m� de�il mi
            //    x.SaveToken = true;
            //    x.TokenValidationParameters = new TokenValidationParameters
            //    {
            //        ValidIssuer = Configuration["Token:Issuer"], // appsettingten �ekiyoruz, kim tafar�ndan olu�turuluyor // http://www.mywebsites.com
            //        ValidAudience = Configuration["Token:Audience"], // kim tara�ndan t�ketilecek // http://www.apileriKullanacakDigerSite.com
            //        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(Configuration["Token:SecurityKey"])), // keyi tan�mla
            //        ValidateIssuerSigningKey = true, // key �al��s�n
            //        ValidateLifetime = true,
            //        ClockSkew = TimeSpan.Zero,
            //        ValidateIssuer = true,
            //        ValidateAudience = true
            //    };
            //});
            ////-------------------------------------------------

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
            app.UseStatusCodePagesWithReExecute("/ErrorPage/Error1", "?code={0}");

            app.UseHttpsRedirection();

            app.UseStaticFiles();

            app.UseSession(); // bunu da biz ekledik...

            app.UseAuthentication(); // bunu biz ekledik...

            app.UseRouting();

            app.UseAuthorization();

            //app.UseCookiePolicy(); //Cookie i�lemi 2

            app.UseEndpoints(endpoints =>
            {
              //  endpoints.MapControllerRoute(
              //name: "Blog",
              //pattern: "Blog/{id}/{blogTitle}",
              //new { controller = "Blog", action = "BlogDetails" });

                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Blog}/{action=IndexBlog}/{id?}");
        });
        }
}
}
