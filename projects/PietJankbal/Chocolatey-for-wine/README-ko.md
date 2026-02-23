<div align="right">
  <details>
    <summary >🌐 언어</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=PietJankbal&project=Chocolatey-for-wine&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=PietJankbal&project=Chocolatey-for-wine&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=PietJankbal&project=Chocolatey-for-wine&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=PietJankbal&project=Chocolatey-for-wine&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=PietJankbal&project=Chocolatey-for-wine&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=PietJankbal&project=Chocolatey-for-wine&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=PietJankbal&project=Chocolatey-for-wine&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=PietJankbal&project=Chocolatey-for-wine&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=PietJankbal&project=Chocolatey-for-wine&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=PietJankbal&project=Chocolatey-for-wine&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=PietJankbal&project=Chocolatey-for-wine&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=PietJankbal&project=Chocolatey-for-wine&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=PietJankbal&project=Chocolatey-for-wine&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=PietJankbal&project=Chocolatey-for-wine&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=PietJankbal&project=Chocolatey-for-wine&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=PietJankbal&project=Chocolatey-for-wine&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=PietJankbal&project=Chocolatey-for-wine&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=PietJankbal&project=Chocolatey-for-wine&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=PietJankbal&project=Chocolatey-for-wine&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=PietJankbal&project=Chocolatey-for-wine&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=PietJankbal&project=Chocolatey-for-wine&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

# Chocolatey-for-wine

Chocolatey 패키지 매니저를 wine에서 자동으로 설치해주는 도구로, wine에서 프로그램을 빠르게 설치할 때 유용합니다(그리고 wine의 버그도 쉽게 찾을 수 있죠 ;) )  
일부 버그에 대한 해결책이 추가되어 있습니다. 예를 들어 Visual Studio Community 2022와 nodejs에 대한 워크어라운드가 있으니 아래를 참고하세요.  

락다운 기간에 심심해서 제가 자주 쓰는 동사(verb)들을 모아 커스텀 winetricks(.ps1)을 작성했습니다. 'winetricks'만 입력하면 목록을 볼 수 있습니다.
일부 동사(verb)는 wine을 완전히 재시작해야 적용됩니다(최근 wine의 변경 사항 때문입니다). 이 경우 메시지박스가 나타나고 세션이 종료됩니다. 다시 powershell을 실행한 뒤 해당 동사를 재시도하세요. 한 번만 하면 이후엔 어떤 동사도 재시작 없이 사용 가능합니다.  


예시:  

'winetricks vs22_interactiveinstaller'  ( --> 세션이 종료됩니다)  

'wine powershell' 실행  

'winetricks vs22_interactiveinstaller' 실행  


(참고로, 'winetricks vs22_interactive_installer'를 통해 Visual Studio 2022 설치 관리자를 사용하여 설치할 항목을 선택할 수 있습니다; 'winetricks vs22_interactive_installer'를 실행하면 약 10분 만에 메인 프로그램(Desktop development with C++ 선택)에 진입할 수 있습니다).

설치 :
- 릴리즈 zip 파일을 다운로드하고 압축을 푼 후 'wine ChoCinstaller_0.5c.751.exe'를 실행하세요 (완료까지 약 1분 소요)

옵션:
- 설치 파일(예: Powershell*.msi 및 dotnet48)이 MyDocuments에 저장되어 새로운 프리픽스를 생성할 때 다시 다운로드할 필요가 없도록 'wine ChoCinstaller_0.5a.751.exe /s'로 설치 관리자를 실행

옵션:
- 자동으로 파워셸 창이 실행되는 것을 방지하고 싶으면 'wine ChoCinstaller_0.5a.751.exe /q'로 설치 관리자를 실행 (설치만 진행됨) 

옵션:
- 정상적으로 설치되었는지 확인: "choco install chromium" 및  "start chrome.exe (--no-sandbox는 wine-8.4부터 더 이상 필요 없음)" 

