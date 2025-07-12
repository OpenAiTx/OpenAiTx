# 寸止 🛑

> **AI 對話「早洩」終結者，讓交流持續到底**

還在為 AI 助手總是提前結束對話而抓狂嗎？明明還有很多要聊，它卻說「還有什麼需要幫助的嗎？」**寸止** 專治這個毛病！

當 AI 想要「草草了事」時，寸止會及時彈出對話框，讓你能夠繼續深入交流，直到真正解決問題為止。

## 🌟 核心特性

- 🛑 **智能攔截**：AI 想結束時自動彈出繼續選項
- 🧠 **記憶管理**：按項目儲存開發規範和偏好
- 🎨 **優雅互動**：Markdown 支援、多種輸入方式
- ⚡ **即裝即用**：3 秒安裝，跨平台支援

## 📸 看看效果

### 🛑 智能攔截彈窗
![寸止彈窗演示](https://raw.githubusercontent.com/imhuso/cunzhi/main/./screenshots/popup.png)

*當 AI 想要結束對話時，寸止智能彈窗及時出現，提供預定義選項快速選擇，讓交流持續深入*
### ⚙️ 設定管理介面
![寸止設定介面](https://raw.githubusercontent.com/imhuso/cunzhi/main/./screenshots/settings.png)

*優雅的設定介面，支援記憶管理、功能開關、主題切換和智慧提示詞生成*

## 🚀 開始使用

### 方式一：快速安裝（推薦）

**macOS 使用者：**
```bash
# 3 秒安裝，無需等待編譯
brew tap imhuso/cunzhi && brew install cunzhi
```

> ⚠️ **故障排除**：如果遇到 404 下載錯誤，請執行以下步驟：
>
> ```bash
> # 清除舊的 tap 快取
> brew untap imhuso/cunzhi
> # 重新安裝
> brew tap imhuso/cunzhi && brew install cunzhi
> ```
>
> **常見錯誤範例：**
> ```
> curl: (56) The requested URL returned error: 404
> Error: cunzhi: Failed to download resource "cunzhi"
> Download failed: https://github.com/imhuso/cunzhi/releases/download/v0.2.0/cunzhi-cli-v0.2.4-macos-aarch64.tar.gz
> ```
>
> 這通常是由於先前版本的快取問題導致版本號不匹配。清除 tap 後重新安裝即可解決。

**Windows/Linux 使用者：**
推薦使用方式二手動下載，簡單快捷！
### 方式二：手動下載

1. 訪問 [Releases 頁面](https://github.com/imhuso/cunzhi/releases)
2. 下載適合你系統的版本：
   - 🐧 **Linux**: `cunzhi-cli-v*-linux-x86_64.tar.gz`
   - 🍎 **macOS (Intel)**: `cunzhi-cli-v*-macos-x86_64.tar.gz`
   - 🍎 **macOS (Apple Silicon)**: `cunzhi-cli-v*-macos-aarch64.tar.gz`
   - 🪟 **Windows**: `cunzhi-cli-v*-windows-x86_64.zip`

3. 解壓後將 `寸止` 和 `等一下` 添加到系統 PATH

## ⚡ 快速上手

### 第一步：配置 MCP 客戶端

在你的 MCP 客戶端（如 Claude Desktop）配置文件中添加：

```json
{
  "mcpServers": {
    "寸止": {
      "command": "寸止"
    }
  }
}
```
### 第二步：打開設定介面

```bash
# 執行設定指令
等一下
```

### 第三步：配置提示詞

在設定介面的「參考提示詞」標籤頁：
1. 查看自動生成的提示詞
2. 點擊複製按鈕
3. 將提示詞添加到你的 AI 助手中

### 第四步：開始使用

現在你的 AI 助手就擁有了智慧攔截、記憶管理和彈窗互動功能！

> 💡 **小貼士**：你可以參考生成的提示詞進行個性化修改，打造專屬的 AI 互動體驗。
## 🤝 參與貢獻

寸止是開源項目，我們歡迎所有形式的貢獻！

### 🐛 發現問題？
- [提交 Issue](https://github.com/imhuso/cunzhi/issues) 描述問題
- 提供重現步驟和環境資訊

### 💡 有好想法？
- [發起討論](https://github.com/imhuso/cunzhi/discussions) 分享你的想法
- 提交 Pull Request 實現新功能

### 🛠️ 本地開發
```bash
git clone https://github.com/imhuso/cunzhi.git
cd cunzhi
pnpm install
pnpm tauri:dev
```
## 📞 聯絡我們

- 🐛 **問題回饋**：[GitHub Issues](https://github.com/imhuso/cunzhi/issues)
- 💬 **功能討論**：[GitHub Discussions](https://github.com/imhuso/cunzhi/discussions)
- ⭐ **喜歡專案**：給我們一個 Star 支持！

## 📄 開源協議

MIT License - 自由使用，歡迎貢獻！

---

<div align="center">

**告別 AI 對話「早洩」｜讓每次交流都持續到底**

[⭐ Star](https://github.com/imhuso/cunzhi) · [🐛 回報錯誤](https://github.com/imhuso/cunzhi/issues) · [💡 功能建議](https://github.com/imhuso/cunzhi/discussions)

</div>

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-12

---