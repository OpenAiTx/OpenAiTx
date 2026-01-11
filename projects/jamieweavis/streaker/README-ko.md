# Streaker <img alt="Streaker Logo" align="right" width=40 height=40 alt="Screenshot" src="https://raw.githubusercontent.com/jamieweavis/streaker/main/./.github/icons/icon.svg">

알림 알림과 함께하는 크로스 플랫폼 GitHub 기여 연속 기록 및 통계 추적 메뉴 바 애플리케이션

[![ci](https://github.com/jamieweavis/streaker/actions/workflows/ci.yml/badge.svg)](https://github.com/jamieweavis/streaker/actions)
[![downloads](https://img.shields.io/github/downloads/jamieweavis/streaker/total.svg)](https://github.com/jamieweavis/streaker/releases)
[![version](https://img.shields.io/github/release/jamieweavis/streaker.svg)](https://github.com/jamieweavis/streaker/releases)
[![license](https://img.shields.io/badge/license-MIT-blue.svg)](https://github.com/jamieweavis/streaker/blob/main/LICENSE)

<img width="716" alt="Screenshot" src="https://raw.githubusercontent.com/jamieweavis/streaker/main/.github/icons/screenshot.png">

## 설치

**[GitHub 릴리스](https://github.com/jamieweavis/streaker/releases)** 페이지에서 Streaker 최신 버전을 다운로드하세요 (또는 직접 빌드하려면 **[개발](#development)** 섹션을 참조하세요).

## 기능

- 메뉴 바 기여 통계
  - 연속 기록
    - 최고
    - 현재
    - 이전
  - 기여
    - 가장 많은 (하루)
    - 오늘
    - 총합 (연도)
- 기여 상태에 따라 메뉴 바 아이콘 변경
  - 비어 있음 - 오늘 기여하지 않음
  - 채워짐 - 오늘 기여함
  - 왕관 - 현재 최고 연속 기록 중
- 세 가지 메뉴 바 아이콘 테마
  - 불꽃
  - 타일
  - 옥토캣
- 연속 기록을 잃지 않도록 알림

### 메뉴 바 아이콘

#### 라이트 모드

| 상태 | 불꽃 | 타일 | 옥토캣 |
| ----- | ----- | ---- | ------- |
| 대기 중 | <img width="20" alt="Flame Empty" src="https://raw.githubusercontent.com/jamieweavis/streaker/main/.github/icons/pending-flame-mac.svg"> | <img width="20" alt="Tile Empty" src="https://raw.githubusercontent.com/jamieweavis/streaker/main/.github/icons/pending-tile-mac.svg"> | <img width="20" alt="Octocat Empty" src="https://raw.githubusercontent.com/jamieweavis/streaker/main/.github/icons/pending-octocat-mac.svg"> |
| 기여함 | <img width="20" alt="Flame Contributed" src="https://raw.githubusercontent.com/jamieweavis/streaker/main/.github/icons/contributed-flame-mac.svg"> | <img width="20" alt="Tile Contributed" src="https://raw.githubusercontent.com/jamieweavis/streaker/main/.github/icons/contributed-tile-mac.svg"> | <img width="20" alt="Octocat Contributed" src="https://raw.githubusercontent.com/jamieweavis/streaker/main/.github/icons/contributed-octocat-mac.svg"> |
| 연속중 | <img width="20" alt="Flame Crown" src="https://raw.githubusercontent.com/jamieweavis/streaker/main/.github/icons/streaking-flame-mac.svg"> | <img width="20" alt="Tile Streaking" src="https://raw.githubusercontent.com/jamieweavis/streaker/main/.github/icons/streaking-tile-mac.svg"> | <img width="20" alt="Octocat Streaking" src="https://raw.githubusercontent.com/jamieweavis/streaker/main/.github/icons/streaking-octocat-mac.svg"> |

#### 다크 모드

| 상태 | 불꽃 | 타일 | 옥토캣 |
| ----- | ----- | ---- | ------- |
| 대기 중 | <img width="20" alt="Flame Empty" src="https://raw.githubusercontent.com/jamieweavis/streaker/main/.github/icons/pending-flame-mac-white.svg"> | <img width="20" alt="Tile Empty" src="https://raw.githubusercontent.com/jamieweavis/streaker/main/.github/icons/pending-tile-mac-white.svg"> | <img width="20" alt="Octocat Empty" src="https://raw.githubusercontent.com/jamieweavis/streaker/main/.github/icons/pending-octocat-mac-white.svg"> |
| 기여함 | <img width="20" alt="Flame Contributed" src="https://raw.githubusercontent.com/jamieweavis/streaker/main/.github/icons/contributed-flame-mac-white.svg"> | <img width="20" alt="Tile Contributed" src="https://raw.githubusercontent.com/jamieweavis/streaker/main/.github/icons/contributed-tile-mac-white.svg"> | <img width="20" alt="Octocat Contributed" src="https://raw.githubusercontent.com/jamieweavis/streaker/main/.github/icons/contributed-octocat-mac-white.svg"> |
| 연속중 | <img width="20" alt="Flame Crown" src="https://raw.githubusercontent.com/jamieweavis/streaker/main/.github/icons/streaking-flame-mac-white.svg"> | <img width="20" alt="Tile Streaking" src="https://raw.githubusercontent.com/jamieweavis/streaker/main/.github/icons/streaking-tile-mac-white.svg"> | <img width="20" alt="Octocat Streaking" src="https://raw.githubusercontent.com/jamieweavis/streaker/main/.github/icons/streaking-octocat-mac-white.svg"> |

## 개발

### 사전 요구 사항

- [Node.js](https://github.com/nodejs/node) (>=22.x.x)
- [pnpm](https://github.com/pnpm/pnpm) (>=10.x.x)

### 시작하기

저장소를 복제하고 의존성을 설치하세요:

```sh
git clone https://github.com/jamieweavis/streaker.git

cd streaker

pnpm install
```

현재 플랫폼에 맞게 앱을 패키징하십시오:
```bash
pnpm package
```
_패키지된 앱은 이제 `out/` 디렉토리에 있습니다_

개발 모드에서 앱을 실행하세요:

```bash
pnpm start
```
*현재 핫 리로딩을 지원하는 것은 렌더러 프로세스뿐이며, `src/main/`의 변경 사항은 재시작이 필요합니다*

## 관련

- [Streaker CLI](https://github.com/jamieweavis/streaker-cli) - ASCII 기여 그래프가 포함된 GitHub 기여 연속 기록 및 통계 추적 커맨드 라인 애플리케이션
- [Contribution](https://github.com/jamieweavis/contribution) - GitHub 기여 그래프 파서로, 사용자의 GitHub 기여 그래프 페이지에서 기여 연속 기록 및 커밋 통계를 계산합니다



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-01-11

---