![Screenshot from 2022-08-26 12-31-18](https://user-images.githubusercontent.com/26839562/186885380-d5a617c4-9cf4-4831-a475-2bd85a3b5784.png)
PowerShell 관련:

팁: Chocolatey는 일반적으로 프로그램의 최신 버전을 설치하므로 새로운 wine 버그가 나타날 수 있습니다. 구버전 소프트웨어가 더 잘 동작할 수도 있습니다.  
예시:  

choco search --exact microsoft-edge --all (--> 모든 버전 목록 출력)  

choco install microsoft-edge --version --version='135.0.3179.98'

일반 정보:

- 'wine powershell.exe'로 PowerShell-Core 콘솔을 시작합니다.

 
ConEmu 관련:

ConEmu 콘솔은 몇 가지 wine 버그로 인해 문제가 있습니다:
  - 콘솔로 돌아오지 않는 프로그램을 종료하기 위해 Ctrl^C를 눌러도 동작하지 않습니다. 대신 Shift^Ctrl^C를 사용하세요.
  - ConEmu 창에서 텍스트를 선택(복사/붙여넣기 용)하면 선택 영역이 하이라이트되지 않습니다. 최근 wine 버전에 대한 임시 방편이 포함되어 있어 이제 하이라이팅이 정상적으로 동작해야 합니다.
   
winetricks(.ps1)에 대하여:

- 직접 호출하지 않으면('winetricks'를 powershell 콘솔에서 실행하지 않으면) 아무것도 다운로드되지 않으므로 오버헤드가 없습니다.
- 많은 동사(예: powershell 5.1)는 msu 패키지에서 자료를 추출할 수 있는 필수 파일이 필요합니다. 이 파일 설치는 처음에 대용량 다운로드가 필요하고, 첫 사용 시 시간이 오래 걸릴 수 있습니다. 그러나 캐시가 되면 이후엔 빨라집니다. 예를 들어 'winetricks ps51'을 처음 실행하면 약 15분 정도 소요될 수 있습니다. 다른 동사도 첫 실행 시 5분 정도 걸릴 수 있습니다. 그러나 한 번 실행한 후에는 이런 번거로움이 사라집니다.
- 파일은 MyDocuments 디렉토리에 캐시됩니다. 모든 동사를 호출하면 약 800MB가 필요합니다.
- 여러 동사에 대해 더 나은 64비트 지원을 기대할 수 있습니다.
- msu 파일에서 파일을 추출하고 (설치 시도) 할 수 있는 기능. 방법은 'winetricks install_dll_from_msu'를 참고하세요.
- 기본적인 Powershell 5.1이 포함되어 있습니다.
- 실험적인 dotnet481 설치와 dotnet35 설치(현재 dotnet48 설치로 만족하지 않는 앱에서 필요할 수 있음).
- 자동 탭 완성 기능. 참고: 명령줄에서 여러 동사를 사용할 경우 이제 콤마로 구분해야 합니다.
  이제부터는 'winetricks riched20 gdiplus'는 동작하지 않고, 대신 'winetricks riched20,gdiplus'를 사용해야 합니다.
- 일부 프로그램은 wine 버그로 인해 Chocolatey를 통해 설치/실행 시 실패할 수 있습니다. 이에 대한 몇 가지 우회 방법을 winetricks에 추가하였습니다. 아래를 참조하세요.
- Visual Studio Community 2019 및 2022를 설치할 수 있는 특별 동사(winetricks vs19, vs22 및 vs22_interactive_installer)가 있습니다(스크린샷 참고, 설치에 10분 이상 소요 및 약 10GB 필요! 설치 후 c:\Program\ Files (x86)\Microsoft Visual Studio\2019\Community\Common7\IDE/에서 devenv.exe 실행).
  ![screenshot](https://github.com/PietJankbal/Chocolatey-for-wine/assets/26839562/d576a619-c752-4eb1-81c2-6f6b66b50ff6)
- grep, sed, file, less, curl 등 다양한 유닉스 명령어를 사용할 수 있는 특별 동사(winetricks git.portable, 참고: 일부 명령은 wine 버그로 아직 동작하지 않을 수 있음)
- 인터넷에서 가져온 코드 스니펫을 응용한 몇 가지 파워셸 스크립트도 포함되어 있습니다:
    - Invoke-ReflectivePEInjection으로 exe를 파워셸 스크립트에 임베드하는 방법(이 exe는 작업 목록에 표시되지 않음).
    - 멋진 메시지박스 만드는 법
    - 파워셸 스크립트(ps1)를 exe로 변환하는 방법.
    - 기타 몇 가지
 
     
시스템 프로그램 관련:

setx.exe와 같은 간단한 시스템 프로그램을 c:\\Program Files\Powershell\7\profile.ps1의 함수로 대체하는 기능이 추가되었습니다.
또한 getmac.exe처럼 없는 시스템 프로그램을 추가할 수 있습니다.
프로그램이 미성숙하거나 누락된 시스템 프로그램으로 인해 실패한다면, 프로그램이 기대하는 값을 반환하는 함수를 작성할 수 있습니다.
profile.ps1에는(그 외에도) 더 다양한 옵션을 지원하는 wmic.exe와
기본적인 setx.exe가 포함되어 있습니다.
또는 시스템 프로그램에 전달되는 인자를 조작할 수도 있습니다. 자세한 내용은 profile.ps1과 choc_install.ps1을 참고하세요.
더 복잡한 프로그램에서는 동작을 보장하지 않습니다... 
 
참고 사항:



  - 기존 wineprefix에는 사용하지 마십시오. 반드시 새로 생성된 prefix에서만 사용하십시오! 설치 프로그램은 단순히 dotnet48을 설치하고 레지스트리 키를 엉망으로 만듭니다.
    이미 winetricks.sh를 통해 dotnet 버전을 설치한 경우, 설치가 실패할 가능성이 높으며, 성공하더라도 prefix가 손상될 수 있습니다.
    프로그램 설치를 위해 winetricks.sh를 사용해야 한다면, dotnet* 관련 명령어는 절대 사용하지 마십시오.
    참고로 'Arial'과 'd3dcompiler_47' 명령어는 기본적으로 이미 설치되어 있습니다.
  - WINEARCH=win32는 _지원되지 않습니다_!
  - 이전 버전에서의 업그레이드는 현재(아직) 지원되지 않으며, 추후 지원될 수 있습니다.

컴파일:
  - 바이너리를 다운로드하는 대신 직접 컴파일하려면: mainv1.c와 installer.c의 컴파일 지침을 참조하십시오.
  - 그리고 choc_install.ps1을 동일한 디렉토리에 복사하십시오.
  - 그리고 'wine ChoCinstaller_0.5a.735.exe'를 실행하십시오.
  


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-02-23

---