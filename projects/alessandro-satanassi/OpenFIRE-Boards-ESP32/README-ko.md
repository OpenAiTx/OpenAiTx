## ... ESP32용 OpenFIRE-Boards 포팅

이 저장소는 TeamOpenFIRE의 원본 'OpenFIRE-Boards' 프로젝트를 ESP32S3 마이크로컨트롤러에서 동작하도록 포팅한 것입니다.  
몇 가지 조정과 소소한 변경을 제외하고는, 코드는 TeamOpenFIRE의 원본과 본질적으로 동일합니다.  
이 저장소의 코드는 RP2040 마이크로컨트롤러에서도 작동합니다.  
TeamOpenFIRE의 원본 'OpenFIRE-Boards' 프로젝트에 변경 사항이 있을 때마다, 이 저장소의 코드도 이에 맞게 업데이트할 것입니다.  
'OpenFIRE-Boards' 프로젝트를 만들어 주신 TeamOpenFIRE에 진심으로 감사드리며, 모든 공로와 감사의 마음을 전합니다.  
이것은 단순히 ESP32S3에서 작동하도록 한 적응판입니다.  


This repository is a porting of the original 'OpenFIRE-Boards' project by TeamOpenFIRE, adapted to work on the ESP32S3 microcontroller.  
Apart from some adaptations and minor adjustments, the code remains largely faithful to the original by TeamOpenFIRE.  
The code in this repository also works on the RP2040 microcontroller.  
Whenever changes are made to the original 'OpenFIRE-Boards' project by TeamOpenFIRE, I will update the code in this repository accordingly.  
I sincerely thank TeamOpenFIRE for creating the 'OpenFIRE-Boards' project; all credit and gratitude go to them for their work.  
This is simply an adaptation to make it work on ESP32S3.  

