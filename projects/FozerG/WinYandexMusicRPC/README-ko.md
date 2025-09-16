# **<img src="https://raw.githubusercontent.com/FozerG/WinYandexMusicRPC/main/./assets/YMRPC_ico.ico" alt="[DISCORD RPC]" width="30"/> &nbsp;WinSdk + Yandex Music Discord 리치 프레즌스**
[![TotalDownloads](https://img.shields.io/github/downloads/FozerG/WinYandexMusicRPC/total)](https://github.com/FozerG/WinYandexMusicRPC/releases "Download") [![LastRelease](https://img.shields.io/github/v/release/FozerG/WinYandexMusicRPC)](https://github.com/FozerG/WinYandexMusicRPC/releases "Download") [![CodeOpen](https://img.shields.io/github/languages/top/FozerG/WinYandexMusicRPC)](https://github.com/FozerG/WinYandexMusicRPC/blob/main/main.py "Show code") [![OS - Windows](https://img.shields.io/badge/OS-Windows-blue?logo=windows&logoColor=white)](https://github.com/FozerG/WinYandexMusicRPC/releases "Download")

>러시아에서 Discord 차단이라는 비합리적인 결정에도 불구하고, 가능한 한 이 스크립트를 계속 작동 상태로 유지할 것입니다 🕊️

>[우리는 우리가 좋아하는 것을 사용할 것입니다.](https://github.com/Flowseal/zapret-discord-youtube)

**컴퓨터에서 현재 듣고 있는 음악을 보여주는 Discord RPC입니다. 트랙과 앨범 커버는 Yandex Music에서 로드됩니다.**

<img src="https://github.com/user-attachments/assets/99d15c70-632f-41ec-a6cd-49de8a7d2a8f" alt="discord" width="340">

Yandex Music API를 사용하여 현재 트랙을 보여주는 유사한 RPC가 존재합니다. 하지만 이들은 라디오에서 재생 중인 정보(예: `Моя Волна`)를 표시할 수 없습니다.

그래서 저는 `Windows.Media.Control`을 사용하여 현재 트랙 정보를 가져오고, Yandex Music에서 검색하여 Discord에 트랙을 표시하는 스크립트를 만들었습니다.

다른 스크립트와 비교한 장점:    
Yandex Music 토큰이 필요 없음 ✅  
플레이리스트, 라디오 트랙 표시 가능 ✅  
Yandex Music에 국한되지 않고 VKontakte 등 다른 곳에서도 음악 청취 가능 ✅  
브라우저 및 앱 모두에서 작동 ✅   
일시정지 상태 표시 ✅  
트랙 종료까지 남은 시간 표시 ✅  
"게임 중" 대신 "청취 중" 상태 표시 ✅

## 요구사항
윈도우 11과 윈도우 10에서만 동작이 확인되었으며, 다른 버전이나 플랫폼에서는 작동하지 않습니다. **제한된 Lite 및 Custom 버전 윈도우에서는 작동이 보장되지 않습니다.**

exe 파일을 사용하지 않는 경우:  
1. Python <3.14, >=3.10

## Exe 파일 다운로드 및 사용 방법
1. [최신 릴리스](https://github.com/FozerG/WinYandexMusicRPC/releases) 다운로드
  
2. WinYandexMusicRPC 실행

3. 스크립트는 3초 후 자동으로 시스템 트레이로 숨겨집니다. 작동 확인을 위해 트레이에서 콘솔을 열어주세요.

## main.py 사용 방법

1. 터미널을 열고 `requirements.txt` 파일이 있는 폴더로 이동합니다.
2. `pip install -r requirements.txt`를 입력하여 종속성을 설치합니다.
3. 터미널에 `python main.py`를 입력합니다.

> [Pyinstaller](https://pypi.org/project/pyinstaller/)를 사용하여 스크립트를 컴파일하려면 다음 명령어를 실행하세요:  
`pyinstaller --noconfirm main.spec`

------------
만약 야ндекс 뮤직뿐만 아니라 다른 곳에서 음악을 듣는다면 `strong_find = True`를 `strong_find = False`로 변경하거나 시스템 트레이를 사용하시길 권장합니다. 그러면 검색 결과가 더 나아지지만 항상 정확하지는 않습니다.

## 버그
버그는 항상 존재하지만 먼저 찾아야 합니다 🫡  
버그를 발견하면 [Issues](https://github.com/FozerG/WinYandexMusicRPC/issues)에 알려주시기 바랍니다.
   
------------
이 프로젝트에 관심을 보여 주시면 가능한 한 업데이트를 진행할 수 있습니다.

>코드는 완벽하지 않습니다. Python이 주 언어가 아니며, 개인 용도로 작성되었기 때문입니다. 하지만 여러분의 스크립트 작성에 기초가 될 수 있습니다.

>[Yandex Music API](https://github.com/MarshalX/yandex-music-api)를 사용합니다.   


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-09-16

---