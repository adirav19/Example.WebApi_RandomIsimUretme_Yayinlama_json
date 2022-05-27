using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Example.WebApi.Controllers
{
    [Route("Products")]
    //PRODUCT İLE BAŞLAYAN TÜM URL LER PRODUCTS CONTROLLERİNDE ÇAĞRILACAK.
    public class ProductController:ControllerBase
    {
        [Route("Merhaba")]
        public string Merhaba()
        {
            return "merhaba";
        }
        [Route("Hello")]
        public string Hello()
        {
            return "hello";
        }
        
    }
}
