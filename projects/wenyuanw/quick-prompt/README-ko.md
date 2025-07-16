# 퀵 프롬프트

<div align="right">
  <details>
    <summary >🌐 언어</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=wenyuanw&project=quick-prompt&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=wenyuanw&project=quick-prompt&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=wenyuanw&project=quick-prompt&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=wenyuanw&project=quick-prompt&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=wenyuanw&project=quick-prompt&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=wenyuanw&project=quick-prompt&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=wenyuanw&project=quick-prompt&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=wenyuanw&project=quick-prompt&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=wenyuanw&project=quick-prompt&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=wenyuanw&project=quick-prompt&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=wenyuanw&project=quick-prompt&lang=it">Itapano</a>
        | <a href="https://openaitx.github.io/view.html?user=wenyuanw&project=quick-prompt&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=wenyuanw&project=quick-prompt&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=wenyuanw&project=quick-prompt&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=wenyuanw&project=quick-prompt&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=wenyuanw&project=quick-prompt&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=wenyuanw&project=quick-prompt&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=wenyuanw&project=quick-prompt&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=wenyuanw&project=quick-prompt&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=wenyuanw&project=quick-prompt&lang=id">Bahasa Indonesia</a>
      </div>
    </div>
  </details>
</div>

<p align="center">
  <img src="https://raw.githubusercontent.com/wenyuanw/quick-prompt/main/./assets/icon.png" alt="Quick Prompt Logo" width="128" style="background: transparent;">
</p>

강력한 브라우저 확장 프로그램으로, 프롬프트 관리와 빠른 입력에 중점을 두었습니다. 사용자가 프롬프트 라이브러리를 생성, 관리, 조직할 수 있도록 도와주며, 모든 웹페이지 입력창에서 미리 설정한 프롬프트 내용을 신속하게 삽입하여 업무 효율을 높여줍니다.

