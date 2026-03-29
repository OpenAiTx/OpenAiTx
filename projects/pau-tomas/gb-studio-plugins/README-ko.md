# GB Studio 4.2 - 플러그인 팩

GB Studio 4.2용 실험적 플러그인 세트입니다. 사용은 본인 책임 하에 하세요 :)

> [!NOTE]
> 이전에 사용 가능했던 일부 이벤트 플러그인은 이제 더 이상 사용되지 않으며, 해당 기능은 GB Studio에 포함되어 있습니다. [아래 목록을 참조하세요](#deprecated-plugins).

## 대화 및 메뉴

### 생명력 바 그리기

오버레이의 지정된 위치에 (생명/파워/마나) 바를 그립니다.

- `X`, `Y`: 오버레이의 타일 좌표.
- `Tileset`: 연속된 순서로 바 타일을 포함하는 타일셋.
- `Tile`: 타일셋 내 바의 첫 번째 타일 (보통 비어있는 타일).
- `Value`: 바가 표현할 현재 값.
- `Max Value`: 바가 표현할 수 있는 최대 값.
- `Steps`: 바 내 아이템을 "채우는" 데 필요한 타일 수 (빈 타일 제외).

[예제 프로젝트](examples/Draw%20Lifebar/)

_참고:_ 타일셋은 VRAM의 타일 128부터 로드됩니다 (스프라이트 블록 바로 다음). 이는 오버레이에서 `Draw Text`와 생명력 바 렌더링을 결합할 수 있게 합니다. VRAM 인덱스는 플러그인 파일 내 `const VRAM_BASE_START_TILE = 128` 라인을 수정하여 변경할 수 있습니다.

<img width="300" alt="Draw Lifebar" src="https://raw.githubusercontent.com/pau-tomas/gb-studio-plugins/main/plugins/Draw Lifebar/screenshots/draw_lifebar.png"/>

<img width="300" alt="Draw Lifebar" src="https://raw.githubusercontent.com/pau-tomas/gb-studio-plugins/main/plugins/Draw Lifebar/screenshots/draw_lifebar_screenshot.png"/>

### 고급 메뉴 표시

여러 옵션의 메뉴를 표시하고 선택한 옵션의 값으로 지정된 변수를 설정합니다. 메뉴 옵션 위치 및 탐색 순서는 `Items` 탭에서 각 항목별로 설정할 수 있습니다. 선택적으로 'B' 버튼으로 메뉴를 닫고 변수를 '0'으로 설정할 수 있으며, 마지막 메뉴 항목을 선택 시 '0'을 반환하게 할 수도 있습니다. 대화 상자 크기, 열림 및 닫힘 방향, 메뉴 위치(상단 또는 하단)는 `Layout` 탭에서 설정할 수 있습니다. 메뉴의 열림 및 닫힘 속도는 `Behavior` 탭에서 설정 가능합니다.

항목별 최대 문자 길이는 없으나, 총 표시 문자 수는 UI 텍스트용으로 예약된 타일 수에 의해 제한됩니다 (비컬러 모드에서는 52개).

_참고:_ 항목이 많을 경우 이벤트가 매우 길어질 수 있습니다.

<img width="300" alt="Advanced Menu Items" src="https://raw.githubusercontent.com/pau-tomas/gb-studio-plugins/main/plugins/Advanced Menu/screenshots/advanced_menu_items.png"/> <img width="300" alt="Advanced Menu Screenshot" src="https://raw.githubusercontent.com/pau-tomas/gb-studio-plugins/main/plugins/Advanced Menu/screenshots/advanced_menu_screenshot.png"/>

<img width="300" alt="Advanced Menu Layout" src="https://raw.githubusercontent.com/pau-tomas/gb-studio-plugins/main/plugins/Advanced Menu/screenshots/advanced_menu_layout.png"/>

## 실시간 시계

일부 GB 카트리지에 내장된 실시간 시계 기능에 접근할 수 있는 이벤트 세트입니다.

_참고:_ RTC가 작동하려면 프로젝트 설정에서 카트리지 유형을 `MBC3`으로 설정해야 합니다.

### 시계 시간 설정

실시간 시계 필드의 값을 숫자 또는 변수의 값으로 설정합니다.

<img width="300" alt="시계 시간 설정" src="https://raw.githubusercontent.com/pau-tomas/gb-studio-plugins/main/plugins/RTC/screenshots/set_clock_time.png"/>

### 변수에 시계 시간 저장

현재 시간을 각 값마다 하나의 변수에 저장합니다.

<img width="300" alt="변수에 시계 시간 저장" src="https://raw.githubusercontent.com/pau-tomas/gb-studio-plugins/main/plugins/RTC/screenshots/store_time_in_var.png"/>

### 시계 시작

실시간 시계를 시작합니다.

<img width="300" alt="시계 시작" src="https://raw.githubusercontent.com/pau-tomas/gb-studio-plugins/main/plugins/RTC/screenshots/start_clock.png"/>

### 시계 정지

실시간 시계를 정지합니다.

<img width="300" alt="시계 정지" src="https://raw.githubusercontent.com/pau-tomas/gb-studio-plugins/main/plugins/RTC/screenshots/stop_clock.png"/>

## 화면

### 부드러운 페이드

**컬러 모드 전용**

현재 장면의 배경 또는 스프라이트 팔레트 일부 또는 전체를 흰색 또는 검은색 화면으로, 또는 그 반대로 페이드하며 색상 값을 보간하여 부드러운 페이드 효과를 만듭니다.

<img width="300" alt="플레이어 필드 업데이트" src="https://raw.githubusercontent.com/pau-tomas/gb-studio-plugins/main/plugins/Smooth Fade/screenshots/smooth_fade.png"/>

## β 플러그인

이 카테고리의 플러그인은 위의 것들보다 훨씬 실험적이며 앞으로 변경될 수 있습니다.

- **Move Variable Actor To** 및 **Store Variable Actor Position n Variables**:
  - 이 이벤트들은 기존 GB Studio Actor 이벤트를 복제한 것이지만, 드롭다운에서 배우를 선택하는 대신 변수를 사용합니다. 변수의 값은 장면 내 배우의 인덱스를 나타냅니다(플레이어는 항상 `0`이며, 나머지 배우들은 장면에 추가된 순서에 따라 인덱스가 할당됩니다).

- **Pin Actor to Screen** 및 **Unpin Actor from Screen**:
  - 배우를 현재 화면 좌표에 고정하거나 고정을 해제합니다.\n이벤트 호출 시 배우가 이미 고정되었거나 고정 해제된 상태이면, 위치가 스크롤 위치에 따라 잘못 오프셋될 수 있으니 주의하세요.

## 설치 방법

`plugins` 폴더를 프로젝트에 넣으세요. 위의 모든 이벤트가 `Add Event` 버튼에서 사용 가능해집니다.

## 다른 저자의 더 많은 플러그인:

- [NalaFala (Yousurname)의 GB Studio 플러그인 모음](https://github.com/Y0UR-U5ERNAME/gbs-plugin-collection)
- [Platformer+](https://github.com/becomingplural/GBS_PlatformerPlus)
- [Advanced Dialog and Menu vB](https://github.com/dochardware/Advanced-Dialog-and-Menu)
- [Shin의 GB Studio 플러그인](https://github.com/shin-gamedev/gbs-plugins)
- [Gud GBS 플러그인](https://github.com/mikeleisz/gud_gbs_plugins)
- [Fade Street](https://gearfo.itch.io/fade-street)
- [Scroll Scene transition](https://github.com/Mico27/GBS-scrollScenePlugin) 및 더 많은 [Mico27의 플러그인](https://github.com/Mico27/)

## 더 이상 지원되지 않는 플러그인 이벤트

다음 이벤트 플러그인들은 기능이 GB Studio에 기본적으로 추가되어 Plugin Pak에서 더 이상 제공되지 않습니다.

4.2 버전부터:

- Player Field Update
- Store Player Field In Variable
- Store Camera Field In Variable

4.1 버전부터:

- Display Advanced Dialogue
- Display Background Text
- Print Screen Background
- Mute Channel
- 카메라 필드 업데이트
- 대화 프레임 설정
- 액터 FX

4.0 이후:

- 잠금 이벤트 그룹
- 잠금 해제 이벤트 그룹


GB Studio 4.2 이상을 사용하지 않는 경우에도 위 기능을 [여기](https://github.com/pau-tomas/gb-studio-plugins/tree/4.1)에서 찾을 수 있습니다. 4.0과 호환되는 플러그인은 [여기](https://github.com/pau-tomas/gb-studio-plugins/tree/4.0)를 확인하세요.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-29

---