![Waveshare-esp32-s3-pico](https://github.com/user-attachments/assets/2ce848f3-f308-43cc-b753-3b1dac1647e4)  

![YD-esp32-s3-wroom1-DevKitC-1-N16R8](https://github.com/user-attachments/assets/080baf9b-f050-4b3e-ba59-4fb4aa784909)  


## ... 원본 프로젝트 페이지 계속  
## ... follows the original project page  

# OpenFIRE-Boards  
OpenFIRE 펌웨어 및 데스크톱 앱 간에 공유되는 보드들의 공통 저장소  

# OpenFIRE 공유 리소스  
이 저장소는 마이크로컨트롤러 펌웨어 구현과 PC 장치에서 인터페이스 및 설정을 위해 의도된 애플리케이션 간에 공유될 수 있는 리소스를 포함합니다.  

## `OpenFIREshared.h`  
이 파일 상단 절반은 펌웨어와 앱 구현 양쪽에서 공통적인 다음을 정의합니다:  
 - 마이크로컨트롤러가 초기 도킹 시 보고할 보드 이름들을 문자열 리터럴로 정의  
 - 핀 기능 유형, 토글, 설정, I2C 장치 및 설정, 펌웨어와 앱 간 직렬 통신에 사용되는 명령의 열거형  
 - 부팅 시 로드되고 기본 보드 레이아웃을 보여주는 앱에서 참조하는 정의된 보드의 프리셋  

`OF_APP` 전처리기 검사 아래에는 지원되는 보드와 핀 기능에 대한 '보기 좋은' 문자열과, 데스크톱 앱에서만 사용되어 정의된 보드의 GPIO 핀을 그래픽으로 표현하는 보드 레이아웃이 있습니다 - 이 레이아웃은 보드 중심 벡터를 기준으로 핀들이 어디에 렌더링되어야 하는지 보여주며, 앱이 사용자에게 옵션으로 제시할 수 있는 대체 레이아웃도 포함할 수 있습니다.  

### `boardPresetsMap`
지원되는 보드는 파일 상단에 정의된 `OPENFIRE_BOARD` 정의와 일치하는 이름을 가져야 하며, 각 GPIO가 기본적으로 어떤 기능을 가져야 하는지의 맵이 뒤따라야 합니다(`OF_Prefs::toggles[OF_Const::customPins]`가 보드의 현재 환경설정에서 *true*로 설정되었을 때 로드됨). 마이크로컨트롤러가 가진 각 GPIO가 여기에서 표현되어야 하며, 매핑되지 않은 핀은 `btnUnmapped`로, 예약되었거나 사용자에게 노출되지 않는 핀은 `unavailable`로 지정되어야 합니다. RP2040 및 RP235X-A 보드는 최대 30핀을 가져야 하며 - `rpipico`가 약 26핀만 노출하더라도 숨겨진 GPIO를 고려한다는 점을 주목하세요.

### `boardBoxPositions`
`boardPresetsMap`과 마찬가지로, 지원되는 각 `OPENFIRE_BOARD`마다, 데스크톱 앱의 그래픽 보드 뷰에서 각 핀이 대략 *어디에* 위치해야 하는지 나타내는 맵을 제공합니다. 이 맵은 두 값의 합으로 표현되며 - 왼쪽 값은 1부터 시작하는 양의 정수로서 상대 위치를 나타내고, 오른쪽 값은 핀 요소가 보드의 어느 쪽에 위치해야 하는지 나타내는 열거형 값입니다. `posLeft`, `posRight`, `posMiddle`을 추가하면 이 GPIO가 보드 뷰의 해당 측면에 배치되며, `posNothing` (문자 그대로 0)을 추가하면 앱이 이 핀을 전혀 표시하지 않도록 알리는데, 이는 `boardPresetsMap`에서 `unavailable` 핀에 사용되어야 합니다. 값의 개수는 프리셋 맵에 정의된 GPIO의 개수와 일치해야 합니다.

### `boardsAltPresets`
이것은 선택적 대체 보드 프리셋용으로, 보드 레이아웃 뷰에서 대체 레이아웃 이름의 드롭다운 목록으로 표시됩니다. 지원되는 각 `OPENFIRE_BOARD`는 여러 번 나열될 수 있으며, 각 대체 레이아웃마다 하나씩 - 보드 이름 뒤의 문자열은 인터페이스에 표시될 레이블을 나타내며, 중괄호 안의 맵은 `boardPresetsMap`과 동일하게 GPIO 보드 기능을 나타냅니다; 같은 규칙과 제약이 적용됩니다. 주로 기본 SAMCO 2.0 레이아웃과 다른 매핑을 갖는 `adafruitItsy`의 SAMCO 1.1 레이아웃과 같은 어댑터 보드의 다른 권장 버튼 매핑/배선을 맞추기 위해 의도되었습니다; 또한 현재 참조 데스크톱 앱이 사용자 지정 레이아웃을 내보내고 가져오는 기능을 지원한다는 점도 주목하세요.

## `boardPics/` - 보드 벡터 및 핀 하이라이트
이는 데스크톱 앱이 보드 레이아웃 뷰에서 현재 애플리케이션에 연결된 보드를 그래픽으로 표현하는 데 사용하는 보드 벡터 저장소입니다. 보드 벡터는 *Plain SVG* (또는 동등한 포맷)로 내보내져야 하며, `vectors.qrc` 리소스 파일에 추가되어야 하고, 각 파일의 별칭은 `OpenFIREshared.h`의 `OPENFIRE_BOARD` 문자열과 일치해야 합니다.

현재 참조 데스크톱 앱은 사용자가 인터페이스에서 GPIO 핀 항목 위에 마우스를 올릴 때 *하이라이트된 핀*을 표시할 수 있습니다. 이를 위해 SVG는 다음과 같이 수정되어야 합니다(Inkscape를 주요 인터페이스 예시로 사용):
 1. 아직 하지 않았다면, 이미지의 기존 보드 객체 모두를 하나의 그룹으로 묶으세요(이름은 상관없음). 또한 핀 구멍이 실제로 투명하며 배경색으로 채워져 있지 않은지 확인하세요.
 2. 보드 그룹 *아래*에 새 그룹을 만드세요 - 이름은 상관없지만, 사용 편의를 위해 `OF` 같은 이름을 추천합니다.
 3. 새로 만든 하이라이트 그룹 안에 스트로크 없이 단일 평면 색상으로 채워진 하이라이트 요소를 만드세요(기존 보드는 RGBA `ebe713`, 즉 *R253/G231/B19*를 사용).
 4. 하이라이트 요소를 선택하고 *객체 속성* 탭(또는 *"ID"* 줄이 보이는 유사 탭)으로 이동하세요: 각 하이라이트 요소는 `OF_pinX`라는 ID를 가져야 하며, 여기서 X는 GPIO 핀 번호이고 선행 0은 없습니다.
 5. 요소가 선택된 상태에서 *채우기 및 스트로크* 탭(또는 *"불투명도 (%)"*가 보이는 탭)으로 이동해 불투명도를 **0.0**으로 설정하세요.
 6. 배치, 이름 지정, 불투명도가 모두 만족스러우면 파일을 `boardPics` 디렉터리에 ***Plain SVG*** 파일로 저장하세요. `vectors.qrc`에 이 보드가 `OpenFIREshared.h`의 `OPENFIRE_BOARD` 문자열과 일치하는 별칭으로 등록되어 있는지 꼭 확인하세요!

> [!NOTE]
> 이 절차는 보드의 *접근 가능한* 모든 GPIO 핀에 대해서만 수행해야 합니다 (즉, `boardPresetsMap`에서 `unavailable`인 핀은 추가하지 마세요. 이들은 애플리케이션에서 숨겨집니다).

이 작업이 끝나면 애플리케이션을 다시 빌드하고 보드 그림을 테스트하세요; 가장 쉬운 방법은 *도움말->호환 보드 보기* 창을 열고 마우스 커서를 GPIO에 해당하는 레이블 위에 올려놓는 것입니다.

> [!NOTE]
> - 보드 그림이 전혀 표시되지 않으면 벡터 이름이 적절하지 않거나 올바르게 내보내지 않은 것일 수 있으니 위 6단계를 다시 한 번 꼼꼼히 확인하세요.
> - 보드 그림은 표시되지만 하이라이트가 표시되지 않거나 잘못된 핀에 나타나면, 내보낸 SVG를 메모장 등의 텍스트 편집기로 수동으로 편집해야 할 수도 있습니다. 벡터가 작동하기 위한 기술적 요구사항 및 확인할 사항은 다음과 같습니다:
>   - `id="OF_pinX"` 줄이 `style="` 줄보다 *위*에 있어야 합니다.
>   - `style="` 줄 안에 `opacity:0`이 포함되어 있어야 합니다 (선호는 `0` 또는 `0.0`이며, 어느 쪽이든 상관없지만 일치해야 합니다).
> 다음 예시는 각 하이라이트 요소의 이상적인 포맷을 보여줍니다([`pico.svg`](https://raw.githubusercontent.com/alessandro-satanassi/OpenFIRE-Boards-ESP32/main/boardPics/pico.svg)에서 발췌):
> ```html
>   <g
>      id="OF">
>     <path
>        id="OF_pin1"
>        style="opacity:0;fill:#ebe713;fill-opacity:1"
>        class="st10"
>        d="M19.7,47.4c0,3.4-2.9,6.2-6.3,6.2s-6.2-2.8-6.3-6.2,2.7-6.3,6.1-6.4c3.4,0,6.3,2.6,6.5,6" />
>     <path
>        id="OF_pin2"
>        style="opacity:0;fill:#ebe713;fill-opacity:1"
>        class="st10"
>        d="M19.8,88.1c0,3.4-2.9,6.2-6.3,6.2s-6.2-2.8-6.3-6.2c0-3.4,2.7-6.3,6.1-6.4,3.4,0,6.3,2.6,6.5,6" />
> ...
> ```




---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-12-11

---