using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WEB_API
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
            services.AddControllers();
            //---- cors i�in yap�land�rma ayarlar�-----
            services.AddCors(options => options.AddDefaultPolicy(policy =>
            //Api ye istekte bulunan localhost k�sm�
           policy.WithOrigins("http://localhost:44380", "https://localhost:44380").AllowAnyHeader().AllowAnyMethod()
            ));
            //-----------------------------------------

            //--- jwt i�in ekledi�imiz configirasy�onlar-------
            
            services.AddAuthentication(x =>
            {
                x.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                x.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            }).AddJwtBearer(x =>
            {
                x.RequireHttpsMetadata = true; //https laz�m m� de�il mi
                x.SaveToken = true;
                x.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidIssuer = Configuration["Token:Issuer"], // appsettingten �ekiyoruz, kim tafar�ndan olu�turuluyor // http://www.mywebsites.com
                    ValidAudience = Configuration["Token:Audience"], // kim tara�ndan t�ketilecek // http://www.apileriKullanacakDigerSite.com
                    IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(Configuration["Token:SecurityKey"])), // keyi tan�mla
                    ValidateIssuerSigningKey = true, // key �al��s�n
                    ValidateLifetime = true,
                    ClockSkew = TimeSpan.Zero,
                    ValidateIssuer = true,
                    ValidateAudience = true
                };
            });
            //-------------------------------------------------
        }
        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();
            
            app.UseCors(); // cors middleware'ini ekledik....

            app.UseAuthentication();// jwt token i�in biz ekledik.s�ras� �nemli...
             
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
