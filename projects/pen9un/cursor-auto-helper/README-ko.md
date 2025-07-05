<h1 align="center">Cursor Auto Helper&nbsp;&nbsp;사용을 환영합니다 👋</h1>
<p>
  <img alt="Version" src="https://img.shields.io/badge/version-2.3.0-blue.svg?cacheSeconds=2592000" />
  <img alt="License: MIT" src="https://img.shields.io/badge/License-MIT-yellow.svg" />
  <img alt="Cursor Version" src="https://img.shields.io/badge/Cursor-0.48.x%20%E8%87%B3%201.0.0-blue.svg" />
</p>

> Cursor 자동 계속 도구, Cursor 자동 재시도, Cursor 자동 확인, Cursor 사용량 통계, Cursor 향상 도구, Cursor 보조 도구, Cursor 자동화 도구, Cursor 테마 설정, Cursor Auto Continue Tool, Cursor Auto Retry Tool, Cursor Auto Confirm Tool, Cursor Usage Statistics Tool, Cursor Efficiency Tool, Cursor Automation Tool, Cursor Theme Settings, Cursor after 25 tool calls, Cursor Tool Call Limit🔧🤖🚀
> 

## 🏠 [홈페이지](https://github.com/pen9un/cursor-auto-helper)

Cursor Auto Helper는 Cursor IDE를 위해 특별히 제작된 자동화 향상 도구로, 실시간 사용량 표시, 25회 대화 제한 자동 처리, 네트워크 연결 실패, 확인 알림 등 다양한 상황을 자동으로 처리해 개발 경험을 더욱 원활하게 만들어줍니다.

