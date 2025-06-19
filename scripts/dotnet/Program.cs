using Newtonsoft.Json;
using System.Diagnostics;
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
    // @ Use C disk file to avoid people leak token/key in current project folder and upload to github
    private static string _gitRootPath = @"../../../../../projects";
    private static string _ProjectFullPath = "D:/git/OpenAiTx/projects"; // !please change to your own path, this is the path where the projects will be saved and indexed.
    private static string _githubToken = File.ReadAllText(@"C:\gitHubPersonalAccessToken.txt"); // e.g. ghp_xxxxxxxxxxxxxxxxxxxxxxxBk8
    private static string _openAiKey = File.ReadAllText(@"C:\openAiKey.txt"); //e.g. 92973yO74hVyVmdby4Xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx
    private static string _openAiApiEndpoint = File.ReadAllText(@"C:\openAiApiEndpoint.txt"); // e.g. https://xxxxxx.openai.azure.com/openai/deployments/gpt-4.1/chat/completions?api-version=2025-01-01-preview
    private const int MaxTokens = 32768;
    private static void GitCommitAndPush()
    {

        // Check for git changes and commit/push if needed
        string gitProjectPath = _ProjectFullPath;
        var gitStatus = new ProcessStartInfo
        {
            FileName = "git",
            Arguments = "status --porcelain",
            WorkingDirectory = gitProjectPath,
            RedirectStandardOutput = true,
            UseShellExecute = false,
            CreateNoWindow = true
        };

        using (var process = Process.Start(gitStatus))
        {
            string output = process.StandardOutput.ReadToEnd();
            process.WaitForExit();

            if (!string.IsNullOrWhiteSpace(output))
            {
                // There are changes to commit
                var gitAdd = new ProcessStartInfo
                {
                    FileName = "git",
                    Arguments = "add .",
                    WorkingDirectory = gitProjectPath,
                    RedirectStandardOutput = true,
                    UseShellExecute = false,
                    CreateNoWindow = true
                };
                Process.Start(gitAdd).WaitForExit();

                var commitMsg = $"Index projects {DateTime.Now:yyyyMMddHHmm}";
                var gitCommit = new ProcessStartInfo
                {
                    FileName = "git",
                    Arguments = $"commit -m \"{commitMsg}\"",
                    WorkingDirectory = gitProjectPath,
                    RedirectStandardOutput = true,
                    UseShellExecute = false,
                    CreateNoWindow = true
                };
                Process.Start(gitCommit).WaitForExit();

                var gitPush = new ProcessStartInfo
                {
                    FileName = "git",
                    Arguments = "push",
                    WorkingDirectory = gitProjectPath,
                    RedirectStandardOutput = true,
                    UseShellExecute = false,
                    CreateNoWindow = true
                };
                Process.Start(gitPush).WaitForExit();

                Console.WriteLine("Git changes committed and pushed.");
            }
            else
            {
                Console.WriteLine("No git changes to commit.");
            }
        }
    }
    public static async Task Main(string[] args)
    {
        _client.DefaultRequestHeaders.UserAgent.ParseAdd("OpenAiTx App");
        _client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", _githubToken);
        _client.DefaultRequestHeaders.Add("api-key", _openAiKey);

        while (true)
        {
            var random = new Random();
            var daysAgo = random.Next(0, 365 * 3);
            var sDate = DateTime.UtcNow.AddDays(-daysAgo);
            var eDdate = sDate.AddDays(2);
            var page = random.Next(1, 5);
            var queryQ = $"q=created:{sDate.ToString("yyyy-MM-dd")}..{eDdate.ToString("yyyy-MM-dd")}%20stars:>=200%20fork:false&sort=updated&order=desc&page={page}&per_page=3";
            Console.WriteLine($"----start----");
            Console.WriteLine($"QueryQ : {queryQ}");

            var isNeedGitPush = false;
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

                        string user = (fullName).Split("/")[0];
                        string projectName = (fullName).Split("/")[1];

                        var readmeData = await GetReadmeUrl(fullName);

                        var projectJsonPath = $"{_gitRootPath}/{user}/{projectName}/project.json";
                        GitHubProject existProject;
                        if (File.Exists(projectJsonPath))
                        {
                            existProject = JsonConvert.DeserializeObject<GitHubProject>(await File.ReadAllTextAsync(projectJsonPath));
                        }
                        else
                        {
                            existProject = null;
                        }
                        if (existProject != null)
                        {
                            if (existProject.sha == readmeData.Item2)
                            {
                                Console.WriteLine($"Project {fullName} already indexed with same sha, skipping.");
                                continue;
                            }
                            else
                            {
                                Console.WriteLine($"Project {fullName} updated with new sha, updating...");
                            }
                        }
                        else if (readmeData.Item1 == "" || readmeData.Item2 == "" || readmeData.Item3 == 0)
                        {
                            Console.WriteLine($"Project {fullName} has no README.md, skipping.");
                            continue;
                        }
                        else
                        {
                            Console.WriteLine($"Project {fullName} has README.md, creating...");
                        }


                        var project = new GitHubProject
                        {
                            fullName = fullName,
                            htmlUrl = htmlUrl,
                            readmeUrl = readmeData.Item1,
                            sha = readmeData.Item2,
                            siz = readmeData.Item3,
                            stargazers_count = stargazers_count,
                            indexTime = DateTime.UtcNow
                        };




                        string originalContent = "";
                        try
                        {
                            originalContent = await GetReadmeContentAsync(project.readmeUrl);
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine($"Readme Content Error: {e.Message}");
                            continue;
                        }
                        
                        CreateDirectoryFolder($"{_gitRootPath}/{user}");
                        CreateDirectoryFolder($"{_gitRootPath}/{user}/{projectName}");
                        foreach (var lan in _languages)
                        {
                            var filePath = $"{_gitRootPath}/{user}/{projectName}/README-{lan.lang}.md";

                            await File.WriteAllTextAsync(filePath, "");
                            Console.WriteLine($"project: {project.fullName}, stars: {project.stargazers_count}");

                            var lastIndex = project.readmeUrl.LastIndexOf('/');
                            var blobUrl = project.readmeUrl.Substring(0, lastIndex + 1); // 包含最后的 /
                            try
                            {
                                var (txt, usage) = await TranslateTextAsync(originalContent
                                    , $"Translate the following technical document into {lan.name}, preserving the original Markdown format, Relative paths in markdown, please complete with {blobUrl}:");

                                Console.WriteLine($"Token usage for {lan.name} translation:");
                                Console.WriteLine($"Prompt tokens: {usage.PromptTokens}");
                                Console.WriteLine($"Completion tokens: {usage.CompletionTokens}");
                                Console.WriteLine($"Total tokens: {usage.TotalTokens}");

                                usage.Language = lan.lang;

                                project.TokenUsage.Add(usage);
                                if (string.IsNullOrEmpty(txt))
                                    continue;

                                await File.WriteAllTextAsync(filePath, txt);
                                await File.AppendAllTextAsync(filePath, $"\n\r\n\r---\n\r\n\rTranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: {DateTime.UtcNow.ToString("yyyy-MM-dd")}\n\r\n\r---");
                                Console.WriteLine($"{filePath} OK");
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine(ex.Message);
                                continue;
                            }
                        }
                        isNeedGitPush = true;
                        await File.WriteAllTextAsync(projectJsonPath, JsonConvert.SerializeObject(project, Formatting.Indented));
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }

            if (isNeedGitPush)
                GitCommitAndPush();
            else
                Console.WriteLine($"{DateTime.Now} No update projects");

            Thread.Sleep(15 * 60 * 1000);
        }
    }

    public class GitHubProject
    {
        public string fullName { get; set; }
        public string htmlUrl { get; set; }
        public string readmeUrl { get; set; }
        public string sha { get; set; }
        public int siz { get; set; }
        public int stargazers_count { get; set; }
        public DateTime indexTime { get; set; }
        public List<TokenUsage> TokenUsage { get; set; } = new List<TokenUsage>();
    }

    public class TokenUsage
    {
        public string Language { get; set; }
        public int PromptTokens { get; set; }
        public int CompletionTokens { get; set; }
        public int TotalTokens { get; set; }
    }

    private static async Task<(string translatedText, TokenUsage usage)> TranslateTextAsync(string text, string instruction)
    {
        var lines = text.Split(new[] { "\r\n", "\n" }, StringSplitOptions.None);
        Console.WriteLine($"Total lines in original content: {lines.Length}");

        if (lines.Length <= 15)
        {
            Console.WriteLine("Content is too small to split, translating directly.");
            return (text, new TokenUsage { PromptTokens = 0, CompletionTokens = 0, TotalTokens = 0 }); // No token usage for direct translation
        }
        if (lines.Length >= 5000)
        {
            Console.WriteLine("Content is too large to split, translating directly.");
            return (text, new TokenUsage { PromptTokens = 0, CompletionTokens = 0, TotalTokens = 0 }); // No token usage for direct translation
        }

        var chunks = new List<string>();
        var currentChunk = new List<string>();

        foreach (var line in lines)
        {
            currentChunk.Add(line);
            if (currentChunk.Count >= 200)
            {
                chunks.Add(string.Join("\n", currentChunk));
                currentChunk.Clear();
            }
        }

        // Add remaining lines if any
        if (currentChunk.Any())
        {
            chunks.Add(string.Join("\n", currentChunk));
        }

        Console.WriteLine($"Content split into {chunks.Count} chunks of 200 lines each");
        for (int i = 0; i < chunks.Count; i++)
        {
            Console.WriteLine($"Chunk {i + 1}: {chunks[i].Split('\n').Length} lines");
        }

        var translatedChunks = new List<string>();
        var totalUsage = new TokenUsage
        {
            PromptTokens = 0,
            CompletionTokens = 0,
            TotalTokens = 0
        };

        // Translate each chunk
        for (int i = 0; i < chunks.Count; i++)
        {
            Console.WriteLine($"Translating chunk {i + 1} of {chunks.Count}...");
            var chunk = chunks[i];
            var chunkInstruction = $"{instruction} (Part {i + 1} of {chunks.Count})";

            var requestBody = new
            {
                messages = new[]
                {
                    new
                    {
                        role = "system",
                        content = "You are a professional translation assistant, specializing in the translation of technical documents. Please don't add your remark or thinking content. Maintain the exact same line breaks and formatting as the original text."
                    },
                    new
                    {
                        role = "user",
                        content = $"{chunkInstruction}\n\n{chunk}"
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
            string translatedChunk = responseData.choices[0].message.content;

            totalUsage.PromptTokens += (int)responseData.usage.prompt_tokens;
            totalUsage.CompletionTokens += (int)responseData.usage.completion_tokens;
            totalUsage.TotalTokens += (int)responseData.usage.total_tokens;

            translatedChunks.Add(translatedChunk);
        }

        // Combine all translated chunks
        string finalTranslatedText = string.Join("\n", translatedChunks);

        return (finalTranslatedText, totalUsage);
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






