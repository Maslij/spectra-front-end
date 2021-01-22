using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace Spectra.Model.Client.Models
{
    public class Http
    {
        private readonly IHttpClientFactory _clientFactory;

        public Http(IHttpClientFactory clientFactory)
        {
            _clientFactory = clientFactory;
        }
    }
}