**동영상 시연:** [Cursor Auto Helper 시연 영상](https://www.bilibili.com/video/BV1cajKzCEzv/)

프롬프트 품질이 높고, 프로젝트 요구 사항이 잘 기획되어 있다면, 이 프로그램은 Cursor가 별도의 인위적 개입 없이 프로젝트를 자동으로 완료할 수 있게 해줍니다.

> 🔒 **버전 호환:** 현재 Cursor 0.49.6, Cursor 1.0.0 버전에서 개발 및 테스트를 완료했으며, 이론적으로 Cursor 0.48.x - 1.0.0 버전과 호환됩니다.

<img src="https://raw.githubusercontent.com/pen9un/cursor-auto-helper/master/./resource/image/cursor-auto-helper.png" alt="cursor-auto-helper" />

## 📖업데이트 로그

- 2025-06-01 v2.3 버전 출시, Cursor 테마 설정 기능 추가, 코드 주입 안정성 최적화, 사용량 표시를 공식 포맷과 일치하도록 수정
- 2025-05-21 v2.1 버전 출시, 아키텍처 리팩토링, 다중 플랫폼 지원, 실시간 사용량 표시 기능 등 추가
- 2025-04-25 v1.0 버전 완성, 25회 대화 제한, 네트워크 연결 실패, 확인 알림 등 자동 처리
- 2025-04-20 프로젝트 시작

## 🌟 Cursor Auto Helper 베스트 프랙티스

참고: 아래 문서는 Cursor 등 AI의 보조로 생성할 수 있으나, 반드시 사람이 검증 및 조정해야 합니다.

**STEP 1:** 상세한 프로젝트 시스템 요구사항 설계 (요구사항이 명확할수록 프로젝트 품질이 높아집니다), 고품질 개발 프롬프트 **SYSTEM.md** 작성

**STEP 2:** **SYSTEM.md**를 기반으로 고품질 시스템 개발 설계안 문서 **DESIGN.md** 작성

**STEP 3:** **SYSTEM.md**와 **DESIGN.md**를 기반으로 고품질 개발 계획 문서 **TODOLIST.md** 작성

**STEP 4:** **Cursor Auto Helper**를 사용해 **SYSTEM.md**, **DESIGN.md**, **TODOLIST.md**를 지정하고, 자동 계속 피드백 프롬프트를 사용해 Cursor가 개발 계획에 따라 자동으로 프로젝트를 완료할 때까지 진행

**Cursor Auto Helper 자동 계속 피드백 프롬프트:**

```
@SYSTEM.md @DESIGN.md @TODOLIST.md 반드시 TODOLIST 개발 계획에 따라 후속 기능을 개발하고, TODOLIST 개발 계획을 실시간으로 업데이트 및 기록하세요. 각 작업이 완료될 때마다 "계속 진행할까요?"라고 물어보고, 프로젝트가 완료되면 "프로젝트가 모두 개발 완료되었습니다"라고 반환하세요.
```

<img src="https://raw.githubusercontent.com/pen9un/cursor-auto-helper/master/./resource/image/guide.png" alt="guide" />

## 🚀 사용법 안내

Star로 응원해 주세요. 문제가 있으면 [Issues](https://github.com/pen9un/cursor-auto-helper/issues)에 제보해 주세요.

### 📝 설정 파일 안내

설정 파일 `config.ini`는 **자동화 동작을 사용자 정의**하기 위한 용도로(필요에 따라 설정 및 테스트 가능), 다음 항목들을 지원합니다.

#### 기본 설정
```ini
[common]
log_enable = true     # 로그 활성화 여부, 로그 기록을 원하지 않으면 false로 변경

[cursor]
path = C:\Path\To\Cursor.exe  # Cursor IDE 설치 경로, 프로그램이 자동으로 Cursor 경로를 탐색하며, 찾지 못할 경우 안내가 표시되니 이 항목만 수정하면 됩니다
```

#### 자동 동작 설정
각 자동 동작은 `action이름.`을 접두어로 하며, 다음 필드를 지원합니다:

- `type`: 동작 유형
  - `click`: 버튼 클릭
  - `input_and_submit`: 입력 및 제출

- `text` / `text_list`: 매칭할 텍스트 내용
  - `text`: 단일 문자열
  - `text_list`: |로 구분된 여러 문자열, 페이지 내용에 하나라도 포함되면 트리거

- `button_selector`: 클릭할 버튼의 CSS 셀렉터(`click` 유형만 필요)
- `button_text`: 버튼 텍스트(선택 사항, 버튼을 더 명확히 지정)
- `input_box_selector`: 입력창의 CSS 셀렉터(`input_and_submit` 유형 필요)
- `input_content`: 자동 입력할 내용
- `submit_btn_selector`: 제출 버튼의 CSS 셀렉터
- `delay`: 동작 실행 전 대기(ms), 페이지 렌더링 대기용

##### 설정 예시
```ini
[auto_actions]
# 연결 실패 시 자동 재시도
action_retry.type = "click"
action_retry.text = "Connection failed. If the problem persists, please check your internet connection or VPN"
action_retry.button_selector = "div.anysphere-secondary-button"
action_retry.button_text = "Try again"
action_retry.delay = 3000

# after 25 tool calls
action_continue.type = "input_and_submit"
action_continue.text_list = "agent after 25 tool calls"
action_continue.input_box_selector = ".full-input-box.undefined"
action_continue.input_content = "계속 진행해 주세요"
action_continue.submit_btn_selector = ".codicon-arrow-up-two"
```
action_continue.delay = 1000

# 자동 확인 계속
action_need_continue.type = "input_and_submit"
action_need_continue.text_list = "是否需要|是否继续|需要我|请告诉我"
action_need_continue.input_box_selector = ".full-input-box.undefined"
action_need_continue.input_content = "请继续后续开发，并实时记录更新开发进度"
action_need_continue.submit_btn_selector = ".codicon-arrow-up-two"
action_need_continue.delay = 1000
```

> **주의:**
> 1. 각 action의 이름(예: `action_retry`, `action_continue`)은 자유롭게 지정할 수 있으나, 동일 action의 모든 필드 접두사는 일치해야 합니다.
> 2. CSS 선택자는 브라우저 개발자 도구로 위치를 정확히 지정하는 것이 좋습니다.
> 3. 설정 파일을 수정한 후에는 프로그램을 재시작해야 적용됩니다.

## 🎯 적용 사례

### 💼 장시간 대화 개발
- 25회 대화 제한을 자동 처리, 연속 장시간 대화 개발 지원, 대화 플로우 자동 진행, 개발 효율 향상.

### 👥 네트워크 불안정
- 네트워크 이상 자동 감지, 지능형 재시도, 대화 자동 복구, 개발 연속성 보장.

### 🏢 확인 시나리오
- 확인 안내 상황 지능형 식별, 확인 안내 자동 처리, 수작업 개입 감소.

### 📚 사용량 모니터링
- 대화 횟수 실시간 통계, Cursor 사용량 모니터링, 데이터 기록, 사용 효율 최적화.

터미널 사용량 표시:

<img src="https://raw.githubusercontent.com/pen9un/cursor-auto-helper/master/./resource/image/cursor-auto-helper-1.png" alt="cursor-auto-helper-1" />

Cursor IDE 사용량 표시:

<img src="https://raw.githubusercontent.com/pen9un/cursor-auto-helper/master/./resource/image/cursor-auto-helper-logs.png" alt="cursor-auto-helper-logs" />

## 🌟기능 설명

### 🤖자동 장시간 대화 이어가기
- Cursor 25회 대화 제한 자동 처리, 다중 연속 대화 지원.

### 🎨 자동 연결 재시도
- 네트워크 연결 실패 자동 감지, 지능형 재시도, 연결 상태 실시간 모니터링.

### 📱 자동 확인 안내
- 다양한 확인 안내 상황 지능형 식별, 확인 팝업 자동 처리.
- 확인 내용 및 응답 사용자 정의 지원, 수작업 개입 감소.
- 유연한 규칙 설정, 다양한 개발 플로우에 적합.

### 🛍️ 사용량 통계
- 대화 횟수 및 사용량 실시간 통계, 데이터 자동 기록.
- 사용량 데이터 시각화, 분석 및 최적화 용이.
- 터미널 컬러 로그 표시, IDE 사용량 패널 지원, 사용성 향상.

### 💡 로그 시스템
- 다단계 로그(DEBUG/INFO/SUCCESS/WARNING/ERROR/CRITICAL), 터미널 컬러 출력.
- 로그 파일 날짜별 자동 생성, 파일 기록 및 드래그 패널 지원.
- 실시간 패널로 개발자 모니터링 및 추적 용이.

### 🔒 버전 호환 및 성능 최적화
- Cursor 0.49.6 기반 개발, 핵심 기능 완전 테스트.
- 특정 버전 최적화, Cursor 버전 업데이트 지속 추적.
- 높은 안정성, 뛰어난 호환성, 프로덕션 환경 적합.

## 🔮효과 시연

### 🤖 자동 대화 이어가기

<img src="https://raw.githubusercontent.com/pen9un/cursor-auto-helper/master/./resource/image/auto-continue.png" alt="auto-continue" />

### 🚀 Cursor 자동 완성 프로그램 시연

프로젝트 요구부터 완성까지, 전 과정 무인 자동화:

<img src="https://raw.githubusercontent.com/pen9un/cursor-auto-helper/master/./resource/image/auto-complete.png" alt="auto-complete" />

## 🤝저자

👤 **pen9un**

* Website: https://github.com/pen9un/
* Github: [@pen9un](https://github.com/pen9un)

## ❤️지원

이 프로젝트가 유용하다면 무료로 작은 ⭐️⭐️ 하나 눌러주세요.

## ✨Star History

[![Star History Chart](https://api.star-history.com/svg?repos=pen9un/cursor-auto-helper&type=Date)](https://star-history.com/#pen9un/cursor-auto-helper&Date)

## 💹 방문자 통계

![Visitor Count](https://profile-counter.glitch.me/pen9un/count.svg) 


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-05

---