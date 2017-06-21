
using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(ProjetoModelo.Services.WebAPI.Startup))]

namespace ProjetoModelo.Services.WebAPI
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
         
        }
    }
}