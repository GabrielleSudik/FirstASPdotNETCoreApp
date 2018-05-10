using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;

namespace FirstASPdotNETCoreApp
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            //added by you during lesson
            //services.AddMvc();
            //then coded out by you later in the lesson.
            //you can use services.AddXXX (intellisense) to add a lot of stuff

            //added by you to make it an MVC project:
            services.AddMvc();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        //IE: how messages get passed. It's middleware.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            /*
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.Run(async (context) =>
            {
                //you wrote more here, to prove you were here.
                await context.Response.WriteAsync("Hello World! I wish I were more creative, I'd write something funny here.");
            });
            */
            //that code was default; you coded it out during lesson
            //instead, you're adding:

            //this was added later:
            DefaultFilesOptions defaultFilesOptions = new DefaultFilesOptions();
            defaultFilesOptions.DefaultFileNames.Clear();
            defaultFilesOptions.DefaultFileNames.Add("home.html"); //sets which page the program will open on
                //when passed to the next line of code
                //hmm, doesn't seem to matter what I type: "index" also opens up "home"
                //maybe because below is/was set to controller=Home ??

            //this was added earlier in the lesson:
            app.UseDefaultFiles(defaultFilesOptions); //this opens some page when you run the program, no need to add anything
            app.UseStaticFiles(); //this allows access to my html pages. 
                                  //need to add /home or index.html at end of URL if you don't have the first line.

            //added by you to make it an MVC project:
            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Employee}/{action=Index}/{id?}");
            });
            //this configures the routes.
            //you also added Controllers folder, plus controllers.
        }
    }
}
