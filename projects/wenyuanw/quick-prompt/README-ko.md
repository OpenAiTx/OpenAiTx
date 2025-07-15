<translate-content># 빠른 프롬프트

[English](https://raw.githubusercontent.com/wenyuanw/quick-prompt/main/./README_en.md) | 中文

<p align="center">
  <img src="https://raw.githubusercontent.com/wenyuanw/quick-prompt/main/./assets/icon.png" alt="Quick Prompt Logo" width="128" style="background: transparent;">
</p>

강력한 브라우저 확장 프로그램으로, 프롬프트 관리 및 빠른 입력에 중점을 둡니다. 사용자가 프롬프트 라이브러리를 생성, 관리 및 조직할 수 있도록 도우며, 모든 웹페이지 입력란에 사전 설정된 프롬프트 내용을 빠르게 삽입하여 작업 효율을 향상시킵니다.

> 브라우저 플러그인은 웹에서만 사용할 수 있으므로, 동일한 기능의 [Raycast 플러그인](https://github.com/wenyuanw/quick-prompt-raycast)을 오픈 소스로 제공하며, 브라우저 플러그인 데이터 형식을 호환하여 동일한 JSON 데이터로 무결점 마이그레이션을 지원합니다.

## ✨ 기능 특성

- 📚 **프롬프트 관리**: 프롬프트 라이브러리를 쉽고 편리하게 생성, 편집 및 관리
- 🚀 **빠른 입력**: 모든 웹페이지 입력란에서 `/p`를 입력하여 프롬프트 선택기를 빠르게 실행
- ⌨️ 프롬프트 선택기 열기 및 선택한 텍스트를 프롬프트로 저장하는 단축키 지원
- 📑 선택한 텍스트를 오른쪽 클릭 메뉴에서 바로 프롬프트로 저장 지원
- 🎯 분류, 제목, 내용, 태그 및 변수를 포함한 사용자 정의 프롬프트 지원
- 🧑‍💻 **변수 지원**: 프롬프트 내에서 `{{변수명}}` 형식의 변수를 사용할 수 있으며, 사용 시 구체적인 값을 입력 가능
- 💾 **데이터 백업**: 프롬프트 라이브러리 내보내기 및 가져오기를 지원하여 장치 간 마이그레이션 및 백업 용이
- 🔗 **Notion 동기화**: 프롬프트 라이브러리를 Notion 데이터베이스와 동기화 지원
- 🔍 프롬프트 검색 및 필터링 기능 지원
- 🌙 시스템의 라이트/다크 테마를 자동으로 감지하여 적응

## ⚠️ 알려진 문제

- Doubao(doubao.com) 웹페이지에서 `/p`로 프롬프트 선택기를 실행할 경우 일부 입력란에서 `/p`가 삭제되지 않는 문제가 있습니다. 걱정 마세요, 저와 제 오랜 파트너 Cursor가 밤낮으로 해결책을 찾고 있으며 조속히 수정할 예정입니다!

## 🚀 사용 방법

1. **빠른 실행**: 모든 웹페이지 텍스트 입력란에 `/p`를 입력하여 프롬프트 선택기를 실행
2. **단축키로 선택기 열기**: `Ctrl+Shift+P`(Windows/Linux) 또는 `Command+Shift+P`(macOS)로 프롬프트 선택기 열기
3. **프롬프트 선택**: 팝업된 선택기에서 원하는 프롬프트를 클릭하면 현재 입력란에 자동 삽입
4. **빠른 프롬프트 저장**: 텍스트를 선택한 후 `Ctrl+Shift+S`(Windows/Linux) 또는 `Command+Shift+S`(macOS)로 빠르게 프롬프트로 저장
5. **오른쪽 클릭 메뉴 저장**: 텍스트 선택 후 오른쪽 클릭하여 "해당 프롬프트 저장" 선택 시 선택된 내용이 프롬프트로 저장
6. **프롬프트 라이브러리 내보내기**: 관리 페이지에서 "내보내기" 버튼 클릭하여 모든 프롬프트를 JSON 파일로 로컬에 저장
7. **프롬프트 라이브러리 가져오기**: 관리 페이지에서 "가져오기" 버튼 클릭하여 로컬 JSON 파일에서 프롬프트 가져오기 (기존 프롬프트와 병합 또는 덮어쓰기 지원)

## 📸 인터페이스 미리보기

Quick Prompt는 직관적이고 친숙한 UI를 제공하여 프롬프트를 쉽게 관리하고 사용할 수 있습니다.

### 프롬프트 선택기

![프롬프트 선택기](https://github.com/user-attachments/assets/41b9897c-d701-4ff0-97f7-2f1754f570a8)

![프롬프트 선택기](https://github.com/user-attachments/assets/22d9d30c-b4c3-4e34-a0a0-8ef51e2cb942)

`/p` 단축명령어 또는 단축키를 사용하여 어떤 입력란에서도 빠르게 프롬프트 선택기를 불러와 필요한 프롬프트를 편리하게 선택하고 삽입할 수 있습니다.

### 프롬프트 관리 페이지

![프롬프트 관리](https://github.com/user-attachments/assets/371ae51e-1cee-4a66-a2a5-cca017396872)

관리 페이지에서 새 프롬프트를 생성하고, 기존 프롬프트를 편집하며, 태그를 추가하고 분류 관리가 가능합니다. UI가 간결하고 조작이 편리합니다.

### 오른쪽 클릭 메뉴 저장

![오른쪽 클릭 메뉴 저장](https://github.com/user-attachments/assets/17fc3bfd-3fa4-4b0b-ae1a-5cfd0b62be2e)

웹페이지에서 어떤 텍스트든 선택하고 오른쪽 클릭하여 빠르게 프롬프트로 저장할 수 있어 업무 효율을 높입니다.

### 프롬프트 변수 입력

![프롬프트 변수 팝업](https://github.com/user-attachments/assets/c91c1156-983a-454d-aad0-5698b0291b9b)

프롬프트는 변수를 설정할 수 있으며, 선택 후 팝업창에서 해당 변수 값을 입력할 수 있습니다.

## ⚙️ 사용자 정의 설정

1. 확장 아이콘을 클릭한 후 "프롬프트 관리" 버튼 클릭
2. 관리 페이지에서 다음 작업 가능:
   - 새 프롬프트 추가
   - 기존 프롬프트 편집
   - 필요 없는 프롬프트 삭제
   - 프롬프트에 태그 추가하여 분류
   - 프롬프트 라이브러리 내보내기로 백업
   - 이전에 백업한 프롬프트 라이브러리 가져오기

## 📦 설치 가이드

### 앱 스토어에서 설치

Chrome 웹 스토어에 출시되었습니다! [여기를 클릭하여 설치](https://chromewebstore.google.com/detail/quick-prompt/hnjamiaoicaepbkhdoknhhcedjdocpkd)

### GitHub 릴리즈에서 다운로드

1. [GitHub 릴리즈 페이지](https://github.com/wenyuanw/quick-prompt/releases) 방문
2. 최신 버전의 빌드된 플러그인 패키지 다운로드
3. 다운로드한 파일 압축 해제
4. 아래 설명에 따라 빌드된 확장 프로그램 설치

### 소스코드에서 빌드

1. 저장소 클론하기
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

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-15

---