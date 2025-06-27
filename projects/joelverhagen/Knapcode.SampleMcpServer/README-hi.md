# MCP सर्वर

यह README .NET MCP सर्वर टेम्पलेट प्रोजेक्ट का उपयोग करके बनाया गया है। यह दर्शाता है कि आप .NET का उपयोग करके आसानी से एक MCP सर्वर कैसे बना सकते हैं और फिर इसे एक NuGet पैकेज में पैक कर सकते हैं।

पूरा गाइड देखने के लिए [aka.ms/nuget/mcp/guide](https://aka.ms/nuget/mcp/guide) देखें।

## NuGet.org पर प्रकाशित करने से पहले चेकलिस्ट

- .csproj फ़ाइल में पैकेज मेटाडेटा अपडेट करें
- अपने MCP सर्वर के इनपुट्स घोषित करने के लिए `.mcp/server.json` अपडेट करें
- नीचे दिए गए चरणों का उपयोग करके MCP सर्वर को लोकली टेस्ट करें

## VS Code में MCP सर्वर का उपयोग करना

एक बार जब MCP सर्वर पैकेज NuGet.org पर प्रकाशित हो जाता है, तो आप निम्नलिखित VS Code उपयोगकर्ता कॉन्फ़िगरेशन का उपयोग करके MCP सर्वर पैकेज डाउनलोड और इंस्टॉल कर सकते हैं। VS Code में MCP सर्वरों का उपयोग करने के बारे में अधिक जानकारी के लिए [Use MCP servers in VS Code (Preview)](https://code.visualstudio.com/docs/copilot/chat/mcp-servers) देखें।

```json
{
  "mcp": {
    "servers": {
      "my-custom-mcp": {
        "type": "stdio",
        "command": "dotnet",
        "args": [
          "tool",
          "exec",
          "<your package ID here>",
          "--version",
          "<your package version here>",
          "--yes",
          "--",
          "start-mcp"
        ],
        "env": {
          "MAX_RANDOM_NUMBER": 100
        }
      }
    }
  }
}
```

अब आप Copilot चैट से एक रैंडम नंबर मांग सकते हैं, उदाहरण के लिए `Give me 3 random numbers`। यह आपको `my-custom-mcp` MCP सर्वर पर `GetRandomNumber` टूल का उपयोग करने के लिए प्रेरित करेगा और आपको परिणाम दिखाएगा।

## लोकली डेवलपमेंट करना

सोर्स कोड (लोकली) से इस MCP सर्वर का परीक्षण करने के लिए बिना बनाए गए MCP सर्वर पैकेज का उपयोग किए, निम्नलिखित VS Code कॉन्फ़िगरेशन का उपयोग करें:

```json
{
  "mcp": {
    "servers": {
      "my-custom-mcp": {
        "type": "stdio",
        "command": "dotnet",
        "args": [
          "run",
          "--project",
          "<PATH TO PROJECT DIRECTORY>",
          "--",
          "start-mcp"
        ],
        "env": {
          "MAX_RANDOM_NUMBER": 100
        }
      }
    }
  }
}
```

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-27

---