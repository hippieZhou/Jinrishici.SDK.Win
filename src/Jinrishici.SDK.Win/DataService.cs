using Jinrishici.SDK.Win.Models;
using Jinrishici.SDK.Win.Utils;
using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace Jinrishici.SDK.Win
{
    /// <summary>
    /// https://www.jinrishici.com/doc/
    /// </summary>
    public interface IDataService
    {
        Task GetTokenAsync(Action<PoetyToken, Exception> action);

        Task GetSentenceAsync(string token, Action<PoetySentence, Exception> action);
    }

    public class DataService : IDataService
    {
        public async Task GetTokenAsync(Action<PoetyToken, Exception> action)
        {
            string uri = $"{Constant.DOMAIN}/token".Trim();

            using (HttpClient client = new HttpClient())
            {
                try
                {
                    HttpResponseMessage message = await client.GetAsync(uri).ConfigureAwait(false);
                    message.EnsureSuccessStatusCode();
                    string json = await message.Content.ReadAsStringAsync().ConfigureAwait(false);

                    PoetyToken data = json.DeserializeObject<PoetyToken>();
                    action(data, null);
                }
                catch (Exception ex)
                {
                    action(null, ex);
                }
            }
        }

        public async Task GetSentenceAsync(string token, Action<PoetySentence, Exception> action)
        {
            string uri = $"{Constant.DOMAIN}/sentence".Trim();

            using (HttpClient client = new HttpClient())
            {
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Add("X-User-Token", token.Trim());

                try
                {
                    HttpResponseMessage message = await client.GetAsync(uri).ConfigureAwait(false);
                    message.EnsureSuccessStatusCode();
                    string json = await message.Content.ReadAsStringAsync().ConfigureAwait(false);
                    PoetySentence data = json.DeserializeObject<PoetySentence>();

                    action(data, null);
                }
                catch (Exception ex)
                {
                    action(null, ex);
                }
            }
        }
    }
}
