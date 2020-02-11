using GraphQL;
using GraphQL.Server;
using GraphQL.Server.Ui.Playground;
using MediatR;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using PocGraphicQL.GraphQL;
using PocGraphicQL.Repositories;
using System;

namespace PocGraphicQL
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
            

            services
                .AddScoped<ICustomerRepository, CustomerRepository>()
                .AddMediatR(AppDomain.CurrentDomain.Load("PocGraphicQL"))
                .AddControllers();

            services
                .AddScoped<IDependencyResolver>(s => new FuncDependencyResolver(s.GetRequiredService));
            services
                .AddScoped<CustomerSchema>();
            services
                .AddGraphQL(x => x.ExposeExceptions = true)
                .AddGraphTypes(ServiceLifetime.Scoped)
                .AddUserContextBuilder(httpContext => httpContext.User)
                .AddDataLoader();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });

            app
                .UseGraphQL<CustomerSchema>()
                .UseGraphQLPlayground(new GraphQLPlaygroundOptions());
        }
    }
}
