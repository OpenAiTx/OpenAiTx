# cq - CSV 파일용 고성능 SQL 쿼리 엔진

 [![Cross-Build and Test (with zig build system)](https://github.com/baldimario/cq/actions/workflows/build-zig-cross.yml/badge.svg)](https://github.com/baldimario/cq/actions/workflows/build-zig-cross.yml)

데이터베이스 없이 CSV 파일에서 직접 SQL 쿼리를 실행할 수 있는 C로 작성된 경량, 고속 SQL 쿼리 프로세서입니다. 전체 문서는 /doc 디렉토리를 참조하세요.

 ![cq in action](https://raw.githubusercontent.com/baldimario/cq/main/assets/cq.png)

## 문서

- 시작하기: `doc/GettingStarted.md`
- 설치: `doc/Installation.md`
- 명령줄 인터페이스: `doc/CLI.md`
- **TUI (터미널 사용자 인터페이스)**: `doc/TUI.md`
- 아키텍처: `doc/Architecture.md`
- 테스트: `doc/Testing.md`
- 로드맵: `doc/Roadmap.md`
- 기여하기: `doc/Contributing.md`

## 빠른 시작

빌드: `make`

### 명령줄

샘플 쿼리 실행:
`./build/cq -q "SELECT name, age FROM 'data.csv' WHERE age > 25" -p`

### 터미널 UI

대화형 TUI 실행:
`./build/cqtui data/`

기능:
- CSV 파일을 테이블로 탐색 및 열기
- SQL 쿼리를 대화형으로 실행
- 여러 테이블을 위한 다중 탭 인터페이스
- 키보드 기반 탐색
- 외부 종속성 없음

## 예제 SQL 파일

저장소에는 assets/ 폴더에 예제 SQL 파일들(example_between.sql, example_aggregation.sql 등)이 포함되어 있습니다. 자세한 내용은 assets/를 참조하세요.

## 데이터 및 기능 개요

- 데이터 유형, 날짜 형식, CSV 형식 등에 대한 자세한 내용은 /doc 폴더를 참조하세요.

## 라이선스

MIT 라이선스입니다. 자세한 내용은 LICENSE 파일을 참조하세요.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-08

---