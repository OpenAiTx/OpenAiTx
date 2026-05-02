# 마우스 오른쪽 버튼 클릭 윈도우 매직

마우스 오른쪽 버튼 클릭 윈도우 매직은 관리자, 고급 사용자 및 기타 매직 사용자들을 위한 우클릭(컨텍스트) 메뉴 도구 모음입니다. 자신을 마법사라고 생각하고 시간을 절약하며 골칫거리를 줄이고 싶다면, 이 *올바른* 컨텍스트 메뉴 도구 모음이 바로 당신을 위한 것입니다.

이 작은 매직 팩에는 다음이 포함됩니다:
- 윈도우 11에서 예전 컨텍스트 메뉴를 다시 추가하는 옵션
- 디렉터리 복사 및 이동을 위한 robocopy (일반 복사보다 훨씬 빠름)
- robocopy는 네트워크 공유 간 복사/이동에도 작동
- 클립보드에서 붙여넣기(robocopy 사용)
- SCP 전송/수신
- 폴더 또는 드라이브에서 CMD 또는 파워셸 창 열기
- .ps1 스크립트를 관리자 권한으로 실행
- 파일 또는 디렉터리 소유권 가져오기(재귀 포함) (takeown && icacls)
- 안전 모드로 부팅하는 옵션
- 복구 모드로 재부팅하는 옵션
- 바탕화면에서 제어판 열기
- 프로그램을 사용자 지정 우선순위로 실행
- 항상 관리자 권한으로 CMD 열기 옵션
- 심볼릭/하드 링크 생성
- "God Mode" 열기
- x초 후 재부팅/종료
- MoveTo / SendTo 폴더 옵션 (윈도우 7부터)
- 바탕화면 배경에서 로그아웃
- GodMode 열기
- 변경한 사항을 제거하는 옵션
- UAC 비활성화
- 긴 경로 활성화(260자 이상 경로)

또한 메뉴가 너무 복잡해지지 않도록 몇 가지 우클릭 메뉴 옵션을 제거할 수 있습니다:
- 빠른 액세스에 고정
- 시작 화면에 고정
- 라이브러리에 포함
- 보내기
- 공유
- 윈도우 미디어 플레이어에 추가
- 윈도우 디펜더로 검사

기타 제거 항목:
- 탐색기 내부의 "버전" 탭

TODO (마법에는 시간이 걸립니다):
- 파일에 대해 takeown (.exe 및 기타)
- 여러 파일/폴더에 대한 디렉터리 접합점
- 관리자 권한으로 열린 pwsh
- 배경에서 우클릭 시 다른 관리자 도구 추가
- 여러분의 제안


