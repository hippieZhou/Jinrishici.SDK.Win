using Jinrishici.SDK.Win.Models;
using System;
using System.Threading.Tasks;

namespace Jinrishici.SDK.Win
{
    public class JinrishiciFactory
    {
        private readonly DataService _dataService;
        private JinrishiciFactory() { _dataService = new DataService(); }
        public static JinrishiciFactory GetInstance() => Nested.Instance;

        private sealed class Nested
        {
            static Nested()
            {
            }
            internal static readonly JinrishiciFactory Instance = new JinrishiciFactory();
        }

        public async Task GetTokenAsync(Action<PoetyToken, Exception> action)
        {
            await _dataService?.GetTokenAsync(action);
        }

        public async Task GetSentenceAsync(string token, Action<PoetySentence, Exception> action)
        {
            await _dataService?.GetSentenceAsync(token, action);
        }
    }
}
