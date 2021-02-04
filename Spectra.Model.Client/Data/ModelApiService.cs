using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Spectra.Model.Client.Data
{
    public class ModelApiService
    {
        private string _TrainingKey;
        private string _PredictionKey;
        private string _Endpoint;
        private string httpHeaders;

        private readonly ModelApiConfig _modelApiConfig;
        private readonly IHttpClientFactory _clientFactory;

        public ModelApiService(IOptions<ApiConfig> apiConfig, IHttpClientFactory clientFactory)
        {
            _clientFactory = clientFactory;
            _modelApiConfig = apiConfig.Value.ModelApiConfiguration;
            _Endpoint = _modelApiConfig.EndPoint;
            _TrainingKey = _modelApiConfig.TrainingKey;
            _PredictionKey = _modelApiConfig.PredictionKey;

            Dictionary<string, string> apiHeaders = new Dictionary<string, string>
            {
                { "Endpoint", _Endpoint },
                { "TrainingKey", _TrainingKey },
                { "PredictionKey",  _PredictionKey}
            };

            httpHeaders = JsonConvert.SerializeObject(apiHeaders);
        }

        public async Task<string> DemoPredictFromUrl(string projectId, string imageUrl, string model)
        {
            Dictionary<string, string> apiHeaders = new Dictionary<string, string>
            {
                { "Endpoint", _Endpoint },
                { "TrainingKey", _TrainingKey },
                { "PredictionKey",  _PredictionKey},
                { "ImageUrl",  imageUrl}
            };

            httpHeaders = JsonConvert.SerializeObject(apiHeaders);

            var url = $"https://spectra-model-api.azurewebsites.net/api/project/{projectId}/model/{model}";

            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Post,
                RequestUri = new Uri(url),
                Content = new StringContent(httpHeaders, Encoding.UTF8, "application/json"),
            };

            var client = _clientFactory.CreateClient();
            client.Timeout = TimeSpan.FromMinutes(20);

            var response = await client.SendAsync(request);
            response.EnsureSuccessStatusCode();

            var responseBody = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
            return responseBody;
        }

        public async Task<string> GetProject(string projectId)
        {
            var url = $"https://spectra-model-api.azurewebsites.net/api/project/{projectId}";

            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri(url),
                Content = new StringContent(httpHeaders, Encoding.UTF8, "application/json"),
            };

            var client = _clientFactory.CreateClient();
            client.Timeout = TimeSpan.FromMinutes(20);

            var response = await client.SendAsync(request);
            response.EnsureSuccessStatusCode();

            var responseBody = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
            return responseBody;
        }

        public async Task<string> GetProjects()
        {
            var url = $"https://spectra-model-api.azurewebsites.net/api/projects";

            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri(url),
                Content = new StringContent(httpHeaders, Encoding.UTF8, "application/json"),
            };

            var client = _clientFactory.CreateClient();
            client.Timeout = TimeSpan.FromMinutes(20);

            var response = await client.SendAsync(request);
            response.EnsureSuccessStatusCode();

            var responseBody = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
            return responseBody;
        }
    }
}