![마법 예시](https://raw.githubusercontent.com/GChuf/RCWM/magic/img/RCWM.gif)


# 설치


도구를 설치하려면: 릴리스([여기](https://github.com/GChuf/RCWM/releases/latest))에서 최신 zip 파일을 다운로드하고 압축을 풀고 __관리자 권한으로__ install.cmd 스크립트를 실행하세요 - 그 후에는 가장 많이 사용하는 두 키, __*Y*__ 와 __*N*__ (그리고 아마 몇 가지 더)만 필요합니다.
RCWM 명령을 실행하는 사용자가 관리자 권한이 없으면 일부 마법 기능이 제대로 작동하지 않을 수 있습니다.


# 어떻게 작동하나요?

기본적으로 마법입니다. 약간의 스파게티 코드도 포함되어 있습니다.

현재 마법은 배치 및 파워셸 스크립팅의 도움을 받아 Windows 레지스트리 내에서 이루어집니다.

목표는 robocopy 같은 명령줄 도구를 자동화하여 1) 모두가 사용할 수 있도록 하고, 2) 이미 사용하는 방법을 아는 사람들에게 시간을 절약하는 것이었습니다. 작업을 자동화하는 과정에서 생각보다 훨씬 더 많은 것을 자동화할 수 있다는 것을 우연히 발견했고, 이제는 일반 느리고 느긋한 Windows GUI 복사처럼 여러 폴더를 선택해 모두 한 폴더에 복사/이동할 수 있습니다.


# RoboCopy: 항목 복사 및 이동 옵션

복사/붙여넣기 및 파일/디렉터리 이동 모두 작업을 수행하기 위해 robocopy를 사용합니다.
두 가지 옵션이 있습니다: 한 번에 여러 디렉터리를 복사하거나 단일 디렉터리를 복사할 수 있습니다.

__단일__:
복사할 파일/폴더(디렉터리 경로)가 우클릭 "복사" 시 레지스트리에 기록되며 기존에 저장된 경로를 __덮어씁니다__. 새 폴더를 지정하면 기존 폴더(있다면)가 덮어써집니다.

__여러개__:
복사할 파일/폴더 경로 목록이 *HKCU:\SOFTWARE\RCWM\{rcopy || rcmov}* 키 아래 레지스트리에 __덧붙여집니다__. 그런 다음 스크립트가 파워셸 루프를 통해 모두 복사합니다.

기본적으로 최대 15개 폴더까지만 선택할 수 있습니다(우클릭 옵션의 기본 Windows 제한이 15개이며, 설치 스크립트에서 31개 이상으로 늘릴 수 있습니다 - 자세한 내용은 *MultipleInvokeMinimum.reg* 파일 참조). 재귀적 복사/이동도 문제없으며 (하위 폴더가 원하는 만큼 있어도 됩니다).

많이 RoboCopy를 사용할 계획이라면 이 옵션을 사용하세요. 스크립트가 어떻게 작동하는지 이해하려면 rcp.ps1 파워셸 파일을 읽어보실 수 있습니다.

복사(다중) 대 이동(단일):

![Single vs Multiple](https://raw.githubusercontent.com/GChuf/RCWM/magic/img/sm.gif)

# RoboCopy: 기타 옵션

Ctrl+C로 선택한 폴더도 붙여넣을 수 있습니다. 이 옵션은 "클립보드에서 붙여넣기"라고 합니다.
또한, 미러링 옵션(/MIR)을 사용하여 디렉터리를 미러링할 수 있습니다. 이 옵션은 동일한 이름의 디렉터리가 이미 존재하는 위치에 디렉터리를 미러링할 때만 작동합니다.

# 알려진 버그

- 매우 많은 폴더를 마우스 오른쪽 클릭할 때 TakeOwn이 제대로 작동하지 않을 수 있습니다(일부 폴더 권한이 변경되지 않아 두 번 실행해야 할 수도 있음)?
대량의 재귀 폴더 소유권 변경은 정상 작동합니다.
- 우선순위로 실행은 프로그램을 어떤 우선순위로 실행할지 선택하는 메뉴를 표시하지 않습니다 - 이런 현상이 발생하면 알려주세요
- rmdir 및 robocopy는 때때로 관리자 권한이 필요합니다 (robocopy가 오류 5를 발생시킴) - 이런 경우 takeown을 하거나 항상 관리자 권한으로 cmd를 실행하면 도움이 됩니다

# 테스트
RoboCopy는 많은 소규모 파일을 복사할 때 훨씬 빠릅니다.
RmDir(del 및 rd)도 "표준" 삭제보다 빠르며, 빈 디렉터리를 사용할 때 robocopy의 /MIR 옵션보다 빠릅니다.

내 컴퓨터의 SSD 디스크에서 테스트 결과:
폴더 정보: 1.73GB / 12,089 파일
- rcopy/일반 복사: 43초/91초
- rmdir/일반 삭제: 약 3초/4.5초

결과는 컴퓨터 및 디스크에 따라 다를 수 있지만, 소규모 파일이 많을수록 이점이 있을 것입니다.

# 안전성

RCWM v2는 ps2exe 스크립트와 그 출력물이 안티바이러스 소프트웨어에 의해 차단되는 문제가 있었습니다.
이제 ps2exe에서 벗어났습니다.

모든 .exe 파일은 바이러스 토탈에서 검사되었고 안전한 것으로 표시되었습니다 (파일들은 HKCU 레지스트리에 폴더 경로를 저장하는 데 사용됨):

[rcwm-single.exe](https://www.virustotal.com/gui/url/3f1d93268323b721b956ac7a015e80a68768fedf34adbbb022b660c06b7f2efb?nocache=1)



[rcwm-multiple.exe](https://www.virustotal.com/gui/url/bcf252d68d68198eb304682dc070f0bed0b14fa159add7e6766c3c41b1feff86?nocache=1)

[RCWMInit.exe](https://www.virustotal.com/gui/url-analysis/u-13bb952212b2d23dce18713803085437b31180b593acb4f4f2d13753269e2db3-21bd70f1?nocache=1)

# 기여하기

버그나 제안에 대해 언제든지 PR을 만들거나 새로운 이슈를 열 수 있습니다.

# 지원

이 프로젝트의 목표는 다른 사람들의 삶을 더 쉽게 만드는 것입니다.

프로젝트에 별표를 표시하면 사람들이 이 프로젝트를 알게 됩니다.

원하신다면 저에게 ~~커피~~ 맥주를 사주실 수 있습니다:

- paypal.me: paypal.me/gchuf

- btc: 16BRUTbKu3tSuS9SudCoP7qHreNs6sAp8d

- eth: 0x75240bb1d3fac69954e980ec53d1c93a2d140389

- ltc: LWtm2gXdr29HhaiaXytnaz799RwYbxhz2d

# 크레딧

안전 모드 부팅 및 우선 순위 실행 파일들은 [tenforums.com](https://www.tenforums.com/tutorials/1977-windows-10-tutorial-index.html)의 Shawn Brink에게 큰 영향을 받았습니다.

소유권 획득용 TakeOwn.reg 파일들은 [AskVG.com](https://www.askvg.com/)의 Vishal Gupta와 Shawn Brink에게 큰 영향을 받았습니다.

복구 모드로 재부팅 옵션은 얼마 전에 인터넷에서 찾았습니다. 불행히도 원 저자가 누구인지 기억할 수 없습니다.

관리자 권한으로 스크립트 실행 아이디어는 여기서 찾았습니다: https://ss64.com/ps/syntax-elevate.html

모든 파일을 변경하고 조정했지만, 그 아이디어와 초기 구현에 대해 공로를 인정합니다.

그 외 모든 것은 인터넷의 도움을 받아 제가 직접 작업한 것입니다.

# 다운로드

![Downloads](https://img.shields.io/github/downloads/GChuf/RCWM/total?label=TotalDownloads)

![Downloads-Latest](https://img.shields.io/github/downloads/GChuf/RCWM/latest/total?label=LatestReleaseDownloads)

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-05-02

---