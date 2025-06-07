using Newtonsoft.Json;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;

public class Program
{
    private static readonly HttpClient _client = new HttpClient();
    private static dynamic[] _languages = new[] {
	    // Asia
	    new { lang = "zh-CN", name = "Simplified Chinese", native = "简体中文" },
        new { lang = "zh-TW", name = "Traditional Chinese", native = "繁體中文" },
        new { lang = "ja", name = "Japanese", native = "日本語" },
        new { lang = "ko", name = "Korean", native = "한국어" },
        new { lang = "hi", name = "Hindi", native = "हिन्दी" },
        new { lang = "th", name = "Thai", native = "ไทย" },
	    
	    // EU
	    new { lang = "en", name = "English", native = "English" },
        new { lang = "fr", name = "French", native = "Français" },
        new { lang = "de", name = "German", native = "Deutsch" },
        new { lang = "es", name = "Spanish", native = "Español" },
        new { lang = "it", name = "Italian", native = "Italiano" },
        new { lang = "ru", name = "Russian", native = "Русский" },
        new { lang = "pt", name = "Portuguese", native = "Português" },
        new { lang = "nl", name = "Dutch", native = "Nederlands" },
        new { lang = "pl", name = "Polish", native = "Polski" },
	    
	    // Middle Eastern
	    new { lang = "ar", name = "Arabic", native = "العربية" },
        new { lang = "fa", name = "Persian", native = "فارسی" },
        new { lang = "tr", name = "Turkish", native = "Türkçe" },
	    
	    // Other
	    new { lang = "vi", name = "Vietnamese", native = "Tiếng Việt" },
        new { lang = "id", name = "Indonesian", native = "Bahasa Indonesia" }
    };
    private static string _gitRootPath = @"../../../../../projects";
    private static string _githubToken;
    private static string _openAiKey;
    private static string _openAiApiEndpoint;
    private const int MaxTokens = 32768;
    public static async Task Main(string[] args)
    {
        // @ Use C disk file to avoid people leak token/key in current project folder and upload to github
        _githubToken = File.ReadAllText(@"C:\gitHubPersonalAccessToken.txt"); // e.g. ghp_xxxxxxxxxxxxxxxxxxxxxxxBk8
        _openAiKey = File.ReadAllText(@"C:\openAiKey.txt"); //e.g. 92973yO74hVyVmdby4Xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx
        _openAiApiEndpoint = File.ReadAllText(@"C:\openAiApiEndpoint.txt"); // e.g. https://xxxxxx.openai.azure.com/openai/deployments/gpt-4.1/chat/completions?api-version=2025-01-01-preview

        _client.DefaultRequestHeaders.UserAgent.ParseAdd("OpenAiTx App");
        _client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", _githubToken);
        _client.DefaultRequestHeaders.Add("api-key", _openAiKey);

        while (true)
        {
            var random = new Random();
            var daysAgo = random.Next(365, 365 * 3);
            var sDate = DateTime.UtcNow.AddDays(-daysAgo);
            var eDdate = sDate.AddDays(2);
            // page 1-20 random
            var page = random.Next(1,20);
            var queryQ = $"q=created:{sDate.ToString("yyyy-MM-dd")}..{eDdate.ToString("yyyy-MM-dd")}%20stars:>=20%20fork:false&sort=updated&order=desc&page={page}&per_page=1";
            Console.WriteLine($"----start----");
            Console.WriteLine($"QueryQ : {queryQ}");

            var response = await _client.GetAsync($"https://api.github.com/search/repositories?{queryQ}");
            if (response.StatusCode == System.Net.HttpStatusCode.Forbidden)
            {
                Console.WriteLine("Rate limit exceeded.");
                return;
            }
            try
            {
                response.EnsureSuccessStatusCode();
                var content = await response.Content.ReadAsStringAsync();
                var jsonDoc = JsonDocument.Parse(content);
                var root = jsonDoc.RootElement;
                if (root.TryGetProperty("items", out var items))
                {
                    var list = items.EnumerateArray();
                    foreach (var item in list)
                    {
                        string fullName = item.GetProperty("full_name").GetString();
                        string htmlUrl = item.GetProperty("html_url").GetString();
                        var stargazers_count = item.GetProperty("stargazers_count").GetInt32();

                        var readmeData = await GetReadmeUrl(fullName);
                        var project = new
                        {
                            fullName,
                            htmlUrl,
                            readmeUrl = readmeData.Item1,
                            sha = readmeData.Item2,
                            siz = readmeData.Item3,
                            stargazers_count
                        };

                        string user = (fullName).Split("/")[0];
                        string projectName = (fullName).Split("/")[1];


                        string originalContent = await GetReadmeContentAsync(project.readmeUrl);
                        CreateDirectoryFolder($"{_gitRootPath}/{user}");
                        CreateDirectoryFolder($"{_gitRootPath}/{user}/{projectName}");
                        foreach (var lan in _languages)
                        {
                            var filePath = $"{_gitRootPath}/{user}/{projectName}/README-{lan.lang}.md";
                            if (File.Exists(filePath))
                            {
                                Console.WriteLine($"{filePath} exist");
                                continue;
                            }
                            await File.WriteAllTextAsync(filePath, "");
                            Console.WriteLine($"project: {project.fullName}, stars: {project.stargazers_count}");
                            string txt = await TranslateTextAsync(originalContent
                                , $"Translate the following technical document into {lan.name}, preserving the original Markdown format:");

                            await File.WriteAllTextAsync(filePath, txt);
                            await File.AppendAllTextAsync(filePath, $"\n\r\n\r---\n\r\n\r[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx) - {DateTime.UtcNow.ToString("yyyy-MM-dd")}\n\r\n\r---");
                            Console.WriteLine($"{filePath} OK");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw;
            }

            Thread.Sleep(15 * 1000);
        }
    }

    private static async Task<string> TranslateTextAsync(string text, string instruction)
    {
        var requestBody = new
        {
            messages = new[]
            {
                    new
                    {
                        role = "system",
                        content = "You are a professional translation assistant, specializing in the translation of technical documents.please don't add your remark or thinking content."
                    },
                    new
                    {
                        role = "user",
                        content = $"{instruction}\n\n{text}"
                    }
                },
            temperature = 0.7,
            top_p = 0.95,
            frequency_penalty = 0,
            presence_penalty = 0,
            max_tokens = MaxTokens
        };

        string requestBodyJson = JsonConvert.SerializeObject(requestBody);
        var content = new StringContent(requestBodyJson, Encoding.UTF8, "application/json");

        HttpResponseMessage response = await _client.PostAsync(_openAiApiEndpoint, content);
        response.EnsureSuccessStatusCode();
        string responseJson = await response.Content.ReadAsStringAsync();
        dynamic responseData = JsonConvert.DeserializeObject(responseJson);
        string translatedText = responseData.choices[0].message.content;

        return translatedText;

    }

    private static void CreateDirectoryFolder(string directoryPath)
    {
        if (!Directory.Exists(directoryPath))
            Directory.CreateDirectory(directoryPath);
    }

    private static async Task<string> GetReadmeContentAsync(string url)
    {
        using (HttpClient client = new HttpClient())
        {
            HttpResponseMessage response = await client.GetAsync(url);
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadAsStringAsync();
        }
    }

    private static async Task<Tuple<string, string, int>> GetReadmeUrl(string repoFullName)
    {
        try
        {
            var response = await _client.GetAsync($"https://api.github.com/repos/{repoFullName}/contents/README.md");
            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                var jsonDoc = JsonDocument.Parse(content);
                var root = jsonDoc.RootElement;
                var downloadUrl = string.Empty;
                var sha = string.Empty;
                var size = 0;
                if (root.TryGetProperty("download_url", out var _downloadUrl))
                    downloadUrl = _downloadUrl.GetString();
                if (root.TryGetProperty("sha", out var _sha))
                    sha = _sha.GetString();
                if (root.TryGetProperty("size", out var _size))
                    size = _size.GetInt32();
                return new Tuple<string, string, int>(downloadUrl, sha, size);
            }
        }
        catch
        {
            // igor
        }

        return new Tuple<string, string, int>("", "", 0);
    }
}






