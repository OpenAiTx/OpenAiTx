<div align="right">
  <details>
    <summary >🌐 언어</summary>
    <div>
      <div align="center">
        <p>다음 번역은 AI를 사용하여 자동으로 생성되었습니다. 오래된 버전의 readme를 참조하거나 부정확할 수 있으니 참고 바랍니다.</p>
        <a href="https://openaitx.github.io/view.html?user=Namo2&project=InPlayerEpisodePreview&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=Namo2&project=InPlayerEpisodePreview&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=Namo2&project=InPlayerEpisodePreview&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=Namo2&project=InPlayerEpisodePreview&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=Namo2&project=InPlayerEpisodePreview&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=Namo2&project=InPlayerEpisodePreview&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=Namo2&project=InPlayerEpisodePreview&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=Namo2&project=InPlayerEpisodePreview&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=Namo2&project=InPlayerEpisodePreview&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=Namo2&project=InPlayerEpisodePreview&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=Namo2&project=InPlayerEpisodePreview&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=Namo2&project=InPlayerEpisodePreview&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=Namo2&project=InPlayerEpisodePreview&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=Namo2&project=InPlayerEpisodePreview&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=Namo2&project=InPlayerEpisodePreview&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=Namo2&project=InPlayerEpisodePreview&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=Namo2&project=InPlayerEpisodePreview&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=Namo2&project=InPlayerEpisodePreview&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=Namo2&project=InPlayerEpisodePreview&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=Namo2&project=InPlayerEpisodePreview&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=Namo2&project=InPlayerEpisodePreview&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

인 플레이어 에피소드 미리보기
====================
## 📄 소개
이 플러그인은 비디오 플레이어에 에피소드 목록을 추가하여 플레이어를 떠나지 않고도 TV 프로그램의 모든 에피소드를 미리 볼 수 있게 해줍니다.

