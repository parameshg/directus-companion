using Microsoft.VisualBasic.ApplicationServices;
using Refit;

namespace Directus.Companion.Api
{
    internal interface IDirectusApi
    {
        [Get("/schema/snapshot")]
        Task<string> GetSnapshot();

        [Post("/schema/apply")]
        Task ApplySnapshot([Body] string schema);
    }
}