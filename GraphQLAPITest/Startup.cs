using GraphiQl;
using GraphQL.Server;
using GraphQL.Server.Transports.AspNetCore;
using GraphQL.Server.Transports.AspNetCore.SystemTextJson;
using GraphQL.Types;
using GraphQLAPITest.Data;
using GraphQLAPITest.Interfaces;
using GraphQLAPITest.Mutations;
using GraphQLAPITest.Queries;
using GraphQLAPITest.Schemas;
using GraphQLAPITest.Services;
using GraphQLAPITest.Types;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;

namespace GraphQLAPITest
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        //This method gets called by the runtime. Use this method to add services to the container

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();

            //Services
            services.AddTransient<IMenu, MenuService>();
            services.AddTransient<ISubMenu, SubMenuService>();
            services.AddTransient<IReservation, ReservationService>();

            //Types
            services.AddTransient<MenuType>();
            services.AddTransient<SubMenuType>();
            services.AddTransient<ReservationType>();
            services.AddTransient<MenuInputType>();
            services.AddTransient<SubMenuInputType>();
            services.AddTransient<ReservationInputType>();

            //Queries
            services.AddTransient<MenuQuery>();
            services.AddTransient<SubMenuQuery>();
            services.AddTransient<ReservationQuery>();
            services.AddTransient<RootQuery>();

            //Mutations
            services.AddTransient<MenuMutation>();
            services.AddTransient<SubMenuMutation>();
            services.AddTransient<ReservationMutation>();
            services.AddTransient<RootMutation>();

            //Schema
            services.AddTransient<ISchema, RootSchema>();

            services.AddGraphQL(options =>
            {
                options.EnableMetrics = false;
            }).AddSystemTextJson();

            services.AddDbContext<GraphQLDbContext>(option => option.UseSqlServer(@"Data Source= (localdb)\ProjectModels;Initial Catalog=CoffeeShopDb,Integrated Security = True"));
        }
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, GraphQLDbContext dbContext)
        {
            // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            dbContext.Database.EnsureCreated();
            app.UseGraphiQl("/graphql");
            app.UseGraphQL<ISchema>();
        }
    }
}
