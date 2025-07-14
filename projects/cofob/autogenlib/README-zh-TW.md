# AutoGenLib

> 你唯一需要的程式庫。
>
> 導入智慧，匯出程式碼。

AutoGenLib 是一個使用 OpenAI API 即時自動生成程式碼的 Python 程式庫。當你嘗試匯入不存在的模組或函式時，AutoGenLib 會根據你所需的高階描述幫你創建它們。

## 功能

- **動態程式碼生成**：匯入尚未存在的模組和函式
- **具上下文感知**：新函式會根據現有程式碼生成
- **漸進式增強**：無縫為現有模組新增功能
- **無預設快取**：每次匯入皆生成新程式碼，帶來更多元創意
- **完整程式碼庫上下文**：大型語言模型可查看所有先前生成的模組，提升一致性
- **呼叫端程式碼分析**：大型語言模型會分析實際匯入模組的程式碼，更了解上下文與需求
- **自動例外處理**：所有例外皆送至大型語言模型，提供清楚的錯誤說明與修正建議。

## 安裝

```bash
pip install autogenlib
```
或者從原始碼安裝：


```bash
git clone https://github.com/cofob/autogenlib.git
cd autogenlib
pip install -e .
```
## 需求

- Python 3.12+
- OpenAI API 金鑰

## 快速開始

將 OpenAI API 金鑰設置在 `OPENAI_API_KEY` 環境變數中。


```python
# Import a function that doesn't exist yet - it will be automatically generated
from autogenlib.tokens import generate_token

# Use the generated function
token = generate_token(length=32)
print(token)
```
## 運作原理

1. 你使用需求描述初始化 AutoGenLib  
2. 當你在 `autogenlib` 命名空間下匯入模組或函式時，該函式庫會：  
   - 檢查模組／函式是否已存在  
   - 若不存在，分析執行匯入的程式碼以理解上下文  
   - 將你的描述與上下文發送至 OpenAI 的 API  
   - API 產生相應的程式碼  
   - 程式碼經驗證並執行  
   - 請求的模組／函式即可使用  

## 範例

### 產生 TOTP 產生器


```python
from autogenlib.totp import totp_generator

print(totp_generator("SECRETKEY123"))
```
稍後新增驗證功能


```python
# Later in your application, you need verification:
from autogenlib.totp import verify_totp
result = verify_totp("SECRETKEY123", "123456")
print(f"Verification result: {result}")
```
### 使用情境感知


```python
# Import a function - AutoGenLib will see how your data is structured
from autogenlib.processor import get_highest_score

# Define your data structure
data = [{"user": "Alice", "score": 95}, {"user": "Bob", "score": 82}]

# The function will work with your data structure without you having to specify details
print(get_highest_score(data))  # Will correctly extract the highest score
```
### 建立多個模組


```python
# You can use init function to additionally hint the purpose of your library
from autogenlib import init
init("Cryptographic utility library")

# Generate encryption module
from autogenlib.encryption import encrypt_text, decrypt_text
encrypted = encrypt_text("Secret message", "password123")
decrypted = decrypt_text(encrypted, "password123")
print(decrypted)

# Generate hashing module
from autogenlib.hashing import hash_password, verify_password
hashed = hash_password("my_secure_password")
is_valid = verify_password("my_secure_password", hashed)
print(f"Password valid: {is_valid}")
```
## 配置

### 設定 OpenAI API 金鑰

將您的 OpenAI API 金鑰設為環境變數：


```bash
export OPENAI_API_KEY="your-api-key-here"
# Optional
export OPENAI_API_BASE_URL="https://openrouter.ai/api/v1"  # Use OpenRouter API
export OPENAI_MODEL="openai/gpt-4.1"
```
或者在你的 Python 代碼中（不建議用於生產環境）：


```python
import os
os.environ["OPENAI_API_KEY"] = "your-api-key-here"
```
### 快取行為

預設情況下，AutoGenLib 不會快取生成的程式碼。這表示：

- 每次匯入模組時，LLM 都會生成新的程式碼
- 你會得到更多樣且經常更有趣的結果，因為 LLM 可能產生幻覺
- 相同的匯入在不同執行中可能產生不同的實作

如果你想啟用快取（為了穩定性或減少 API 呼叫）：


```python
from autogenlib import init
init("Library for data processing", enable_caching=True)
```
或者在運行時切換快取：


```python
from autogenlib import init, set_caching
init("Library for data processing")

# Later in your code:
set_caching(True)  # Enable caching
set_caching(False)  # Disable caching
```
當啟用快取時，產生的程式碼會儲存在 `~/.autogenlib_cache`。

## 限制

- 需要網路連線以產生新程式碼
- 依賴 OpenAI API 的可用性
- 產生的程式碼品質取決於描述的清晰度
- 未經審查不適用於生產關鍵程式碼

## 進階用法

### 檢視產生的程式碼

您可以檢視為模組產生的程式碼：


```python
from autogenlib.totp import totp_generator
import inspect
print(inspect.getsource(totp_generator))
```
## AutoGenLib 如何使用 OpenAI API

AutoGenLib 為 OpenAI API 建立包含以下內容的提示：

1. 您提供的描述
2. 正在增強模組中的任何現有程式碼
3. 所有先前生成模組的完整上下文
4. 匯入該模組/函式的程式碼（新功能！）
5. 需要的具體函式或功能

這種全面的上下文有助於大型語言模型產生與您現有程式碼庫一致且完美符合您使用意圖的程式碼。

## 貢獻

不歡迎貢獻！這只是個有趣的概念驗證專案。

## 授權條款

MIT 授權條款

---

*注意：此函式庫用於原型設計與實驗。請務必在生產環境使用前審查自動生成的程式碼。*

*注意：當然，這個函式庫 100% 的程式碼都是透過大型語言模型生成的*



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-14

---