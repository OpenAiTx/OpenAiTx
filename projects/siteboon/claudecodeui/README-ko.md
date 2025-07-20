<div align="center">
  <img src="https://raw.githubusercontent.com/siteboon/claudecodeui/main/public/logo.svg" alt="Claude Code UI" width="64" height="64">
  <h1>Claude Code UI</h1>
</div>


AI 지원 코딩을 위한 Anthropic의 공식 CLI인 [Claude Code](https://docs.anthropic.com/en/docs/claude-code)를 위한 데스크톱 및 모바일 UI입니다. 로컬 또는 원격으로 사용하여 claude code의 활성 프로젝트와 세션을 보고 claude code CLI에서 하듯이 변경할 수 있습니다. 이를 통해 어디서나 작동하는 적절한 인터페이스를 제공합니다.

## 스크린샷

<div align="center">
  
<table>
<tr>
<td align="center">
<h3>데스크톱 뷰</h3>
<img src="https://raw.githubusercontent.com/siteboon/claudecodeui/main/public/screenshots/desktop-main.png" alt="Desktop Interface" width="400">
<br>
<em>프로젝트 개요 및 채팅을 보여주는 메인 인터페이스</em>
</td>
<td align="center">
<h3>모바일 경험</h3>
<img src="https://raw.githubusercontent.com/siteboon/claudecodeui/main/public/screenshots/mobile-chat.png" alt="Mobile Interface" width="250">
<br>
<em>터치 내비게이션을 지원하는 반응형 모바일 디자인</em>
</td>
</tr>
</table>



</div>

## 기능

- **반응형 디자인** - 데스크톱, 태블릿, 모바일에서 원활하게 작동하여 모바일에서도 Claude Code를 사용할 수 있습니다.
- **인터랙티브 채팅 인터페이스** - Claude Code와 원활하게 소통할 수 있는 내장 채팅 인터페이스
- **통합 셸 터미널** - 내장 셸 기능을 통해 Claude Code CLI에 직접 접근 가능
- **파일 탐색기** - 문법 하이라이트 및 실시간 편집이 가능한 인터랙티브 파일 트리
- **Git 탐색기** - 변경 사항 보기, 스테이징 및 커밋, 브랜치 전환 가능
- **세션 관리** - 대화 이어가기, 여러 세션 관리, 기록 추적


## 빠른 시작

### 사전 요구사항

- [Node.js](https://nodejs.org/) v20 이상
- [Claude Code CLI](https://docs.anthropic.com/en/docs/claude-code) 설치 및 구성 완료

### 설치

1. **레포지토리 클론:**
```bash
git clone https://github.com/siteboon/claudecodeui.git
cd claudecodeui
```
2. **종속성 설치:**

```bash
npm install
```
3. **환경 구성:**

```bash
cp .env.example .env
# Edit .env with your preferred settings
```
4. **애플리케이션 시작:**

```bash
# Development mode (with hot reload)
npm run dev

```
애플리케이션은 .env 파일에 지정한 포트에서 시작됩니다.

5. **브라우저 열기:**
   - 개발 환경: `http://localhost:3001`

## 보안 및 도구 설정

**🔒 중요 공지**: 모든 Claude Code 도구는 **기본적으로 비활성화**되어 있습니다. 이는 잠재적으로 해로운 작업이 자동으로 실행되는 것을 방지합니다.

### 도구 활성화

Claude Code의 모든 기능을 사용하려면 도구를 수동으로 활성화해야 합니다:

1. **도구 설정 열기** - 사이드바의 톱니바퀴 아이콘 클릭
3. **선택적 활성화** - 필요한 도구만 켜기
4. **설정 적용** - 환경 설정이 로컬에 저장됩니다

<div align="center">

![도구 설정 모달](https://raw.githubusercontent.com/siteboon/claudecodeui/main/public/screenshots/tools-modal.png)
*도구 설정 인터페이스 - 필요한 도구만 활성화하세요*

</div>

**권장 방법**: 기본 도구부터 활성화하고 필요에 따라 추가하세요. 언제든지 설정을 조정할 수 있습니다.

## 사용 가이드

### 핵심 기능

#### 프로젝트 관리
UI는 `~/.claude/projects/`에서 Claude Code 프로젝트를 자동으로 탐색하며 다음을 제공합니다:
- **시각적 프로젝트 브라우저** - 메타데이터 및 세션 수가 포함된 모든 프로젝트
- **프로젝트 작업** - 이름 변경, 삭제 및 프로젝트 구성
- **스마트 내비게이션** - 최근 프로젝트 및 세션에 빠르게 접근

#### 채팅 인터페이스
- **반응형 채팅 또는 Claude Code CLI 사용** - 적응된 채팅 인터페이스를 사용하거나 셸 버튼을 눌러 Claude Code CLI에 연결할 수 있습니다.
- **실시간 통신** - WebSocket 연결을 통한 Claude 응답 스트리밍
- **세션 관리** - 이전 대화 이어가기 또는 새 세션 시작
- **메시지 기록** - 타임스탬프 및 메타데이터가 포함된 전체 대화 기록
- **다중 포맷 지원** - 텍스트, 코드 블록, 파일 참조

#### 파일 탐색기 및 편집기
- **인터랙티브 파일 트리** - 확장/축소 내비게이션으로 프로젝트 구조 탐색
- **실시간 파일 편집** - 인터페이스 내에서 직접 파일 읽기, 수정, 저장
- **문법 강조** - 여러 프로그래밍 언어 지원
- **파일 작업** - 파일 및 디렉터리 생성, 이름 변경, 삭제

#### Git 탐색기


#### 세션 관리
- **세션 지속성** - 모든 대화 자동 저장
- **세션 조직화** - 프로젝트 및 타임스탬프별 세션 그룹화
- **세션 작업** - 이름 변경, 삭제 및 대화 기록 내보내기
- **기기 간 동기화** - 모든 기기에서 세션 접근 가능

### 모바일 앱
- **반응형 디자인** - 모든 화면 크기에 최적화
- **터치 친화적 인터페이스** - 스와이프 제스처 및 터치 내비게이션
- **모바일 내비게이션** - 엄지손가락 조작이 편리한 하단 탭 바
- **적응형 레이아웃** - 접이식 사이드바 및 스마트 콘텐츠 우선순위 지정
- **홈 화면에 바로가기 추가** - 홈 화면에 바로가기를 추가하면 앱이 PWA처럼 동작합니다

## 아키텍처

### 시스템 개요

```
┌─────────────────┐    ┌─────────────────┐    ┌─────────────────┐
│   Frontend      │    │   Backend       │    │  Claude CLI     │
│   (React/Vite)  │◄──►│ (Express/WS)    │◄──►│  Integration    │
└─────────────────┘    └─────────────────┘    └─────────────────┘
```
### Backend (Node.js + Express)
- **Express 서버** - 정적 파일 제공이 포함된 RESTful API
- **WebSocket 서버** - 채팅 및 프로젝트 새로고침용 통신
- **Claude CLI 통합** - 프로세스 생성 및 관리
- **세션 관리** - JSONL 파싱 및 대화 지속성
- **파일 시스템 API** - 프로젝트용 파일 브라우저 노출

### Frontend (React + Vite)
- **React 18** - 훅을 활용한 최신 컴포넌트 아키텍처
- **CodeMirror** - 구문 강조 기능이 있는 고급 코드 편집기





### 기여하기

기여를 환영합니다! 다음 가이드라인을 따라주세요:

#### 시작하기
1. 저장소를 **포크**하세요
2. 포크한 저장소를 **클론**하세요: `git clone <your-fork-url>`
3. 의존성 **설치**: `npm install`
4. 기능 브랜치 **생성**: `git checkout -b feature/amazing-feature`

#### 개발 절차
1. 기존 코드 스타일을 따라 **변경 사항을 만드세요**
2. **철저히 테스트**하세요 - 모든 기능이 올바르게 작동하는지 확인
3. 품질 검사 실행: `npm run lint && npm run format`
4. [Conventional Commits](https://conventionalcommits.org/) 규칙에 따라 설명이 포함된 커밋
5. 브랜치에 **푸시**: `git push origin feature/amazing-feature`
6. 풀 리퀘스트 제출 시:
   - 변경 사항에 대한 명확한 설명
   - UI 변경의 스크린샷
   - 해당하는 경우 테스트 결과

#### 기여 가능한 내용
- **버그 수정** - 안정성 개선 지원
- **새 기능** - 기능 향상 (사전 이슈 논의 필수)
- **문서화** - 가이드 및 API 문서 개선
- **UI/UX 개선** - 사용자 경험 향상
- **성능 최적화** - 속도 향상

## 문제 해결

### 자주 발생하는 문제 및 해결책

#### "Claude 프로젝트를 찾을 수 없음"
**문제**: UI에 프로젝트가 없거나 프로젝트 목록이 비어 있음  
**해결책**:
- [Claude CLI](https://docs.anthropic.com/en/docs/claude-code)가 제대로 설치되었는지 확인
- 최소 한 개 프로젝트 디렉터리에서 `claude` 명령 실행하여 초기화
- `~/.claude/projects/` 디렉터리가 존재하고 적절한 권한이 있는지 확인  
d

#### 파일 탐색기 문제
**문제**: 파일이 로드되지 않거나 권한 오류, 빈 디렉터리  
**해결책**:
- 프로젝트 디렉터리 권한 확인 (`터미널에서 ls -la` 명령)
- 프로젝트 경로가 존재하고 접근 가능한지 확인
- 서버 콘솔 로그에서 자세한 오류 메시지 검토
- 프로젝트 범위를 벗어난 시스템 디렉터리에 접근하지 않는지 확인


## 라이선스

GNU 일반 공중 사용 허가서 v3.0 - 자세한 내용은 [LICENSE](LICENSE) 파일 참조.

이 프로젝트는 오픈 소스이며 GPL v3 라이선스 하에 자유롭게 사용, 수정, 배포할 수 있습니다.

## 감사의 말

### 사용 기술
- **[Claude Code](https://docs.anthropic.com/en/docs/claude-code)** - Anthropic 공식 CLI
- **[React](https://react.dev/)** - 사용자 인터페이스 라이브러리
- **[Vite](https://vitejs.dev/)** - 빠른 빌드 도구 및 개발 서버
- **[Tailwind CSS](https://tailwindcss.com/)** - 유틸리티 우선 CSS 프레임워크
- **[CodeMirror](https://codemirror.net/)** - 고급 코드 편집기


## 지원 및 커뮤니티

### 최신 소식 받기
- 이 저장소에 **별**을 주세요
- 업데이트 및 새 릴리스에 대해 **감시**하세요
- 공지 사항을 위해 프로젝트를 **팔로우**하세요

### 후원사
- [Siteboon - AI 기반 웹사이트 빌더](https://siteboon.ai)
---

<div align="center">
  <strong>Claude Code 커뮤니티를 위해 정성껏 만들었습니다.</strong>
</div>



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-20

---