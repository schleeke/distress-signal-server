using Microsoft.AspNetCore.Authentication.Negotiate;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace MgmtAPI {
    /// <summary>
    /// Manages the Web Server / Kestrel configuration.
    /// </summary>
    public class Startup {

        /// <inheritdoc/>
        public Startup(IConfiguration configuration) => Configuration = configuration;

        /// <summary>
        /// The application's configuraton.
        /// </summary>
        public IConfiguration Configuration { get; }

        /// <summary>
        /// Configures the middleware services.
        /// </summary>
        /// <param name="services">The collection of available middleware services.</param>
        public void ConfigureServices(IServiceCollection services) {
            services.AddAuthentication(NegotiateDefaults.AuthenticationScheme).AddNegotiate();
            services.AddMvc();
            services.AddCors();
            services.AddHsts(options => { });
            services.AddLogging(config => {
                config.ClearProviders();
                config.AddConsole(loggingConfig => { });
            });
            
        }

        /// <summary>
        /// Configures the Web Server / Kestrel host.
        /// </summary>
        /// <param name="app">The current web application.</param>
        /// <param name="env">The runtime environment.</param>
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env) {
            if(env.IsDevelopment()) {
                app.UseDeveloperExceptionPage(); }
            else {
                app.UseExceptionHandler("/Error");
                app.UseHsts(); }
            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseRouting();
            app.UseAuthorization();
            app.UseAuthentication();
            app.UseEndpoints(config => {
                config.MapControllers(); });
        }

    }
}