이 수정 사항은 다음 클라이언트들을 지원합니다:
* [젤리핀 웹 클라이언트](https://github.com/jellyfin/jellyfin-web)
* [젤리핀 미디어 플레이어](https://github.com/jellyfin/jellyfin-media-player) (JMP) 데스크탑 클라이언트

## ✨ 기능
* 시즌의 모든 에피소드 목록 표시
* 시즌 간 전환 가능
* 에피소드 제목, 설명, 썸네일 및 재생 진행 상황 표시
* 커뮤니티 순위 등 에피소드 세부 정보 표시
* 에피소드를 시청 완료 또는 즐겨찾기로 표시
* 새로운 에피소드 시작
* 커스텀 테마와 호환되어야 함

## 📸 미리보기
<img src="https://github.com/Namo2/InPlayerEpisodePreview/blob/master/Images/preview.gif" width="550" height="450">

사용된 테마: (SkinManager) Kaleidochromic
<br>
이 미리보기에는 에피소드를 완료 또는 즐겨찾기로 표시하는 새로운 버튼이 포함되어 있지 않습니다.

## 🔧 설치

### Jellyfin 웹 클라이언트(서버)

> [!NOTE]
> [file-transformation](https://github.com/IAmParadox27/jellyfin-plugin-file-transformation) v2.2.1.0 이상의 버전 설치를 강력히 권장합니다. 모든 종류의 설치에서 index.html을 수정할 때 권한 문제를 방지하는 데 도움이 됩니다!
<details open>
<summary> 설치 방법 보기... </summary>

1. 매니페스트 `https://raw.githubusercontent.com/Namo2/InPlayerEpisodePreview/master/manifest.json` 를 Jellyfin 플러그인 저장소로 서버에 추가합니다.
2. 저장소에서 `InPlayerEpisodePreview` 플러그인을 설치합니다.
3. Jellyfin 서버를 재시작합니다.
</details>

### Jellyfin 미디어 플레이어(JMP) 데스크탑 클라이언트(지원 중단됨)
<details>
<summary> 설치 방법 보기... </summary>

**JMP 버전 [1.11.0](https://github.com/jellyfin/jellyfin-media-player/releases/tag/v1.11.0)부터 지원 중단됨**

새로운 JMP 클라이언트는 서버의 현재 웹 플레이어를 사용하므로, 클라이언트 코드를 직접 수정할 필요가 없습니다.

데스크탑 클라이언트에 스크립트를 설치하는 권장 방법입니다.
본인이 nativeshell.js 파일을 직접 수정하는 것이 불편하다면(3~6단계), 이미 nativeshell.js 파일에 스크립트가 추가된 전체 릴리스를 대신 다운로드할 수 있습니다.
릴리스에서 nativeshell.js 파일을 교체할 경우 잠재적인 문제가 발생할 수 있으므로, 아래 모든 단계를 따라 진행하는 것이 권장됩니다.

1. 최신 릴리스 [JMP](https://github.com/Namo2/InPlayerEpisodePreview/releases/download/v1.1.0.0/inPlayerEpisodePreview-1.1.0.0-jmp.zip) 또는 [JMP-full](https://github.com/Namo2/InPlayerEpisodePreview/releases/download/v1.1.0.0/inPlayerEpisodePreview-1.1.0.0-jmp-full.zip) (스크립트가 nativeshell.js 파일에 이미 추가됨)을 다운로드합니다.
2. 압축 파일을 Jellyfin 디렉터리에 압축 해제합니다 (예: C:\Program Files\Jellyfin\Jellyfin Media Player).
3. Jellyfin 디렉터리 내에서 "web-client\extension" 폴더 경로를 따라 이동합니다.
4. 텍스트 편집기로 "nativeshell.js" 파일을 엽니다.
5. 파일에서 `const plugins = [];` 섹션을 찾습니다. 리스트의 처음에 새 줄을 추가하고 `'inPlayerEpisodePreviewPlugin',`을 붙여 넣습니다. 해당 섹션은 다음과 유사하게 보여야 합니다:
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
6. 파일을 저장하고 JMP 클라이언트를 재시작하세요.
</details>

## 💡 문제 해결

### 1. 미리보기 버튼이 보이지 않음
이것은 대부분 `index.html` 파일의 권한이 잘못 설정된 것과 관련이 있습니다.

<details>
<summary> 가능한 해결 방법 목록 보기... </summary>

#### 1.1 [file-transformation](https://github.com/IAmParadox27/jellyfin-plugin-file-transformation) 플러그인을 사용하여 이 문제를 방지하세요.

#### 1.2 도커 컨테이너 내에서 소유권 변경
jellyfin을 도커 컨테이너에서 실행 중이라면, 다음 명령어로 소유권을 변경할 수 있습니다
(jellyfin을 컨테이너 이름으로, user와 group을 컨테이너의 사용자와 그룹으로 바꿔서 사용하세요):
```
docker exec -it --user root jellyfin chown user:group /jellyfin/jellyfin-web/index.html && docker restart jellyfin
```
이 작업은 시스템 시작 시 크론 작업으로 실행할 수 있습니다.
([muisje](https://github.com/muisje)에게 [이](https://github.com/Namo2/InPlayerEpisodePreview/issues/49#issue-2825745530) 솔루션에 도움을 준 것에 감사드립니다)

#### 1.3 Windows 설치에서 소유권 변경
1. 다음 경로로 이동: `C:\Program Files\Jellyfin\Server\jellyfin-web\`
2. `index.html`을 마우스 오른쪽 버튼으로 클릭 → `속성` → `보안 탭` → `편집` 클릭
3. 목록에서 자신의 사용자를 선택하고 쓰기 `권한` 상자를 체크합니다.
4. 서버와 클라이언트를 모두 재시작합니다.
   ([xeuc](https://github.com/xeuc)에게 [이](https://github.com/Namo2/InPlayerEpisodePreview/issues/49#issuecomment-2746136069) 솔루션에 감사드립니다)

위의 어떤 해결책도 효과가 없다면, 예전 이슈들을 참고해 주세요. 예: [여기](https://github.com/Namo2/InPlayerEpisodePreview/issues/10) 또는 [여기](https://github.com/Namo2/InPlayerEpisodePreview/issues/49).
</details>

<br/>
<br/>
직접 해결할 수 없는 오류가 발생하면 언제든지 이슈를 등록해 주세요.
<br/>모든 시스템이 다르기 때문에 예기치 않은 동작이 발생할 수 있으니 최대한 많은 정보를 추가해 주세요.
<br/>Jellyfin 로그와 브라우저 콘솔 로그([InPlayerEpisodePreview]로 접두사 표시됨)는 항상 유용합니다.

## 크레딧
플러그인 구조는 [NickNSY](https://github.com/nicknsy)의 [Jellyscrub](https://github.com/nicknsy/jellyscrub) 플러그인을 기반으로 영감을 받아 제작되었습니다.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-11-15

---