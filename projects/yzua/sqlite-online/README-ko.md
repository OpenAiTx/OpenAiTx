# SQLite 온라인

<div align="center">
  <a href="https://yzua.github.io/sqlite-online/">
    <img
      src="https://github.com/user-attachments/assets/aef749bf-df08-4a84-8148-d34b796449d8"
      alt="SQLite 온라인 로고"
      width="128"
    />
  </a>
</div>

React, TypeScript, Vite, 그리고 `sql.js`로 구축된 클라이언트 사이드 SQLite 편집기입니다.
브라우저에서 실행되며, 기본적으로 데모 데이터베이스를 초기화하고
백엔드 없이 로컬 SQLite 파일을 열 수 있습니다.

## 개요

- **로컬 `.db`, `.sqlite`, `.sqlite3` 파일 열기**
- **SQL로 테이블, 뷰, 인덱스 생성 및 수정**
- **행 탐색, 필터링, 정렬, 페이지네이션, 추가, 편집, 삭제**
- **사용자 정의 SQL 실행 및 결과를 CSV로 내보내기**

대부분의 데이터베이스 작업은 WebAssembly와 웹 워커를 통해 브라우저 내에서 로컬로 실행됩니다.
URL 로딩, CORS 프록시 폴백, Google 폰트, Gemini 기반 쿼리 생성 같은 선택적 기능은 네트워크 요청을 사용합니다.

## 기능

- **로컬 우선 데이터베이스 편집:** 디스크에서 파일 열기, 데이터베이스를 페이지에 드래그 앤 드롭, 현재 데이터베이스를
  `database.sqlite`로 다운로드.
- **스키마 및 데이터 작업 흐름:** 스키마 검사, 테이블 데이터 탐색, 행 편집,
  새 행 삽입, 행 삭제, 사용자 정의 SQL 문 실행.
- **CSV 내보내기 경로:** 전체 테이블, 현재 테이블 페이지 또는
  현재 사용자 정의 쿼리 결과 세트를 CSV로 내보내기.
- **추가 UX 기능:** 다크 모드, 고대비 모드, 키보드 단축키, 건너뛰기 링크, 접근성을 위한 라이브 영역.
- **선택적 통합:** `?url=` 쿼리 매개변수로 데이터베이스 로드 및 Gemini API 키 구성 후 `/ai ...` 프롬프트를 통한 SQL 생성.





## 개발

```bash
npm install
npm run dev
```
유용한 프로젝트 명령어:

- `npm run build`
- `npm run build:pages`
- `npm run typecheck`
- `npm run check`
- `npm run check:fix`
- `npm run doctor`
- `npm run preview`
- `npm run preview:pages`
- `npm run lint`
- `npm run lint:fix`
- `npm run format`
- `npm run format:check`
- `npm test`
- `npm run test:watch`
- `npm run knip`
- `npm run deploy`

## 키보드 단축키 (핫키)

이 내장 핫키로 작업 흐름을 간소화하세요:

| 단축키                 | 동작                        |
| --------------------- | --------------------------- |
| **Ctrl + s**          | 데이터베이스 다운로드         |
| **Ctrl + ArrowRight** | 다음 페이지로 이동           |
| **Ctrl + ArrowUp**    | 첫 페이지로 점프             |
| **Ctrl + ArrowDown**  | 마지막 페이지로 점프         |
| **Ctrl + ArrowLeft**  | 이전 페이지로 이동           |
| **Ctrl + \`**         | 편집 패널 닫기              |
| **Ctrl + i**          | 입력 모드 / 입력 제출        |
| **Ctrl + u**          | 수정 편집 제출              |
| **Ctrl + d**          | 삭제 편집 제출              |
| **Ctrl + q**          | SQL 쿼리 실행               |

## 라이선스

SQLite Online은 [GNU GPL v3.0](https://github.com/yzua/sqlite-online/blob/main/LICENSE) 하에 배포됩니다.



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-07-06

---