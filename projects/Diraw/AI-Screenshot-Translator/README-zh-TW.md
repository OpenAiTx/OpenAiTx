# AI 截圖翻譯工具 (AI Screenshot Translator)

[![Python Version](https://img.shields.io/badge/python-3.8+-blue.svg)](https://www.python.org/downloads/) [![Nuitka](https://img.shields.io/badge/Nuitka-Compiled-purple)](https://nuitka.net/) [![Release Version](https://img.shields.io/badge/Release-v0.3.4-red)](https://github.com/Diraw/AI-Screenshot-Translator/releases/tag/v0.3.4-test)

# 簡介

本工具通過**簡單的截圖操作**，將圖片發送給 AI 模型進行文本識別和翻譯，並將翻譯結果以可互動的 HTML 格式顯示在獨立的視窗中。

本工具支援**自訂快捷鍵觸發、多視窗結果管理以及系統托盤運行**，大幅提升日常工作和學習中的翻譯效率。

**工具特色**：1、截圖翻譯，快捷鍵啟動；2、貼片截圖與翻譯，可隨意拖動、縮放，可建立多組翻譯貼片；3、公式可切換原始文本方便複製；4、自訂api介面

**欲解決的痛點**：1、目前市面上主流的整篇文件翻譯過於臃腫；2、若選擇pdf複製文本貼上翻譯，有時公式區塊會錯亂或無法複製；3、針對影像掃描的pdf，無法複製文本

# 演示

<img src="https://raw.githubusercontent.com/Diraw/AI-Screenshot-Translator/main/img/0.1.gif" alt="" width="100%">

# 視窗展示

翻譯視窗：

<img src="https://raw.githubusercontent.com/Diraw/AI-Screenshot-Translator/main/img/v0.2.1.svg" alt="" width="100%">

設定視窗：

<table>
  <tr>
    <td><img src="https://raw.githubusercontent.com/Diraw/AI-Screenshot-Translator/main/img/v3.0.1.png" /></td>
    <td><img src="https://raw.githubusercontent.com/Diraw/AI-Screenshot-Translator/main/img/v3.0.0_2.png" /></td>
  </tr>
</table>

更詳細的設定選項介紹可於軟體內部或網頁查看 [提示](https://raw.githubusercontent.com/Diraw/AI-Screenshot-Translator/main/doc/hint.md)

# 安裝

您可以選擇下載原始碼運行，或前往 [Releases](https://github.com/Diraw/AI-Screenshot-Translator/releases) 頁面下載可執行檔

### 1. 複製專案

```bash
git clone https://github.com/Diraw/AI-Screenshot-Translator.git
cd AI-Screenshot-Translator/src
```

### 2. 建立虛擬環境並運行

```bash
conda create -n AI-Translator python=3.8
conda activate AI-Translator
pip install -r requirements.txt
python main.py
```

# 更新計畫

- ~~新增api設定的gui視窗，優化手動設定yaml檔案的邏輯為軟體自動產生（v0.3.0已完成）~~
- 新增圖片與公式儲存系統，方便後續調用（預計v0.4完成）
- （更多功能歡迎issue提出或PR貢獻）

# 其他

- 軟體icon來自 [iconfinder](https://www.iconfinder.com/search?q=screenshot&price=free)
- 感謝 Gemini 2.5 Flash 和 DeepSeek-V3-0324 幫我找bug

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-10

---