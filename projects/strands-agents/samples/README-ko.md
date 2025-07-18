<div align="center">
  <div>
    <a href="https://strandsagents.com">
      <img src="https://strandsagents.com/latest/assets/logo-auto.svg" alt="Strands Agents" width="55px" height="105px">
    </a>
  </div>

  <h1>
    Strands Agents 샘플
  </h1>

  <h2>
    몇 줄의 코드로 AI 에이전트를 구축하는 모델 기반 접근법.
  </h2>

  <div align="center">
    <a href="https://github.com/strands-agents/samples/graphs/commit-activity"><img alt="GitHub commit activity" src="https://img.shields.io/github/commit-activity/m/strands-agents/samples"/></a>
    <a href="https://github.com/strands-agents/samples/issues"><img alt="GitHub open issues" src="https://img.shields.io/github/issues/strands-agents/samples"/></a>
    <a href="https://github.com/strands-agents/samples/pulls"><img alt="GitHub open pull requests" src="https://img.shields.io/github/issues-pr/strands-agents/samples"/></a>
    <a href="https://github.com/strands-agents/samples/blob/main/LICENSE"><img alt="License" src="https://img.shields.io/github/license/strands-agents/samples"/></a>
  </div>
  
  <p>
    <a href="https://strandsagents.com/">문서</a>
    ◆ <a href="https://github.com/strands-agents/samples">샘플</a>
    ◆ <a href="https://github.com/strands-agents/sdk-python">Python SDK</a>
    ◆ <a href="https://github.com/strands-agents/tools">도구</a>
    ◆ <a href="https://github.com/strands-agents/agent-builder">에이전트 빌더</a>
    ◆ <a href="https://github.com/strands-agents/mcp-server">MCP 서버</a>
  </p>
</div>

Strands Agents 샘플 저장소에 오신 것을 환영합니다!

<a href="https://strandsagents.com">Strands Agents</a>를 시작하는 데 도움이 되는 사용하기 쉬운 예제를 살펴보세요.

이 저장소의 예제는 **시연 및 교육 목적으로만** 제공됩니다. 개념과 기법을 보여주지만 **직접적인 프로덕션 사용을 위한 것은 아닙니다**. 프로덕션 환경에서 사용하기 전에 항상 적절한 **보안**과 **테스트** 절차를 적용하세요.

## 📚 목차

- [📚 목차](#-목차)
- [🏁 시작하기](#-시작하기)
  - [1단계: 필수 패키지 설치](#1단계-필수-패키지-설치)
  - [2단계: 모델 제공자 설정](#2단계-모델-제공자-설정)
  - [3단계: 첫 번째 Strands 에이전트 구축](#3단계-첫-번째-strands-에이전트-구축)
  - [4단계: SDK 시작하기](#4단계-sdk-시작하기)
  - [5단계: 더 많은 샘플 탐색](#5단계-더-많은-샘플-탐색)

## 🏁 시작하기

### 1단계: 필수 패키지 설치

```bash
pip install strands-agents
pip install strands-agents-tools
```
### 2단계: 모델 공급자 설정

[여기](https://strandsagents.com/latest/user-guide/quickstart/#model-providers)의 지침을 따라 모델 공급자 및 모델 접근 권한을 구성하세요.

### 3단계: 첫 번째 Strands 에이전트 만들기


```python
from strands import Agent, tool
from strands_tools import calculator, current_time, python_repl

@tool
def letter_counter(word: str, letter: str) -> int:
    """
    Count the occurrences of a specific letter in a word.
    """
    if not isinstance(word, str) or not isinstance(letter, str):
        return 0
    if len(letter) != 1:
        raise ValueError("The 'letter' parameter must be a single character")
    return word.lower().count(letter.lower())

agent = Agent(tools=[calculator, current_time, python_repl, letter_counter])

message = """
I have 4 requests:

1. What is the time right now?
2. Calculate 3111696 / 74088
3. Tell me how many letter R's are in the word "strawberry" 🍓
4. Output a script that does what we just spoke about!
   Use your python tools to confirm that the script works before outputting it
"""

agent(message)
```
### Step 4: SDK 시작하기

[01-tutorials](./01-tutorials/) 디렉토리에서 시작하세요.  
[첫 번째 에이전트](./01-tutorials/01-fundamentals/01-first-agent/)를 만들고 핵심 기능을 다루는 노트북 기반 예제를 탐색해보세요.

### Step 5: 더 많은 샘플 탐색

영감을 찾고 계신가요?  
실제 사용 사례에 대한 더 많은 예제는 [02-samples](./02-samples/) 폴더를 확인하세요.

## 기여하기 ❤️

기여를 환영합니다! 자세한 내용은 [기여 가이드](https://raw.githubusercontent.com/strands-agents/samples/main/CONTRIBUTING.md)를 참조하세요:  
- 버그 및 기능 보고  
- 개발 환경 설정  
- 풀 리퀘스트를 통한 기여  
- 행동 강령  
- 보안 문제 보고  

## 라이선스

이 프로젝트는 Apache License 2.0 하에 라이선스가 부여되었습니다 - 자세한 내용은 [LICENSE](LICENSE) 파일을 참조하세요.

## 보안

자세한 내용은 [CONTRIBUTING](https://raw.githubusercontent.com/strands-agents/samples/main/CONTRIBUTING.md#security-issue-notifications)을 참조하세요.



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-18

---