using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;

public class YandexGptService
{
    private readonly HttpClient _httpClient;
    private readonly string _apiKey;
    private readonly string _folderId;

    public YandexGptService(HttpClient httpClient, IConfiguration config)
    {
        _httpClient = httpClient;
        _apiKey = config["YandexCloud:ApiKey"]!;
        _folderId = config["YandexCloud:FolderId"]!;

        // Устанавливаем заголовки
        _httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        _httpClient.DefaultRequestHeaders.Add("Authorization", $"Api-Key {_apiKey}");
    }

    public async Task<string> GetResponseAsync(string systemPrompt, string userMessage)
    {
        try
        {
            // Формируем запрос в точном соответствии с документацией Yandex
            var requestBody = new
            {
                modelUri = $"gpt://{_folderId}/yandexgpt-lite",
                completionOptions = new
                {
                    stream = false,
                    temperature = 0.3,
                    maxTokens = "2000"
                },
                messages = new[]
                {
                    new
                    {
                        role = "system",
                        text = systemPrompt
                    },
                    new
                    {
                        role = "user",
                        text = userMessage
                    }
                }
            };

            // Сериализуем с правильными настройками
            var json = JsonSerializer.Serialize(requestBody, new JsonSerializerOptions
            {
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
                WriteIndented = false
            });

            var content = new StringContent(json, Encoding.UTF8, "application/json");

            // Отправляем запрос
            var response = await _httpClient.PostAsync(
                "https://llm.api.cloud.yandex.net/foundationModels/v1/completion",
                content
            );

            // Проверяем ответ
            if (!response.IsSuccessStatusCode)
            {
                var error = await response.Content.ReadAsStringAsync();
                return $"Ошибка: {response.StatusCode}\n{error}";
            }

            // Читаем и парсим ответ
            var responseContent = await response.Content.ReadAsStringAsync();
            using var doc = JsonDocument.Parse(responseContent);

            Console.WriteLine("===== YANDEX GPT REQUEST =====");
            Console.WriteLine(json);
            Console.WriteLine("===== YANDEX GPT RESPONSE =====");
            Console.WriteLine(responseContent);
            Console.WriteLine("==============================");

            return doc.RootElement
                .GetProperty("result")
                .GetProperty("alternatives")[0]
                .GetProperty("message")
                .GetProperty("text")
                .GetString() ?? "Не удалось получить ответ";
        }
        catch (Exception ex)
        {
            Console.WriteLine($"YandexGPT error: {ex.Message}");
            return "Не удалось получить ответ от сервиса";
        }
    }
}