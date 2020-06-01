using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace AdegaZeRataoWebApi.Classes
{
    public class FuncoesUteis
    {
        private static readonly IConfiguration Configuration;

        static FuncoesUteis()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);

            Configuration = builder.Build();
        }

        public static string Get(string name)
        {
            return Configuration[name];
        }
    }
}
