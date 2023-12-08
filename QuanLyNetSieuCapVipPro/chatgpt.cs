using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;  // Don't forget to include this namespace for async Task
using System;
using RestSharp;
using Newtonsoft.Json;

namespace QuanLyNetSieuCapVipPro
{
    public class chatgpt
    {
        private readonly string _apiKey = "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";
        private readonly RestClient _client;

        // Constructor that takes the API key as a parameter
        public chatgpt()
        {
            // Initialize the RestClient with the ChatGPT API endpoint
            _client = new RestClient("https://api.openai.com/v1/engines/text-davinci-003/completions");
        }
        public async Task<string> SendMessageAsync(string message)
        {
            // Create a new POST request
            var request = new RestRequest("", Method.Post);
            // Set the Content-Type header
            request.AddHeader("Content-Type", "application/json");
            // Set the Authorization header with the API key
            request.AddHeader("Authorization", $"Bearer {_apiKey}");

            // Create the request body with the message and other parameters
            var requestBody = new
            {
                prompt = message,
                max_tokens = 3000,
                n = 1,
                stop = (string?)null,
                temperature = 0.7,
            };

            // Add the JSON body to the request
            request.AddJsonBody(JsonConvert.SerializeObject(requestBody));

            // Execute the request and receive the response
            var response = await _client.ExecuteAsync(request);

            // Deserialize the response JSON content
            var jsonResponse = JsonConvert.DeserializeObject<dynamic>(response.Content ?? string.Empty);

            // Extract and return the chatbot's response text
            return jsonResponse?.choices[0]?.text?.ToString()?.Trim() ?? string.Empty;
        }
    }
}