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
            //---- cors için yapýlandýrma ayarlarý-----
            services.AddCors(options => options.AddDefaultPolicy(policy =>
            //Api ye istekte bulunan localhost kýsmý
           policy.WithOrigins("http://localhost:44380", "https://localhost:44380").AllowAnyHeader().AllowAnyMethod()
            ));
            //-----------------------------------------

            //--- jwt için eklediðimiz configirasyýonlar-------
            
            services.AddAuthentication(x =>
            {
                x.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                x.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            }).AddJwtBearer(x =>
            {
                x.RequireHttpsMetadata = true; //https lazým mý deðil mi
                x.SaveToken = true;
                x.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidIssuer = Configuration["Token:Issuer"], // appsettingten çekiyoruz, kim tafarýndan oluþturuluyor // http://www.mywebsites.com
                    ValidAudience = Configuration["Token:Audience"], // kim taraýndan tüketilecek // http://www.apileriKullanacakDigerSite.com
                    IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(Configuration["Token:SecurityKey"])), // keyi tanýmla
                    ValidateIssuerSigningKey = true, // key çalýþsýn
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

            app.UseAuthentication();// jwt token için biz ekledik.sýrasý önemli...
             
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
