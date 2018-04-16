using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using MongoDB.Bson.Serialization;
using MongoDB.Driver;
using IEatHealthy.Models;
using Microsoft.AspNetCore.Http.Features;


namespace IEatHealthy
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
            services.Configure<FormOptions>(x => x.ValueCountLimit = 4096);
            services.AddMvc();

            //auto map all classes
            BsonClassMap.RegisterClassMap<Recipe>(cm =>
            {
                cm.AutoMap();
            });

            BsonClassMap.RegisterClassMap<Ingredient>(cm =>
            {
                cm.AutoMap();
            });

            BsonClassMap.RegisterClassMap<IngredientItem>(cm =>
            {
                cm.AutoMap();
            });

            //connect to mongo
            MongoClient client = MongoClientFactory.GetInstance();


        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }

            //app.UseForwardedHeaders(new ForwardedHeadersOptions
            //{
            //    ForwardedHeaders = ForwardedHeaders.XForwardedFor | ForwardedHeaders.XForwardedProto
            //});

            app.UseStaticFiles();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });

        }
    }
}
