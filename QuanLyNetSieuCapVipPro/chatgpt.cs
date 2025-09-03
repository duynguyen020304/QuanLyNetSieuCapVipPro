using System;
using System.Threading.Tasks;
using RestSharp;
using Newtonsoft.Json;

namespace QuanLyNetSieuCapVipPro
{
    public class chatgpt
    {
        private readonly string _apiKey;
        private readonly RestClient _client;

        // Preferred constructor: pass your API key here
        public chatgpt(string apiKey)
        {
            _apiKey = "my_key" ?? string.Empty;
            // Use the completions endpoint and send model in body
            _client = new RestClient("https://api.openai.com/v1/completions");
        }

        // Backward-compatible parameterless ctor (will error if used without setting key)
        public chatgpt() : this(string.Empty) { }

        public async Task<string> SendMessageAsync(string message)
        {
            if (string.IsNullOrWhiteSpace(_apiKey))
                throw new InvalidOperationException("OpenAI API key is not set. Use new chatgpt(\"YOUR_KEY\") or provide a key.");

            var request = new RestRequest("", Method.Post);
            request.AddHeader("Content-Type", "application/json");
            request.AddHeader("Authorization", $"Bearer {_apiKey}");

            var requestBody = new
            {
                model = "text-davinci-003",
                prompt = message,
                max_tokens = 3000,
                n = 1,
                stop = (string?)null,
                temperature = 0.7,
            };

            // Let RestSharp serialize the object
            request.AddJsonBody(requestBody);

            var response = await _client.ExecuteAsync(request);

            if (response == null)
                throw new HttpRequestException("No response received from the OpenAI API.");

            // If the call failed, try to extract a helpful error message
            if (!response.IsSuccessful)
            {
                var content = response.Content ?? string.Empty;
                try
                {
                    var err = JsonConvert.DeserializeObject<dynamic>(content);
                    string errorMsg = err?.error?.message ?? content;
                    throw new HttpRequestException($"OpenAI API error: {errorMsg} (HTTP {(int)response.StatusCode})");
                }
                catch (JsonException)
                {
                    throw new HttpRequestException($"OpenAI API returned HTTP {(int)response.StatusCode}: {response.StatusDescription}");
                }
            }

            if (string.IsNullOrWhiteSpace(response.Content))
                return string.Empty;

            var jsonResponse = JsonConvert.DeserializeObject<dynamic>(response.Content);

            if (jsonResponse == null)
                return string.Empty;

            // Safely attempt to read the text field
            try
            {
                var text = jsonResponse.choices?[0]?.text?.ToString()?.Trim();
                return string.IsNullOrEmpty(text) ? string.Empty : text;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
            {
                // Unexpected structure: return empty string (or consider throwing)
                return string.Empty;
            }
        }
    }
}