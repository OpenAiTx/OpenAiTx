# Joplin용 macOS 테마

노트 작성 앱 [Joplin](https://joplinapp.org/) v2.2.4 이상 버전을 위한 네이티브 스타일의 macOS 테마입니다. macOS가 아닌 기기에서도 작동합니다.

![Joplin용 macOS 테마](/images/macos-theme-for-joplin.png)

- ✨ 모든 컨트롤을 포함한 완전한 UI 스타일링,
- 🌜 라이트, 다크, 다크 사이드바가 있는 라이트 또는 자동(시스템 설정에 따른 라이트/다크) 중 선택 가능,
- 👌 네이티브 아이콘(macOS 전용) 또는 Phosphor 아이콘 패밀리 사용,
- 👨‍🎨 Joplin 환경설정을 통해 쉽게 커스터마이징 가능.

## 설치

- Joplin 환경설정 › '플러그인'을 열고 'macOS theme'를 검색하여 테마를 설치하세요.
- Joplin을 재시작하세요. 즐기세요!

‘모양 › 테마’를 ‘라이트’ 또는 ‘다크’로 설정했는지 확인하세요. 노트북 전환 시 깜빡임이 발생하면 ‘모양 › 테마’의 라이트/다크 설정과 ‘macOS theme › Appearance’에서 선택한 값을 동기화하세요. 추가 커스터마이징 옵션은 아래를 참고하세요.

## 커스터마이징

설치 후 Joplin 환경설정에 ‘macOS theme’라는 항목이 추가됩니다. 변경 사항을 적용하려면 Joplin을 재시작해야 합니다.

**Mac 사용자**: 네이티브 아이콘을 사용하려면 [Apple 웹사이트](https://developer.apple.com/fonts/)에서 SF Pro를 다운로드하여 설치하세요.

## 아이콘이 보이지 않나요?

**Windows 사용자**: 아이콘이 빈 사각형으로 나타나거나 보이지 않는 경우, Phosphor 폰트를 수동으로 설치해야 합니다. [phosphoricons.com](https://phosphoricons.com/)에서 다운로드([직접 다운로드](https://phosphoricons.com/assets/phosphor-icons.zip)) 후 압축을 풀고 `Fonts/regular/Phosphor.ttf`를 설치한 다음 Joplin을 재시작하세요.

**Mac 사용자**: ‘Icon family’ 설정이 ‘macOS native (SF Pro)’로 되어 있다면 [Apple 웹사이트](https://developer.apple.com/fonts/)에서 SF Pro가 설치되어 있어야 합니다. 이 설정은 macOS 기기에서만 작동합니다.

## 면책 조항

⚠️ Joplin은 스타일링에 styled-components를 사용하여 앱 테마 적용이 매우 어렵습니다. 많은 해킹성 CSS 우회 방법과 `!important`가 사용되었습니다. 이로 인해 향후 Joplin 업데이트에서 UI 문제가 발생할 수 있습니다. 단순 CSS이므로 데이터는 안전하며 스타일을 쉽게 되돌릴 수 있습니다.

문제가 발생하면 [이슈 생성](https://github.com/ajilderda/joplin-macos-native-theme/issues) 또는 [포럼에 글 작성](https://discourse.joplinapp.org/t/plugin-macos-theme-for-joplin)해 주세요.

## 플러그인 설치 후 빈 화면이 나타나요.

플러그인 설치 후 빈 화면이 나타난다면 이모지 처리 문제일 가능성이 높습니다. 해결 방법은 다음과 같습니다:

1. 먼저, Joplin 구성 디렉토리를 찾으세요:

   - macOS: `~/.config/joplin-desktop`
   - Windows: `%APPDATA%\Joplin`
   - Linux: `~/.config/Joplin`

2. `plugins` 폴더로 이동하여 macOS 테마 플러그인의 `.jpl` 파일을 삭제하세요.
3. Joplin을 재시작하세요.

### 예방

이 문제를 방지하려면:

- Joplin의 "이모지 선택..." 대화 상자를 사용하는 대신, 노트북 제목 텍스트 상자에 직접 이모지를 추가하세요 (시각적 참고를 위해 [이 토론](https://github.com/andrejilderda/joplin-macos-native-theme/issues/96#issuecomment-1553517708)을 참조하세요).
- 이제 플러그인을 다시 설치할 수 있습니다.

## 개발

Joplin의 환경설정에서 테마를 조정할 수 있습니다. 완전히 커스텀 빌드를 원한다면 다음 단계를 따르세요.

의존성 설치:

```sh
npm install
```
플러그인을 빌드하려면:


```sh
npm run dist
```
플러그인 프레임워크를 업데이트하려면:


```sh
npm run update
```
CSS를 빌드하고 변경 사항을 감시하려면:


```sh
npm run dev
```
생성된 CSS는 다음 위치에서 확인할 수 있습니다: http://localhost:8080/macos-theme-for-joplin.css

## 기여하기

기여(특히 수정)는 매우 환영합니다!

### 개발 워크플로우

변경할 때마다 Joplin을 재시작하는 것은 다소 번거롭습니다. 속도를 높이고 피드백 루프를 단축하기 위해:

1. `npm run dev`를 실행하세요. 이 명령은 .scss 파일의 변경을 감시하고 CSS를 재빌드합니다.
2. Joplin의 개발자 도구를 토글하세요 (**도움말 › 개발자 도구 토글**)
3. [이 gist](https://gist.github.com/andrejilderda/f6673f1b1a986b2dc0cd01607acbff26)에서 두 가지 새로고침 방법 중 하나를 선택하세요.
4. 개발자 도구 콘솔에 스크립트를 붙여넣고 실행하여 CSS를 자동으로 새로고침하세요.

이 방법은 대부분 잘 작동하지만, 일부 경우 변경된 스타일이 설치된 플러그인의 스타일과 충돌할 수 있습니다. 그런 경우를 확인하려면 다음과 같이 깨끗한 환경을 보장할 수 있습니다:

1. 이미 설치된 macOS 테마 플러그인을 제거하세요.
2. 빌드를 실행하세요: `npm run build`
3. Joplin에서 **플러그인 › 고급 설정 표시**로 이동하세요.
4. **개발 플러그인** 아래에 `dist` 폴더 경로를 붙여넣으세요.
5. Joplin을 재시작하여 로컬 빌드된 플러그인을 로드하세요.



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-23

---