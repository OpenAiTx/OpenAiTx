# Git Smart Squash

別再浪費時間手動重組提交記錄了。讓 AI 為你完成這項工作。

## 問題

你一定遇過這種情況：為了一個功能提交了 15 次，其中一半是「fix」、「typo」或「WIP」。現在你需要在 PR 審查前整理這些提交。手動壓縮和重寫非常繁瑣。

## 解決方案

Git Smart Squash 會分析你的變更，並將它們重新組織為具備合適訊息的邏輯提交：

```bash
# 之前：你凌亂的分支
* fix tests
* typo  
* more auth changes
* WIP: working on auth
* update tests
* initial auth implementation
```
# After: clean, logical commits
* feat: 實作 JWT 認證系統
* test: 增加認證端點的測試覆蓋率
```

## 快速開始

### 1. 安裝

```bash
# 使用 pip
pip install git-smart-squash

# 使用 pipx（建議用於隔離安裝）
pipx install git-smart-squash

# 使用 uv（快速的 Python 套件管理器）
uv tool install git-smart-squash
```
### 2. 設定 AI

**選項 A：本地端（免費，私密）**
```bash
# 從 https://ollama.com 安裝 Ollama
ollama pull devstral  # 預設模型
```

**選項 B：雲端（更佳結果）**
```bash
export OPENAI_API_KEY="your-key"
export ANTHROPIC_API_KEY="your-key"
export GEMINI_API_KEY="your-key"
```

### 3. 執行

```bash
cd your-repo
git-smart-squash
```
就是這樣。請審查並批准該計劃。

## 命令列參數

| 參數 | 說明 | 預設值 |
|------|------|--------|
| `--base` | 要比較的基礎分支 | 設定檔或 `main` |
| `--ai-provider` | 要使用的 AI 供應商（openai、anthropic、local、gemini） | 設定中已設定 |
| `--model` | 要使用的特定 AI 模型（見下方推薦模型） | 供應商預設 |
| `--config` | 自訂設定檔的路徑 | `.git-smart-squash.yml` 或 `~/.git-smart-squash.yml` |
| `--auto-apply` | 不需確認提示自動套用提交計劃 | `false` |
| `--instructions`, `-i` | 提供 AI 的自訂指示（例如：「依功能區分組」） | 無 |
| `--no-attribution` | 在提交中停用出處訊息 | `false` |
| `--debug` | 啟用詳細資訊的除錯日誌 | `false` |

## 推薦模型

### 預設模型
- **OpenAI**: `gpt-4.1`（預設）
- **Anthropic**: `claude-sonnet-4-20250514`（預設）
- **Gemini**: `gemini-2.5-pro`（預設）
- **Local/Ollama**: `devstral`（預設）

### 模型選擇
```bash
# 指定不同的模型
git-smart-squash --ai-provider openai --model gpt-4.1-mini

# 用於本地 Ollama
git-smart-squash --ai-provider local --model llama-3.1
```

## 自訂指令

`--instructions` 參數讓你控制如何組織提交紀錄：

### 範例
```bash
# 新增票證前綴
git-smart-squash -i "Prefix all commits with [ABC-1234]"

# 依類型區分
git-smart-squash -i "Keep backend and frontend changes in separate commits"
```
# 限制提交數量
git-smart-squash -i "最多只建立 3 個提交"

```

### 更佳結果的小技巧
- **具體說明**：「將資料庫遷移單獨分組」比「整理好」更有效
- **一次一個指令**：複雜的多步驟指令可能會被部分忽略
- **使用更佳模型**：較大的模型比小型模型更能可靠遵從指令

## 常見使用情境

### 「我需要在 PR 審查前清理提交」
```bash
git-smart-squash              # 顯示計劃並提示確認
git-smart-squash --auto-apply # 自動套用，不提示
```

### 「我的主分支名稱不同」
```bash
git-smart-squash --base develop
```
### 「我想使用特定的 AI 供應商」
```bash
git-smart-squash --ai-provider openai
```

## 安全性

**您的程式碼是安全的：**
- 變更前顯示計劃
- 自動建立備份分支
- 需要乾淨的工作目錄
- 從不會在未經您指示下推送

**如果發生問題：**
```bash
# 查找備份
git branch | grep backup

# 還原
git reset --hard your-branch-backup-[timestamp]
```

## AI 提供者

| 提供者      | 費用    | 隱私     |
|-------------|---------|----------|
| **Ollama**  | 免費    | 本地端   |
| **OpenAI**  | 約 $0.01 | 雲端     |
| **Anthropic** | 約 $0.01 | 雲端   |
| **Gemini**  | 約 $0.01 | 雲端     |

## 進階設定（選用）

想自訂嗎？建立一個設定檔：

**專案專屬**（在你的倉庫中 `.git-smart-squash.yml`）：
```yaml
ai:
  provider: openai  # 這個專案使用 OpenAI
base: develop       # 這個專案使用 develop 作為基礎分支
```
**全域預設**（`~/.git-smart-squash.yml`）：
```yaml
ai:
  provider: local   # 預設一律使用本地 AI
base: main          # 所有專案的預設基礎分支
```

## 疑難排解

### 「Invalid JSON」錯誤
這通常表示 AI 模型無法正確格式化回應：
- **使用 Ollama 時**：從 `llama2` 換成 `mistral` 或 `mixtral`
- **解決方法**：執行 `ollama pull mistral` 然後重試
- **替代方案**：使用雲端供應商並加上 `--ai-provider openai`

### 模型未遵循指示
某些模型在處理複雜指令時會遇到困難：
- **使用更好的模型**：`--model gpt-4-turbo` 或 `--model claude-3-opus`
- **簡化指令**：一個明確的指示比多個指示效果更好
- **明確說明**：「以 [ABC-123] 為前綴」比「加上票號」更有效
### "找不到 Ollama"
```bash
# 從 https://ollama.com 安裝
ollama serve
ollama pull devstral  # 預設模型
```

### 提交分組不佳
如果 AI 產生太多提交或分組不佳：
- **模型不足**：請使用更大型的模型
- **新增指示**：`-i "將相關更動分組，最多 3 次提交"`
- **提供回饋**：在 GitHub 上建立 issue 並讓我們知道發生了什麼事

### 安裝問題（Mac）
如果你沒有 pip 或偏好隔離安裝：
```bash
# 使用 pipx（推薦）
brew install pipx
pipx install git-smart-squash
```
### 「沒有可重組的變更」
```bash
git log --oneline main..HEAD  # 檢查你有提交紀錄
git diff main                 # 檢查你有變更內容
```

### 大型差異 / Token 限制
本地模型有約 32k token 的限制。若有大量變更：
- 使用 `--base` 搭配較新的提交紀錄
- 切換到雲端：`--ai-provider openai`
- 拆分成較小的 PR

### 需要更多幫助？

請參閱我們的[詳細文件](https://raw.githubusercontent.com/edverma/git-smart-squash/main/DOCUMENTATION.md)，或提出 issue！

## 授權

MIT 授權 - 詳情請參見 [LICENSE](LICENSE) 檔案。

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-12

---