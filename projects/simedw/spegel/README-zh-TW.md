# Spegel – 透過 AI 反映網頁

自動將網站重寫為適合在終端機中瀏覽的 Markdown 格式。
閱讀介紹部落格文章 [這裡](https://simedw.com/2025/06/23/introducing-spegel/)

這是一個概念驗證專案，預期會有錯誤，但歡迎提出 Issue 或 Pull Request。

##  截圖
有時你不想為了拿到食譜而讀完某人的人生故事
![Recipe Example](https://simedw.com/2025/06/23/introducing-spegel/images/recipe_example.png)


## 安裝

需要 Python 3.11 以上版本

```
pip install spegel
```
或是 clone 這個 repo 並以可編輯模式安裝

```bash
# Clone 並進入目錄
$ git clone <repo-url>
$ cd spegel

# 安裝相依套件與 CLI
$ pip install -e .
```

## API 金鑰
Spegel 目前僅支援 Gemini 2.5 Flash，使用時需於環境變數中提供 API 金鑰

```
GEMINI_API_KEY=...
```


## 使用方式

### 啟動瀏覽器

```bash
spegel                # 啟動歡迎畫面
spegel bbc.com        # 直接開啟指定網址
```

或者，等效地：

```bash
python -m spegel      # 啟動歡迎畫面
python -m spegel bbc.com
```

### 基本操作
- `/`         – 開啟網址輸入
- `Tab`/`Shift+Tab` – 巡覽連結
- `Enter`     – 開啟選定連結
- `e`         – 編輯目前畫面的 LLM 提示詞
- `b`         – 返回
- `q`         – 離開

## 編輯設定

Spegel 會從 TOML 設定檔載入設定。你可以自訂檢視、提示詞，以及 UI 選項。

**設定檔搜尋順序：**
1. `./.spegel.toml`（目前目錄）
2. `~/.spegel.toml`
3. `~/.config/spegel/config.toml`

編輯設定的方法：
1. 複製範例設定檔：
   ```bash
   cp example_config.toml .spegel.toml
   # 或建立 ~/.spegel.toml
   ```
2. 用你喜愛的編輯器編輯 `.spegel.toml`。

範例片段：
```toml
[settings]
default_view = "terminal"
app_title = "Spegel"

[[views]]
id = "raw"
name = "Raw View"
prompt = ""

[[views]]
id = "terminal"
name = "Terminal"
prompt = "Transform this webpage into the perfect terminal browsing experience! ..."
```

---

更多資訊請參考原始碼或提出 Issue！

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-08

---