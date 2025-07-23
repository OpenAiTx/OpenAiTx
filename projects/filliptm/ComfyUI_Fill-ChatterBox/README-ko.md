<div align="right">
  <details>
    <summary >🌐 언어</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=filliptm&project=ComfyUI_Fill-ChatterBox&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=filliptm&project=ComfyUI_Fill-ChatterBox&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=filliptm&project=ComfyUI_Fill-ChatterBox&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=filliptm&project=ComfyUI_Fill-ChatterBox&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=filliptm&project=ComfyUI_Fill-ChatterBox&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=filliptm&project=ComfyUI_Fill-ChatterBox&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=filliptm&project=ComfyUI_Fill-ChatterBox&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=filliptm&project=ComfyUI_Fill-ChatterBox&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=filliptm&project=ComfyUI_Fill-ChatterBox&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=filliptm&project=ComfyUI_Fill-ChatterBox&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=filliptm&project=ComfyUI_Fill-ChatterBox&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=filliptm&project=ComfyUI_Fill-ChatterBox&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=filliptm&project=ComfyUI_Fill-ChatterBox&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=filliptm&project=ComfyUI_Fill-ChatterBox&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=filliptm&project=ComfyUI_Fill-ChatterBox&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=filliptm&project=ComfyUI_Fill-ChatterBox&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=filliptm&project=ComfyUI_Fill-ChatterBox&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=filliptm&project=ComfyUI_Fill-ChatterBox&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=filliptm&project=ComfyUI_Fill-ChatterBox&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=filliptm&project=ComfyUI_Fill-ChatterBox&lang=id">Bahasa Indonesia</a>
      </div>
    </div>
  </details>
</div>

# ComfyUI_Fill-ChatterBox

이 프로젝트가 마음에 드신다면 Patreon을 통해 저를 후원해 주세요!
<p align="left">
  <a href="https://www.patreon.com/c/Machinedelusions">
    <img src="https://raw.githubusercontent.com/filliptm/ComfyUI_Fill-ChatterBox/main/assets/Patreon.png" width="150px" alt="Patreon">
  </a>
</p>

Chatterbox 라이브러리를 사용하여 텍스트-음성 변환(TTS) 및 음성 변환(VC) 기능을 추가하는 ComfyUI용 커스텀 노드 확장입니다.
최대 40초까지 지원합니다. 이 제한을 없애려고 시도했으나, 그보다 길면 모델이 제대로 동작하지 않아 제한을 유지했습니다.

![ChatterBox Example](https://raw.githubusercontent.com/filliptm/ComfyUI_Fill-ChatterBox/main/web/image.png)

## 설치 방법

1. 이 저장소를 ComfyUI의 custom_nodes 디렉토리에 클론합니다:

   ```bash
   cd /path/to/ComfyUI/custom_nodes
   git clone https://github.com/filliptm/ComfyUI_Fill-ChatterBox.git
   ```
2. 기본 종속성을 설치합니다:

   ```bash
   pip install -r ComfyUI_Fill-ChatterBox/requirements.txt
   ```
3. (선택 사항) 워터마킹 지원 설치:

   ```bash
   pip install resemble-perth
   ```

   **참고**: `resemble-perth` 패키지는 Python 3.12 이상에서 호환성 문제가 있을 수 있습니다. 임포트 오류가 발생하더라도 노드는 워터마크 없이 작동합니다.


## 사용법

### 텍스트-음성 변환 노드 (FL Chatterbox TTS)
- 워크플로우에 "FL Chatterbox TTS" 노드를 추가하세요
- 텍스트 입력 및 매개변수(과장, cfg_weight, 온도)를 설정하세요
- 선택적으로 음성 클로닝을 위한 오디오 프롬프트를 제공할 수 있습니다

### 음성 변환 노드 (FL Chatterbox VC)
- 워크플로우에 "FL Chatterbox VC" 노드를 추가하세요
- 입력 오디오와 대상 음성을 연결하세요
- 두 노드는 CUDA 오류 발생 시 CPU 폴백을 지원합니다

## 변경 로그

### 2025년 6월 24일
- 재현 가능한 생성을 위해 TTS 및 VC 노드에 시드 매개변수 추가
- 시드 범위: 0에서 4,294,967,295 (32비트 정수)
- 디버깅 및 워크플로우 제어를 위한 일관된 오디오 출력 가능
- Python 3.12 이상 호환성 문제 해결을 위해 Perth 워터마크를 선택 사항으로 변경
- resemble-perth 임포트 실패 시 워터마크 없이 노드 작동

### 2025년 5월 31일
- 지속 모델 로딩 및 로딩 바 기능 추가
- Mac 지원 추가 (테스트 필요하니 연락 바람)
- chatterbox-tts 라이브러리 제거 및 네이티브 추론 코드 구현




---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-23

---