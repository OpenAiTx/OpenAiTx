<div align="center">

# fbchat-muqit 페이스북 & 메신저 API

![PyPI - Python Version](https://img.shields.io/pypi/pyversions/fbchat-muqit)
![PyPI - Version](https://img.shields.io/pypi/v/fbchat-muqit)
[![License: GPLv3](https://img.shields.io/badge/License-GPLv3-blue.svg)](https://www.gnu.org/licenses/gpl-3.0)

**fbchat-muqit** 비공식 비동기 페이스북 메신저 API로, 페이스북 및 메신저와 상호작용하도록 설계되었습니다. 비공식 API이므로 페이스북에서 차단당해도 당사는 책임지지 않습니다. 더미 페이스북 계정 사용을 권장합니다. 자세한 내용은 [문서](http://fbchat-muqit.rtfd.io/)를 참고하세요.

</div>

> [!Note]
> 버전 `1.1.31`에서 `1.2.0`으로 업데이트되었으며, `1.2.0` 버전은 라이브러리가 완전히 재작성된 리라이팅 버전으로 주요 변경사항이 포함되어 있습니다. API가 완전하게 문서화되었고 사용 예제도 업데이트되었습니다.

> [!WARNING]
> `종단 간(end-to-end)` 암호화로 인해 다른 사용자에게 메시지 전송은 더 이상 지원되지 않습니다. 그룹 채팅, 룸 채팅 및 페이지에는 메시지 전송이 가능합니다. [자세히 보기](https://about.fb.com/news/2024/03/end-to-end-encryption-on-messenger-explained/)
> 해당 사용자의 계정이 수년간 비활성 상태인 경우 `종단 간` 암호화가 적용되지 않으므로 메시지 전송이 가능할 수 있으나, 계정이 다시 활성화되면 암호화가 적용됩니다.

## 🛠️ 설치

pip을 사용하여 fbchat-muqit을 설치할 수 있습니다:

```bash
pip install fbchat-muqit

```
최신 개발 버전의 경우:


```bash
pip install git+https://github.com/togashigreat/fbchat-muqit.git

```
## 📙 문서

API가 문서화되어 있습니다. [문서 읽기](http://fbchat-muqit.rtfd.io/).  
이전 버전 [1.1.31](https://fbchat-muqit.readthedocs.io/en/v1.1.31/) 문서도 이용 가능합니다.

## 🔧 전제 조건

- Python 3.9 이상  
- 페이스북 계정 (사용하지 않는 오래된 계정을 사용하는 것이 더 안전합니다)  
- 페이스북 계정 쿠키 🍪  

## 📖 사용 예시

페이스북에 로그인하려면 페이스북 계정 쿠키가 필요합니다. 이메일과 비밀번호를 통한 로그인이 더 이상 지원되지 않기 때문입니다.

페이스북 계정 쿠키를 얻으려면, 먼저 페이스북 계정에 로그인한 후 브라우저에 [C3C Chrome 확장 프로그램](https://github.com/c3cbot/c3c-ufc-utility)을 추가하세요. 브라우저 탭에서 페이스북 계정을 열고 이 확장 프로그램을 사용해 계정 쿠키를 가져옵니다. 쿠키를 복사하여 json 파일에 저장하세요. 이 쿠키를 사용하여 페이스북 서버와 상호작용할 것입니다. 이 계정을 `Client` 계정이라고 부릅니다.

기본적인 사용 예시입니다.


```python
from fbchat_muqit import Client, Message, EventType

client = Client(cookies_file_path="cookies.json")

@client.event
async def on_message(message: Message):
    # To avoid spam check if sender_id is client's id or not
    if message.sender_id != client.uid:
        # echo the message
        await client.send_message(message.text, message.thread_id)

client.run()

```
코드를 `test.py` 파일에 저장하고 이제 코드를 실행합니다.


```bash
python3 test.py
```
만약 성공적으로 로그인되면 다른 페이스북 계정을 사용하여 메신저 그룹을 만들고 두 계정 모두를 그룹에 추가하세요. 이제 그룹에 메시지를 보내면 fbchat_muqit 클라이언트 계정이 모든 수신 메시지와 이벤트를 수신합니다. 모든 것이 제대로 작동하면 다른 계정에서 보낸 메시지에 이모지로 답장하고 반응해야 합니다.

### 📄 라이선스

이 프로젝트는 이중 라이선스 모델로 배포됩니다:

- **BSD-3-Clause 라이선스**: 코드 일부는 원본 [fbchat](https://github.com/fbchat-dev/fbchat) 라이브러리에서 재사용 및 수정되었으며 BSD-3-Clause 라이선스 하에 있습니다.
  자세한 내용은 [LICENSE-BSD](https://raw.githubusercontent.com/togashigreat/fbchat-muqit/main/./LICENSE-BSD.md)를 참조하세요.

- **GPL v3 라이선스**: Muhammad MuQiT/togashigreat의 새로운 기여 및 수정 사항은 GPL v3.0 라이선스 하에 있습니다.
  자세한 내용은 [LICENSE](https://raw.githubusercontent.com/togashigreat/fbchat-muqit/main/./LICENSE.md)를 참조하세요.

### ✉️ 연락처

- [페이스북](https://facebook.com/muqit.dev)



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-06-22

---