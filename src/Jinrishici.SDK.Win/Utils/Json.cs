using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Diagnostics;

namespace Jinrishici.SDK.Win.Utils
{
    public static class Json
    {
        private static JsonSerializerSettings CreateJsonSerializerSettings()
        {
            JsonSerializerSettings settings = new JsonSerializerSettings
            {
                NullValueHandling = NullValueHandling.Ignore,
                Error = (sender, e) =>
                {
                    Trace.WriteLine(e.ErrorContext.Error.Message);
                    e.ErrorContext.Handled = true;
                },
                Converters = { new IsoDateTimeConverter() }
            };
            return settings;
        }

        public static string SerializeObject<T>(this T model) where T : class
        {
            var settings = CreateJsonSerializerSettings();
            var json = JsonConvert.SerializeObject(model, settings);
            return json;
        }

        public static T DeserializeObject<T>(this string json) where T : class
        {
            try
            {
                var settings = CreateJsonSerializerSettings();
                return JsonConvert.DeserializeObject<T>(json, settings);
            }
            catch (Exception)
            {
                return default(T);
            }
        }
    }
}
