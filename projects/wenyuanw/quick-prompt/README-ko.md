# 빠른 프롬프트

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

강력한 브라우저 확장 프로그램으로, 프롬프트 관리와 빠른 입력에 집중합니다. 사용자가 프롬프트 라이브러리를 생성, 관리, 조직하고 웹페이지 입력창에서 미리 설정한 프롬프트 내용을 신속하게 삽입하여 업무 효율을 높입니다.

> 브라우저 플러그인은 웹에서만 사용할 수 있으므로, 동일한 기능을 제공하는 [Raycast 플러그인](https://github.com/wenyuanw/quick-prompt-raycast)을 오픈소스화하였습니다. 브라우저 플러그인 데이터 형식을 호환하며, 동일한 JSON 데이터를 통해 무결점으로 이전할 수 있습니다.

## ✨ 기능 특성

- 📚 **프롬프트 관리**: 손쉽게 프롬프트 라이브러리를 생성, 편집 및 관리할 수 있습니다
- 🚀 **빠른 입력**: 모든 웹페이지 입력란에서 `/p`를 입력해 프롬프트 선택기를 빠르게 호출
- ⌨️ 단축키로 프롬프트 선택기 열기 & 선택한 텍스트를 프롬프트로 저장 지원
- 📑 마우스 오른쪽 버튼 메뉴에서 선택한 텍스트를 바로 프롬프트로 저장 지원
- 🎯 카테고리, 제목, 내용, 태그, 변수 등 사용자 정의 프롬프트 지원
- 🧑‍💻 **변수 지원**: 프롬프트 내에서 `{{변수명}}` 형식의 변수를 사용할 수 있으며, 사용할 때 값을 입력
- 💾 **데이터 백업**: 프롬프트 라이브러리 내보내기 및 가져오기 지원, 다양한 기기에서 손쉽게 이전 및 백업
- 🔗 **클라우드 동기화**: 프롬프트 라이브러리를 Notion 데이터베이스 또는 Gitee/GitHub Gist와 동기화 지원
- 🔍 프롬프트 검색 및 필터 기능 지원
- 🌙 시스템의 다크/라이트 테마 자동 적용

## 🚀 사용 방법

1. **빠른 호출**: 모든 웹페이지의 텍스트 입력란에서 `/p`를 입력해 프롬프트 선택기 호출
2. **단축키로 선택기 열기**: `Ctrl+Shift+P`(Windows/Linux) 또는 `Command+Shift+P`(macOS)로 프롬프트 선택기 열기
3. **프롬프트 선택**: 팝업된 선택기에서 원하는 프롬프트를 클릭하면, 현재 입력란에 자동으로 삽입됩니다
4. **프롬프트 빠른 저장**: 원하는 텍스트를 선택 후 `Ctrl+Shift+S`(Windows/Linux) 또는 `Command+Shift+S`(macOS)로 빠르게 프롬프트로 저장
5. **오른쪽 버튼 메뉴 저장**: 원하는 텍스트를 선택 후 마우스 오른쪽 클릭 → "해당 프롬프트 저장"을 선택해 저장
6. **프롬프트 라이브러리 내보내기**: 관리 페이지에서 "내보내기" 버튼 클릭, 모든 프롬프트를 JSON 파일로 저장
7. **프롬프트 라이브러리 가져오기**: 관리 페이지에서 "가져오기" 버튼 클릭, 로컬 JSON 파일로부터 프롬프트 가져오기(병합 또는 덮어쓰기 지원)

## 📸 인터페이스 미리보기

Quick Prompt는 직관적이고 친화적인 사용자 인터페이스를 제공하여 프롬프트를 쉽게 관리하고 사용할 수 있습니다.

### 프롬프트 선택기

![프롬프트 선택기](https://github.com/user-attachments/assets/41b9897c-d701-4ff0-97f7-2f1754f570a8)

![프롬프트 선택기](https://github.com/user-attachments/assets/22d9d30c-b4c3-4e34-a0a0-8ef51e2cb942)

`/p` 단축 명령어 또는 단축키를 사용하면 어떤 입력란에서도 빠르게 프롬프트 선택기를 띄워서 원하는 프롬프트를 편리하게 선택하고 삽입할 수 있습니다.

### 프롬프트 관리 페이지

![프롬프트 관리](https://github.com/user-attachments/assets/371ae51e-1cee-4a66-a2a5-cca017396872)

관리 페이지에서는 새로운 프롬프트 생성, 기존 프롬프트 편집, 태그 추가 및 카테고리 관리를 할 수 있습니다. 인터페이스가 간결하고 조작이 쉽습니다.

### 우클릭 메뉴 저장

![우클릭 메뉴 저장](https://github.com/user-attachments/assets/17fc3bfd-3fa4-4b0b-ae1a-5cfd0b62be2e)

웹페이지의 텍스트를 선택한 후 우클릭하면 즉시 프롬프트로 저장할 수 있어 업무 효율성이 향상됩니다.

### 프롬프트 변수 입력

![프롬프트 변수 팝업](https://github.com/user-attachments/assets/c91c1156-983a-454d-aad0-5698b0291b9b)

프롬프트는 변수 설정을 지원하며, 선택 후 팝업 창에서 해당 변수 값을 입력할 수 있습니다.

## ⚙️ 사용자 정의 설정

1. 확장 프로그램 아이콘을 클릭한 뒤 "프롬프트 관리" 버튼을 클릭하세요.
2. 관리 페이지에서 다음을 할 수 있습니다:
   - 새로운 프롬프트 추가
   - 기존 프롬프트 편집
   - 필요 없는 프롬프트 삭제
   - 프롬프트에 태그 추가하여 분류
   - 프롬프트 라이브러리 내보내기(백업)
   - 이전에 백업한 프롬프트 라이브러리 가져오기

## 📦 설치 가이드

### 스토어에서 설치

현재 Chrome 웹 스토어에 출시되었습니다! [여기를 클릭하여 설치](https://chromewebstore.google.com/detail/quick-prompt/hnjamiaoicaepbkhdoknhhcedjdocpkd)

### GitHub Releases에서 다운로드

1. [GitHub Releases 페이지](https://github.com/wenyuanw/quick-prompt/releases)에 접속하세요.
2. 최신 버전의 빌드된 확장 프로그램 파일을 다운로드하세요.
3. 다운로드한 파일을 압축 해제하세요.
4. 아래 안내에 따라 빌드된 확장 프로그램을 설치하세요.

### 소스 코드에서 빌드

1. 저장소를 클론하세요.
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

### 이미 빌드된 확장 프로그램 설치

#### Chrome / Edge
1. 확장 프로그램 관리 페이지를 엽니다 (`chrome://extensions` 또는 `edge://extensions`)
2. "개발자 모드"를 활성화합니다
3. "압축 해제된 확장 프로그램 로드"를 클릭합니다
4. 프로젝트의 `.output/chrome-mv3/` 디렉터리를 선택합니다

#### Firefox
1. `about:debugging`을 엽니다
2. "이 Firefox"를 클릭합니다
3. "임시 부가 기능 로드"를 클릭합니다
4. 프로젝트의 `.output/firefox-mv2/` 디렉터리 내 `manifest.json` 파일을 선택합니다

## 📄 라이선스

MIT

## 🤝 기여 지침

Pull Request 및 Issue 제출을 환영합니다!

1. 이 저장소를 Fork 합니다
2. 기능 브랜치를 생성합니다 (`git checkout -b feature/amazing-feature`)
3. 변경 사항을 커밋합니다 (`git commit -m 'Add some amazing feature'`)
4. 브랜치에 푸시합니다 (`git push origin feature/amazing-feature`)
5. Pull Request를 엽니다

## 👏 기여자 명단

프로젝트에 기여한 모든 개발자에게 감사드립니다!

<a href="https://github.com/wenyuanw/quick-prompt/graphs/contributors">
  <img src="https://contrib.rocks/image?repo=wenyuanw/quick-prompt" />
</a>


## Star History

[![Star History Chart](https://api.star-history.com/svg?repos=wenyuanw/quick-prompt&type=Date)](https://www.star-history.com/#wenyuanw/quick-prompt&Date)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-04-16

---