<img src="https://raw.githubusercontent.com/obsidianforensics/hindsight/main/./pyhindsight/static/h.png" height="100px"/> Hindsight
=========

Google Chrome/Chromium 인터넷 기록 포렌식

Hindsight는 웹 아티팩트를 분석하기 위한 무료 도구입니다. Google Chrome 웹 브라우저의 방문 기록에서 시작하여 다른 Chromium 기반 애플리케이션도 지원하도록 확장되었습니다(더 많은 지원 예정!). Hindsight는 URL, 다운로드 기록, 캐시 기록, 북마크, 자동 완성 기록, 저장된 비밀번호, 환경설정, 브라우저 확장 프로그램, HTTP 쿠키 및 로컬 저장소 기록(HTML5 쿠키) 등 여러 종류의 웹 아티팩트를 파싱할 수 있습니다. 각 파일에서 데이터를 추출한 후, 다른 기록 파일의 데이터와 연관시켜 타임라인에 배치합니다.

간단한 웹 UI를 제공합니다 - 시작하려면 "hindsight_gui.py"를 실행하거나(Windows에서는 패키지된 "hindsight_gui.exe") 브라우저에서 http://localhost:8080 을 방문하세요:  

<img src="https://raw.githubusercontent.com/obsidianforensics/hindsight/main/documentation/interface-v2.gif"/>

필수로 입력해야 하는 필드는 "Profile Path"뿐입니다. 이곳에 분석할 Chrome 프로필 경로를 입력하세요(운영체제별 기본 프로필 경로는 이 페이지 하단에 나와 있습니다). "Run"을 클릭하면 결과 페이지로 이동하며, 결과를 스프레드시트(또는 기타 형식)로 저장할 수 있습니다.

## 수동 설치

Hindsight(명령어 도구 및 웹 인터페이스 모두)를 설치하려면 다음을 실행하세요:
```sh
pip install pyhindsight
pip install git+https://github.com/cclgroupltd/ccl_chromium_reader.git
```
<translate-content>
Hindsight 웹 인터페이스에서 "브라우저에서 SQLite DB 보기" 기능을 사용하려면, 다음 설치 명령을 추가로 실행해야 합니다:  
</translate-content>
```sh
curl -sSL https://raw.githubusercontent.com/obsidianforensics/hindsight/master/install-js.sh | sh
```
## 명령 줄

Hindsight에는 명령 줄 버전도 있습니다 - hindsight.py 또는 hindsight.exe. 문서 폴더의 사용자 가이드는 많은 주제를 다루고 있지만, 아래 정보가 명령 줄 버전을 시작하는 데 도움이 될 것입니다:

사용 예:  \> C:\\hindsight.py -i "C:\Users\Ryan\AppData\Local\Google\Chrome\User Data\Default" -o test_case

명령 줄 옵션:

| 옵션           | 설명                                                    |
| -------------- | ------------------------------------------------------- |
| -i 또는 --input  | Chrome(ium) "Default" 디렉터리 경로                     |
| -o 또는 --output | 출력 파일 이름 (확장자 제외)                            |
| -f 또는 --format | 출력 형식 (기본값은 XLSX, 다른 옵션은 SQLite 및 JSONL)  |
| -c 또는 --cache  | 캐시 디렉터리 경로; 디렉터리가 지정된 "input" 디렉터리 외부에 있을 때만 필요합니다. Mac 시스템은 기본적으로 이렇게 설정되어 있습니다. |
| -b 또는 --browser_type | 입력 파일이 속한 브라우저 유형. 지원되는 옵션은 Chrome(기본값)과 Brave입니다. |
| -l 또는 --log	 | Hindsight가 로그를 기록할 위치 (존재하면 추가 기록)        |
| -h 또는 --help   | 이 옵션들과 기본 Chrome 데이터 위치를 표시합니다          |
| -t 또는 --timezone | XLSX 출력에서 타임스탬프에 대한 시간대 표시              |

## 기본 프로필 경로

Chrome 기본 프로필 폴더 기본 위치는 다음과 같습니다:
* WinXP:   \[userdir\]\Local Settings\Application Data\Google\Chrome\User Data\Default
* Vista/7/8/10: \[userdir\]\AppData\Local\Google\Chrome\User Data\Default
* Linux:   \[userdir\]/.config/google-chrome/Default
* OS X:    \[userdir\]/Library/Application Support/Google/Chrome/Default
* iOS:   \Applications\com.google.chrome.ios\Library\Application Support\Google\Chrome\Default
* Android: /userdata/data/com.android.chrome/app_chrome/Default
* CrOS: \home\user\\<GUID\>

## 기능 요청

새로운 기능에 대한 아이디어가 있거나 문제가 발견되면 [이슈 등록](https://github.com/obsidianforensics/hindsight/issues/new/choose) 부탁드립니다.



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-20

---