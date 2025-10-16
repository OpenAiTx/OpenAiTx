In Player Episode Preview
====================
## 소개 ##
이 플러그인은 비디오 플레이어에 에피소드 목록을 추가하여 플레이어를 떠나지 않고도 TV 쇼의 모든 에피소드를 미리 볼 수 있게 합니다.

이 수정은 다음 클라이언트를 지원합니다:
* [Jellyfin 웹 클라이언트](https://github.com/jellyfin/jellyfin-web)
* [Jellyfin 미디어 플레이어](https://github.com/jellyfin/jellyfin-media-player) (JMP) 데스크탑 클라이언트

### 기능 ###
* 시즌의 모든 에피소드 목록 표시
* 시즌 간 전환
* 에피소드 제목, 설명, 썸네일 및 재생 진행 상태 표시
* 커뮤니티 순위와 같은 에피소드 상세 정보 표시
* 에피소드를 재생 완료 또는 즐겨찾기로 표시
* 새 에피소드 시작
* 커스텀 테마와 호환 가능

## 미리보기 ##
<img src="https://github.com/Namo2/InPlayerEpisodePreview/blob/master/Images/preview.gif" width="550" height="450">

사용된 테마: (SkinManager) Kaleidochromic
<br>
이 미리보기에는 에피소드를 완료 또는 즐겨찾기로 표시하는 새 버튼이 없습니다.

## 설치 ##

### Jellyfin 웹 클라이언트 (서버) ###
1. 서버에 Jellyfin 플러그인 저장소로 `https://raw.githubusercontent.com/Namo2/InPlayerEpisodePreview/master/manifest.json` 매니페스트를 추가합니다.
2. 저장소에서 `InPlayerEpisodePreview` 플러그인을 설치합니다.
3. Jellyfin 서버를 재시작합니다.

<br/>

### Jellyfin 미디어 플레이어 (JMP) 데스크탑 클라이언트 ###
### **JMP 버전 [1.11.0](https://github.com/jellyfin/jellyfin-media-player/releases/tag/v1.11.0)부터 사용 중단됨** ###
새 JMP 클라이언트는 서버 자체의 현재 웹 플레이어를 사용하므로 클라이언트 코드를 직접 변경할 필요가 없습니다.

데스크탑 클라이언트에 스크립트를 설치하는 권장 방법입니다.
직접 nativeshell.js 파일을 편집하는 것이 부담스러우면(3~6단계), 이미 스크립트가 추가된 nativeshell.js 파일을 포함한 전체 릴리스를 대신 다운로드할 수 있습니다.
릴리스에서 제공된 nativeshell.js 파일로 교체할 경우 잠재적인 문제가 발생할 수 있으므로 아래 모든 단계를 따르는 것이 권장됩니다.

1. 최신 릴리스 [JMP](https://github.com/Namo2/InPlayerEpisodePreview/releases/download/v1.1.0.0/inPlayerEpisodePreview-1.1.0.0-jmp.zip) 또는 [JMP-full](https://github.com/Namo2/InPlayerEpisodePreview/releases/download/v1.1.0.0/inPlayerEpisodePreview-1.1.0.0-jmp-full.zip) (nativeshell.js 파일에 스크립트가 이미 추가되어 있음)을 다운로드합니다.
2. ZIP 파일을 Jellyfin 디렉토리(예: C:\Program Files\Jellyfin\Jellyfin Media Player)로 압축 해제합니다.
3. Jellyfin 디렉토리 내에서 "web-client\extension" 폴더 경로를 따라 이동합니다.
4. 텍스트 편집기로 "nativeshell.js" 파일을 엽니다.
5. 파일 내에서 `const plugins = [];` 섹션을 찾습니다. 리스트 시작 부분에 새 줄을 추가하고 `'inPlayerEpisodePreviewPlugin',`를 붙여넣습니다. 섹션은 이제 다음과 유사하게 보여야 합니다:
```javascript
const plugins = [
    'inPlayerEpisodePreviewPlugin',
    'mpvVideoPlayer',
    'mpvAudioPlayer',
    'jmpInputPlugin',
    'jmpUpdatePlugin',
    'jellyscrubPlugin',
    'skipIntroPlugin'
];
```
6. 파일을 저장하고 JMP 클라이언트를 재시작합니다.

## 문제 해결 ##

### 1. 미리보기 버튼이 보이지 않는 경우 ###
이는 대부분 `index.html` 파일의 권한이 잘못 설정된 것과 관련이 있습니다.

#### 1.1 도커 컨테이너 내부에서 소유권 변경 ####
도커 컨테이너에서 jellyfin을 실행 중인 경우, 다음 명령어로 소유권을 변경할 수 있습니다.
(jellyfin을 컨테이너 이름으로, user와 group을 컨테이너의 사용자 및 그룹으로 교체하세요):
```
docker exec -it --user root jellyfin chown user:group /jellyfin/jellyfin-web/index.html && docker restart jellyfin
```
시스템 시작 시 크론 작업으로 실행할 수 있습니다.

([muisje](https://github.com/muisje)에게 이 [해결책](https://github.com/Namo2/InPlayerEpisodePreview/issues/49#issue-2825745530)에 도움을 준 것에 감사드립니다)

#### 1.2 Windows 설치에서 소유권 변경하기 ####
1. 다음 경로로 이동: `C:\Program Files\Jellyfin\Server\jellyfin-web\`
2. `index.html`을 우클릭 → `속성` → `보안` 탭 → `편집` 클릭
3. 목록에서 사용자 선택 후 쓰기 `권한` 체크
4. 서버와 클라이언트를 모두 재시작

([xeuc](https://github.com/xeuc)에게 이 [해결책](https://github.com/Namo2/InPlayerEpisodePreview/issues/49#issuecomment-2746136069)에 감사드립니다)

이 방법이 작동하지 않으면 [이](https://github.com/Namo2/InPlayerEpisodePreview/issues/10) (또는 [이](https://github.com/Namo2/InPlayerEpisodePreview/issues/49)) 이슈의 토론을 참고하세요.

<br/>
스스로 해결할 수 없는 오류가 발생하면 언제든지 이슈를 열어주세요.
<br/>시스템마다 다르기 때문에 예기치 않은 동작이 발생할 수 있으니 가능한 많은 정보를 제공해 주세요.
<br/>Jellyfin 로그와 브라우저의 콘솔 로그([InPlayerEpisodePreview] 접두사 포함)는 항상 유용합니다.

## 단점 ##
* 플러그인은 서버에서 에피소드 설명과 같은 추가 데이터를 다운로드합니다.

## 크레딧 ##
이 플러그인 구조는 [NickNSY](https://github.com/nicknsy)의 [Jellyscrub](https://github.com/nicknsy/jellyscrub) 플러그인을 기반으로 하며 영감을 받았습니다.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-10-16

---