![2](https://github.com/user-attachments/assets/a18257a3-a678-4fd4-bf77-750dab4d99bb)

# Agent

고속의 자급자족 Python AI 에이전트 프레임워크로, OpenAI Python SDK를 활용하여 자연어 명령을 해석하고, 코드를 동적으로 생성 및 실행하며, 런타임 환경을 무마찰로 관리합니다. 자동 의존성 설치, 안전한 환경 구성, 구조화된 로깅, 강력한 Python 도구를 임베딩할 수 있는 미니멀리스트 플러그인 인터페이스 등을 제공하며, 모두 관대한 Apache 2.0 라이선스 하에 배포됩니다.

## ⭐ Star History

<p align="center">
  <a href="https://star-history.com/#machinegpt/agent&Date">
    <img alt="Star History Chart" src="https://api.star-history.com/svg?repos=machinegpt/agent&type=Date&theme=dark" onerror="this.src='https://api.star-history.com/svg?repos=machinegpt/agent&type=Date'" />
  </a>
</p>


## 🔧 환경 설정

### Python 가상 환경
프로젝트 설정 전에 가상 환경을 만드는 것이 권장됩니다. 다음 단계를 따르세요:

가상 환경에 대해 알아보기: [Python Packaging Guide](https://packaging.python.org/en/latest/guides/installing-using-pip-and-virtual-environments/)

가상 환경을 생성 및 활성화:

**Windows:**

```
py -m venv .venv
.venv\Scripts\activate
```

**macOS/Linux:**
```
python3 -m venv .venv
source .venv/bin/activate
```

### 프로젝트 설정
이 프로젝트는 동작을 위해 OpenAI API 키가 필요합니다. 이를 제공하려면, 루트 디렉터리에 아래 내용을 가진 .env 파일을 생성하세요:
```
OPENAI_API_KEY=
```
또는, 제공된 .env.example 파일을 복사한 후 키를 업데이트할 수 있습니다:
```
cp .env.example .env
```

## 🧠 시작하기
에이전트를 시작하려면, 다음을 실행하세요:
```
git clone https://github.com/machinegpt/agent.git
cd agent

python machine.py
```

## ✨ 기여 안내

기여, 제안, 버그 리포트 및 수정 모두 환영합니다!

새로운 기능, 컴포넌트, 확장 등을 제안할 경우 PR을 보내기 전에 반드시 이슈를 열고 먼저 논의해 주세요.

## 💖 이 프로젝트는 기여해주신 모든 분들 덕분에 현재의 모습을 갖추게 되었습니다
<a href="https://github.com/machinegpt/agent/graphs/contributors">
  <img src="https://contrib.rocks/image?repo=machinegpt/agent" />
</a>


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-04

---