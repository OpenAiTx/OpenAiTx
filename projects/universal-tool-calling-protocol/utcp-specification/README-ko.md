<div align="right">
  <details>
    <summary >🌐 언어</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=universal-tool-calling-protocol&project=utcp-specification&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=universal-tool-calling-protocol&project=utcp-specification&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=universal-tool-calling-protocol&project=utcp-specification&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=universal-tool-calling-protocol&project=utcp-specification&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=universal-tool-calling-protocol&project=utcp-specification&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=universal-tool-calling-protocol&project=utcp-specification&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=universal-tool-calling-protocol&project=utcp-specification&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=universal-tool-calling-protocol&project=utcp-specification&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=universal-tool-calling-protocol&project=utcp-specification&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=universal-tool-calling-protocol&project=utcp-specification&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=universal-tool-calling-protocol&project=utcp-specification&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=universal-tool-calling-protocol&project=utcp-specification&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=universal-tool-calling-protocol&project=utcp-specification&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=universal-tool-calling-protocol&project=utcp-specification&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=universal-tool-calling-protocol&project=utcp-specification&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=universal-tool-calling-protocol&project=utcp-specification&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=universal-tool-calling-protocol&project=utcp-specification&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=universal-tool-calling-protocol&project=utcp-specification&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=universal-tool-calling-protocol&project=utcp-specification&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=universal-tool-calling-protocol&project=utcp-specification&lang=id">Bahasa Indonesia</a>
      </div>
    </div>
  </details>
</div>

# 범용 도구 호출 프로토콜 (UTCP) 명세

이 저장소는 범용 도구 호출 프로토콜(UTCP)의 공식 명세 문서를 포함하고 있습니다. UTCP는 다양한 통신 프로토콜을 통해 도구를 정의하고 상호작용하기 위한 현대적이고 유연하며 확장 가능한 표준입니다.

## UTCP란 무엇인가?

UTCP는 AI 시스템 및 기타 클라이언트가 사용된 기반 프로토콜(HTTP, WebSocket, CLI 등)에 관계없이 다양한 공급자의 도구를 탐색하고 호출할 수 있는 표준화된 방식을 제공합니다. 이 명세는 다음을 정의합니다:

- 도구 탐색 메커니즘
- 도구 호출 형식
- 공급자 구성
- 인증 방법
- 응답 처리

## 명세에 기여하기

UTCP 명세에 대한 기여를 환영합니다! 기여하는 방법은 다음과 같습니다:

1. **저장소를 포크하세요**: 명세 저장소를 자신의 포크로 만드세요
2. **변경 사항을 만드세요**: 필요에 따라 문서를 업데이트하거나 추가하세요
3. **풀 리퀘스트 제출**: 변경 사항을 리뷰를 위해 PR로 제출하세요
4. **토론에 참여하세요**: 제안된 변경 사항에 대한 대화에 참여하세요

기여 시, 다음 지침을 따라 주세요:

- 변경 사항이 UTCP의 전반적인 비전과 목표에 부합하는지 확인하세요
- 확립된 문서 구조와 형식을 준수하세요
- 새로운 기능이나 개념을 추가할 때 예제를 포함하세요
- 문서 전반의 일관성을 유지하기 위해 관련 섹션을 업데이트하세요

## 문서를 로컬에서 빌드하기

### 필수 조건

문서 사이트를 로컬에서 빌드하고 미리 보려면 다음이 필요합니다:

- Ruby 버전 2.5.0 이상
- RubyGems
- Bundler

### 설정

1. 저장소를 클론하세요:


   ```bash
   git clone https://github.com/universal-tool-calling-protocol/utcp-specification.git
   cd utcp-specification
   ```
2. 종속성 설치:

   ```bash
   bundle install
   ```
### 문서 사이트 실행하기

사이트를 로컬에서 빌드하고 서비스하려면:


```bash
bundle exec jekyll serve
```
This will start a local web server at `http://localhost:4000` where you can preview the documentation.

## Documentation Structure

The UTCP documentation is organized as follows:

- `index.md`: 홈페이지 및 UTCP 소개
- `docs/`
  - `introduction.md`: 자세한 소개 및 핵심 개념
  - `for-tool-providers.md`: 도구 제공자 구현 가이드
  - `for-tool-callers.md`: 도구 호출자 구현 가이드
  - `providers/`: 각 제공자 유형에 대한 문서
    - `http.md`: HTTP 제공자
    - `websocket.md`: WebSocket 제공자
    - `cli.md`: CLI 제공자
    - `sse.md`: 서버 전송 이벤트 제공자
    - 기타
  - `implementation.md`: 구현 지침 및 모범 사례

## Working with the Specification

### Modifying the Documentation

The documentation is written in Markdown format with Jekyll front matter. When making changes:

1. Markdown이 기존 스타일을 준수하는지 확인
2. PR 제출 전 로컬에서 변경 사항 미리보기
3. 예제는 최신 사양에 맞게 업데이트 유지
4. 새 페이지 추가 시 `_config.yml` 내 네비게이션 항목 업데이트

### File Organization

When adding new documentation:

- 제공자별 문서는 `docs/providers/`에 배치
- 일관된 front matter와 적절한 네비게이션 순서 사용
- GitHub Pages 검색 향상을 위한 태그 포함

## Version Control

The UTCP specification follows semantic versioning:

- 주요 버전 (1.0, 2.0): 프로토콜의 호환성 깨는 변경
- 부 버전 (1.1, 1.2): 하위 호환되는 신규 기능 추가
- 패치 버전 (1.0.1, 1.0.2): 하위 호환되는 버그 수정 및 명확화

## License

This specification is distributed under the Mozilla Public License 2.0 (MPL-2.0).

## Additional Resources

- [UTCP GitHub Organization](https://github.com/universal-tool-calling-protocol)
- [UTCP Website](https://utcp.io)
- [Reference Implementations](https://github.com/universal-tool-calling-protocol/python-utcp)
- [Community Discussions](https://github.com/universal-tool-calling-protocol/utcp-specification/discussions)



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-21

---