> 브라우저 확장 프로그램은 웹에서만 사용할 수 있기 때문에, 동일한 기능의 [Raycast 플러그인](https://github.com/wenyuanw/quick-prompt-raycast)을 오픈소스로 공개했습니다. 브라우저 확장과 동일한 데이터 형식을 지원하여 JSON 데이터로 원활하게 이전할 수 있습니다.

## ✨ 기능 특성

- 📚 **프롬프트 관리**: 프롬프트 라이브러리를 손쉽게 생성, 편집, 관리
- 🚀 **빠른 입력**: 모든 웹 입력창에서 `/p`로 프롬프트 선택기를 신속하게 호출
- ⌨️ 단축키로 프롬프트 선택기 열기 & 선택한 텍스트를 프롬프트로 저장하는 기능 지원
- 📑 우클릭 메뉴로 선택한 텍스트를 프롬프트로 바로 저장 가능
- 🎯 분류, 제목, 내용, 태그, 변수 등 맞춤형 프롬프트 지원
- 🧑‍💻 **변수 지원**: 프롬프트 내에서 `{{변수명}}` 형식의 변수를 사용할 수 있으며, 사용할 때 구체 값을 입력 가능
- 💾 **데이터 백업**: 프롬프트 라이브러리 내보내기/가져오기 지원, 기기간 이전 및 백업 용이
- 🔗 **Notion 동기화**: 프롬프트 라이브러리와 Notion 데이터베이스 동기화 지원
- 🔍 프롬프트 검색 및 필터링 기능 지원
- 🌙 시스템 다크/라이트 테마 자동 적용

## ⚠️ 알려진 문제

- 두바오(doubao.com) 웹사이트에서는 `/p`로 프롬프트 선택기를 호출한 뒤 일부 입력창에 `/p`가 지워지지 않는 문제가 있습니다. 걱정 마세요! 저와 오래된 동료 Cursor가 밤낮없이 해결책을 찾고 있으니, 곧 수정될 예정입니다!

## 🚀 사용 방법

1. **빠른 호출**: 모든 웹페이지의 텍스트 입력창에 `/p`를 입력하여 프롬프트 선택기 호출
2. **단축키로 선택기 열기**: `Ctrl+Shift+P`(Windows/Linux) 또는 `Command+Shift+P`(macOS)로 프롬프트 선택기 열기
3. **프롬프트 선택**: 팝업된 선택기에서 원하는 프롬프트를 클릭하면, 해당 내용이 자동으로 현재 입력창에 삽입됨
4. **프롬프트 빠른 저장**: 임의 텍스트를 선택한 후 `Ctrl+Shift+S`(Windows/Linux) 또는 `Command+Shift+S`(macOS)로 프롬프트로 빠르게 저장
5. **우클릭 메뉴 저장**: 임의 텍스트를 선택한 후 우클릭 → "이 프롬프트 저장"을 선택하면 선택 내용을 프롬프트로 저장
6. **프롬프트 라이브러리 내보내기**: 관리 페이지에서 "내보내기" 버튼 클릭, 모든 프롬프트를 JSON 파일로 로컬 저장
7. **프롬프트 라이브러리 가져오기**: 관리 페이지에서 "가져오기" 버튼 클릭, 로컬 JSON 파일에서 프롬프트를 가져오기(기존 프롬프트와 병합 또는 덮어쓰기 지원)

## 📸 인터페이스 미리보기

퀵 프롬프트는 직관적이고 친화적인 UI를 제공하여 프롬프트를 쉽게 관리하고 사용할 수 있습니다.

### 프롬프트 선택기

![프롬프트 선택기](https://github.com/user-attachments/assets/41b9897c-d701-4ff0-97f7-2f1754f570a8)

![프롬프트 선택기](https://github.com/user-attachments/assets/22d9d30c-b4c3-4e34-a0a0-8ef51e2cb942)

`/p` 단축 명령어나 단축키로 어디서나 입력창에 프롬프트 선택기를 빠르게 띄워, 원하는 프롬프트를 손쉽게 선택·삽입할 수 있습니다.

### 프롬프트 관리 페이지

![프롬프트 관리](https://github.com/user-attachments/assets/371ae51e-1cee-4a66-a2a5-cca017396872)

관리 페이지에서 새 프롬프트를 생성하거나, 기존 프롬프트를 편집, 태그 추가, 분류 관리 등이 가능합니다. 인터페이스가 간결하며 사용이 편리합니다.

### 우클릭 메뉴 저장

![우클릭 메뉴 저장](https://github.com/user-attachments/assets/17fc3bfd-3fa4-4b0b-ae1a-5cfd0b62be2e)

웹페이지에서 원하는 텍스트를 선택한 뒤, 우클릭만으로 빠르게 프롬프트로 저장하여 업무 효율을 높일 수 있습니다.

### 프롬프트 변수 입력

![프롬프트 변수 입력창](https://github.com/user-attachments/assets/c91c1156-983a-454d-aad0-5698b0291b9b)

프롬프트는 변수 설정을 지원하며, 선택 후 팝업창에서 해당 변수 값을 입력할 수 있습니다.

## ⚙️ 맞춤 설정

1. 확장 아이콘을 클릭한 후 "프롬프트 관리" 버튼을 클릭하세요
2. 관리 페이지에서 다음을 할 수 있습니다:
   - 새로운 프롬프트 추가
   - 기존 프롬프트 편집
   - 필요 없는 프롬프트 삭제
   - 프롬프트에 태그를 추가하여 분류
   - 프롬프트 라이브러리 내보내기(백업용)
   - 이전에 백업한 프롬프트 라이브러리 가져오기

## 📦 설치 안내

### 앱 스토어에서 설치

이제 Chrome 웹스토어에서 사용할 수 있습니다! [여기를 클릭하여 설치하세요](https://chromewebstore.google.com/detail/quick-prompt/hnjamiaoicaepbkhdoknhhcedjdocpkd)

### GitHub Releases에서 받기

1. [GitHub Releases 페이지](https://github.com/wenyuanw/quick-prompt/releases)에 접속
2. 최신 버전의 빌드된 플러그인 패키지 다운로드
3. 다운로드한 파일 압축 해제
4. 아래 안내에 따라 빌드된 확장 프로그램 설치

### 소스 코드에서 빌드

1. 저장소 클론
   ```bash
   git clone https://github.com/wenyuanw/quick-prompt.git
   cd quick-prompt
   ```
2. 의존성 설치
   ```bash
   pnpm install
   ```
3. 개발 및 빌드

   ```bash
   # 开发模式 (Chrome)
   pnpm dev
   
   # 开发模式 (Firefox)
   pnpm dev:firefox
   
   # 构建扩展 (Chrome)
   pnpm build
   
   # 构建扩展 (Firefox)
   pnpm build:firefox
   ```
### 빌드된 확장 프로그램 설치

#### Chrome / Edge
1. 확장 프로그램 관리 페이지 열기 (`chrome://extensions` 또는 `edge://extensions`)
2. "개발자 모드" 활성화
3. "압축 해제된 확장 프로그램 로드" 클릭
4. 프로젝트의 `.output/chrome-mv3/` 디렉터리 선택

#### Firefox
1. `about:debugging` 열기
2. "이 Firefox" 클릭
3. "임시 부가 기능 로드" 클릭
4. 프로젝트의 `.output/firefox-mv2/` 디렉터리 내 `manifest.json` 파일 선택

## 📄 라이선스

MIT

## 🤝 기여 가이드

Pull Request 및 Issue 제출을 환영합니다!

1. 이 저장소를 Fork 합니다
2. 기능 브랜치 생성 (`git checkout -b feature/amazing-feature`)
3. 변경 사항 커밋 (`git commit -m 'Add some amazing feature'`)
4. 브랜치 푸시 (`git push origin feature/amazing-feature`)
5. Pull Request 생성

## 👏 기여자 목록

프로젝트에 기여해 주신 모든 개발자분들께 감사드립니다!

<a href="https://github.com/wenyuanw/quick-prompt/graphs/contributors">
  <img src="https://contrib.rocks/image?repo=wenyuanw/quick-prompt" />
</a>


## Star History

[![Star History Chart](https://api.star-history.com/svg?repos=wenyuanw/quick-prompt&type=Date)](https://www.star-history.com/#wenyuanw/quick-prompt&Date)



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-16

---