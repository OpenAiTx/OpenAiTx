<div align="center">
<img src="https://moooonet.github.io/assets/Comfy-Align//images/display.jpg" width="100%">
<br><br>

[![Version](https://img.shields.io/badge/Version-3.0.4-cyan)](README.md)
[![Youtube](https://img.shields.io/badge/Video-Tutorial-red)](https://youtu.be/p1niyxwsOes)

</div>

ComfyUI-Align은 ComfyUI에서 부족한 노드 정렬 기능을 해결하기 위해 강력한 노드 정렬, 확장 및 색상 구성 도구 세트를 제공합니다.

> _이 플러그인이 여러분의 정신 건강을 지키는 데 도움이 되었다면, 카페인 습관 유지를 위해 ⭐를 눌러주세요._

## 환경

- ComfyUI: 버전 0.3.76에서 테스트 완료; 최근 및 향후 버전을 이론적으로 지원합니다.
- Python: Python 3.12에서 테스트 완료
- 시스템: Windows 11 및 Ubuntu 25.10에서 테스트 완료. 다른 리눅스 배포판도 작동할 것으로 예상되며, 직접 테스트해 주세요. macOS도 이론적으로 지원하지만, 장비 부족으로 테스트되지 않았습니다.

## 설치

- **ComfyUI 매니저에서:** ComfyUI 매니저에서 "ComfyUI-Align"을 검색 후 설치하세요.
- **Git 클론:** ComfyUI 디렉토리를 열고, `custom_nodes` 폴더로 이동한 후 다음을 실행하세요:
  ```bash
  git clone https://github.com/Moooonet/ComfyUI-Align.git
  ```
- **ComfyUI 재시작:** 설치 후, 새로운 플러그인을 불러오기 위해 ComfyUI를 재시작하세요.

## 설정 및 사용법

- **단축키:** 기본은 백틱 키 <kbd>`</kbd>이며, 다중 시스템 호환성을 위해 ComfyUI의 기본 기능으로 커스텀 단축키를 구현했습니다. "Align Panel"을 키바인딩에서 검색하여 원하는 단축키를 설정하세요.

<div align="center">
  <img src="https://moooonet.github.io/assets/Comfy-Align/images/keybindings.jpg" width="100%">
</div>

- **두 가지 작동 모드:**
- 1. <kbd>`</kbd> 키로 정렬 패널의 표시를 토글합니다. (탭 키 위에 위치한 백틱 키)
- 2. 설정에서 홀드 모드 활성화 (단축키를 누르고 있으면 패널이 표시됨; 버튼 위에 마우스를 올리고 키를 놓으면 클릭 없이 실행; 또는 키를 누른 상태에서 여러 버튼을 클릭하여 여러 작업 수행).

<div align="center">
  <img src="https://moooonet.github.io/assets/Comfy-Align/images/settings.jpg" width="100%">
</div>

## 주요 기능

### 1. 노드 및 그룹 정렬, 분배, 그리고 늘리기

- **정렬:**

  - **왼쪽 정렬, 오른쪽 정렬, 위쪽 정렬, 아래쪽 정렬:**
  - `Alt` 키: <kbd>Alt</kbd> 키를 누른 채 정렬하면 대상 노드가 반전됩니다.

- **분배:**

  - **수평 상단 정렬 분배:** 노드를 수평으로 고르게 분배한 후 상단 정렬합니다.
  - **수직 중앙 정렬 분배:** 노드를 수직으로 고르게 분배한 후 중앙 정렬합니다.
  - **간격 설정:** `Align` 옵션에서 간격을 설정합니다.

- **늘리기:**
  - **왼쪽 늘리기, 오른쪽 늘리기, 위쪽 늘리기, 아래쪽 늘리기:**
  - **수평 양측 늘리기:** 가장 넓은 노드를 기준으로 다른 노드가 좌우로 늘어나면서 너비를 유지합니다.
  - **수직 양측 늘리기:** 가장 높은 노드를 기준으로 다른 노드가 위아래로 늘어나면서 높이를 유지합니다.
  - **`Alt` 키:** <kbd>Alt</kbd> 키를 누른 채 늘리면 대상 노드가 반전됩니다.

### 2. 노드 및 그룹 색상 관리
- **ColorBar:**

  - 7개의 기본 색상
  - 달 아이콘 (ColorPicker 열기)
  - 색상 지우기 (선택된 노드의 색상 지우기)
  - 색상 적용 (프리셋에서 해당 노드에 색상 적용)

- **ColorPicker:**

  - 색상 선택 영역
  - 스포이드 도구
  - 색상 슬라이더
  - 알파 슬라이더
  - HEX 값 (클릭 시 복사, 더블 클릭 시 편집)
  - RGBA 값 (클릭 시 복사, 더블 클릭 시 편집. Ctrl 누르고 복사 시 모든 값 복사)
  - 색상 기록
  - 색상 프리셋

- **ColorPresets:**
  - 초기에는 플러그인 루트 디렉토리에 `color_presets.json` 파일이 생성되어 사용자 지정 색상 프리셋을 저장합니다.
  - 노드의 색상을 설정한 후 `Save` 버튼을 클릭하여 프리셋을 저장합니다.
  - `Clear` 버튼을 클릭하여 저장된 모든 프리셋 색상을 지웁니다.
  - `Apply` 버튼을 클릭하여 프리셋의 색상을 해당 노드에 적용합니다. (`Apply` 버튼은 `ColorBar`의 마지막 위치에 있습니다.)

---

<div align="center">
   <a href="https://www.star-history.com/#Moooonet/ComfyUI-Align&Date">
    <picture>
      <source media="(prefers-color-scheme: dark)" srcset="https://api.star-history.com/svg?repos=Moooonet/ComfyUI-Align&type=Date&theme=dark" />
      <source media="(prefers-color-scheme: light)" srcset="https://api.star-history.com/svg?repos=Moooonet/ComfyUI-Align&type=Date" />
      <img alt="Star History Chart" src="https://api.star-history.com/svg?repos=Moooonet/ComfyUI-Align&type=Date" />
    </picture>
   </a>
</div>

---

<div align="center">

  <p>명시적으로 허가받지 않는 한, 어떤 형태로든 통합, 수정 또는 재배포는 엄격히 금지됩니다.</p>
  <p>© 2025 무운넷. 판권 소유.</p>
</div>


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-01-23

---