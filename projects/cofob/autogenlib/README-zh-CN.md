# AutoGenLib

> 你唯一需要的库。
>
> 导入智慧，导出代码。

AutoGenLib 是一个使用 OpenAI API 实时自动生成代码的 Python 库。当你尝试导入不存在的模块或函数时，AutoGenLib 会根据你需要的高级描述为你创建它。

## 功能

- **动态代码生成**：导入尚不存在的模块和函数  
- **上下文感知**：新函数生成时会考虑已有代码  
- **渐进增强**：无缝为现有模块添加新功能  
- **无默认缓存**：每次导入都会生成新代码，带来更多变化和创意  
- **完整代码库上下文**：LLM 可查看所有先前生成的模块以保证一致性  
- **调用者代码分析**：LLM 分析实际导入模块的代码，更好地理解上下文和需求  
- **自动异常处理**：所有异常都发送给 LLM，提供清晰的错误解释和修复方案。

## 安装

```bash
pip install autogenlib
```
或者从源码安装：


```bash
git clone https://github.com/cofob/autogenlib.git
cd autogenlib
pip install -e .
```
## 要求

- Python 3.12 及以上版本
- OpenAI API 密钥

## 快速开始

在环境变量 `OPENAI_API_KEY` 中设置 OpenAI API 密钥。


```python
# Import a function that doesn't exist yet - it will be automatically generated
from autogenlib.tokens import generate_token

# Use the generated function
token = generate_token(length=32)
print(token)
```
## 工作原理

1. 你用所需功能的描述初始化 AutoGenLib
2. 当你导入 `autogenlib` 命名空间下的模块或函数时，库会：
   - 检查该模块/函数是否已存在
   - 如果不存在，它会分析执行导入的代码以理解上下文
   - 它将你的描述和上下文发送给 OpenAI 的 API 请求
   - API 生成相应的代码
   - 代码经过验证并执行
   - 请求的模块/函数即可使用

## 示例

### 生成 TOTP 生成器


```python
from autogenlib.totp import totp_generator

print(totp_generator("SECRETKEY123"))
```
稍后添加验证功能


```python
# Later in your application, you need verification:
from autogenlib.totp import verify_totp
result = verify_totp("SECRETKEY123", "123456")
print(f"Verification result: {result}")
```
### 使用上下文感知


```python
# Import a function - AutoGenLib will see how your data is structured
from autogenlib.processor import get_highest_score

# Define your data structure
data = [{"user": "Alice", "score": 95}, {"user": "Bob", "score": 82}]

# The function will work with your data structure without you having to specify details
print(get_highest_score(data))  # Will correctly extract the highest score
```
### 创建多个模块


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

### 设置 OpenAI API 密钥

将您的 OpenAI API 密钥设置为环境变量：


```bash
export OPENAI_API_KEY="your-api-key-here"
# Optional
export OPENAI_API_BASE_URL="https://openrouter.ai/api/v1"  # Use OpenRouter API
export OPENAI_MODEL="openai/gpt-4.1"
```
或者在你的 Python 代码中（不推荐用于生产环境）：


```python
import os
os.environ["OPENAI_API_KEY"] = "your-api-key-here"
```
### 缓存行为

默认情况下，AutoGenLib 不缓存生成的代码。这意味着：

- 每次导入模块时，LLM 都会生成新的代码
- 由于 LLM 的幻觉，结果更加多样且常常更有趣
- 同一个导入在不同运行中可能产生不同的实现

如果您想启用缓存（为了保持一致性或减少 API 调用）：


```python
from autogenlib import init
init("Library for data processing", enable_caching=True)
```
或者在运行时切换缓存：


```python
from autogenlib import init, set_caching
init("Library for data processing")

# Later in your code:
set_caching(True)  # Enable caching
set_caching(False)  # Disable caching
```
开启缓存时，生成的代码会存储在 `~/.autogenlib_cache`。

## 限制

- 生成新代码需要互联网连接
- 依赖于 OpenAI API 的可用性
- 生成代码的质量取决于描述的清晰度
- 未经审核不适合用于生产关键代码

## 高级用法

### 查看生成代码

您可以查看为某个模块生成的代码：


```python
from autogenlib.totp import totp_generator
import inspect
print(inspect.getsource(totp_generator))
```
## AutoGenLib 如何使用 OpenAI API

AutoGenLib 为 OpenAI API 创建的提示包含：

1. 您提供的描述
2. 正在增强模块中的任何现有代码
3. 所有先前生成模块的完整上下文
4. 导入该模块/函数的代码（新功能！）
5. 所需的具体函数或功能

这个全面的上下文帮助大型语言模型生成与您现有代码库一致且完全符合您使用意图的代码。

## 贡献

不欢迎贡献！这只是一个有趣的概念验证项目。

## 许可

MIT 许可

---

*注意：此库用于原型设计和实验。在生产环境中使用前，请务必审查自动生成的代码。*

*注意：当然，此库 100% 的代码均由大型语言模型生成*



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-14

---