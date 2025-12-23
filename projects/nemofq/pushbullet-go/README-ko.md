# Pushbullet Go

[![Chrome Web Store Version](https://img.shields.io/chrome-web-store/v/dghndapbehjdbhiffbckojkhoennbofg)](https://chromewebstore.google.com/detail/push-go-for-pushbullet/dghndapbehjdbhiffbckojkhoennbofg) [![Chrome Web Store Users](https://img.shields.io/chrome-web-store/users/dghndapbehjdbhiffbckojkhoennbofg)](https://chromewebstore.google.com/detail/push-go-for-pushbullet/dghndapbehjdbhiffbckojkhoennbofg) [![Chrome Web Store Rating](https://img.shields.io/chrome-web-store/rating/dghndapbehjdbhiffbckojkhoennbofg)](https://chromewebstore.google.com/detail/push-go-for-pushbullet/dghndapbehjdbhiffbckojkhoennbofg)

> **참고 1**: Chrome 웹 스토어 정책으로 인해 확장 프로그램 이름이 "Push Go"로 변경되었습니다.
>
> **참고 2**: 이 확장 프로그램은 Pushbullet API를 위한 서드파티 오픈소스 클라이언트입니다. 해당 서비스와는 관련이 없으며 승인받지 않았습니다.

![Pushbullet Go](https://raw.githubusercontent.com/nemofq/pushbullet-go/main/screenshots/1_popup.png)

브라우저에서 바로 푸시를 수신하고 전송할 수 있는 가벼운 Pushbullet용 크롬 확장 프로그램입니다.

이 확장 프로그램은 Manifest V3와 호환되며, 더 이상 작동하지 않는 공식 확장의 대안입니다.

[![](https://developer.chrome.com/static/docs/webstore/branding/image/UV4C4ybeBTsZt43U4xis.png)](https://chromewebstore.google.com/detail/push-go-for-pushbullet/dghndapbehjdbhiffbckojkhoennbofg)

## 기능

[Pushbullet](https://www.pushbullet.com/) 계정이 필요합니다. 주요 기능은 다음과 같습니다:

- 푸시 수신 및 전송
- 붙여넣기, 드래그, 업로드로 파일/이미지 전송 (크롬 제한으로 인해 독립 창에서 실행)
- 현재 페이지 URL, 선택한 텍스트 또는 이미지의 컨텍스트 메뉴에서 기기/사람 선택 후 전송
- 전송할 기기 선택으로 푸시 대상 제어
- 링크 열기 및 닫기 버튼이 있는 수신 푸시 알림
- 수신한 링크를 새 탭에서 자동으로 열기 (기본 꺼짐, 옵션 페이지에서 활성화 가능)
- 최신 100개 푸시를 로컬에 저장 (전체 기록은 Pushbullet 웹사이트에서 확인 가능)
- (신규) 대상 기기별로 푸시 표시 및 알림 필터링
- (신규) 브라우저 소스 푸시 알림 제어 (다중 브라우저 사용 시 유용)
- (신규) 알림 미러링 (Pushbullet 안드로이드 앱 설치 및 안드로이드 앱과 Push Go 설정 모두에서 활성화 필요)
- (신규) 다크 모드 (기본적으로 시스템 설정 따름, 수동 선택 가능)
- (신규) 33개 언어 지원 i18n
- (신규) 읽지 않은 메시지 수 표시
- (신규) 팝업에서 현재 탭 링크 빠른 공유 (기본 꺼짐, 옵션 페이지에서 활성화 가능)
- (신규) 알림 시 사운드 재생 (옵션 페이지에서 비활성화 가능)
- (신규) 알림 미러링에 대한 종단 간 암호화
- (신규) 미러링된 알림에서 인증 코드 추출 (팝업에서 클릭하여 복사)

## 설치
> **참고 3**: Pushbullet WebSocket 서버와 연결 유지를 위해 `chrome.idle` API 사용이 필요한 Chrome 116 이상이 필요합니다.

### 권장 설치 방법

[Chrome 웹 스토어](https://chromewebstore.google.com/detail/push-go/dghndapbehjdbhiffbckojkhoennbofg)에서 직접 설치하거나:

### 수동 설치

1. `release/` 폴더에서 확장 프로그램을 다운로드하고 압축을 풉니다.
2. Chrome을 열고 `chrome://extensions/`로 이동합니다.
3. 오른쪽 상단에서 "개발자 모드"를 활성화합니다.
4. "압축 해제된 확장 프로그램 로드"를 클릭하고 압축을 푼 `/src` 폴더를 선택합니다.

## 설정

1. 확장 프로그램 아이콘을 클릭하고 "설정 열기"를 선택합니다.
2. OAuth 인증을 통해 또는 수동으로 액세스 토큰을 입력합니다 ([Pushbullet 설정](https://www.pushbullet.com/#settings/account)에서).
3. 검색 버튼을 클릭하고 푸시 전송 및 수신을 시작합니다!
4. 필요에 따라 옵션 페이지에서 설정을 사용자화합니다.

## 권한

이 확장 프로그램은 다음 권한을 필요로 합니다:
- **저장소**: 옵션과 푸시 기록을 로컬에 저장하기 위해
- **유휴 상태**: 실시간 푸시 수신을 위한 연결을 유지하기 위해
- **알림**: 푸시 알림을 표시하기 위해
- **컨텍스트 메뉴**: 콘텐츠 푸시를 위한 우클릭 메뉴 옵션을 추가하기 위해
- **활성 탭**: 컨텍스트 메뉴 및 단축키 작업을 위해 현재 페이지의 URL과 제목에 접근하기 위해
- **호스트 접근**: Pushbullet API 서버와 통신하기 위해
- **오프스크린**: 알림 소리를 재생하기 위해
- **신원**: OAuth 프로세스를 완료하기 위해

## 개인정보

이 확장 프로그램은 모든 데이터를 로컬에 저장하며 Pushbullet의 API 외에는 어떠한 정보도 전송하지 않습니다.

## 라이선스

이 프로젝트는 [AGPL-3.0 라이선스](https://github.com/nemofq/pushbullet-go?tab=AGPL-3.0-1-ov-file)를 사용합니다. 기능 요청이나 피드백이 있으면 이슈 또는 풀 리퀘스트를 자유롭게 생성하세요.

## 한 가지 더
iOS+Pushbullet 사용자라면, 다음 단축어들이 유용할 수 있습니다:

- [Push to Pushbullet](https://www.icloud.com/shortcuts/5549bbb5b06e4f0a8ccb1b6fd33e853f)
- [Pushbullet Receiver](https://www.icloud.com/shortcuts/1f94913de21b41debe60ef43631afde2)



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-12-23

---