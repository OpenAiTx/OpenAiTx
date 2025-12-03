# Chocolatey-for-wine

Wine에서 Chocolatey 패키지 관리자의 자동 설치 프로그램으로, wine에서 프로그램을 빠르게 설치하고 (그리고 이후에 wine의 버그를 찾는 데 편리합니다 ;) )  
일부 버그에 대한 우회 방법이 Visual Studio Community 2022와 nodejs용으로 추가되어 있으니 아래를 참조하세요.  

락다운 기간 동안 심심해서 제가 편리하다고 생각하는 동사들을 포함한 맞춤형 winetricks(.ps1)를 작성했습니다. 그냥 'winetricks'를 실행하면 볼 수 있습니다.  
일부 동사들은 wine의 최근 변경으로 인해 완전한 wine 재시작이 필요합니다. 메시지 박스가 나타나고 세션이 종료됩니다. 그냥 다시 powershell을 시작하고 동사를 다시 시도하세요. 한 번만 하면 어떤 동사에도 더 이상 필요하지 않습니다.  

예시:  

'winetricks vs22_interactiveinstaller'  ( --> 세션이 종료됩니다)  

'wine powershell' 실행  

'winetricks vs22_interactiveinstaller' 실행  


(참고로 'winetricks vs22_interactive_installer'를 통해 Visual Studio 2022 설치 프로그램에서 설치할 항목을 선택할 수 있습니다; 'winetricks vs22_interactive_installer' 덕분에 10분 만에 메인 프로그램에 들어갈 수 있었습니다 (Desktop development with C++ 선택).)

설치:  
- 릴리스 zip 파일을 다운로드하여 압축을 풀고 'wine ChoCinstaller_0.5c.751.exe'를 실행하세요 (완료까지 약 1분 소요)

선택사항:  
- 'wine ChoCinstaller_0.5a.751.exe /s'처럼 설치 프로그램을 실행하면 설치 파일들(예: Powershell*.msi와 dotnet48)이  
  MyDocuments에 저장되어 새 프리픽스를 만들 때 다시 다운로드할 필요가 없습니다)  
선택사항:  
- 'wine ChoCinstaller_0.5a.751.exe /q'로 설치 프로그램을 실행하면 powershell 창이 자동으로 실행되는 것을 방지할 수 있습니다 (설치만 진행).  

선택사항:  
- 설치가 잘 되었는지 확인하려면: "choco install chromium" 그리고 "start chrome.exe (--no-sandbox는 wine-8.4부터 더 이상 필요 없음)" 실행  

