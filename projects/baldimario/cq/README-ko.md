
<div align="right">
  <details>
    <summary >🌐 언어</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=baldimario&project=cq&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=baldimario&project=cq&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=baldimario&project=cq&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=baldimario&project=cq&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=baldimario&project=cq&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=baldimario&project=cq&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=baldimario&project=cq&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=baldimario&project=cq&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=baldimario&project=cq&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=baldimario&project=cq&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=baldimario&project=cq&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=baldimario&project=cq&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=baldimario&project=cq&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=baldimario&project=cq&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=baldimario&project=cq&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=baldimario&project=cq&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=baldimario&project=cq&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=baldimario&project=cq&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=baldimario&project=cq&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=baldimario&project=cq&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=baldimario&project=cq&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

# cq - CSV 파일을 위한 고성능 SQL 쿼리 엔진

 [![교차 빌드 및 테스트 (zig 빌드 시스템)](https://github.com/baldimario/cq/actions/workflows/build-zig-cross.yml/badge.svg)](https://github.com/baldimario/cq/actions/workflows/build-zig-cross.yml)

C로 작성된 경량, 고속 SQL 쿼리 프로세서로 데이터베이스 없이 CSV 파일에서 직접 SQL 쿼리를 실행할 수 있습니다. 전체 문서는 /doc 디렉터리를 참조하세요.

 ![cq 실행 화면](https://raw.githubusercontent.com/baldimario/cq/main/assets/cq.png)

## 문서

- 시작하기: `doc/GettingStarted.md`
- 설치: `doc/Installation.md`
- 명령줄 인터페이스: `doc/CLI.md`
- **TUI (터미널 사용자 인터페이스)**: `doc/TUI.md`
- 아키텍처: `doc/Architecture.md`
- 테스트: `doc/Testing.md`
- 로드맵: `doc/Roadmap.md`
- 기여 방법: `doc/Contributing.md`

## 빠른 시작

빌드: `make`

### 명령줄

샘플 쿼리 실행:
`./build/cq -q "SELECT name, age FROM 'data.csv' WHERE age > 25" -p`

### 터미널 UI

인터랙티브 TUI 실행:
`./build/cqtui data/`

기능:
- CSV 파일을 테이블로 탐색 및 열기
- SQL 쿼리 대화식 실행
- 여러 테이블을 위한 멀티탭 인터페이스
- 키보드 기반 탐색
- 외부 종속성 없음

## 예제 SQL 파일

이 저장소에는 assets/ 디렉터리에 예제 SQL이 포함되어 있습니다 (example_between.sql, example_aggregation.sql 등). 자세한 내용은 assets/ 폴더를 참조하세요.

## 데이터 및 기능 개요

- 데이터 타입, 날짜 형식, CSV 형식 등에 대한 자세한 내용은 /doc 폴더를 참조하세요.

## 라이선스

MIT 라이선스. 자세한 내용은 LICENSE 파일을 참조하세요.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-04-28

---