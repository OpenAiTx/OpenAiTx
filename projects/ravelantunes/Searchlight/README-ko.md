# Searchlight - Postgres MacOS 클라이언트

![Searchlight 스크린샷](https://raw.githubusercontent.com/ravelantunes/Searchlight/main/./docs/screenshot1.png)

Searchlight은 간단하고 가벼우며 개발자 친화적인 네이티브 macOS 오픈소스 PostgreSQL 클라이언트입니다. 완전한 데이터베이스 관리 도구의 복잡성 없이 데이터베이스 관리와 쿼리 실행을 위한 깔끔하고 직관적인 인터페이스를 제공합니다. Searchlight은 PostgreSQL 데이터베이스에 빠르고 쉽게 접근해야 하는 개발자에게 원활하고 효율적인 경험을 제공하는 데 중점을 둡니다.

## 설치

[릴리즈 페이지](https://github.com/ravelantunes/Searchlight/releases)에서 최신 버전을 다운로드하세요.

> 저는 개인 Apple 개발자 계정을 사용하므로 Apple에서 앱을 공인(notarize)할 수 없습니다. GitHub 릴리즈 페이지에서 설치를 시도하면 MacOS가 개발자 신원을 확인할 수 없다고 경고하므로 설정 > 개인정보 보호에서 설치를 승인하거나 소스에서 빌드해야 합니다.

## 현재 기능

### 연결 관리

- 즐겨찾기 연결 저장 및 관리
- 키 기반 인증을 사용하는 SSH 터널 지원
- SSL/TLS 연결 지원

### 데이터베이스 브라우저

- 데이터베이스, 스키마, 테이블 탐색
- 테이블 데이터에 대한 빠른 검색 및 필터링
- 외래 키 관계 링크 — 관련 레코드로 클릭하여 이동
- 컬럼 통계 팝오버 — 고유 값, 널 개수, 값 분포 차트 보기

### 데이터 조작

- 테이블에서 직접 새 행 삽입
- 셀 값, 행, 열을 다양한 형식으로 복사
- 데이터 삽입 시 외래 키 참조에서 자동 완성/데이터 조회
- 내보내기 형식: 일반 텍스트, CSV, SQL INSERT 문

### 쿼리 편집기

- 자유 형식 SQL 쿼리 실행
- 자동 완성, 진단, 호버 문서화를 위한 SQL LSP 지원

## 소스에서 빌드하기
1. 저장소 복제
2. Xcode에서 `Searchlight.xcodeproj` 열기
3. 두 번 빌드하기 (⌘B, ⌘B) — 첫 번째 빌드는 종속성을 다운로드하고 두 번째 빌드는 이를 포함합니다
4. 실행하기 (⌘R)

첫 번째 빌드는 SQL 자동완성, 문법 검사, 호버 문서화를 위한 [Postgres Language Server](https://github.com/supabase-community/postgres-language-server) 바이너리(~16MB)를 자동으로 다운로드합니다. 두 번째 빌드는 이를 앱에 번들로 포함하기 위해 필요합니다.

> **참고:** LSP 바이너리는 Apple Silicon(arm64) 전용입니다.

## 기술 스택

- **Swift & SwiftUI** — 고급 테이블 뷰를 위한 AppKit 통합을 포함한 네이티브 macOS 앱
- **PostgresKit / PostgresNIO** — 연결 풀링 기능이 있는 PostgreSQL 드라이버
- **SwiftNIO** — 비동기 네트워킹 기반
- **System SSH** — macOS 시스템 도구를 이용한 네이티브 SSH 터널 지원
- **Postgres Language Server** — SQL 지능(자동완성, 진단, 호버 문서)

## 기여

기여를 환영합니다! 이슈를 열거나 풀 리퀘스트를 제출해 주세요.

## 라이선스

자세한 내용은 [LICENSE](LICENSE)를 참조하세요.



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-07-09

---