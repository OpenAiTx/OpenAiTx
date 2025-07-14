# AutoGenLib

> あなたがこれから必要とする唯一のライブラリ。
>
> 知識をインポートし、コードをエクスポート。

AutoGenLibは、OpenAIのAPIを使用してリアルタイムでコードを自動生成するPythonライブラリです。存在しないモジュールや関数をインポートしようとすると、必要な内容の高レベルな説明に基づいてAutoGenLibがそれを作成します。

## 特徴

- **動的コード生成**：まだ存在しないモジュールや関数をインポート可能
- **コンテキスト認識**：既存コードを理解した上で新しい関数を生成
- **段階的強化**：既存モジュールに新機能をシームレスに追加
- **デフォルトキャッシュなし**：インポートごとに新鮮なコードを生成し、より多様で創造的な結果を実現
- **コードベース全体のコンテキスト**：LLMは以前に生成された全てのモジュールを参照し、一貫性を向上
- **呼び出し元コード解析**：インポートしている実際のコードをLLMが解析し、文脈と要件をより深く理解
- **自動例外処理**：全ての例外をLLMに送信し、エラーの明確な説明と修正を提供

## インストール

```bash
pip install autogenlib
```
またはソースからインストール:


```bash
git clone https://github.com/cofob/autogenlib.git
cd autogenlib
pip install -e .
```
## 要件

- Python 3.12以上
- OpenAI APIキー

## クイックスタート

`OPENAI_API_KEY` 環境変数にOpenAI APIキーを設定してください。


```python
# Import a function that doesn't exist yet - it will be automatically generated
from autogenlib.tokens import generate_token

# Use the generated function
token = generate_token(length=32)
print(token)
```
## 仕組み

1. 必要な内容の説明を使って AutoGenLib を初期化します  
2. `autogenlib` 名前空間の下でモジュールまたは関数をインポートすると、ライブラリは以下を行います  
   - モジュール/関数がすでに存在するかチェックします  
   - 存在しない場合は、インポートを実行しているコードを解析してコンテキストを理解します  
   - 説明とコンテキストを用いて OpenAI の API にリクエストを送信します  
   - API が適切なコードを生成します  
   - コードが検証され、実行されます  
   - 要求されたモジュール/関数が使用可能になります  

## 例

### TOTP ジェネレーターを生成する


```python
from autogenlib.totp import totp_generator

print(totp_generator("SECRETKEY123"))
```
後で検証機能を追加する


```python
# Later in your application, you need verification:
from autogenlib.totp import verify_totp
result = verify_totp("SECRETKEY123", "123456")
print(f"Verification result: {result}")
```
### コンテキスト認識の使用


```python
# Import a function - AutoGenLib will see how your data is structured
from autogenlib.processor import get_highest_score

# Define your data structure
data = [{"user": "Alice", "score": 95}, {"user": "Bob", "score": 82}]

# The function will work with your data structure without you having to specify details
print(get_highest_score(data))  # Will correctly extract the highest score
```
### 複数のモジュールを作成する


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
## 設定

### OpenAI APIキーの設定

OpenAIのAPIキーを環境変数として設定します：


```bash
export OPENAI_API_KEY="your-api-key-here"
# Optional
export OPENAI_API_BASE_URL="https://openrouter.ai/api/v1"  # Use OpenRouter API
export OPENAI_MODEL="openai/gpt-4.1"
```
またはPythonコード内で（本番環境では推奨されません）：


```python
import os
os.environ["OPENAI_API_KEY"] = "your-api-key-here"
```
### キャッシングの動作

デフォルトでは、AutoGenLibは生成されたコードをキャッシュしません。これはつまり：

- モジュールをインポートするたびに、LLMが新しいコードを生成する
- LLMの誤認識によって、より多様でしばしば面白い結果が得られる
- 同じインポートでも実行ごとに異なる実装が生成される可能性がある

キャッシュを有効にしたい場合（安定性のためやAPIコール削減のため）：


```python
from autogenlib import init
init("Library for data processing", enable_caching=True)
```
または実行時にキャッシュを切り替えます:


```python
from autogenlib import init, set_caching
init("Library for data processing")

# Later in your code:
set_caching(True)  # Enable caching
set_caching(False)  # Disable caching
```
キャッシュが有効な場合、生成されたコードは `~/.autogenlib_cache` に保存されます。

## 制限事項

- 新しいコードを生成するにはインターネット接続が必要です
- OpenAI APIの利用可能性に依存します
- 生成されるコードの品質は説明の明確さに依存します
- レビューなしで本番重要コードに使用するのは適していません

## 高度な使用法

### 生成コードの検査

モジュールに対して生成されたコードを検査することができます：


```python
from autogenlib.totp import totp_generator
import inspect
print(inspect.getsource(totp_generator))
```
## AutoGenLibがOpenAI APIをどのように使用するか

AutoGenLibはOpenAI API用のプロンプトを作成します。内容は以下を含みます：

1. あなたが提供した説明
2. 強化されるモジュール内の既存コード
3. これまでに生成されたすべてのモジュールの完全なコンテキスト
4. モジュール/関数をインポートしているコード（新機能！）
5. 必要な特定の関数または機能

この包括的なコンテキストにより、LLMは既存のコードベースと一貫性があり、使用意図に完全に合ったコードを生成できます。

## 貢献について

貢献は歓迎しません！これは単なる楽しいPoCプロジェクトです。

## ライセンス

MITライセンス

---

*注：このライブラリはプロトタイピングと実験用です。自動生成されたコードは本番環境で使用する前に必ず確認してください。*

*注：もちろん、このライブラリのコードの100％はLLMによって生成されています*



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-14

---