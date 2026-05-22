# macOS용 DisableCtrlClick

<p align="center">
  <img src="https://raw.githubusercontent.com/achendev/DisableCtrlClick/master/DisableCtrlClick.png" alt="앱 아이콘" width="128">
</p>

<p align="center">
  <a href="https://github.com/achendev/DisableCtrlClick/releases">
    <img src="https://img.shields.io/github/downloads/achendev/DisableCtrlClick/total.svg" alt="총 다운로드 수">
  </a>
  <a href="https://github.com/achendev/DisableCtrlClick">
    <img src="https://img.shields.io/github/stars/achendev/DisableCtrlClick?style=social" alt="GitHub에서 스타 받기">
  </a>
</p>

Control 키만 누르려다 실수로 컨텍스트 메뉴가 열리는 게 지겹지 않으신가요? 저도 그래요.

많은 애플리케이션, 특히 프로그래밍, 디자인, 게임에서 `Control`은 기본 동작을 위한 수정키로 사용됩니다. 만약 오른쪽 클릭을 위해 두 손가락 탭이나 전용 마우스 버튼에 익숙하다면, 기본 `Ctrl-Click` 동작은 귀찮은 방해가 될 수 있습니다. 이 앱이 그 문제를 해결합니다.

## 기능 설명

이것은 메뉴바에 상주하며 단 하나의 일을 하는 작고 네이티브한 macOS 유틸리티입니다: **`Control + 왼쪽 클릭`**을 일반 **`왼쪽 클릭`**처럼 동작하게 강제하여 기본 오른쪽 클릭/컨텍스트 메뉴 동작을 비활성화합니다.

그게 다입니다. 더 이상 무작위 오른쪽 클릭은 없습니다.

## 특징

*   ✅ **가볍고 네이티브:** 최소한의 리소스를 사용하는 간단한 Swift 앱입니다.
*   ✅ **메뉴바에서 설정 가능:** 아이콘을 클릭하여 기능을 일시 비활성화하거나, "로그인 시 자동 실행"을 토글하거나, 앱을 종료할 수 있습니다.
*   ✅ **메뉴바 앱:** 메뉴바에 조용히 상주합니다. Cmd+드래그로 숨기고 다시 실행하면 복구됩니다.
*   ✅ **로그인 시 시작 (선택 사항):** 로그인 시 자동으로 시작합니다. 앱 메뉴에서 토글할 수 있습니다.
*   ✅ **설정 불필요:** 실행 후 권한만 부여하면 끝입니다.
*   ✅ **현대적이고 안전:** 최신 API로 구축되었으며, 기능 수행에 필요한 최소 권한만 요구합니다.
*   ✅ **투명하고 작음:** 앱 코드를 전부 읽거나 AI에 입력해 정확히 무엇을 하는지, Mac에서 어떤 앱이 실행되는지 알 수 있을 정도로 매우 작습니다.



## 설치 및 사용법

1.  **다운로드:** [**릴리스 페이지**](https://github.com/achendev/DisableCtrlClick/releases)로 이동하여 최신 `DisableCtrlClick.dmg`를 다운로드하세요.
2.  **설치:** 파일을 열고 `DisableCtrlClick.app`를 `/Applications` 폴더로 드래그하세요.
3.  **실행:** Applications 폴더에서 앱을 엽니다.
4.  **권한 부여:** 처음 실행할 때 앱이 권한 부여를 요청한 후 종료됩니다. `DisableCtrlClick`에 대해 **접근성** 및 **입력 모니터링**을 활성화해야 합니다:
    *   `시스템 설정 > 개인정보 보호 및 보안 > 접근성`
    > **왜 필요한가요?** 마우스나 키보드 이벤트를 시스템 전역에서 보고 수정해야 하는 모든 앱에 필요합니다. 이 앱은 `Ctrl-Click`만 감지하며 다른 작업은 하지 않습니다.

5.  **완료!** 앱을 한 번 더 실행하세요. 이제 실행 중이며 기본적으로 로그인할 때마다 자동으로 시작됩니다. 이 동작은 메뉴바 아이콘에서 변경할 수 있습니다.

앱은 메뉴바에 작은 아이콘을 표시합니다.
*   아이콘을 클릭하면 기능을 일시적으로 비활성화하거나 로그인 시 실행 여부를 제어하거나 앱을 종료할 수 있는 메뉴가 열립니다.
*   `⌘` (커맨드)를 누른 상태에서 아이콘을 메뉴바 밖으로 드래그하면 아이콘을 숨길 수 있습니다. 다시 표시하려면 앱을 다시 실행하세요.

## 소스에서 빌드하기

직접 앱을 빌드하려면:

1.  이 저장소를 클론하세요:
    ```bash
    git clone https://github.com/achendev/DisableCtrlClick.git
    cd DisableCtrlClick
    ```
2.  Xcode용 명령줄 도구가 설치되어 있는지 확인하십시오.
3.  터미널에서 빌드 스크립트를 실행하십시오:
    ```bash
    ./build.sh
    ```
4.  `DisableCtrlClick.app` 번들이 프로젝트 디렉토리에 생성됩니다. 이후 이를 `/Applications` 폴더로 이동할 수 있습니다.

5.  /Applications로 드래그하여 실행하세요. 기본적으로 '로그인 시 열기'에 자동으로 추가됩니다.

6.  시스템 설정에서 접근성 및 입력 모니터링 권한을 부여하세요.

## 문제 해결 

앱은 '있는 그대로' 제공되며 명시적이거나 묵시적인 보증이 없습니다.

macOS 13.0 (Ventura) 이상이 필요합니다.

**종료 방법**
메뉴바 아이콘을 클릭하고 "종료"를 선택하세요. 아이콘을 숨긴 경우, 앱을 다시 실행하여 아이콘을 표시하거나 터미널에서 `killall DisableCtrlClick` 명령어를 사용하세요.

**권한 재설정 방법**
앱이 작동하지 않을 경우 권한을 재설정해 보세요:
    ```bash
    tccutil reset Accessibility com.usr.DisableCtrlClick
    ```
## 라이선스

이 프로젝트는 MIT 라이선스 하에 배포됩니다.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-05-22

---