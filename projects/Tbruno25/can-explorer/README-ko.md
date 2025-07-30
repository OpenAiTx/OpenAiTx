<h1 align="center">
  <a href="https://github.com/tbruno25/can-explorer">
    <!-- 여기에 로고 경로를 제공해주세요 -->
    <img src="https://github.com/Tbruno25/can-explorer/raw/main/docs/images/logo.png" alt="Logo" width="200" height="200">
  </a>
</h1>

<div align="center">
  can-explorer
  <br />
  <a href="https://github.com/tbruno25/can-explorer/issues/new?assignees=&labels=bug&template=01_BUG_REPORT.md&title=bug%3A+">버그 신고</a>
  ·
  <a href="https://github.com/tbruno25/can-explorer/issues/new?assignees=&labels=enhancement&template=02_FEATURE_REQUEST.md&title=feature%3A+">기능 요청</a>
  ·
  <a href="https://github.com/tbruno25/can-explorer/issues/new?assignees=&labels=question&template=04_SUPPORT_QUESTION.md&title=support%3A+">질문하기</a>
</div>

<div align="center">
<br/>


[![PyPI version](https://img.shields.io/pypi/v/can-explorer?color=mediumseagreen)](https://pypi.org/project/can-explorer/)
[![Python Versions](https://img.shields.io/pypi/pyversions/can-explorer?color=mediumseagreen)](https://pypi.org/project/can-explorer/)
[![Stars](https://img.shields.io/github/stars/tbruno25/can-explorer?color=mediumseagreen)](https://github.com/Tbruno25/can-explorer/stargazers)
</div>

---

## 소개

`can-explorer`는 리버스 엔지니어링에 도움을 주기 위해 설계된 CAN 버스 시각화 도구입니다.

![Demo](https://github.com/Tbruno25/can-explorer/raw/main/docs/images/demo.gif)

### 이것이 어떻게 도움이 되나요?
각 CAN ID에 대한 모든 페이로드를 지속적으로 플로팅함으로써, 특정 동작에 대응하는 추세를 식별하는 것이 훨씬 쉬워질 수 있습니다.

이 방법을 사용하여 어떤 ID가 속도계 데이터를 포함하는지 찾는 작동 예제를 확인하려면 제가 작성한 [이전 글](https://tbruno25.medium.com/car-hacking-faster-reverse-engineering-using-canopy-be1955843d57)을 참조하세요.


### 사용된 기술


[![DearPyGui](https://github.com/Tbruno25/can-explorer/raw/main/docs/images/dearpygui-logo.png)](https://github.com/hoffstadt/DearPyGui)
[![PythonCan](https://github.com/Tbruno25/can-explorer/raw/main/docs/images/pythoncan-logo.png)](https://github.com/hardbyte/python-can)

## 시작하기

### 설치

[pipx](https://pypa.github.io/pipx/)를 권장하지만, `pyproject.toml` 파일을 지원하는 모든 패키지 관리자를 사용할 수 있습니다.

```sh
pipx install can-explorer
``` 

## 사용법

터미널에서 아래 명령어 중 하나를 실행하여 GUI를 시작할 수 있습니다.
```sh 
can-explorer
``` 

```sh 
python3 -m can_explorer
``` 
뷰어를 시작하기 전에, 설정 탭으로 이동하여 인터페이스 어댑터 구성을 입력하여 버스 인스턴스를 생성해야 합니다. 다양한 인터페이스 지원에 관한 자세한 내용은 [python-can 문서](https://python-can.readthedocs.io/en/stable/index.html)를 참조하십시오. 

GUI는 데모 플래그와 함께 실행할 수도 있으며, 이 경우 가상 인터페이스 옵션을 자동으로 선택하고 백그라운드 프로세스에서 시뮬레이션된 CAN 데이터를 스트리밍합니다.


```sh 
can-explorer --demo
``` 
## 지원

다음 위치 중 하나에서 유지 관리자에게 연락하십시오:
- [GitHub 이슈](https://github.com/tbruno25/can-explorer/issues/new?assignees=&labels=question&template=04_SUPPORT_QUESTION.md&title=support%3A+)
- [이 GitHub 프로필](https://github.com/tbruno25)에 나열된 연락처 옵션

감사의 뜻을 전하거나 can-explorer의 활발한 개발을 지원하고 싶다면 프로젝트에 [GitHub 스타](https://github.com/tbruno25/can-explorer)를 추가하는 것을 고려해 보십시오.


## 기여

[기여 가이드라인](https://raw.githubusercontent.com/Tbruno25/can-explorer/main/docs/CONTRIBUTING.md)을 읽어 주십시오.

모든 저자 및 기여자의 전체 목록은 [기여자 페이지](https://github.com/tbruno25/can-explorer/contributors)를 참조하십시오.

## 라이선스

이 프로젝트는 **GNU 일반 공중 사용 허가서 v3**에 따라 라이선스가 부여됩니다.

자세한 내용은 [LICENSE](LICENSE)를 참조하십시오.



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-30

---