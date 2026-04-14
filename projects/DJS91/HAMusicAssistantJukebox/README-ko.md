# <img src="https://raw.githubusercontent.com/DJS91/HAMusicAssistantJukebox/main/logo.png" width="25" height="25"> Music Assistant Jukebox 통합 (지원 중단)

## 공지: 이 통합은 더 이상 적극적으로 유지 관리되지 않습니다.

Music Assistant는 이제 대신 사용해야 하는 플러그인이 있으며, 많은 동일한 기능을 제공합니다.
https://beta.music-assistant.io/plugins/party-mode/ 를 참조하세요.

---

홈 어시스턴트 통합으로, Music Assistant와 연동되어 게스트를 위한 인터랙티브 주크박스 경험을 제공하는 웹 기반 노래 요청 시스템입니다!

![Jukebox Interface](https://raw.githubusercontent.com/DJS91/HAMusicAssistantJukebox/main/showcase.avifs)

## 기능
- 연결된 모든 Music Assistant 제공자에서 실시간 노래 검색
- 앨범 아트워크 표시가 포함된 미니멀리스트 반응형 디자인
- 현재 재생 중 및 다음 재생 곡을 실시간으로 확인
- 게스트는 로그인 필요 없이 URL만 공유하면 됨
- 홈 어시스턴트 엔티티를 통한 대기열 관리
- 요청 대기열이 비었을 때 기본 파티 플레이리스트 자동 대기열 추가
- 대기열 빈도 제어 (대기열 스팸 제한)
- 홈 어시스턴트를 통한 접근 제어
- 보안을 위한 접근 토큰 자동 취소/생성

새로운 기능 요청이나 일반 토론은 [Discussions / FeatureRequests](https://github.com/DJS91/HAMusicAssistantJukebox/discussions)로 방문하세요!

## 사전 요구 사항

이 통합을 설치하기 전에 다음을 확인하세요:
- [Music Assistant](https://github.com/music-assistant/hass-music-assistant) 통합이 설치된 홈 어시스턴트 인스턴스
- 홈 어시스턴트 내 Music Assistant 서버 애드온 (별도로 호스팅되는 HA/MA 인스턴스는 작동하지 않을 수 있음)
- Music Assistant에 구성된 지원되는 음악 제공자 (예: Spotify, Apple Music 등)
- 홈 어시스턴트에 구성된 미디어 플레이어 엔티티

## 설치

### HACS (권장)
[![홈 어시스턴트 인스턴스를 열고 홈 어시스턴트 커뮤니티 스토어에서 저장소를 엽니다.](https://my.home-assistant.io/badges/hacs_repository.svg)](https://my.home-assistant.io/redirect/hacs_repository/?owner=DJS91&repository=HAMusicAssistantJukebox&category=Integration)

또는
1. 이 저장소를 HACS에 사용자 저장소로 추가합니다  
   - HACS > 메뉴 > 사용자 저장소  
   - URL: `https://github.com/DJS91/HAMusicAssistantJukebox`  
   - 카테고리: 통합  
2. 설치를 클릭합니다  
3. Home Assistant를 재시작합니다  

### 수동 설치  
1. 최신 릴리스를 다운로드합니다  
2. `custom_components/music_assistant_jukebox` 폴더를 Home Assistant의 `custom_components` 폴더에 복사합니다  
3. Home Assistant를 재시작합니다  

## 구성  

1. 설정 > 장치 및 서비스로 이동합니다  
2. "통합 추가"를 클릭합니다  
3. "Music Assistant Jukebox"를 검색합니다  
4. Music Assistant 인스턴스와 미디어 플레이어 엔티티를 선택합니다  
5. 설정 > 자동화 및 장면 > + 자동화 생성으로 이동합니다  
6. 목록에서 "Music Assistant Jukebox Controller"를 선택합니다  
7. 4단계에서 선택한 미디어 플레이어 엔티티와 music assistant에서 기본 재생목록 이름을 입력하고 저장을 클릭합니다  

## 사용법  
"JukeBox: 허용 액세스" 스위치를 켜서 주크박스를 작동시킵니다.  

새로운 "Music Assistant Jukebox" 사이드바 패널을 통해 주크박스에 접근하거나  

선택한 QR 코드 엔티티를 스캔하거나  

다음 URL에서 직접 주크박스 인터페이스에 접근할 수 있습니다:
```
http://homeassistant:8123/local/jukebox/jukebox.html
```
## 엔티티
이 통합은 Home Assistant에 다음 엔티티를 추가합니다:

### 스위치
- `switch.jukebox_queue`: 노래 대기열 사용/사용 안 함 (수동 제어 불필요. 자동화로 관리됨)
- `switch.jukebox_allow_access`: 주크박스 인터페이스 접근 허용/차단
- `switch.music_assistant_jukebox_jukebox_play_music_on_start`: 주크박스 켜질 때 기본 재생목록 자동 재생 여부 켜기/끄기
  
### 숫자
- `number.jukebox_queue_length`: 현재 대기열 길이 표시 (수동 조정 불필요, 자동화로 관리됨)
- `number.music_assistant_jukebox_jukebox_queuing_delay`: 손님 노래 요청 간 지연 시간 설정(초) (0 = 끔)
  
### 센서
- `music_assistant_jukebox_external_qr_code`: 네트워크 외부 사용자들을 위해 대시보드에서 쉽게 공유할 수 있는 외부 주크박스 UI 접근 QR 코드 이미지
- `music_assistant_jukebox_internal_qr_code`: 네트워크 내부 사용자들을 위해 쉽게 공유할 수 있는 내부 주크박스 UI 접근 QR 코드 이미지

## 자동화 블루프린트

이 통합에는 다음을 처리하는 자동화 블루프린트가 포함되어 있습니다:
- 대기열 길이 추적
- 기본 재생목록 대체
- 접근 제어
- 미디어 플레이어 제어

블루프린트를 사용하려면:
1. 설정 > 자동화 및 장면으로 이동
2. "+ 자동화 만들기" 클릭
3. "Music Assistant Jukebox Controller" 선택
4. 구성:
   - 미디어 플레이어: Music Assistant 미디어 플레이어 선택
   - 기본 재생목록: 대체 재생목록 이름 입력

## 크레딧
큰 감사의 말씀을 전합니다:
- [OddPirate](https://github.com/TheOddPirate) 이 통합을 만드는 데 기여해 주셨습니다.

- [PilaScat](https://github.com/PilaScat) 정리, 다듬기 및 UI 개선에 기여해 주셨습니다.




---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-04-14

---