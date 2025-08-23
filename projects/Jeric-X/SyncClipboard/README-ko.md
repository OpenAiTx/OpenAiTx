# SyncClipboard
[![build](https://github.com/Jeric-X/SyncClipboard/actions/workflows/build-entry.yml/badge.svg?branch=master)](https://github.com/Jeric-X/SyncClipboard/actions?query=branch%3Amaster)

中文 | [English](https://raw.githubusercontent.com/Jeric-X/SyncClipboard/master/docs/README_EN.md)  

<details>
<summary>목차</summary>

- [SyncClipboard](#syncclipboard)
  - [기능](#功能)
  - [서버](#服务器)
    - [독립 서버](#独立服务器)
      - [서버 구성](#服务器配置)
      - [Docker](#docker)
      - [Arch Linux](#arch-linux)
    - [클라이언트 내장 서버](#客户端内置服务器)
    - [WebDAV 서버](#webdav服务器)
  - [클라이언트](#客户端)
    - [Windows](#windows)
      - [설치 불필요 버전](#免安装板)
      - [문제 해결](#故常排除)
    - [macOS](#macos)
      - [수동 설치](#手动安装)
      - [문제 해결](#故常排除-1)
    - [Linux](#linux)
      - [수동 설치](#手动安装-1)
      - [Arch Linux](#arch-linux-1)
      - [문제 해결](#故常排除-2)
    - [데스크탑 클라이언트 명령행 인자](#桌面客户端命令行参数)
      - [--shutdown-previous](#--shutdown-previous)
      - [--command-{command-name}](#--command-command-name)
    - [IOS](#ios)
      - [단축어 사용](#使用快捷指令)
    - [Android](#android)
      - [HTTP Request Shortcuts 사용](#使用http-request-shortcuts)
      - [Autox.js 사용](#使用autoxjs)
      - [SmsForwarder 사용](#使用smsforwarder)
      - [Tasker 사용](#使用tasker)
    - [클라이언트 구성 설명](#客户端配置说明)
  - [API](#api)
    - [클립보드 가져오기/업로드(텍스트)](#获取上传剪贴板文字)
    - [클립보드 가져오기/업로드(이미지/파일)](#获取上传剪贴板图片文件)
    - [SyncClipboard.json](#syncclipboardjson)
  - [프로젝트 의존성](#项目依赖)

</details>

## 기능

- 클립보드 동기화, 텍스트, 이미지, 파일 지원. 서버/클라이언트 구조로 클라이언트 내장 서버, 독립 배포 서버 사용 가능하며, WebDAV 지원 클라우드 드라이브도 서버로 사용 가능  
- 이미지 형식 클립보드 최적화 기능:
  - 임의 위치에서 이미지 복사 시, 파일 시스템에 직접 이미지 파일 붙여넣기 가능하며 반대도 가능
  - 브라우저에서 이미지 복사 후 백그라운드에서 원본 이미지 로컬 다운로드, 브라우저에서 동적 이미지 복사 불가 문제 해결(대부분 사이트 인증 필요, 적용 범위 제한, bilibili 동적 이미지 지원)
  - 파일 시스템에서 최신 포맷 이미지 파일(webp/heic 등) 복사 시 클립보드에 gif 또는 jpg 형식 저장, 이미지 지원 텍스트 박스에 직접 이미지 붙여넣기 용이

## 서버
### 독립 서버
[SyncClipboard.Server](https://github.com/Jeric-X/SyncClipboard/releases/)는 크로스 플랫폼 실행 지원, [ASP.NET Core 8.0](https://dotnet.microsoft.com/zh-cn/download/dotnet/8.0)에 의존하며, `ASP.NET Core 런타임` 설치 후 다음 명령어로 실행
```
dotnet /path/to/SyncClipboard.Server.dll --contentRoot ./
```
작업 디렉터리는 dll이 위치한 디렉터리와 동일하며, 쓰기 권한이 필요합니다. 작업 디렉터리를 변경하려면 `appsettings.json` 파일을 새 작업 디렉터리에 복사하고 `--contentRoot` 뒤의 경로를 수정하세요  

#### 서버 구성
서버는 `appsettings.json` 파일을 통해 구성되며, 형식은 다음과 같습니다:
```jsonc
{
  "Logging": {
    "LogLevel": {
      "Default": "Information",
      "Microsoft.AspNetCore": "Warning"
    }
  },
  "AllowedHosts": "*",
  "Kestrel": {
    "Endpoints": {
      "http": {
        "Url": "http://*:5033"
      },
      //"https": {
      //  "Url": "https://*:5033"
      //}
    },
    //"Certificates": {
    //  "Default": {
    //    "Path": "/path/to/pem",
    //    "KeyPath": "/path/to/pem_key"
    //  }
    //}
  },
  "AppSettings": {
    "UserName": "your_username",
    "Password": "your_password"
  }
}
```
HTTPS를 사용하려면 `https` 및 `Certificates` 부분의 주석을 해제하고 HTTPS 인증서 경로를 설정하십시오. 마지막으로 `http` 부분을 주석 처리하거나 삭제하여 안전하지 않은 연결을 차단하십시오. HTTP와 HTTPS를 동시에 사용하려면 두 `Url`을 서로 다른 포트 번호로 설정하십시오.  
다양한 인증서 유형 구성 방법은 [마이크로소프트 공식 문서](https://learn.microsoft.com/en-us/aspnet/core/fundamentals/servers/kestrel/endpoints?view=aspnetcore-8.0#configure-https-in-appsettingsjson)를 참고할 수 있습니다.

사용자 이름과 비밀번호는 환경 변수를 사용하여 구성할 수 있으며, 환경 변수 `SYNCCLIPBOARD_USERNAME`, `SYNCCLIPBOARD_PASSWORD`가 모두 비어 있지 않은 경우 이 두 환경 변수를 우선적으로 사용자 이름과 비밀번호로 사용합니다.  

환경 변수 `ASPNETCORE_hostBuilder__reloadConfigOnChange`는 appsettings.json 변경을 자동으로 감지하고 구성을 다시 로드할지 여부를 설정하는 데 사용되며, 기본값은 `false`입니다. 이 값을 `false`가 아닌 값으로 변경하면 이 기능이 활성화됩니다.

> [!WARNING]  
> HTTP는 평문 전송을 사용하므로, 공용 네트워크에 서버를 배포할 때는 HTTPS를 활성화하거나 리버스 프록시 도구를 사용하여 HTTPS를 구성하십시오. 인증 기관에서 인증서를 받을 수 없는 경우 오픈 소스 도구 [mkcert](https://github.com/FiloSottile/mkcert) 또는 기타 방법을 사용하여 자체 서명 인증서를 생성하는 것을 권장합니다.

#### Docker

```shell
# docker
docker run -d \
  --name=syncclipboard-server \
  -p 5033:5033 \
  -e SYNCCLIPBOARD_USERNAME=your_username \
  -e SYNCCLIPBOARD_PASSWORD=your_password \
  --restart unless-stopped \
  jericx/syncclipboard-server:latest

# docker compose
curl -sL https://github.com/Jeric-X/SyncClipboard/raw/master/src/SyncClipboard.Server/docker-compose.yml
docker compose up -d
```
HTTPS를 구성하려면 `appsettings.json`과 인증서 파일을 직접 매핑해야 하며, `appsettings.json`의 컨테이너 내 경로는 `/app/appsettings.json`입니다.

#### Arch Linux

[AUR](https://aur.archlinux.org/packages/syncclipboard-server)에서 직접 설치할 수 있습니다 ([@devome](https://github.com/devome) 유지 관리):

```shell
paru -Sy syncclipboard-server
```

설정 파일 경로는 `/etc/syncclipboard/appsettings.json`이며, 설정을 변경한 후 `systemctl` 명령어로 시작하면 됩니다:

```shell
sudo systemctl enable --now syncclipboard.service
```
### 클라이언트 내장 서버

데스크톱 클라이언트(Windows/Linux/macOS)는 서버 기능이 내장되어 있으며, 시각적 인터페이스를 사용해 설정할 수 있습니다.

### WebDAV 서버
WebDAV 프로토콜을 지원하는 클라우드 드라이브를 서버로 사용할 수 있습니다.  
테스트된 서버:   

- [x] [Nextcloud](https://nextcloud.com/) 
- [x] [AList](https://alist.nn.ci/)
- [x] [InfiniCLOUD](https://infini-cloud.net/en/)
- [x] [aliyundrive-webdav](https://github.com/messense/aliyundrive-webdav)

## 클라이언트

데스크톱 클라이언트(Windows/Linux/macOS)는 백그라운드에서 실행 중일 때 클립보드를 자동으로 동기화합니다.
<details>
<summary>스크린샷 펼치기/접기</summary>

![](https://raw.githubusercontent.com/Jeric-X/SyncClipboard/master/docs/image/WinUI.png)

</details>

### Windows
#### 설치 불필요 버전

[Release](https://github.com/Jeric-X/SyncClipboard/releases/latest) 페이지에서 이름이 `SyncClipboard_win_`로 시작하는 zip 파일을 다운로드한 후, 압축을 풀고 `SyncClipboard.exe`를 실행하세요.

#### 자주 발생하는 문제
- 지원하는 최소 시스템 버전은 Windows 10 2004입니다.
- Windows 10에서 SyncClipboard를 실행할 때 인터페이스 아이콘이 광범위하게 깨지는 경우, 마이크로소프트의 [Segoe Fluent Icons](https://aka.ms/SegoeFluentIcons) 아이콘 폰트를 설치하세요.

### macOS
#### 수동 설치
[Release](https://github.com/Jeric-X/SyncClipboard/releases/latest) 페이지에서 이름이 `SyncClipboard_macos_`로 시작하는 설치 패키지를 다운로드한 후, 더블 클릭하여 SyncClipboard 아이콘을 Applications 폴더로 드래그하세요.

#### 자주 발생하는 문제
- 시스템에서 `개발자를 확인할 수 없으므로 “SyncClipboard”를 열 수 없습니다`라는 메시지가 표시될 경우:  
macOS의 `설정` -> `개인 정보 및 보안` 페이지에서 `그래도 열기`를 클릭하세요.

- 시스템 메시지 `“SyncClipboard”가 손상되어 열 수 없습니다`가 표시될 경우: 터미널에서 `sudo xattr -d com.apple.quarantine /Applications/SyncClipboard.app` 명령 실행
- 단축키는 보조 기능 권한에 의존하며, 소프트웨어가 필요할 때 권한 요청 팝업을 표시함

### Linux
#### 수동 설치
[Release](https://github.com/Jeric-X/SyncClipboard/releases/latest) 페이지에서 `SyncClipboard_linux_`로 시작하는 설치 패키지 다운로드

#### Arch Linux

Arch Linux 사용자는 [AUR](https://aur.archlinux.org/packages/syncclipboard-desktop)에서 직접 설치 가능(유지 관리자: [@devome](https://github.com/devome)):

```shell
paru -Sy syncclipboard-desktop
```
설치 후 메뉴에서 실행하면 됩니다. 명령줄에서 `syncclipboard-desktop` 명령어로 실행 시 오류가 발생하면 환경 변수 `LANG`을 `en_US.UTF-8`로 설정하여 `LANG=en_US.UTF-8 syncclipboard-desktop`로 실행하세요.

#### 문제 해결
- 클립보드 동기화가 지연되거나 동기화 불가, 업로드 시 깨짐 현상: 시스템에 `xclip`(X11) 또는 `wl-clipboard`(Wayland)를 설치하는 것을 권장합니다. SyncClipboard는 안정성 강화를 위해 이 도구들을 사용하여 클립보드를 보조적으로 가져옵니다. `xclip -version` 또는 `wl-paste -version` 명령어로 설치 여부를 확인하세요.
- `deb`, `rpm` 패키지 사용 시 업그레이드 실패하면 구버전을 삭제 후 신버전 설치
- `AppImage` 패키지 사용 시 AppImage 파일에 실행 권한이 있는지 확인
- Wayland 환경에서는 단축키가 작동하지 않을 수 있음
- 언어를 자동 인식하지 못하면 기본 영어로 설정되며, 실행 후 SyncClipboard 설정에서 변경 가능

> [!NOTE]  
> SyncClipboard를 완전히 삭제하려면 설정 파일과 임시 파일 디렉토리를 수동으로 삭제하세요:  
> `%AppData%\SyncClipboard\`(Windows), `~/Library/Application Support/SyncClipboard/`(macOS), `~/.config/SyncClipboard/`(Linux)

### 데스크톱 클라이언트 명령줄 인자

#### --shutdown-previous
이미 실행 중인 SyncClipboard를 종료하고 새 인스턴스를 실행

#### --command-{command-name}
지정한 명령 실행, `{command-name}`은 명령 이름이며 단축키 설정 후 구성 파일에서 명령 이름을 확인할 수 있습니다. 단축키 구성을 삭제해도 명령줄 인자는 유효합니다.  
이미 실행 중인 SyncClipboard가 있으면 새 인스턴스를 시작하지 않고 실행 중인 SyncClipboard에 명령을 호출합니다. 실행 중인 SyncClipboard가 없으면 실행 완료 직후 명령을 실행합니다.  
여러 개의 `--command-{command-name}` 인자를 지원하며 여러 명령을 동시에 실행할 수 있습니다.

> [!NOTE]  
> macOS에서 명령줄 인자를 사용할 때는 실행 파일의 전체 경로 `/Applications/SyncClipboard.app/Contents/MacOS/SyncClipboard.Desktop.MacOS`를 사용하세요.

### IOS 
#### [단축어](https://apps.apple.com/cn/app/%E5%BF%AB%E6%8D%B7%E6%8C%87%E4%BB%A4/id1462947752) 사용

- 수동 동기화: 이 [단축어](https://www.icloud.com/shortcuts/d1b9e49556e04c2ca290590294afbd99)를 가져와 수동으로 업로드 또는 다운로드 트리거
- 자동 동기화: 이 [단축어](https://www.icloud.com/shortcuts/1ced32f011bc4d3498dca9960dc2c0d5)를 가져와 실행하면 장치가 백그라운드에서 자동으로 클립보드를 동기화합니다. 이 단축어는 무한 실행되므로 수동으로 종료해야 하며, 동기화 후 시스템 알림 전송 여부와 조회 간격(초)을 수동으로 조정할 수 있습니다.
- 자동 문자 인증 코드 업로드: 이 게시물 내 동영상 튜토리얼 참고 https://github.com/Jeric-X/SyncClipboard/discussions/60

### Android
#### [HTTP Request Shortcuts](https://github.com/Waboodoo/HTTP-Shortcuts) 사용
이 [설정 파일](/script/shortcuts.zip)을 가져와 `변수` 내 `UserName`, `UserToken`, `url`을 수정하세요. `url`은 슬래시 구분자 `/`로 끝나지 않아야 합니다. `HTTP Request Shortcuts`는 드롭다운 메뉴, 위젯, 바탕화면 아이콘, 공유 메뉴에서 사용할 수 있습니다.

<details>
<summary>설정 파일 가져온 후 설정 수정 화면</summary>

![](https://raw.githubusercontent.com/Jeric-X/SyncClipboard/master/docs/image/android1.jpg)
![](https://raw.githubusercontent.com/Jeric-X/SyncClipboard/master/docs/image/android2.jpg)
![](https://raw.githubusercontent.com/Jeric-X/SyncClipboard/master/docs/image/android3.jpg)

</details>

#### [Autox.js](https://github.com/kkevsekk1/AutoX) 사용

- 자동 동기화, 이 [js 파일](/script/SyncAutoxJs.js)을 사용합니다. 안드로이드 시스템 제한으로 인해, 안드로이드 10 이상 버전에서는 앱이 백그라운드에서 클립보드를 읽을 수 없지만, 루트 권한 기반 도구(Magisk/Xposed)를 사용하여 앱의 백그라운드 클립보드 읽기 권한을 해제할 수 있습니다. 예를 들어 [Riru-ClipboardWhitelist](https://github.com/Kr328/Riru-ClipboardWhitelist), [Clipboard Whitelist](https://modules.lsposed.org/module/io.github.tehcneko.clipboardwhitelist) 등이 있습니다. 또한 안드로이드 13 이상에서는 앱이 시스템 로그(클립보드)에 접근하려면 사용자가 수동으로 권한을 부여해야 하므로, Xposed를 사용해 앱에 시스템 로그 접근 권한을 자동으로 부여할 수 있습니다. 예: [DisableLogRequest/로그 접근 요청 비활성화](https://github.com/QueallyTech/DisableLogRequest)
- 자동으로 인증 코드를 업로드하려면 이 [js 파일](/script/UploadVerificationCode.js)을 사용하세요. 이 스크립트는 백그라운드에서 실행되며 모든 알림 메시지를 읽어 인증 코드 관련 정보를 인식하면 코드를 서버에 업로드합니다.

js 파일을 가져오고 각 파일 상단의 사용자 설정을 수정한 후 수동으로 실행하거나, 각 js 파일에 대해 트리거 방식을 설정할 수 있습니다. 예: 부팅 시 트리거

#### [SmsForwarder](https://github.com/pppscn/SmsForwarder) 사용

- 자동 인증 코드 업로드, https://github.com/Jeric-X/SyncClipboard/discussions/109

#### [Tasker](https://tasker.joaoapps.com/) 사용

- https://github.com/forrestgao/taskerforSyncClipboard, 제작자: [forrestgao](https://github.com/forrestgao)

Tasker는 안드로이드 시스템에서 매우 강력한 자동화 도구입니다. SyncClipboard API를 기반으로 자신만의 구성 파일을 만들 수 있으며, 만약 당신의 구성 파일이 매우 범용적이고 공유하고 싶다면 언제든지 연락하여 이곳에 올릴 수 있습니다.


### 클라이언트 구성 설명

모든 플랫폼은 세 가지 필수 구성을 필요로 합니다(구성명 철자가 다를 수 있으나 의미는 동일).
- user
- password
- url, 형식은 http(s)://ip(또는 도메인):포트입니다. WebDav 서버를 사용할 경우, url은 반드시 존재하는 폴더로 지정하여 작업 디렉터리로 사용해야 합니다. 예: `https://domain.com/dav/folder1/working%20folder` 특수 문자는 url 인코딩 문자로 대체해야 하며, 이 폴더에는 다른 파일을 저장하지 마십시오. 데스크톱 클라이언트(Windows/Linux/macOS)를 사용하지 않는 경우 작업 디렉터리 내에 `file` 폴더를 추가로 생성해야 파일 동기화가 가능합니다. 데스크톱 클라이언트는 서버 설정 시 자동으로 `file` 폴더를 생성합니다. url은 가능한 한 슬래시 구분자 `/`로 끝나지 않도록 하세요. 일부 클라이언트에서 문제가 발생할 수 있습니다.

## API

API는 WebDAV 기반이며, 독립 서버 실행 환경에서 환경 변수 ASPNETCORE_ENVIRONMENT를 Development로 설정 후 서버를 실행하거나, 데스크톱 클라이언트에서 서버를 열고 설정에서 진단 모드를 활성화한 후,
`http://ip:포트/swagger/index.html`에 접속하면 API 페이지를 열 수 있습니다. 다음은 일부 주요 API입니다.

### 클립보드(텍스트) 가져오기/업로드하기

```
GET /SyncClipboard.json
PUT /SyncClipboard.json
```

### 클립보드 가져오기/업로드(이미지/파일)
```
GET  /SyncClipboard.json
HEAD /file/filename         // optional
GET  /file/filename

PUT /file/filename
PUT /SyncClipboard.json
```

### SyncClipboard.json
```
{
    "Type" : "Text"
    "Clipboard" : "Content",
    "File":""
}

{
    "Type": "Image", // or "File", "Group"
    "Clipboard": "hash, optional",
    "File": "filename"
}
```

## 项目依赖
[NativeNotification](https://github.com/Jeric-X/NativeNotification)  
[Magick.NET](https://github.com/dlemstra/Magick.NET)  
[.NET Community Toolkit](https://github.com/CommunityToolkit/dotnet)  
[H.NotifyIcon](https://github.com/HavenDV/H.NotifyIcon)  
[WinUIEx](https://github.com/dotMorten/WinUIEx)  
[moq](https://github.com/moq/moq)  
[Avalonia](https://avaloniaui.net/)  
[FluentAvalonia.BreadcrumbBar](https://github.com/indigo-san/FluentAvalonia.BreadcrumbBar)  
[FluentAvalonia](https://github.com/amwx/FluentAvalonia)  
[Vanara](https://github.com/dahall/Vanara)  
[Tmds.DBus](https://github.com/tmds/Tmds.DBus)  
[SharpHook](https://github.com/TolikPylypchuk/SharpHook)  
[DotNetZip.Semverd](https://github.com/haf/DotNetZip.Semverd)  
[Quartz.NET](https://github.com/quartznet/quartznet)  
[MiSans](https://hyperos.mi.com/font)

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-23

---