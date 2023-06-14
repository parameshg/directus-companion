using Directus.Companion.Api;
using Directus.Companion.Properties;
using Refit;
using System.ComponentModel;
using System.Net.Http.Headers;

namespace Directus.Companion.Workers
{
    internal class Worker : BackgroundWorker
    {
        protected IDirectusApi Directus
        {
            get
            {
                var client = RestService.CreateHttpClient(Settings.Default.Url, new RefitSettings());

                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", Settings.Default.Token);

                return RestService.For<IDirectusApi>(client);
            }
        }
    }
}