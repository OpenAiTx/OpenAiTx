# Microsoft PowerToys

![Microsoft PowerToys의 대표 이미지](doc/images/overview/PT_hero_image.png)

[PowerToys 사용법][usingPowerToys-docs-link] | [다운로드 및 릴리스 노트][github-release-link] | [PowerToys 기여하기](#contributing) | [최근 소식](#whats-happening) | [로드맵](#powertoys-roadmap)

## 소개

Microsoft PowerToys는 고급 사용자가 Windows 환경을 조정하고 효율적으로 사용할 수 있도록 돕는 유틸리티 모음입니다. [PowerToys 개요 및 유틸리티 사용법][usingPowerToys-docs-link]에 대한 자세한 정보나, [Windows 개발 환경](https://learn.microsoft.com/windows/dev-environment/overview)에 필요한 도구 및 자료는 [learn.microsoft.com][usingPowerToys-docs-link]에서 확인하세요!

|              | 현재 제공 유틸리티: |              |
|--------------|--------------------|--------------|
| [고급 붙여넣기](https://aka.ms/PowerToysOverview_AdvancedPaste) | [항상 위에 고정](https://aka.ms/PowerToysOverview_AoT) | [PowerToys 깨어있기](https://aka.ms/PowerToysOverview_Awake) |
| [색상 선택기](https://aka.ms/PowerToysOverview_ColorPicker) | [명령어를 찾을 수 없음](https://aka.ms/PowerToysOverview_CmdNotFound) | [명령 팔레트](https://aka.ms/PowerToysOverview_CmdPal) |
| [자르기 및 잠금](https://aka.ms/PowerToysOverview_CropAndLock) | [환경 변수](https://aka.ms/PowerToysOverview_EnvironmentVariables) | [팬시존](https://aka.ms/PowerToysOverview_FancyZones) |
| [파일 탐색기 추가 기능](https://aka.ms/PowerToysOverview_FileExplorerAddOns) | [파일 잠금 해제기](https://aka.ms/PowerToysOverview_FileLocksmith) | [Hosts 파일 편집기](https://aka.ms/PowerToysOverview_HostsFileEditor) |
| [이미지 크기 조정기](https://aka.ms/PowerToysOverview_ImageResizer) | [키보드 관리자](https://aka.ms/PowerToysOverview_KeyboardManager) | [마우스 유틸리티](https://aka.ms/PowerToysOverview_MouseUtilities) |
| [경계 없는 마우스](https://aka.ms/PowerToysOverview_MouseWithoutBorders) | [New+](https://aka.ms/PowerToysOverview_NewPlus) | [일반 텍스트로 붙여넣기](https://aka.ms/PowerToysOverview_PastePlain) |
| [피크(미리보기)](https://aka.ms/PowerToysOverview_Peek) | [파워리네임](https://aka.ms/PowerToysOverview_PowerRename) | [PowerToys 실행](https://aka.ms/PowerToysOverview_PowerToysRun) |
| [빠른 악센트](https://aka.ms/PowerToysOverview_QuickAccent) | [레지스트리 미리보기](https://aka.ms/PowerToysOverview_RegistryPreview) | [화면 자](https://aka.ms/PowerToysOverview_ScreenRuler) |
| [단축키 안내](https://aka.ms/PowerToysOverview_ShortcutGuide) | [텍스트 추출기](https://aka.ms/PowerToysOverview_TextExtractor) | [워크스페이스](https://aka.ms/PowerToysOverview_Workspaces) |
| [ZoomIt](https://aka.ms/PowerToysOverview_ZoomIt) |

## Microsoft PowerToys 설치 및 실행

### 요구 사항

- Windows 11 또는 Windows 10 버전 2004(코드명 20H1 / 빌드 번호 19041) 이상
- x64 또는 ARM64 프로세서
- 인스톨러는 다음 항목을 설치합니다:
   - [Microsoft Edge WebView2 런타임](https://go.microsoft.com/fwlink/p/?LinkId=2124703) 부트스트래퍼. 최신 버전이 설치됩니다.

### GitHub에서 EXE로 설치 [권장]

[Microsoft PowerToys GitHub 릴리스 페이지][github-release-link]로 이동하여, 하단의 `Assets`를 클릭해 릴리스에 포함된 파일을 확인하세요. 사용자의 PC 아키텍처와 설치 범위에 맞는 PowerToys 인스톨러를 사용하세요. 대부분의 경우 `x64` 및 사용자별 설치입니다.

<!-- 릴리스별로 업데이트가 필요한 항목 -->
[github-next-release-work]: https://github.com/microsoft/PowerToys/issues?q=is%3Aissue+milestone%3A%22PowerToys+0.92%22
[github-current-release-work]: https://github.com/microsoft/PowerToys/issues?q=is%3Aissue+milestone%3A%22PowerToys+0.91%22
[ptUserX64]: https://github.com/microsoft/PowerToys/releases/download/v0.91.1/PowerToysUserSetup-0.91.1-x64.exe 
[ptUserArm64]: https://github.com/microsoft/PowerToys/releases/download/v0.91.1/PowerToysUserSetup-0.91.1-arm64.exe 
[ptMachineX64]: https://github.com/microsoft/PowerToys/releases/download/v0.91.1/PowerToysSetup-0.91.1-x64.exe 
[ptMachineArm64]: https://github.com/microsoft/PowerToys/releases/download/v0.91.1/PowerToysSetup-0.91.1-arm64.exe
 
|  설명   | 파일명 | sha256 해시 |
|----------------|----------|-------------|
| 사용자별 - x64       | [PowerToysUserSetup-0.91.1-x64.exe][ptUserX64] | 42EA4A3E8C79A5456476D19E72B3E2AB9393A89C4DC7442EB7EE5A1E3490D38A |
| 사용자별 - ARM64     | [PowerToysUserSetup-0.91.1-arm64.exe][ptUserArm64] | F3F433FE04049F9197411D792AADEBF34E3BE7FE16327BD8B73D2A046ED8BAF6 |
| PC 전체 - x64   | [PowerToysSetup-0.91.1-x64.exe][ptMachineX64] | EC4BC3A8625775866B0ED4577CCF83E6EC7B1A0AD267379DDBAF4FE49C7B5BDD |
| PC 전체 - ARM64 | [PowerToysSetup-0.91.1-arm64.exe][ptMachineArm64] | 9CB8911008420D0E446AE3D5CE365E447FA4DF9DCF9337F3A80F933C00FC3689 |

이 방법을 권장합니다.

### Microsoft Store를 통한 설치

[Microsoft Store의 PowerToys 페이지][microsoft-store-link]에서 설치하세요. [새로운 Microsoft Store](https://blogs.windows.com/windowsExperience/2021/06/24/building-a-new-open-microsoft-store-on-windows-11/)를 사용해야 하며, Windows 11 및 Windows 10 모두에서 지원됩니다.

### WinGet을 통한 설치

[WinGet][winget-link]에서 PowerToys를 다운로드하세요. winget을 통한 PowerToys 업데이트는 현재 설치 범위를 유지합니다. PowerToys 설치를 위해 명령줄 또는 PowerShell에서 다음 명령을 실행하세요:

#### 사용자 범위 인스톨러 [기본값]
```powershell
winget install Microsoft.PowerToys -s winget
```

#### PC 전체 범위 인스톨러

```powershell
winget install --scope machine Microsoft.PowerToys -s winget
```

### 기타 설치 방법

Chocolatey 및 Scoop과 같은 [커뮤니티 기반 설치 방법](./doc/unofficialInstallMethods.md)이 있습니다. 선호하는 설치 방법이 있다면 해당 문서에서 설치 방법을 확인할 수 있습니다.

## 서드파티 Run 플러그인

PowerToys와 함께 배포되지 않는, 커뮤니티가 만든 [서드파티 플러그인 모음](./doc/thirdPartyRunPlugins.md)이 있습니다.

## 기여하기

이 프로젝트는 모든 형태의 기여를 환영합니다. 기능 개발/버그 수정 외에도, 명세 작성, 디자인, 문서화, 버그 찾기 등 다양한 방법으로 도움을 줄 수 있습니다. 고급 사용자 커뮤니티와 함께 Windows를 최대한 활용할 수 있는 도구 모음을 만드는 데 여러분의 참여를 기대합니다.

**기여하고 싶은 기능에 대해 작업을 시작하기 전에**, 반드시 [기여자 안내서](CONTRIBUTING.md)를 읽어주세요. 최적의 접근 방법을 함께 고민하고, 개발 과정에서 가이드 및 멘토링을 제공하며, 중복된 노력을 줄일 수 있도록 도와드릴 수 있습니다.

대부분의 기여는 [기여자 라이선스 계약(CLA)][oss-CLA]에 동의해야 합니다. 이를 통해 귀하의 기여물을 사용할 권리와 허가를 당사가 갖게 됩니다.

PowerToys 개발과 관련된 자세한 안내는 [개발자 문서](/doc/devdocs)를 참고하세요. 여기에는 빌드를 위한 환경 설정 방법 등이 포함되어 있습니다.

## 최근 소식

### PowerToys 로드맵

핵심 팀이 집중하고 있는 기능 및 유틸리티의 [우선순위 로드맵][roadmap]입니다.

### 0.91 - 2025년 5월 업데이트

이번 릴리스에서는 신규 기능, 안정성, 자동화에 중점을 두었습니다.

**✨주요 내용**

 - 명령 팔레트의 성능을 대폭 개선하고 많은 버그를 수정하였습니다. 추가된 신규 기능:
 - 명령 팔레트에서 폴백 명령을 사용하여 모든 파일 검색 가능.
 - 명령 팔레트의 글로벌 단축키를 저수준 키보드 후킹으로 설정 가능.
 - WebSearch 확장에 URL 열기 폴백 명령 추가, 명령 팔레트에서 브라우저로 직접 URL 열기 지원.
 - PT Run 및 명령 팔레트의 날짜 및 시간 플러그인에서 사용자 지정 형식 정의 가능. [@htcfreek](https://github.com/htcfreek)님 감사합니다!

### 고급 붙여넣기

 - 특정 영어 언어 태그(예: en-CA)에서 OCR 엔진 생성에 실패하는 문제를 사용자 프로필 언어로 OCR 엔진을 초기화하여 해결. [@cryolithic](https://github.com/cryolithic)님 감사합니다!

### 색상 선택기

 - Graphics 객체를 올바르게 해제하여 리소스 누수로 인한 멈춤/크래시 문제 해결. [@dcog989](https://github.com/dcog989)님 감사합니다!
 - 백스페이스 키 입력 시 Color Picker가 종료되는 문제를 초점이 맞춰졌을 때만 닫히도록 하여 Escape/Backspace 동작을 통일. [@PesBandi](https://github.com/PesBandi)님 감사합니다!
 - Oklab 및 Oklch 색상 형식 지원 추가. [@lemonyte](https://github.com/lemonyte)님 감사합니다!

### 명령어를 찾을 수 없음

 - WinGet 명령어 찾기 스크립트를, 해당 실험적 기능이 실제로 있을 때만 활성화하도록 업데이트.

### 명령 팔레트

 - 버그 템플릿에 명령 팔레트 모듈 추가.
 - 토스트 창이 DPI에 맞춰 크기 조정되지 않아 레이아웃 문제가 발생하던 현상 수정.
 - 위/아래 키보드 탐색 시 커서가 0 위치에 있을 때 선택이 이동하지 않던 문제와, PT Run v1과 같은 연속 탐색 추가. [@davidegiacometti](https://github.com/davidegiacometti)님 감사합니다!
 - 시간 및 날짜 확장 코드 단순화 및 명확성 향상.
 - 명령어 대소문자에 따라 마우스 포인터 이동 실패 문제를 소문자로 변환하여 해결.
 - WebSearch 확장에 URL 열기 폴백 명령 추가, 명령 팔레트에서 브라우저로 직접 URL 열기 지원. [@htcfreek](https://github.com/htcfreek)님 감사합니다!
 - CmdPal에서 시스템 트레이 아이콘 활성/비활성 설정 추가 및 Windows 11 용어와 일치하도록 정렬. [@davidegiacometti](https://github.com/davidegiacometti)님 감사합니다!
 - 별칭 업데이트 문제를 새 별칭이 설정될 때 기존 별칭을 제거하여 해결.
 - GitHub 대소문자 충돌을 Exts와 exts를 ext 디렉터리로 이동하여 플랫폼 간 구조 일관성 및 경로 단절 방지.
 - '새 확장 만들기' 명령에서 빈 파일명이 생성되는 문제 수정.
 - 글로벌 단축키를 저수준 키보드 후킹으로 설정하는 기능 추가.
 - JUMBO 썸네일 지원 추가, 고해상도 아이콘 사용 가능.
 - CmdPal이 MSAL 대화상자 열림 시 자동 숨김으로 인해 크래시되는 문제를, 비활성화 시 숨기지 않도록 하여 해결.
 - 페이지 로드 시 즉시 검색 텍스트 선택 기능 추가.
 - 확장 설정 페이지가 재열기 시 새로고침되지 않던 버그를, 확장 설정 저장 시 설정 폼을 업데이트하여 해결.
 - 명령 팔레트가 실행기에서 실행되지 않던 문제 해결.
 - PowerToys Run v1 계산기 로직을 명령 팔레트로 이식, 설정 지원 및 폴백 동작 개선.
 - 목록 항목 키보드 단축키 지원 재추가.
 - 접근성 개선: 올바른 라벨 추가, 애니메이션 개선, 지역화 향상 및 a11y 관련 문제 수정.
 - 사용자 지정 형식 지원을 시간 및 날짜 플러그인에 이식, 설정 정리 및 오류 메시지 개선, 예외 상황 크래시 수정. [@htcfreek](https://github.com/htcfreek)님 감사합니다!
 - 시스템 명령에 대한 폴백 항목 추가.
 - Windows 시스템 명령에서 "휴지통 열기" 동작의 키 프롬프트가 "Empty"로 잘못 표시되는 문제 해결. [@jironemo](https://github.com/jironemo)님 감사합니다!
 - '더 많은 명령' 목록에 표시되어서는 안 되는 명령이 나타나는 문제 수정. [@davidegiacometti](https://github.com/davidegiacometti)님 감사합니다!
 - 명령 팔레트 상세 보기에서 아이콘이 지나치게 크고 텍스트가 정렬되지 않던 문제를 Windows 검색과 일치하도록 정렬.
 - 빈 화면 내용 및 명령 막대 명령이 긴 라벨 사용 시 잘려서 표시되던 문제 해결.
 - CmdPal의 WinGet 통합 개선: 설치된 패키지의 버전 표시 수정, 아이콘과 함께 업데이트 지원, 프리뷰 winget API를 안정 버전으로 마이그레이션.
 - ContentPage용 명령이 종료 후에야 업데이트되던 문제를, 컨텍스트 메뉴가 변경될 때 완전히 초기화하도록 하여 해결.
 - TimeDate 확장에 폴백 지원 추가, 명령 미리 선택 없이 직접 날짜/시간 쿼리 가능.
 - 여러 CmdPal 프로젝트 파일에 Common.Dotnet.AotCompatibility.props 가져오기 추가로 AoT 컴파일 지원 강화.
 - settings.json이 없거나 단축키 미정의 시 HotKey가 null로 인해 CmdPal 설정에서 크래시되는 문제 해결. [@davidegiacometti](https://github.com/davidegiacometti)님 감사합니다!
 - CmdPal에서 필터 가능한 중첩 컨텍스트 메뉴 및 포커스를 유지하는 검색 상자 지원 추가.
 - CmdPal 클래스 리팩터링, JSON 직렬화 개선 및 성능·유지보수성을 위한 신규 직렬화 컨텍스트 도입.
 - Ahead-of-Time(AoT) 컴파일 지원 추가.
 - CmdPal 실행 재시도 기능 추가.
 - CmdPal.Common에서 사용하지 않는 파일 일부 제거, 코드베이스 간소화 및 AoT 호환성 표시 용이화.
 - SearchText 업데이트의 레이스 컨디션으로 인해 입력 상자 커서가 자동으로 끝으로 이동하는 문제를, 실제 변경 시에만 업데이트하도록 하여 해결.
 - 폴백 명령에서 모든 파일 검색 지원 추가.
 - AoT 관련 코드 정리, 테스트 중 중복 작업 방지.
 - 확장 시작을 병렬화하고 타임아웃을 적용하여 비정상 확장으로 인한 전체 차단 방지, CmdPal 로드 시간 단축.
 - 목록이 비워지면 상세 창을 해제하여 불일치 시각 상태 방지 등 UI 동작 개선.
 - CmdPal에서 일치하는 명령이 없을 때 폴백 명령을 해제하는 기능 추가, 더 깔끔한 재로드 동작 보장.
 - CmdPal 확장 템플릿의 잘못된 ComServer 사용으로 인한 누수 해결.
 - CmdPal 창이 제목 표시줄 더블 클릭 시 최대화되지 않도록 하여 의도된 창 동작 유지. [@davidegiacometti](https://github.com/davidegiacometti)님 감사합니다!
 - 설정 UI가 너무 작게 시작되는 문제를, DPI 인식 및 최소 너비·높이 보장(WinUIEx 사용)으로 해결.
 - CmdPal의 흰색 플래시 및 일회성 애니메이션 문제를, 창을 숨기는 대신 감춤으로 해결.
 - 시작 시 모든 확장 설정을 불러오던 문제를, 확장 설정을 지연 로딩하여 초기화 오버헤드 감소.
 - Adaptive Card 파싱 실패로 인한 CmdPal 크래시 보호 기능 추가.
 - CmdPal에서 shell:AppsFolder를 URI 활성화로 교체하여 신뢰성 향상.
 - PowerToys 설정에서 CmdPal 설정 열기 기능 추가.
 - CmdPal이 선택 항목의 속성 변경을 추적하여 확장 세부 정보를 동적으로 업데이트하는 기능 추가.
 - CmdPal 확장 템플릿에서 사용하는 툴킷 버전을 0.2.0으로 상향.

### 이미지 크기 조정기

 - 이미지 크기 조정 프리셋 삭제 시, 잘못된 프리셋이 삭제되던 문제 수정.

### 키보드 관리자

 - 좌/우 구분 없이 지정된 수정키가 잘못된 키 처리로 인해 입력이 고정되는 문제를, 눌린 키를 추적하고 올바른 키를 전송하도록 하여 해결. [@mantaionut](https://github.com/mantaionut)님 감사합니다!

### 파워리네임

 - 12시간제 시간 형식 및 AM/PM 지원 등 시간 형식 지정 기능 강화. [@bitmap4](https://github.com/bitmap4)님 감사합니다!

### PowerToys 실행

 - "시간 및 날짜" 플러그인에서 사용자 지정 형식 지원 및 잘못된 입력 형식에 대한 오류 메시지 개선. [@htcfreek](https://github.com/htcfreek)님 감사합니다!
 - 두 가지 크래시 수정: WFT의 매우 이른 날짜 처리, 매우 늦은 날짜(예: 31.12.9999)에서 월 주 계산 오류, UI 설정 재정렬. [@htcfreek](https://github.com/htcfreek)님 감사합니다!
 - 명령어 대소문자에 따라 마우스 포인터 이동 실패 문제를 소문자로 변환하여 해결.
 - '로딩 오류' 및 '초기화 오류'에 플러그인 버전 세부 정보 추가. [@htcfreek](https://github.com/htcfreek)님 감사합니다!
 - 결과 모델을 확장하여 사용 기반 정렬 방지 지원 추가, 플러그인 개발자가 정렬 동작을 더 세밀하게 제어 가능. [@CoreyHayward](https://github.com/CoreyHayward), [@htcfreek](https://github.com/htcfreek)님 감사합니다!

### 빠른 악센트

 - GetDefaultLetterKeyEPO의 글자 맵핑에서 "ǔ"를 "ŭ"로 변경하여 VK_U 키가 에스페란토 발음을 정확히 반영하도록 수정. [@OlegKharchevkin](https://github.com/OlegKharchevkin)님 감사합니다!
 - 화면 키보드 사용 시 빠른 악센트가 제대로 동작하지 않던 문제 수정. [@davidegiacometti](https://github.com/davidegiacometti)님 감사합니다!

### 레지스트리 미리보기

 - 파일 헤더를 직접 작성하지 않고도 레지스트리 키 및 값 붙여넣기 지원, 앱 리셋 버튼 추가. [@htcfreek](https://github.com/htcfreek)님 감사합니다!

### 설정

 - 설정 앱이 작업 표시줄에 빈 아이콘을 무작위로 표시하던 문제를, 창이 활성화될 때 아이콘 할당을 지연시켜 해결.
 - "새로운 소식" 창 최대화 기능 추가로 더 편안한 읽기 환경 제공.

### 워크스페이스

 - 창 필터링 및 Steam URL 프로토콜 처리를 업데이트하여 Steam 게임이 제대로 캡처 또는 실행되지 않던 버그 수정.

### 문서화

 - PowerToys Run 서드파티 플러그인 문서에 QuickNotes 추가. [@ruslanlap](https://github.com/ruslanlap)님 감사합니다!
 - PowerToys Run 서드파티 플러그인 문서에 날씨 및 Pomodoro 플러그인 추가. [@ruslanlap](https://github.com/ruslanlap)님 감사합니다!
 - PowerToys Run의 서드파티 플러그인 문서에 Linear 플러그인 추가. [@vednig](https://github.com/vednig)님 감사합니다!
 - 문서 파일의 서식 문제 수정 및 기여자·팀원 정보 업데이트. [@DanielEScherzer](https://github.com/DanielEScherzer), [@RokyZevon](https://github.com/RokyZevon)님 감사합니다!

### 개발

 - .NET 9 설치를 위한 GitHub Action 업데이트(MSStore 릴리스 지원).
 - bug_report.yml의 버전 자리표시자 업데이트로 v0.70.0 잘못 표기되는 문제 예방.
 - GitHub Action의 actions/setup-dotnet을 버전 3에서 4로 업그레이드(MSStore 릴리스).
 - WinGet 구성 파일에 securityContext 추가, 사용자 컨텍스트에서 호출 및 별도 프로세스에서 권한 상승 리소스에 대한 UAC 한 번만 요청. [@mdanish-kh](https://github.com/mdanish-kh)님 감사합니다!
 - 로그 파일 확장자를 .txt에서 .log로 변경하여 파일 연결 및 도구 호환성 개선, 워크스페이스 로그 추가. [@benwa](https://github.com/benwa)님 감사합니다!
 - 테스트 프레임워크 종속성 업그레이드 및 구성요소별 패키지 버전 정렬.
 - 종속성 업그레이드로 취약점 해결.
 - GitHub Actions 및 Docker 태그를 전체 커밋 해시로 고정, Dependency Review Workflow 도입으로 자동 종속성 취약점 스캔 등 저장소 보안 강화. [@Nick2bad4u](https://github.com/Nick2bad4u)님 감사합니다!
 - Boost 종속성을 최신 버전으로 업그레이드.
 - 툴킷을 최신 버전으로 업그레이드, AoT 관련 경고 억제.
 - 새로 추가된 파일의 서명 누락으로 인한 빌드 실패 문제 해결.
 - 릴리스 파이프라인을 업데이트하여 100년간 비공개 심볼이 게시되지 않도록 변경.
 - PowerRename의 신뢰성 향상을 위한 퍼징 도입, 다른 C++ 모듈로 확장 방법 안내 추가.
 - 모든 .csproj 프로젝트에 대한 생성 폴더 사전 생성 중앙화로 빌드 실패 방지.
 - WinAppSDK를 최신 1.7 버전으로 업데이트.
 - PowerRename 퍼징 프로젝트의 Boost 종속성을 최신 버전으로 업그레이드.
 - tsa.json의 ADO area path를 최신 경로로 변경하여 TSA 파이프라인 오류 해결.
 - CmdPal AoT 지원의 기초 작업 진행.
  
### 도구/일반

 - 시스템 및 진단 정보를 포함한 미리 작성된 GitHub 이슈 URL을 생성하여 버그 리포트 자동화 지원 추가. [@donlaci](https://github.com/donlaci)님 감사합니다!
 - 인스톨러의 로컬 빌드 스크립트 추가, CmdPal의 로컬 환경 실행 지원.
 - 하드코딩된 비밀번호 사용 제거 및 PSScriptAnalyzer 보안 경고 해결을 위해 export PFX 로직 제거.
 - src 폴더 내 모든 C# 프로젝트에서 Common.Dotnet.CsWinRT.props 일관 적용을 강제하는 PowerShell 스크립트 및 CI 통합 추가.
   
### 0.92 버전 계획

[v0.92][github-next-release-work]에서는 아래 항목에 중점을 둘 예정입니다:

 - 명령 팔레트 지속적 개선
 - 새로운 UI 자동화 테스트
 - 인스톨러 업그레이드 작업
 - 키보드 관리자 편집기 UI 업그레이드
 - 안정성/버그 수정

## PowerToys 커뮤니티

PowerToys 팀은 [놀라운 활발한 커뮤니티][community-link]의 지원에 깊이 감사드립니다. 여러분의 기여는 매우 중요합니다. PowerToys는 여러분의 버그 리포트, 문서 업데이트, 디자인 가이드, 기능 개발 덕분에 지금의 모습이 될 수 있었습니다. 진심으로 감사드리며, 여러분의 노고를 매달 기억하고자 합니다. 여러분의 참여가 PowerToys를 더 나은 소프트웨어로 만듭니다.

## 행동 강령

이 프로젝트는 [Microsoft 오픈 소스 행동 강령][oss-conduct-code]을 채택하고 있습니다.

## 개인정보 처리방침

이 애플리케이션은 기본적인 진단 데이터(텔레메트리)를 수집합니다. 개인정보 및 수집 정보에 대한 자세한 내용은 [PowerToys 데이터 및 개인정보 문서](https://aka.ms/powertoys-data-and-privacy-documentation)를 참고하세요.

[oss-CLA]: https://cla.opensource.microsoft.com
[oss-conduct-code]: CODE_OF_CONDUCT.md
[community-link]: COMMUNITY.md
[github-release-link]: https://aka.ms/installPowerToys
[microsoft-store-link]: https://aka.ms/getPowertoys
[winget-link]: https://github.com/microsoft/winget-cli#installing-the-client
[roadmap]: https://github.com/microsoft/PowerToys/wiki/Roadmap
[privacy-link]: http://go.microsoft.com/fwlink/?LinkId=521839
[loc-bug]: https://github.com/microsoft/PowerToys/issues/new?assignees=&labels=&template=translation_issue.md&title=
[usingPowerToys-docs-link]: https://aka.ms/powertoys-docs


---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---