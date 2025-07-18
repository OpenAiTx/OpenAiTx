# Agent2Agent (A2A) 範例

<div style="text-align: right;">
  <details>
    <summary>🌐 語言</summary>
    <div style="text-align: center;">
      <a href="https://openaitx.github.io/view.html?user=a2aproject&project=a2a-samples&lang=en">English</a>
      | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=a2a-samples&lang=zh-CN">简体中文</a>
      | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=a2a-samples&lang=zh-TW">繁體中文</a>
      | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=a2a-samples&lang=ja">日本語</a>
      | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=a2a-samples&lang=ko">한국어</a>
      | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=a2a-samples&lang=hi">हिन्दी</a>
      | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=a2a-samples&lang=th">ไทย</a>
      | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=a2a-samples&lang=fr">Français</a>
      | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=a2a-samples&lang=de">Deutsch</a>
      | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=a2a-samples&lang=es">Español</a>
      | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=a2a-samples&lang=it">Italiano</a>
      | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=a2a-samples&lang=ru">Русский</a>
      | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=a2a-samples&lang=pt">Português</a>
      | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=a2a-samples&lang=nl">Nederlands</a>
      | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=a2a-samples&lang=pl">Polski</a>
      | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=a2a-samples&lang=ar">العربية</a>
      | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=a2a-samples&lang=fa">فارسی</a>
      | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=a2a-samples&lang=tr">Türkçe</a>
      | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=a2a-samples&lang=vi">Tiếng Việt</a>
      | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=a2a-samples&lang=id">Bahasa Indonesia</a>
    </div>
  </details>
</div>

本儲存庫包含使用 [Agent2Agent (A2A) 協議](https://goo.gle/a2a) 的程式範例與演示。

## 相關儲存庫

- [A2A](https://github.com/a2aproject/A2A) - A2A 規範與文件。
- [a2a-python](https://github.com/a2aproject/a2a-python) - A2A Python SDK。
- [a2a-inspector](https://github.com/a2aproject/a2a-inspector) - 用於檢查支援 A2A 代理的 UI 工具。

## 貢獻方式

歡迎貢獻！請參閱 [貢獻指南](https://raw.githubusercontent.com/a2aproject/a2a-samples/main/CONTRIBUTING.md)。

## 求助

請使用 [問題頁面](https://github.com/a2aproject/a2a-samples/issues) 提供建議、回饋或提交錯誤報告。

## 免責聲明

本儲存庫本身並非 Google 官方支援的產品。本儲存庫內的程式碼僅供示範用途。

重要事項：提供的範例程式碼僅供演示用途，說明 Agent-to-Agent (A2A) 協議的運作機制。在構建正式應用程式時，任何不在您直接控制下運行的代理都必須視為潛在不可信的實體。

從外部代理收到的所有資料——包括但不限於其 AgentCard、訊息、產物和任務狀態——都應以不可信輸入處理。例如，惡意代理可能會在其 AgentCard 欄位（如 description、name、skills.description）中提供經過設計的資料。如果這些資料在未經過濾的情況下用於構建大型語言模型（LLM）的提示，可能會使您的應用程式暴露於提示注入攻擊。未正確驗證與過濾這些資料可能會為您的應用帶來安全漏洞。

開發人員有責任實施適當的安全措施，如輸入驗證與安全處理憑證，以保護其系統與用戶。


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-18

---