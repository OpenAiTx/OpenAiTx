# 범용 도구 호출 프로토콜 (UTCP) 명세서

이 저장소는 범용 도구 호출 프로토콜(UTCP)의 공식 명세 문서를 포함하고 있습니다. UTCP는 다양한 통신 프로토콜 전반에서 도구를 정의하고 상호작용하기 위한 현대적이고 유연하며 확장 가능한 표준입니다.

## UTCP란 무엇인가요?

UTCP는 AI 시스템 및 기타 클라이언트가 사용되는 기본 프로토콜(HTTP, WebSocket, CLI 등)에 상관없이 다양한 공급업체의 도구를 발견하고 호출할 수 있도록 표준화된 방법을 제공합니다. 이 명세서는 다음을 정의합니다:

- 도구 발견 메커니즘
- 도구 호출 형식
- 공급자 구성
- 인증 방법
- 응답 처리

## 명세 기여 방법

UTCP 명세에 대한 기여를 환영합니다! 기여 방법은 다음과 같습니다:

1. **저장소 포크하기**: 명세 저장소를 자신의 계정으로 포크합니다
2. **변경사항 적용**: 필요에 따라 문서를 업데이트하거나 추가합니다
3. **풀 리퀘스트 제출**: 변경사항을 리뷰받기 위해 PR을 엽니다
4. **토론 참여**: 제안된 변경사항에 대한 논의에 참여합니다

기여 시 다음 지침을 따라주세요:

- 변경사항이 UTCP의 전체적인 비전 및 목표와 일치하는지 확인하세요
- 문서의 기존 구조와 서식을 준수하세요
- 새로운 기능이나 개념을 추가할 때 예제를 포함하세요
- 문서 전체의 일관성을 위해 관련 섹션을 업데이트하세요

## 문서 로컬 빌드 방법

### 사전 준비

문서 사이트를 로컬에서 빌드하고 미리보기하려면 아래가 필요합니다:

- Ruby 2.5.0 이상 버전
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

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-24

---