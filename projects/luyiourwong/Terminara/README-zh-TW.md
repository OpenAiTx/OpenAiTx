
<div align="right">
  <details>
    <summary >🌐 語言</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=luyiourwong&project=Terminara&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=luyiourwong&project=Terminara&lang=zh-CN">簡體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=luyiourwong&project=Terminara&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=luyiourwong&project=Terminara&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=luyiourwong&project=Terminara&lang=ko">韓國語</a>
        | <a href="https://openaitx.github.io/view.html?user=luyiourwong&project=Terminara&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=luyiourwong&project=Terminara&lang=th">泰語</a>
        | <a href="https://openaitx.github.io/view.html?user=luyiourwong&project=Terminara&lang=fr">法語</a>
        | <a href="https://openaitx.github.io/view.html?user=luyiourwong&project=Terminara&lang=de">德語</a>
        | <a href="https://openaitx.github.io/view.html?user=luyiourwong&project=Terminara&lang=es">西班牙語</a>
        | <a href="https://openaitx.github.io/view.html?user=luyiourwong&project=Terminara&lang=it">義大利語</a>
        | <a href="https://openaitx.github.io/view.html?user=luyiourwong&project=Terminara&lang=ru">俄語</a>
        | <a href="https://openaitx.github.io/view.html?user=luyiourwong&project=Terminara&lang=pt">葡萄牙語</a>
        | <a href="https://openaitx.github.io/view.html?user=luyiourwong&project=Terminara&lang=nl">荷蘭語</a>
        | <a href="https://openaitx.github.io/view.html?user=luyiourwong&project=Terminara&lang=pl">波蘭語</a>
        | <a href="https://openaitx.github.io/view.html?user=luyiourwong&project=Terminara&lang=ar">阿拉伯語</a>
        | <a href="https://openaitx.github.io/view.html?user=luyiourwong&project=Terminara&lang=fa">波斯語</a>
        | <a href="https://openaitx.github.io/view.html?user=luyiourwong&project=Terminara&lang=tr">土耳其語</a>
        | <a href="https://openaitx.github.io/view.html?user=luyiourwong&project=Terminara&lang=vi">越南語</a>
        | <a href="https://openaitx.github.io/view.html?user=luyiourwong&project=Terminara&lang=id">印尼語</a>
        | <a href="https://openaitx.github.io/view.html?user=luyiourwong&project=Terminara&lang=as">অসমীয়া</
      </div>
    </div>
  </details>

</div>

# Terminara

[![詢問 DeepWiki](https://deepwiki.com/badge.svg)](https://deepwiki.com/luyiourwong/Terminara)
![Python 支援](https://img.shields.io/badge/Python-3.10%20%7C%203.11%20%7C%203.12%20%7C%203.13-blue)

一款基於終端機的 AI 模擬遊戲。

## 如何使用

你可以從[最新發行版](https://github.com/luyiourwong/Terminara/releases/latest)下載可執行應用程式。

完整的壓縮檔包含可執行檔案以及預設世界設定檔。若你只是要更新遊戲到最新版本，也可以只下載可執行檔案。

| 作業系統 | 版本                                               |
|----------|----------------------------------------------------|
| Windows  | Windows 10、Windows 11                             |
| Linux    | (GLIBC 2.35+) Ubuntu 22.04 LTS、Ubuntu 24.04 LTS   |
| MacOS    | macOS 13、macOS 14、macOS 15、macOS 26             |

<details>
<summary><strong>手動執行</strong></summary>

### 安裝

1.  **複製此儲存庫：**
    ```bash
    git clone https://github.com/luyiourwong/Terminara
    cd Terminara
    ```

2.  **建立虛擬環境：**
    ```bash
    python -m venv .venv
    source .venv/bin/activate
    ```
    在 Windows 上，使用 `.venv\Scripts\activate`

3.  **安裝相依套件：**
    ```bash
    pip install -e .
    ```

### 啟動方法一：使用已安裝的指令（推薦）
安裝完成後，使用以下指令啟動遊戲：
```bash
terminara
```

### 啟動方法2：直接執行
跨平台方式
```bash
python -m terminara.main
```
or
```bash
python terminara/main.py
```
在 Windows 上，請使用 `terminara\main.py`

欲了解更多資訊，請參閱 [貢獻與開發指南](https://raw.githubusercontent.com/luyiourwong/Terminara/main/CONTRIBUTING.md)。
</details>

## AI 設定

啟動應用程式後，請從主選單設定 AI 相關設定。

![AI 設定](https://raw.githubusercontent.com/luyiourwong/Terminara/main/docs/assets/ai_settings.png)

您需要填寫以下欄位：（OpenAI 相容 API）
- **Host**：API 端點。留空則使用預設的 OpenAI 端點。
- **API Key**：您用於 AI 服務的 API 金鑰。
- **Model**：您要使用的模型。

點擊「套用」以儲存設定。

### 範例

#### 1. [OpenAI](https://platform.openai.com/)（預設）
- **Host**：（留空）
- **API Key**：`YOUR_OPENAI_API_KEY`
- **Model**：`gpt-4o-mini-2024-07-18`

#### 2. [Google AI Studio](http://aistudio.google.com/)
- **Host**：`https://generativelanguage.googleapis.com/v1beta/openai/`
- **API Key**：`YOUR_GEMINI_API_KEY`
- **Model**：`gemini-2.0-flash`

## 世界設定

### 設定儲存
世界設定將儲存在 `terminara/data/worlds` 目錄。（完整版釋出時）
```
.
|-- terminara/
|   `-- data/
|       |-- schema/           # Json schema files for world settings
|       `-- worlds/           # Directory for world setting files
`-- terminara_platform_version        # Executable file
```

### 建立新世界
這裡有一個範例世界 [aethelgard.json](https://raw.githubusercontent.com/luyiourwong/Terminara/main/terminara/data/worlds/aethelgard.json)。你可以依照 [schema](https://raw.githubusercontent.com/luyiourwong/Terminara/main/terminara/data/schema/world_schema.json) 來創建新世界。

## 連結

- [GitHub Pages](https://luyiourwong.github.io/Terminara)
- [GitHub Repository](https://github.com/luyiourwong/Terminara)
- [參與與開發指南](https://raw.githubusercontent.com/luyiourwong/Terminara/main/CONTRIBUTING.md)

## 授權

本專案依據 [MIT 授權條款](LICENSE) 發佈。


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-09-26

---