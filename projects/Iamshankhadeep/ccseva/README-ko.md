<translate-content># CCSeva 🤖

[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](https://opensource.org/licenses/MIT)
[![GitHub release](https://img.shields.io/github/release/Iamshankhadeep/ccseva.svg)](https://github.com/Iamshankhadeep/ccseva/releases)
[![Build Status](https://img.shields.io/github/actions/workflow/status/Iamshankhadeep/ccseva/ci.yml?branch=main)](https://github.com/Iamshankhadeep/ccseva/actions)
[![Downloads](https://img.shields.io/github/downloads/Iamshankhadeep/ccseva/total.svg)](https://github.com/Iamshankhadeep/ccseva/releases)
[![macOS](https://img.shields.io/badge/macOS-10.15%2B-blue)](https://github.com/Iamshankhadeep/ccseva)

실시간으로 Claude Code 사용량을 추적할 수 있는 아름다운 macOS 메뉴 바 앱입니다. 우아한 인터페이스로 토큰 소비, 비용 및 사용 패턴을 모니터링하세요.

## 스크린샷

![대시보드](https://raw.githubusercontent.com/Iamshankhadeep/ccseva/main/./screenshots/dashboard.png)
![분석](https://raw.githubusercontent.com/Iamshankhadeep/ccseva/main/./screenshots/analytics.png)
![터미널](https://raw.githubusercontent.com/Iamshankhadeep/ccseva/main/./screenshots/terminal.png)

## 기능

- **실시간 모니터링** - 30초마다 업데이트되는 실시간 토큰 사용량 추적
- **메뉴 바 통합** - 색상 코드 상태와 백분율 표시기
- **스마트 플랜 감지** - Pro/Max5/Max20/사용자 지정 플랜 자동 감지
- **사용 분석** - 7일 차트, 모델별 내역 및 추세 분석
- **스마트 알림** - 70% 및 90% 임계값 도달 시 쿨다운 기능 포함 알림
- **비용 추적** - 일일 비용 추정 및 소모율 계산
- **아름다운 UI** - 그라데이션 디자인과 글래스 모피즘 효과

## 설치

### 다운로드 (권장)
최신 릴리스를 [GitHub 릴리스](https://github.com/Iamshankhadeep/ccseva/releases)에서 다운로드하세요:
- **macOS (Apple Silicon)**: `CCSeva-darwin-arm64.dmg`
- **macOS (Intel)**: `CCSeva-darwin-x64.dmg`

### 소스에서 빌드하기</translate-content>
```bash
git clone https://github.com/Iamshankhadeep/ccseva.git
cd ccseva
npm install
npm run build
npm start
```
### 개발

```bash
npm run electron-dev  # Hot reload development
```
## 사용법

1. **실행** - 메뉴 바에 CCSeva가 나타납니다  
2. **클릭** - 상세 사용 통계 보기  
3. **우클릭** - 새로고침 및 종료 옵션에 접근  

앱은 `~/.claude` 디렉토리에서 Claude Code 설정을 자동으로 감지하며 30초마다 업데이트합니다.

## 요구 사항

- macOS 10.15 이상  
- Node.js 18 이상 (소스 빌드용)  
- Claude Code CLI 설치 및 구성 완료  

## 기술 스택

- Electron 36 + React 19 + TypeScript 5  
- Tailwind CSS 3 + Radix UI 컴포넌트  
- 데이터 통합용 ccusage 패키지  

## 라이선스

MIT 라이선스 - 자세한 내용은 [LICENSE](LICENSE) 파일 참조.

## 크레딧

❤️ 를 담아 [Electron](https://electronjs.org), [React](https://reactjs.org), [Tailwind CSS](https://tailwindcss.com), 그리고 [ccusage](https://github.com/ryoppippi/ccusage) 를 사용하여 제작했습니다.

---

**참고**: 이 도구는 Claude Code 사용 추적을 위한 비공식 도구입니다. 유효한 Claude Code 설치 및 구성이 필요합니다.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-20

---