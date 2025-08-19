# Agent2Agent (A2A) 範例

<a href="https://studio.firebase.google.com/new?template=https%3A%2F%2Fgithub.com%2Fa2aproject%2Fa2a-samples%2Ftree%2Fmain%2F.firebase-studio">
  <picture>
    <source
      media="(prefers-color-scheme: dark)"
      srcset="https://cdn.firebasestudio.dev/btn/try_light_20.svg">
    <source
      media="(prefers-color-scheme: light)"
      srcset="https://cdn.firebasestudio.dev/btn/try_dark_20.svg">
    <img
      height="20"
      alt="在 Firebase Studio 中試用"
      src="https://cdn.firebasestudio.dev/btn/try_blue_20.svg">
  </picture>
</a>

<div style="text-align: right;">
  <details>
    <summary>🌐 語言</summary>
    <div style="text-align: center;">
      <a href="https://openaitx.github.io/view.html?user=a2aproject&project=a2a-samples&lang=en">English</a>
      | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=a2a-samples&lang=zh-CN">簡體中文</a>
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
      | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=a2a-samples&lang=zh-tw">繁體中文</a>
    </div>
  </details>
</div>

本儲存庫包含使用 [Agent2Agent (A2A) 協議](https://goo.gle/a2a) 的程式碼範例與演示。

## 相關儲存庫

- [A2A](https://github.com/a2aproject/A2A) - A2A 規範與文件。
- [a2a-python](https://github.com/a2aproject/a2a-python) - A2A Python SDK。
- [a2a-inspector](https://github.com/a2aproject/a2a-inspector) - 用於檢查支援 A2A 代理的 UI 工具。

## 貢獻說明

歡迎貢獻！請參閱 [貢獻指南](https://raw.githubusercontent.com/a2aproject/a2a-samples/main/CONTRIBUTING.md)。

## 取得協助

請使用 [問題頁面](https://github.com/a2aproject/a2a-samples/issues) 提供建議、回饋或提交錯誤報告。

## 免責聲明

本儲存庫本身並非 Google 官方支援的產品。此儲存庫中的程式碼僅供展示用途。

重要事項：所提供的範例程式碼僅供演示，並說明 Agent-to-Agent (A2A) 協議的運作機制。若用於生產環境，任何在您直接控制範圍外運作的代理都必須視為可能不可信的實體。

所有從外部代理收到的資料——包括但不限於其 AgentCard、訊息、產物及任務狀態——皆應視為不可信的輸入。例如，惡意代理可能在其 AgentCard 欄位中（如描述、名稱、技能描述）提供精心設計的資料。若未經淨化直接用於生成大型語言模型（LLM）的提示，可能使您的應用程式暴露於提示注入攻擊。未妥善驗證並淨化這些資料就使用，將可能為您的應用程式引入安全漏洞。

開發者需負責實作適當的安全措施，如輸入驗證及憑證安全處理，以保護其系統及用戶。


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-19

---