# AADisplay

[![AADisplay](https://img.shields.io/badge/AADisplay-Project-blue?logo=github)](https://github.com/Nitsuya/AADisplay)
[![GitHub Release](https://img.shields.io/github/v/release/Xposed-Modules-Repo/io.github.nitsuya.aa.display)](https://github.com/Xposed-Modules-Repo/io.github.nitsuya.aa.display/releases)
![Xposed Module](https://img.shields.io/badge/Xposed-Module-blue)
[![License](https://img.shields.io/github/license/nitsuya/AADisplay)](https://github.com/nitsuya/AADisplay/blob/main/LICENSE)
![Android SDK min 31](https://img.shields.io/badge/Android%20SDK-%3E%3D%2031-brightgreen?logo=android)
![Android SDK target 33](https://img.shields.io/badge/Android%20SDK-target%2033-brightgreen?logo=android)

AADisplay 관련 튜토리얼 동영상 및 사진을 공개 장소에 게시하지 마십시오. 그렇지 않으면 중국 이외 지역에서 업데이트를 중단할 것입니다.

Android Auto에서 임의의 애플리케이션을 표시하는 VirtualDisplay 기반 중첩 솔루션입니다. Star! Star! Star!

A12+만 지원하며, LSPosed가 필요합니다. 일부 ROM에서는 충돌 가능성이 있으니 복구 지식을 준비하시기 바랍니다.

이론적으로 A10+까지 지원 가능하지만, 장비 및 유지 보수 인력 부족으로 지원하지 않으며, 능력이 있으시면 PR을 제출해 주세요.

본 프로젝트와 무관한 문제는 Issue를 제출하지 마십시오. 반드시 닫힙니다! 예: Magisk/LSPosed 환경 설치, AA 연결/사용 불가 등 관련 문제.

-----

## 사용 방법
- LSPosed에서 본 모듈을 활성화하고 System Framework와 Android Auto를 선택합니다. 좋아하는 런처를 설치한 후 모듈 설정에서 패키지명을 입력하세요.
- DPI 설정을 권장합니다. 애플리케이션 컨텍스트를 사용해 UI를 그리는 일부 까다로운 앱에서 개선됩니다.
- Properties에 AA 관련 매개변수를 추가하여 AA 설정을 후킹 및 수정할 수 있으며, 기본 유형 매개변수만 지원합니다.
- Android Auto가 AA 앱 자체 설치 출처를 검사하는 것을 자동으로 우회합니다.
- 루트 권한은 사용자 구성 쉘 명령 실행에만 사용되며, 필요하지 않으면 부여하지 않아도 됩니다.

## 면책 조항
- 본 모듈 사용은 모든 결과에 대한 자발적 책임을 의미하며, 장치 손상 및 운전 사고 등을 포함하되 이에 국한되지 않습니다.
- 본 프로젝트에서 파생된 모든 프로젝트에 대해서 본 프로젝트는 어떠한 책임도 지지 않습니다.
- 본 프로젝트는 영구적으로 오픈소스이며, Issue 또는 PR 제출을 환영하지만 불법 목적으로 사용되는 기능 제출은 삼가해 주십시오.
- 개발자는 언제든지 **업데이트 중단** 또는 **프로젝트 삭제**를 할 수 있습니다.

## 후원
[기부 Donation](https://afdian.com/a/nitsuya)

CNY:
- [Eclair234](https://github.com/Eclair234) 350
- 수호천사 정말 어렵다(某安) 50
- 狐仙(某Q) 25
- 匿名 20+50

## Thanks

### 库

[AOSP](https://source.android.com/)

[YAMF](https://github.com/duzhaokun123/YAMF)

[DexKit](https://github.com/LuckyPray/DexKit)

[Hide-My-Applist](https://github.com/Dr-TSNG/Hide-My-Applist)

[HiddenApi](https://github.com/RikkaW/HiddenApi)

[LSPosed](https://github.com/LSPosed/LSPosed)

[xposed](https://forum.xda-developers.com/xposed)

[Material](https://material.io/)

[QAuxiliary](https://github.com/cinit/QAuxiliary)

[ViewBindingUtil](https://github.com/matsudamper/ViewBindingUtil)



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-11-27

---