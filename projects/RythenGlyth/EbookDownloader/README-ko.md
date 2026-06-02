# EbookDownloader
다양한 출판사에서 구매한 전자책을 다운로드하는 도구입니다.

![Preview](https://raw.githubusercontent.com/RythenGlyth/EbookDownloader/master/preview.png)

## 목차
- [지원 출판사 (웹사이트)](#supported-publishers-websites)
- [자동 설치](#automatic-installation)
- [수동 설치](#manual-installation)
- [실행 방법](#running)
- [자격 증명 저장](#saving-credentials-to-avoid-entering-them-every-time-optional)
- [Bildungslogin (Cornelsen / Westermann)](#bildungslogin)

## 지원 출판사 (웹사이트)
| 출판사 | 웹사이트 | 최고 품질 | 선택 가능한 텍스트 | 하이퍼링크 | 비고 |
| --- | --- | --- | --- | --- | --- |
| Cornelsen ("신 방식") | cornelsen.de | 무손실 PDF | &check; | &check; |  |
| Cornelsen ("구 방식") | cornelsen.de | 이미지 (8617px x 11792px) 조합 | &check; | &cross; |  |
| Cornelsen.CH | ebooks.cornelsen.ch | 무손실 PDF | &check; | &cross; |  |
| Cornelsen | scook.de | 이미지 (?) 조합 | &cross; | &cross; | |
| Allango Klett | allango.net | 무손실 PDF | &check; | ? | [1] |
| Klett | klett.de | 이미지 (3072px x 4096px) 조합 | &check; | &check; | |
| Westermann | westermann.de | 이미지 (2244px x 3071px) 조합 | &check; | &cross; | |
| C.C.BUCHNER | click-and-study.de | 이미지 (1658px x 2211px) 조합 | &check; | &cross; | |
| C.C.BUCHNER | click-and-teach.de | 이미지 (1658px x 2211px) 조합 | &check; | &cross; | |
| Book2Look | book2look.com | 무손실 PDF | &check; | ? | [2] |
| kiosquemag | kiosquemag.com | 이미지 (?) 조합 | &cross; | &cross; | |
| Helbling Media App | helbling.com | 무손실 PDF | &check; | &cross; | |

[1]: 웹사이트에서 소유하지 않은 파일도 다운로드 가능

[2]: 계정 필요 없음, 책 ID만 필요

## 자동 설치
먼저, 저장소를 클론하거나 다운로드하세요.

이 도구는 이미지 처리 라이브러리를 사용하며 nodejs로 실행해야 하므로 몇 가지 의존성이 필요합니다.

설치 스크립트(`init.bat` 윈도우용, `init.sh` 데비안 계열용)를 사용하거나 수동 설치를 할 수 있습니다. 설치 스크립트는 모든 의존성을 자동으로 다운로드합니다. 실행하려면 윈도우에서는 `.bat` 파일을 더블 클릭하고, 리눅스에서는 `.sh` 파일에 실행 권한을 부여한 뒤 터미널에서 실행하세요.

## 수동 설치
먼저, 저장소를 클론하거나 다운로드하세요. 그런 다음 아래 OS별 지침을 따르세요:

### 윈도우
1. http://www.unifoundry.com/pub/unifont/unifont-15.0.01/font-builds/unifont-15.0.01.ttf 에서 `unifont-15.0.01.ttf`를 다운로드하여 프로젝트 루트에 넣으세요
1. `ffmpeg`를 설치하고 ffmpeg 실행 파일(이름은 `ffmpeg`)을 프로젝트 루트에 넣거나 경로 환경 변수에 추가하세요. 도움이 필요하면 [이곳](https://phoenixnap.com/kb/ffmpeg-windows) 튜토리얼을 참고할 수 있습니다
1. `mutool`을 설치하고 mutool 실행 파일(이름은 `mutool`)을 프로젝트 루트에 넣거나 경로 환경 변수에 추가하세요. 최신 빌드는 [여기](https://mupdf.com/releases)에서 찾을 수 있습니다. `windows` 릴리스를 검색하세요. (book2look 및 cornelsen.ch에만 필요)
1. `nodejs`와 `npm`을 설치하지 않았다면 설치하세요. 도움말은 [여기](https://phoenixnap.com/kb/install-node-js-npm-on-windows)를 참고하세요
1. `npm install`을 실행하세요
1. 선택적으로 `image magick`을 설치하고 magick 실행 파일(이름은 `magick`)을 프로젝트 루트에 넣거나 경로 환경 변수에 추가하세요 (cornelsen "구 방식"에만 필요)

### 리눅스
1. `wget "http://www.unifoundry.com/pub/unifont/unifont-15.0.01/font-builds/unifont-15.0.01.ttf"`를 실행하세요
1. `ffmpeg`, `nodejs`, `mutool`/`mupdf-tools`/`mupdf` (book2look 및 cornelsen.ch에 필요)와 선택적으로 `imagemagick` (cornelsen "구 방식"에만 필요)을 좋아하는 패키지 관리자으로 설치하세요
1. `npm install`을 실행하세요

### Nix가 설치된 Linux/Darwin
- nix-direnv가 있다면 `direnv allow`를 실행하여 모든 의존성을 획득하세요
- 그렇지 않으면 `nix-shell`을 실행하세요
- `wget "http://www.unifoundry.com/pub/unifont/unifont-15.0.01/font-builds/unifont-15.0.01.ttf"`를 실행하세요

## 실행
프로젝트 디렉터리에서 `npm install`을 실행하여 설정을 완료하고,
프로젝트 디렉터리에서 `npm start`를 실행하여 프로그램을 시작하세요.

## 매번 입력하지 않도록 자격 증명 저장 (선택 사항)
프로그램을 시작할 때마다 자격 증명을 입력하지 않도록 `config.json` 파일에 저장할 수 있습니다. 이를 위해 프로젝트 루트에 `config.json`이라는 파일을 생성하고 다음 내용을 추가하세요:

```json
{
    "[PUBLISHER]": {
        "email": "[YOUR_USERNAME_OR_EMAIL]", 
        "passwd": "[YOUR_PASSWORD]"
    },
    "[PUBLISHER]": {
        "email": "[YOUR_USERNAME_OR_EMAIL]", 
        "passwd": "[YOUR_PASSWORD]"
    }
    [...]
}
```

Replace all the square brackets with your data. Publisher keys are: `cornelsen`, `klett`, `allango`, `scook`, `westermann`, `clicknstudy`, `clicknteach`, `kiosquemag`, `cornelsench`, `book2look`, `helbling`

## Bildungslogin

Cornelsen, Click-n-Study, Klett, and Westermann은 Bildungslogin 계정을 사용한 토큰 로그인 지원을 제공합니다.

### Cornelsen

1. Bildungslogin을 열고 로그인하세요
1. 저장소 개발자 도구로 이동하세요 (SHIFT+F9, 또는 CTRL+SHIFT+I를 누른 후 Storage 탭 클릭).
1. 책을 엽니다
1. 개발자 도구에서 Local storage를 선택하세요 (필요시 해당 웹사이트도 선택).
1. 열리는 표에서 아래로 스크롤하여 `id_token`을 찾으세요. 긴 영숫자 문자열이어야 합니다.
1. 복사하세요. (더블 클릭 후 ctrl+c)
1. 비밀번호로 사용하고, 사용자 이름은 `token`으로 사용하세요.

### Click-and-Study

1. Bildungslogin을 열고 로그인하세요
1. 책을 엽니다
1. 저장소 개발자 도구로 이동하세요 (SHIFT+F9, 또는 CTRL+SHIFT+I를 누른 후 Storage 탭 클릭).
1. 개발자 도구에서 Cookies를 선택하세요 (필요시 해당 웹사이트도 선택).
1. 열리는 표에서 아래로 스크롤하여 `CASSID`를 찾으세요. 이후에 영숫자 문자열이 있습니다.
1. 그것을 복사하세요 (무작위 문자처럼 보이는 것). (더블 클릭 후 ctrl+c)
1. 비밀번호로 사용하고, 사용자 이름은 `token`으로 사용하세요.

### Klett

1. Bildungslogin을 열고 로그인하세요
1. 책을 엽니다
1. 저장소 개발자 도구로 이동하세요 (SHIFT+F9, 또는 CTRL+SHIFT+I를 누른 후 Storage 탭 클릭).
1. 개발자 도구에서 Cookies를 선택하세요 (필요시 해당 웹사이트도 선택).
1. 열리는 표에서 아래로 스크롤하여 `SESSION`을 찾으세요. 이후에 영숫자 문자열이 있습니다.
1. 그것을 복사하세요 (무작위 문자처럼 보이는 것). (더블 클릭 후 ctrl+c)
1. 비밀번호로 사용하고, 사용자 이름은 **현재 보고 있는 책 뷰어의 URL**을 사용하세요.

### Westermann

1. Bildungslogin을 열고 로그인하세요
1. 책을 엽니다  
1. 네트워킹 개발자 도구로 들어갑니다 (CTRL+SHIFT+E, 또는 대안으로 CTRL+SHIFT+I를 누른 후 네트워크 탭 클릭).  
1. `Persist logs`를 체크합니다 (기어 메뉴, 아마도 우측 상단 어딘가에 있음)  
1. 페이지를 새로고침합니다  
1. 개발자 도구의 "Filter URLs" 필드에 `/api/user`를 입력합니다  
1. OPTIONS가 아닌 첫 번째 항목을 클릭합니다  
1. 옆에 작은 창이 열립니다. 그 창의 Headers 탭을 클릭합니다  
1. "Filter headers" 필드에 `auth`를 입력합니다 (가능한 경우)  
1. 긴 문자와 숫자 문자열이 나올 때까지 스크롤합니다  
1. 그것을 복사하여 텍스트 문서에 붙여넣습니다  
1. 다시 텍스트 문서에서 복사하되, "Authorization: Bearer " 부분은 선택하지 말고 마지막 긴 문자열만 선택합니다.  
1. 비밀번호로 사용하고, 사용자 이름은 `token`으로 사용합니다.  

## 기여하기  

프로젝트에 기여하고자 한다면 이슈와 풀 리퀘스트를 자유롭게 생성하세요.  

## 면책 조항  
이 프로젝트는 교육 목적으로만 사용됩니다. 이 소프트웨어의 오용에 대해 프로젝트는 책임지지 않습니다. 관할 구역에 따라 출판사의 동의 없이 전자책을 다운로드하는 것은 불법일 수 있습니다. 다른 관할 구역에서는 개인 용도로만 전자책 다운로드가 합법일 수 있습니다. 이 소프트웨어 사용 전에 현지 법률을 확인하시기 바랍니다.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-06-02

---