<div align="center">
  <img src="https://raw.githubusercontent.com/ai-shifu/ChatALL/main/src/assets/logo-cover.png" width=256></img>
  <p><strong>同時與所有 AI 機器人對話，發掘最佳答案</strong></p>

[Deutsch](README_DE-DE.md) | English | [Español](README_ES-ES.md) | [Français](README_FR-FR.md) | [Italian](README_IT-IT.md) | [日本語](README_JA-JP.md) | [한국어](README_KO-KR.md) | [Русский](README_RU-RU.md) | [Tiếng Việt](README_VI-VN.md) | [简体中文](README_ZH-CN.md)

[![Open in GitHub Codespaces](https://github.com/codespaces/badge.svg)](https://codespaces.new/ai-shifu/ChatALL)

</div>

## 截圖

![Screenshot](https://raw.githubusercontent.com/ai-shifu/ChatALL/main/screenshots/screenshot-1.png?raw=true)

## 功能特點

基於大型語言模型（LLMs）的 AI 機器人非常強大，但它們的行為經常具有隨機性，不同的機器人在不同任務上表現各異。如果你想獲得最佳體驗，無需逐一嘗試。ChatALL（中文名：齊叨）能同時將提示發送給多個 AI 機器人，幫助你發掘最佳答案。你只需[下載、安裝](https://github.com/ai-shifu/ChatALL/releases)並開始提問。

### 你是這樣的用戶嗎？

ChatALL 的典型用戶包括：

- 🤠**LLM 專家**，希望從多個 LLM 中找到最佳答案或創作。
- 🤓**LLM 研究人員**，希望直觀對比各 LLM 在不同領域的優劣。
- 😎**LLM 應用開發者**，希望快速調試 prompt 並尋找表現最佳的基礎模型。

### 支援的機器人

| AI 機器人                                                                       | 網頁訪問   | API         | 備註                                         |
| ------------------------------------------------------------------------------ | ----------- | ----------- | ------------------------------------------- |
| [360 智腦](https://ai.360.cn/)                                                 | 是          | 無 API      |                                             |
| [百度文心一言](https://yiyan.baidu.com/)                                        | 否          | 有          |                                             |
| [Character.AI](https://character.ai/)                                          | 是          | 無 API      |                                             |
| [ChatGLM2 6B & 130B](https://chatglm.cn/)                                      | 是          | 無 API      | 無需登入                                    |
| [ChatGPT](https://chatgpt.com)                                             | 是          | 有          | 支援網頁瀏覽，包含 Azure OpenAI 服務         |
| [Claude](https://www.anthropic.com/claude)                                     | 是          | 有          |                                             |
| [Code Llama](https://ai.meta.com/blog/code-llama-large-language-model-coding/) | 是          | 無 API      |                                             |
| [Cohere Aya 23](https://cohere.com/blog/aya23)                                 | 否          | 有          |                                             |
| [Cohere Command R Models](https://cohere.com/command)                          | 否          | 有          |                                             |
| [Copilot](https://copilot.microsoft.com/)                                      | 是          | 無 API      |                                             |
| [得到學習助手](https://ai.dedao.cn/)                                           | 敬請期待    | 無 API      |                                             |
| [Falcon 180B](https://huggingface.co/tiiuae/falcon-180B-chat)                  | 是          | 無 API      |                                             |
| [Gemini](https://gemini.google.com/)                                           | 是          | 有          |                                             |
| [Gemma 2B & 7B](https://blog.google/technology/developers/gemma-open-models/)  | 是          | 無 API      |                                             |
| [Gradio](https://gradio.app/)                                                  | 是          | 無 API      | 用於 Hugging Face space 或自建模型           |
| [Groq Cloud](https://console.groq.com/docs/models)                             | 否          | 有          |                                             |
| [HuggingChat](https://huggingface.co/chat/)                                    | 是          | 無 API      |                                             |
| [科大訊飛星火大模型](http://xinghuo.xfyun.cn/)                                  | 是          | 敬請期待    |                                             |
| [Kimi](https://kimi.moonshot.cn/               )                               | 是          | 無 API      |                                             |
| [Llama 2 13B & 70B](https://ai.meta.com/llama/)                                | 是          | 無 API      |                                             |
| [MOSS](https://moss.fastnlp.top/)                                              | 是          | 無 API      |                                             |
| [Perplexity](https://www.perplexity.ai/)                                       | 是          | 無 API      |                                             |
| [Phind](https://www.phind.com/)                                                | 是          | 無 API      |                                             |
| [Pi](https://pi.ai)                                                            | 是          | 無 API      |                                             |
| [Poe](https://poe.com/)                                                        | 是          | 敬請期待    |                                             |
| [SkyWork](https://neice.tiangong.cn/)                                          | 是          | 敬請期待    |                                             |
| [通義千問](http://tongyi.aliyun.com/)                                          | 是          | 敬請期待    |                                             |
| [Vicuna 13B & 33B](https://lmsys.org/blog/2023-03-30-vicuna/)                  | 是          | 無 API      | 無需登入                                    |
| [WizardLM 70B](https://github.com/nlpxucan/WizardLM)                           | 是          | 無 API      |                                             |
| [xAI Grok](https://x.ai)                                                       | 否          | 有          |                                             |
| [YouChat](https://you.com/)                                                    | 是          | 無 API      |                                             |
| [You](https://you.com/)                                                        | 是          | 無 API      |                                             |
| [Zephyr](https://huggingface.co/spaces/HuggingFaceH4/zephyr-chat)              | 是          | 無 API      |                                             |

更多機器人將陸續支援。歡迎在[這些議題](https://github.com/ai-shifu/ChatALL/labels/more%20LLMs)為你喜歡的機器人投票。

### 關於網頁連接機器人穩定性的說明

連接網頁的 AI 機器人（標記為“網頁訪問”）天生穩定性較差，經常受到服務商調整網頁介面與安全策略的影響。這些基於網頁的連接依賴逆向工程，維護難度大，容易隨時失效。若追求穩定體驗，強烈建議優先選擇支援 API 的機器人。

### 其他功能

- 快速提示模式：無需等待上一個回應即可發送下一條 prompt
- 本地保存聊天記錄，保護你的隱私
- 可標記喜歡的回應，刪除不佳回應
- 隨時啟用/停用任意機器人
- 支援單欄、雙欄、三欄視圖切換
- 自動更新至最新版本
- 暗色模式（貢獻者 @tanchekwei）
- 快捷鍵。按 <kbd>Ctrl</kbd> + <kbd>/</kbd> 查看全部（貢獻者 @tanchekwei）
- 支援多會話（貢獻者 @tanchekwei）
- 支援代理設定（貢獻者 @msaong）
- Prompt 管理（貢獻者 @tanchekwei）
- 支援多語言（中文、英文、德文、法文、俄文、越南文、韓文、日文、西班牙文、義大利文）
- 支援 Windows、macOS 與 Linux

計畫中的功能：

歡迎參與這些功能的開發。

- [ ] 前端部署至 GitHub Pages

## 隱私聲明

所有聊天記錄、設置與登入資料均只保存在本地電腦。

ChatALL 會收集匿名使用數據，以協助我們改進產品。包括：

- 哪些 AI 機器人被觸發、prompt 長度，不包含 prompt 內容。
- 回應長度，以及哪些回應被刪除/標記，不包含回應內容。

## 前置條件

ChatALL 是客戶端而非代理。因此，你必須：

1. 擁有機器人的有效帳號和/或 API 金鑰。
2. 能穩定連接至各機器人網路服務。

## 下載 / 安裝

下載地址：https://github.com/ai-shifu/ChatALL/releases

### Windows 系統

直接下載 \*-win.exe 檔案並進行安裝。

### macOS 系統

Apple Silicon Mac（M1、M2 CPU）請下載 \*-mac-arm64.dmg。

其他 Mac 請下載 \*-mac-x64.dmg。

如使用 [Homebrew](https://brew.sh/)，亦可用以下方式安裝：

```bash
brew install --cask chatall
```

### Linux 系統

Debian 系發行版：下載 .deb 檔，雙擊安裝。
Arch 系發行版：可從 AUR [這裡](https://aur.archlinux.org/packages/chatall-bin) 克隆 ChatALL，可手動或用 yay/paru 等輔助工具安裝。
其他發行版：下載 .AppImage 檔，設為可執行後點擊即用。亦可使用 [AppimageLauncher](https://github.com/TheAssassin/AppImageLauncher)。

## 疑難排解

如使用 ChatALL 遇到問題，可嘗試以下方法解決：

1. **刷新** - 按 <kbd>Ctrl</kbd> + <kbd>R</kbd> 或 <kbd>⌘</kbd> + <kbd>R</kbd>。
2. **重啟** - 退出 ChatALL 後重新啟動。
3. **重新登入** - 點右上角設置按鈕，再點對應登入/登出連結重新登入網站。
4. **新建聊天** - 點擊 `New Chat` 按鈕，重新發送 prompt。

若以上方法皆無效，可嘗試**重置 ChatALL**。注意這會刪除所有設置與聊天記錄。

可通過刪除以下目錄重置：

- Windows: `C:\Users\<user>\AppData\Roaming\chatall\`
- Linux: `/home/<user>/.config/chatall/`
- macOS: `/Users/<user>/Library/Application Support/chatall/`

若問題依然存在，請[提交 issue](https://github.com/ai-shifu/ChatALL/issues)。

## 給開發者

### 貢獻新機器人

[參考指引](https://github.com/ai-shifu/ChatALL/wiki/%E5%A6%82%E4%BD%95%E6%B7%BB%E5%8A%A0%E4%B8%80%E4%B8%AA%E6%96%B0%E7%9A%84-AI-%E5%AF%B9%E8%AF%9D%E6%9C%BA%E5%99%A8%E4%BA%BA) 可能對你有幫助。

### 運行

```bash
npm install
npm run electron:serve
```

### 打包

僅為當前平台打包：

```bash
npm run electron:build
```

打包所有平台：

```bash
npm run electron:build -- -wml --x64 --arm64
```

## 鳴謝

### 貢獻者

<a href="https://github.com/ai-shifu/ChatALL/graphs/contributors">
  <img src="https://contrib.rocks/image?repo=ai-shifu/ChatALL" />
</a>

### 其他

- GPT-4 貢獻了大量程式碼
- ChatGPT、Copilot 及 Google 提供了許多解決方案（按順序排列）
- 靈感來自 [ChatHub](https://github.com/chathub-dev/chathub)。致敬！

## 贊助

如果你喜歡這個項目，請考慮：

[![ko-fi](https://ko-fi.com/img/githubbutton_sm.svg)](https://ko-fi.com/F1F8KZJGJ)

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-22

---