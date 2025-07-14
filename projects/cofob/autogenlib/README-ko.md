# AutoGenLib

> 당신이 필요로 할 유일한 라이브러리.
>
> 지혜를 가져오고, 코드를 내보내세요.

AutoGenLib는 OpenAI의 API를 사용하여 코드를 즉석에서 자동으로 생성하는 파이썬 라이브러리입니다. 존재하지 않는 모듈이나 함수를 가져오려고 할 때, AutoGenLib는 필요한 내용에 대한 높은 수준의 설명을 바탕으로 그것을 생성해 줍니다.

## 기능

- **동적 코드 생성**: 아직 존재하지 않는 모듈과 함수를 가져올 수 있습니다
- **상황 인식**: 기존 코드를 인지하여 새로운 함수를 생성합니다
- **점진적 향상**: 기존 모듈에 새로운 기능을 원활하게 추가합니다
- **기본 캐싱 없음**: 각 임포트마다 신선한 코드를 생성하여 다양하고 창의적인 결과를 도출합니다
- **전체 코드베이스 컨텍스트**: LLM이 이전에 생성된 모든 모듈을 볼 수 있어 더 나은 일관성을 제공합니다
- **호출자 코드 분석**: LLM이 모듈을 가져오는 실제 코드를 분석하여 상황과 요구사항을 더 잘 이해합니다
- **자동 예외 처리**: 모든 예외가 LLM으로 전송되어 오류에 대한 명확한 설명과 해결책을 제공합니다.

## 설치

```bash
pip install autogenlib
```
또는 소스에서 설치하세요:


```bash
git clone https://github.com/cofob/autogenlib.git
cd autogenlib
pip install -e .
```
## 요구 사항

- Python 3.12+
- OpenAI API 키

## 빠른 시작

`OPENAI_API_KEY` 환경 변수에 OpenAI API 키를 설정하세요.


```python
# Import a function that doesn't exist yet - it will be automatically generated
from autogenlib.tokens import generate_token

# Use the generated function
token = generate_token(length=32)
print(token)
```
## 작동 방식

1. 필요한 내용에 대한 설명으로 AutoGenLib를 초기화합니다  
2. `autogenlib` 네임스페이스 아래에서 모듈이나 함수를 임포트하면, 라이브러리는:  
   - 해당 모듈/함수가 이미 존재하는지 확인합니다  
   - 존재하지 않으면, 임포트를 수행하는 코드를 분석하여 문맥을 이해합니다  
   - 설명과 문맥을 담아 OpenAI의 API에 요청을 보냅니다  
   - API가 적절한 코드를 생성합니다  
   - 코드를 검증하고 실행합니다  
   - 요청한 모듈/함수가 사용 가능해집니다  

## 예제

### TOTP 생성기 생성하기


```python
from autogenlib.totp import totp_generator

print(totp_generator("SECRETKEY123"))
```
나중에 검증 함수 추가하기


```python
# Later in your application, you need verification:
from autogenlib.totp import verify_totp
result = verify_totp("SECRETKEY123", "123456")
print(f"Verification result: {result}")
```
### 컨텍스트 인식 사용하기


```python
# Import a function - AutoGenLib will see how your data is structured
from autogenlib.processor import get_highest_score

# Define your data structure
data = [{"user": "Alice", "score": 95}, {"user": "Bob", "score": 82}]

# The function will work with your data structure without you having to specify details
print(get_highest_score(data))  # Will correctly extract the highest score
```
### 여러 모듈 생성하기


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
## 구성

### OpenAI API 키 설정

OpenAI API 키를 환경 변수로 설정하세요:


```bash
export OPENAI_API_KEY="your-api-key-here"
# Optional
export OPENAI_API_BASE_URL="https://openrouter.ai/api/v1"  # Use OpenRouter API
export OPENAI_MODEL="openai/gpt-4.1"
```
또는 Python 코드에서 (프로덕션 환경에서는 권장되지 않음):


```python
import os
os.environ["OPENAI_API_KEY"] = "your-api-key-here"
```
### 캐싱 동작

기본적으로 AutoGenLib는 생성된 코드를 캐싱하지 않습니다. 이것은 다음을 의미합니다:

- 모듈을 불러올 때마다 LLM이 새 코드를 생성합니다
- LLM의 환각으로 인해 더 다양하고 종종 재미있는 결과를 얻습니다
- 동일한 불러오기라도 실행마다 다른 구현을 생성할 수 있습니다

캐싱을 활성화하려면 (일관성을 위해 또는 API 호출을 줄이기 위해):


```python
from autogenlib import init
init("Library for data processing", enable_caching=True)
```
또는 런타임에 캐싱을 전환하십시오:


```python
from autogenlib import init, set_caching
init("Library for data processing")

# Later in your code:
set_caching(True)  # Enable caching
set_caching(False)  # Disable caching
```
캐싱이 활성화되면, 생성된 코드는 `~/.autogenlib_cache`에 저장됩니다.

## 제한 사항

- 새로운 코드를 생성하려면 인터넷 연결이 필요합니다
- OpenAI API 사용 가능 여부에 따라 달라집니다
- 생성된 코드 품질은 설명의 명확성에 의존합니다
- 검토 없이 프로덕션 중요 코드에는 적합하지 않습니다

## 고급 사용법

### 생성된 코드 검사

모듈에 대해 생성된 코드를 검사할 수 있습니다:


```python
from autogenlib.totp import totp_generator
import inspect
print(inspect.getsource(totp_generator))
```
## AutoGenLib가 OpenAI API를 사용하는 방법

AutoGenLib는 OpenAI API를 위한 프롬프트를 생성하는데, 여기에는 다음이 포함됩니다:

1. 사용자가 제공한 설명
2. 개선 중인 모듈 내 기존 코드
3. 이전에 생성된 모든 모듈의 전체 컨텍스트
4. 모듈/함수를 임포트하는 코드 (새 기능!)
5. 필요한 특정 함수 또는 기능

이 포괄적인 컨텍스트는 LLM이 기존 코드베이스와 일치하고 사용 의도에 완벽히 맞는 코드를 생성하는 데 도움을 줍니다.

## 기여

기여는 환영하지 않습니다! 이 프로젝트는 단지 재미있는 PoC 프로젝트입니다.

## 라이선스

MIT 라이선스

---

*참고: 이 라이브러리는 프로토타이핑과 실험을 목적으로 합니다. 자동 생성된 코드를 프로덕션 환경에서 사용하기 전에 항상 검토하세요.*

*참고: 물론 이 라이브러리의 코드 100%는 LLM을 통해 생성되었습니다*



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-14

---