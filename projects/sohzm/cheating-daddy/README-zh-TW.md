# Cheating Daddy

> [!NOTE]  
> 請使用最新版本的 MacOS 和 Windows，舊版本僅有限支援

> [!NOTE]  
> 測試期間若直接發問它不會回答，你必須模擬面試官提問，它才會回應

一款即時 AI 助手，透過螢幕擷取與音訊分析，於視訊通話、面試、簡報和會議中提供情境式協助。

## 功能特色

- **即時 AI 協助**：由 Google Gemini 2.0 Flash Live 提供即時支援
- **螢幕與音訊擷取**：分析你所見與所聞，產生情境式回應
- **多重情境模式**：面試、銷售電話、商務會議、簡報、談判
- **透明覆蓋視窗**：可隨意移動、永遠置頂的小視窗
- **點擊穿透模式**：需要時讓視窗透明以便點擊穿透
- **跨平台支援**：支援 macOS、Windows 與 Linux（僅供測試，請勿正式使用）

## 安裝設定

1. **取得 Gemini API 金鑰**：前往 [Google AI Studio](https://aistudio.google.com/apikey)
2. **安裝相依套件**：`npm install`
3. **啟動應用程式**：`npm start`

## 使用方式

1. 在主視窗輸入你的 Gemini API 金鑰
2. 在設定中選擇你的情境模式與語言
3. 點擊「開始會議」以啟動
4. 使用鍵盤快捷鍵調整視窗位置
5. AI 會根據螢幕內容與面試官問題即時提供協助

## 鍵盤快捷鍵

- **視窗移動**：`Ctrl/Cmd + 方向鍵` - 移動視窗
- **點擊穿透**：`Ctrl/Cmd + M` - 切換滑鼠事件
- **關閉/返回**：`Ctrl/Cmd + \` - 關閉視窗或返回
- **發送訊息**：`Enter` - 傳送文字給 AI

## 音訊擷取

- **macOS**：使用 [SystemAudioDump](https://github.com/Mohammed-Yasin-Mulla/Sound) 擷取系統音訊
- **Windows**：回送音訊擷取
- **Linux**：麥克風輸入

## 系統需求

- 支援 Electron 的作業系統（macOS、Windows、Linux）
- Gemini API 金鑰
- 螢幕錄影權限
- 麥克風/音訊權限

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-10

---