using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using System.Threading.Tasks;

namespace MgmtAPI {

    /// <summary>
    /// Master Control Program ;)
    /// </summary>
    public static class Program {

        /// <summary>
        /// Application's main/entry method.
        /// </summary>
        /// <param name="args">The arguments from the command line.</param>
        /// <returns>Zero (0) if everything went fine.</returns>
        public static async Task Main(string[] args) {
            using var host = CreateHost(args);
            await host.RunAsync();
        }

        private static IHost CreateHost(string[] args) {
            return Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(config => {
                    config
                        .CaptureStartupErrors(true)
                        .UseStartup<Startup>()
                        .UseKestrel()
                        .ConfigureKestrel(kestrel => { });
                }).Build();
        }
    }

}
