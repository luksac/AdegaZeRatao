using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdegaZeRataoWebApi.Models
{
    public class Token
    {
        public string Tokenizer { get; set; }
        public DateTime Expiration { get; set; }
    }
}
