using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using BazorTodo.Model;
using BazorTodo.Store;
using Fluxor;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.DependencyInjection;

namespace BazorTodo
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("app");

            builder.Services.AddTransient(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
            builder.Services.AddSingleton<ITodoState, TodoState>(x => new TodoState(new List<Todo>()));
            builder.Services.AddFluxor(o => o
            .ScanAssemblies(typeof(Program).Assembly));

            await builder.Build().RunAsync();
        }
    }
}
