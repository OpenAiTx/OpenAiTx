# DIY 스마트 홈 가족 달력 (스카이라이트 클론)

![Sklylight calendar](https://raw.githubusercontent.com/mohesles/my-skylight-calendar/main/assets/main_view.jpeg)
![DIY Skylight](https://raw.githubusercontent.com/mohesles/my-skylight-calendar/main/assets/sky2.png)

## 📖 소개

최근에 아내가 스마트 홈 달력(스카이라이트, 코지라, 하스) 광고에 시달리며 300달러 이상을 쓰려고 했습니다. 허락하기 전에 제가 직접 조사할 기회를 달라고 했습니다.

대부분 비슷한 기능을 제공하지만 가격 차이가 크다는 것을 알게 되었습니다. 가장 중요한 점은 **Home Assistant**에서 구현할 수 없는 뛰어난 기능이 전혀 보이지 않았다는 것입니다.

**목표:** 아내가 승인하는(WAF, Wife Acceptance Factor), 주방 위에 두기 좋은 터치스크린 달력으로 월 사용료 없이 스마트 홈과 깊게 통합되는 것.

## 💡 왜 DIY인가?

Home Assistant로 DIY를 선택한 이유는 스카이라이트나 하스 디스플레이를 구매하는 것보다 여러 가지 이점이 있었기 때문입니다:

* **월 사용료 없음:** "프리미엄" 기능을 위한 구독을 피할 수 있습니다.
* **완벽한 통합:** 조명, 집안일(Grocy), 존재 센서와 연동됩니다.
* **오래된 하드웨어 활용:** 미니 PC와 일반 모니터를 재활용했습니다.
* **개인정보 보호:** 공급업체에 종속되지 않고 회사 폐쇄 위험이 없습니다.

## 🛠 하드웨어 선택

현재는 HD(1920x1080) 화면에서 대시보드를 보여주도록 제작되었습니다.

제 경우에는 스카이라이트처럼 보이고 터치스크린이며, 주방 위에 두기 편하고 여러 장소로 옮길 수 있어야 했습니다. 그래서 아래에 설명된 하드웨어를 선택했습니다.
하지만 여러분의 경우는 다를 수 있으므로 태블릿 등 다른 장치에 표시하려면 적절히 조정해야 합니다.

처음 사용한 하드웨어는 위 조건에 맞추고 웹캠, 스피커, 마이크를 이용해 기능을 확장할 수 있길 바라는 마음에서 골랐습니다. 지금 생각해보면 아직 그 추가 하드웨어 아이디어를 구현할 시간이 없었기에 아마 다르게 만들었을 것입니다.

* **모니터:** [HP Engage 15인치 터치스크린](https://computers.woot.com/offers/hp-engage-16t-fhd-monitor). 일반 휴대용 모니터 대신 내장 **스피커, 웹캠, 마이크**가 포함되어 있어 향후 음성 제어나 화상 통화에 유리합니다.
* **컴퓨터:** 윈도우/리눅스 키오스크 모드로 실행되는 오래된 미니 PC(NUC/Tiny PC) 또는 라즈베리 파이 4.~~

## ✨ 기능

* **가족 전체 및 개별 보기:** 특정 가족 구성원의 달력을 켜고 끌 수 있습니다.
* **양방향 동기화:** 화면이나 휴대폰(구글 캘린더)에서 이벤트를 편집할 수 있습니다.
* **"이벤트 추가" 팝업:** 화면에서 특정 달력에 직접 이벤트를 추가할 수 있는 맞춤 UI입니다.

* **날씨 및 날짜:** 아름답고 한눈에 보기 쉬운 헤더.
* **반응형:** 화면 너비(모바일 대 데스크톱)에 따라 자동으로 일 수를 조정합니다.

---

## ⚙️ 설치 가이드

*참고: 이 설정은 필요한 모든 헬퍼, 스크립트 및 변수를 자동으로 생성하는 **YAML 패키지**를 사용합니다. 수동으로 생성할 필요가 없습니다.*

### 1. 사전 준비물 (HACS)

[HACS](https://hacs.xyz/)가 설치되어 있어야 합니다. 다음 **프론트엔드** 통합을 설치하세요:

* `week-planner-card`
* `bubble-card`
* `config-template-card`
* `card-mod`
* `better-moment-card`
* `weather-card`
* `browser_mod` (팝업 작동에 필요)
* `layout-card` (섹션 뷰에 필요)
* `button-card` (이벤트 추가 팝업에 필요)

### 2. 백엔드 (두뇌 역할)

1. Home Assistant의 `configuration.yaml` 파일을 엽니다.
2. 패키지를 활성화하려면 `homeassistant:` 아래에 다음 줄이 추가되어 있는지 확인하세요:

   ```yaml
   homeassistant:
     packages: !include_dir_named packages
   ```
3. HA 구성 디렉토리에 `packages`라는 폴더를 만드세요(없는 경우).
4. 이 저장소에서 [packages/family_calendar.yaml](https://raw.githubusercontent.com/mohesles/my-skylight-calendar/main/packages/family_calendar.yaml)를 다운로드하세요.
5. 파일을 `packages/` 폴더 안에 넣으세요.
6. **Home Assistant를 재시작하세요**.

### 3. 캘린더들

**Google 캘린더** 또는 **로컬 캘린더**를 사용할 수 있습니다.

#### 옵션 A: 로컬 캘린더 (가장 쉬움)

참고: 저는 Google 캘린더만 사용하기 때문에 테스트되지 않았습니다.

1. **설정 > 기기 및 서비스**로 이동하세요.
2. **로컬 캘린더** 통합을 추가하세요.
3. 정확히 `Alice`, `Bob`, `Charlie`, `Daisy`, `Family`라는 이름의 캘린더를 만드세요.
    * *이 이름들을 사용하면, 코드가 바로 작동합니다!*

#### 옵션 B: Google 캘린더

1. `packages/family_calendar.yaml`을 여세요.
2. `add_google_calendar_event` 스크립트로 스크롤하세요.
3. `calendar_map`을 실제 Google 엔티티에 맞게 업데이트하세요:


    ```yaml
    calendar_map:
      "Alice": "calendar.alice_gmail_com"
      "Bob": "calendar.bob_work_account"
    ```
#### 휴일 설정

Home Assistant 업데이트 이후로 휴일은 이제 UI를 통해 추가됩니다:

1. **설정 > 장치 및 서비스 > 통합 추가 > 휴일**로 이동합니다.
2. 국가를 선택합니다.
3. 엔티티 ID(예: `calendar.holidays`)를 확인합니다. 기본값과 다르면 대시보드 YAML에서 업데이트하세요.

### 4. 대시보드 (모양)

1. 새 대시보드 뷰를 만듭니다 (뷰 유형을 **섹션**으로 설정).
2. [dashboard.yaml](https://raw.githubusercontent.com/mohesles/my-skylight-calendar/main/dashboard.yaml)에서 코드를 복사합니다.
3. **사용자 정의:**
   * **검색 및 바꾸기:** `person.alice`를 실제 가족 구성원 엔티티로 교체하세요.
   * **날씨:** `weather.home`을 본인의 날씨 제공자로 교체하세요.
   * **배경:** yaml 하단의 이미지 URL을 업데이트하세요.

### 5단계: 테마 (선택 사항)

특정 폰트 스타일(Ovo)을 적용하려면:

1. `configuration.yaml`의 `frontend:` 아래에 다음 줄이 있는지 확인하세요.


   ```yaml
   frontend:
     themes: !include_dir_merge_named themes
   ```
2. 구성 디렉터리에 `themes`라는 폴더를 만드세요.  
3. [themes/skylight.yaml](https://raw.githubusercontent.com/mohesles/my-skylight-calendar/main/themes/skylight.yaml)을 다운로드하여 해당 폴더에 넣으세요.  
4. Home Assistant를 재시작하세요.  
5. 프로필(왼쪽 하단 사용자 아이콘)로 가서 **Theme**을 `Skylight`로 변경하세요.  
참고: 이 테마는 완전하지 않으니 이 점을 유의하세요.  

---

## 📐 작동 원리 (내부 동작)

### 필터 로직

`week-planner-card`는 특정 캘린더를 실시간으로 숨기는 기능을 기본적으로 지원하지 않습니다. 이를 해결하기 위해 저는 정규식 필터 역할을 하는 **Input Texts**를 사용했습니다.  

* 사람 버튼을 클릭하면 필터가 `.*` (모두 표시)와 `^$` (아무것도 표시 안 함) 사이를 토글합니다.  
* `config-template-card`가 이 변수들을 캘린더 카드에 동적으로 주입합니다.  

### 이벤트 생성 스크립트

"이벤트 추가" 팝업은 여러 사람과 이벤트 유형(종일 vs 시간 지정)을 처리하는 단일 스크립트를 사용합니다.


```yaml
# Simplified Logic Example
target_calendar: "{{ calendar_map.get(states('input_select.calendar_select')) }}"

choose:
  - conditions: "All Day Event is ON"
    action: calendar.create_event (start_date, end_date)
  - conditions: "All Day Event is OFF"
    action: calendar.create_event (start_date_time, end_date_time)
```
## 노트

제 원래 게시물은 이를 수행하는 방법에 대한 개요를 제공하고 사람들이 자신의 특정 시나리오에 맞게 코드를 조정할 수 있도록 하기 위한 것이었습니다.

특히 모든 디스플레이와 필요가 다르기 때문에 이렇게 했습니다. 모든 잠재적인 디스플레이 크기, 대시보드 등을 위해 개발할 수는 없습니다. 그래서 언급한 디스플레이 또는 (1920x1080)에서 작동하도록 만들어졌지만 다른 디스플레이에 맞게 편집 가능해야 합니다.

디스플레이에 대해 말하자면, 원래 제가 제안한 것은 당시 Woot에서 세일 중이었고 터치스크린 디스플레이를 얻는 매우 경제적인 방법이었기 때문입니다. 지금은 그렇지 않을 수 있으니, 자신에게 맞는 디스플레이를 사용하세요. 태블릿, 터치스크린, 휴대폰, 무엇이든 상관없습니다. 편집해야 할 주요 부분은 대시보드입니다.




---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-01-06

---