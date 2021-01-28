using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Spectra.Model.Client
{
    public class ApiConfig
    {
        public ModelApiConfig ModelApiConfiguration { get; set; }
    }

    public class ModelApiConfig
    {
        public string TrainingKey { get; set; }
        public string EndPoint { get; set; }
    }
}