![Screenshot from 2022-08-26 12-31-18](https://user-images.githubusercontent.com/26839562/186885380-d5a617c4-9cf4-4831-a475-2bd85a3b5784.png)  
PowerShell에 대하여:  

팁: Chocolatey는 보통 프로그램의 최신 버전을 설치하는데, 이로 인해 새로운 wine 버그가 드러날 수 있습니다.  
구버전을 사용하면 더 잘 작동할 수도 있습니다.  
예시:  

choco search --exact microsoft-edge --all (--> 모든 버전 목록)  

choco install microsoft-edge --version --version='135.0.3179.98'
일반 정보:

- 'wine powershell.exe'는 PowerShell-Core 콘솔을 시작합니다.

 
ConEmu에 대하여:

ConEmu 콘솔은 몇 가지 wine 버그가 있습니다:
  - Ctrl^C로 종료해도 콘솔로 돌아오지 않는 프로그램이 있습니다. 대신 Shift^Ctrl^C를 사용하세요.
  - ConEmu 창에서 텍스트를 선택해도(복사/붙여넣기 용) 선택 영역이 하이라이트되지 않습니다. 최근 wine 버전을 우회하는 매우 안타까운 해킹이 포함되어 있으므로 이제 하이라이트가 정상 작동해야 합니다.
   
winetricks(.ps1)에 대하여:

- 호출하지 않으면 (powershell 콘솔에서 'winetricks') 아무것도 다운로드되지 않아 오버헤드가 없습니다.
- 많은 동사(예: powershell 5.1)는 msu 패키지에서 파일을 추출하기 위해 필수 파일이 필요합니다. 이 필수 파일 설치에는 처음에 대용량 다운로드와 많은 시간이 소요됩니다. 그러나 캐시된 후에는 빨리 진행됩니다. 예를 들어 'winetricks ps51'을 처음 시도하면 약 15분 정도 걸립니다. 다른 동사는 첫 사용 시 5분 정도 걸릴 수 있습니다. 하지만 한 번 호출하면 이 불편함은 사라집니다.
- 파일은 MyDocuments 디렉토리에 캐시됩니다. 모든 동사를 호출하면 약 800MB가 소요됩니다.
- 다양한 동사에 대해 더 나은 64비트 지원이 기대됩니다.
- msu 파일에서 파일을 추출하고 (시도하여) 설치할 수 있는 기능. 'winetricks install_dll_from_msu'를 실행하여 방법을 확인하세요.
- 기본적인 Powershell 5.1 구현.
- 실험적인 dotnet481 설치 및 dotnet35 (현재 dotnet48 설치에 만족하지 않는 앱에 필요할 수 있음).
- 자동 탭 완성 기능. 주의: 명령줄에서 여러 동사를 사용할 때는 쉼표로 구분해야 합니다.
  지금부터는 (powershell이 여러 인자를 처리하는 방식)
  그래서 'winetricks riched20 gdiplus'는 더 이상 작동하지 않고, 대신 'winetricks riched20,gdiplus'를 사용하세요.
- 일부 프로그램은 wine 버그 때문에 Chocolatey를 통해 설치/실행할 때 실패합니다. 이를 위해 winetricks에 몇 가지 우회책을 추가했습니다. 아래를 참조하세요.
- Visual Studio Community 2019 및 2022를 설치하는 특수 동사 (winetricks vs19, vs22 및 vs22_interactive_installer) (스크린샷 참조, 설치에 10분 이상 소요되고 약 10GB 필요!, 설치 후 c:\Program Files (x86)\Microsoft Visual Studio\2019\Community\Common7\IDE\에서 devenv.exe를 시작하세요.)
  ![screenshot](https://github.com/PietJankbal/Chocolatey-for-wine/assets/26839562/d576a619-c752-4eb1-81c2-6f6b66b50ff6)
- grep, sed, file, less, curl 등 다양한 unix 명령어 접근을 위한 특수 동사 (winetricks git.portable, 면책 조항: 일부 명령은 아직 wine 버그로 작동하지 않습니다)
- 또한 인터넷에서 찾은 코드 스니펫을 기반으로 한 몇 가지 powershell 스크립트를 포함:
    - Invoke-ReflectivePEInjection으로 exe를 powershell 스크립트에 임베드하는 방법 (exe가 tasklist에 나타나지 않음).
    - 멋진 메시지 박스 만드는 방법
    - powershell 스크립트(ps1)를 exe로 변환하는 방법
    - 기타 몇 가지
 
     
시스템 프로그램에 대하여:

기능 추가로 setx.exe 같은 간단한 시스템 프로그램을
c:\Program Files\Powershell\7\profile.ps1 내 함수로 대체하거나, getmac.exe처럼 누락된 시스템 프로그램을 추가할 수 있습니다.
프로그램이 미성숙하거나 누락된 시스템 프로그램 때문에 실패할 경우 사용자가 직접 작성할 수도 있습니다.

프로그램이 기대하는 값을 반환하는 함수.  
profile.ps1에서 (다른 것들 중) 좀 더 많은 옵션을 지원하는 wmic.exe와  
기본 setx.exe를 추가했습니다.  
또는 시스템 프로그램에 전달되는 인수를 조작할 수도 있습니다. profile.ps1과 choc_install.ps1을 참조하세요.  
더 복잡한 프로그램에도 작동한다고 보장하지는 않습니다...  

노트:  

  - 기존 wineprefix에서는 사용하지 말고, 새로 생성한 프리픽스에서만 사용하세요! 인스톨러가 dotnet48을 그냥 멍청하게 설치하고 레지스트리 키를 엉망으로 만듭니다.  
    일반 winetricks.sh로 이미 dotnet 버전을 설치한 경우 실패할 가능성이 높으며, 성공해도 깨진 프리픽스가 될 수 있습니다.  
    프로그램 설치를 위해 일반 winetricks.sh를 사용해야 한다면, dotnet* 동사를 사용하지 마세요.  
    참고로 'Arial'과 'd3dcompiler_47' 동사는 기본으로 이미 설치되어 있습니다.  
  - WINEARCH=win32는 _지원되지 않습니다_!  
  - 이전 버전에서 업데이트하는 것은 아직 지원하지 않으며, 나중에 지원할 수도 있습니다.  

컴파일:  
  - 바이너리 다운로드 대신 직접 컴파일하려면 mainv1.c와 installer.c의 컴파일 지침을 참고하세요.  
  - 그런 다음 choc_install.ps1을 같은 디렉터리에 복사하세요.  
  - 그리고 'wine ChoCinstaller_0.5a.735.exe'를 실행하세요.



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-12-03

---