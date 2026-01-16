# 치트 시트

[![GitHub](https://img.shields.io/badge/github-michaelmagan/cheatsheet-blue?logo=github)](https://github.com/michaelmagan/cheatsheet)
[![License](https://img.shields.io/badge/license-MIT-green.svg)](./LICENSE)
[![Next.js](https://img.shields.io/badge/Next.js-15-black?logo=next.js)](https://nextjs.org/)
[![Tambo AI](https://img.shields.io/badge/Tambo-AI-purple)](https://tambo.co)

[Tambo AI](https://tambo.co)로 제작된 AI 기반 오픈 소스 구글 시트 경쟁자입니다.

자연어와 함께 그래프 및 시각화와 함께 대화형 스프레드시트를 구축하고 조작하세요.

## 데모
직접 사용해보세요: **[CheatSheet](https://cheatsheet.tambo.co)**

### 미리보기
https://github.com/user-attachments/assets/da72aa8b-6bc5-468e-8f42-0da685105d22

## 기능

- **AI로 편집**: 자연어로 스프레드시트와 상호작용하세요.
- **셀 선택**: AI와 상호작용할 셀을 선택하세요.
- **멀티모달**: 메시지와 함께 이미지를 첨부하세요.
- **차트 및 그래프**: 스프레드시트 데이터로 시각화를 생성하세요.
- **모델 컨텍스트 프로토콜 (MCP)**: 외부 데이터 소스 및 도구를 연결하세요.

## 로드맵

- **음성 입력**: 타이핑 외에 음성 입력 지원.
- **수식 지원**: 스프레드시트 수식 (SUM, AVERAGE, IF, VLOOKUP 등)
- **향상된 서식**: 표에 대한 더 많은 시각적 옵션 (색상, 테두리, 글꼴, 정렬)
- **가져오기/내보내기**: CSV, XLSX, JSON 지원


## 시작하기

1. 이 저장소를 클론하세요

2. 프로젝트 디렉터리로 이동하세요:
   ```bash
   cd spreadsheet-template
   ```
3. 의존성 설치:

   ```bash
   npm install
   ```

4. 환경 변수를 설정하세요:

   **옵션 A: Tambo CLI 사용 (권장)**
   ```bash
   npx tambo init
   ```
   이 작업은 대화형으로 Tambo API 키를 입력하도록 요청하고 자동으로 `.env.local`을 생성합니다.

   **옵션 B: 수동 설정**
   ```bash
   cp example.env.local .env.local
   ```
   그런 다음 `.env.local`을 편집하고 [tambo.co/dashboard](https://tambo.co/dashboard)에서 API 키를 추가하세요.

5. 개발 서버를 시작합니다:
   ```bash
   npm run dev
   ```
6. 브라우저에서 [http://localhost:3000](http://localhost:3000) 을 열어 앱을 사용하세요!

## 아키텍처 개요

이 템플릿은 AI가 세 가지 방법으로 스프레드시트를 읽고 업데이트하는 방법을 보여줍니다:

### AI가 스프레드시트 상태에 접근하는 방법

**컨텍스트 헬퍼** (읽기 전용 데이터)
- `spreadsheetContextHelper` - AI에게 현재 탭의 데이터를 마크다운 표 형식으로 제공
- `spreadsheetSelectionContextHelper` - AI에게 현재 선택된 내용을 알려줌
- `tabContextHelper` - 모든 탭을 나열하고 활성 탭을 강조 표시
- 메시지를 보낼 때마다 자동으로 실행
- 참고: `src/lib/spreadsheet-context-helper.ts`, `src/lib/spreadsheet-selection-context.ts`, `src/lib/tab-context-helper.ts`

**도구** (변경 수행)
- AI가 상태를 변경하거나 메타데이터를 검사할 수 있는 스프레드시트 및 탭 도구
- 컨텍스트 헬퍼는 읽기 전용; 도구는 변경 수행
- 참고: `src/tools/spreadsheet-tools.ts`, `src/tools/tab-tools.ts`

### 스프레드시트 도구 참조

| 도구 | 용도 |
|------|---------|
| `updateCell` | 단일 셀 값을 업데이트 |
| `updateRange` | 여러 셀을 한 번에 업데이트 |
| `addColumn` | 새 열 추가 |
| `removeColumn` | 열 삭제 |
| `addRow` | 새 행 추가 |
| `removeRow` | 행 삭제 |
| `readCell` | 단일 셀 값 읽기 |
| `readRange` | 여러 셀 값 읽기 |
| `clearRange` | 범위 내 셀 값 지우기 |
| `sortByColumn` | 열 값으로 행 정렬 |

### 주요 파일

**구성**
- `src/lib/tambo.ts` - 컴포넌트 및 도구 등록

- `src/app/chat/page.tsx` - TamboProvider가 포함된 주요 채팅 인터페이스

**스프레드시트 시스템**
- `src/components/ui/spreadsheet-tabs.tsx` - FortuneSheet 워크북 래퍼 + 탭 UI
- `src/lib/fortune-sheet-store.tsx` - 워크북 상태를 연결하는 인메모리 글로벌 스토어
- `src/lib/fortune-sheet-utils.ts` - FortuneSheet 중심의 유틸리티 (범위, 조회)

**상태 관리**
- `src/lib/canvas-storage.ts` - 캔버스/탭 상태 관리
- 스프레드시트 상태는 FortuneSheet 프로바이더와 워크북 API를 통해 흐릅니다.

**종속성 주의:** FortuneSheet(`@fortune-sheet/{core,react}`)가 모든 스프레드시트 상호작용을 지원합니다.

## 커스터마이징

### 커스텀 컴포넌트 추가

AI가 채팅 내에서 인라인으로 렌더링할 수 있도록 `src/lib/tambo.ts`에 컴포넌트를 등록하세요. 예시 구조:

```tsx
import type { TamboComponent } from "@tambo-ai/react";

const components: TamboComponent[] = [
  {
    name: "MyComponent",
    description: "When to use this component",
    component: MyComponent,
    propsSchema: myComponentSchema, // Zod schema
  },
];
```

컴포넌트 예시는 `src/components/tambo/`를 참조하고, 자세한 안내는 [Tambo Components 문서](https://docs.tambo.co/concepts/components)를 확인하세요.

### 맞춤 도구 만들기

`src/tools/`에 도구를 다음 패턴에 따라 추가하세요:

```tsx
export const myTool = {
  name: "toolName",
  description: "What this tool does",
  tool: async (param: string) => {
    // Implementation
    return { success: true, message: "Result" };
  },
  toolSchema: z.function().args(
    z.string().describe("Parameter description")
  ).returns(z.object({
    success: z.boolean(),
    message: z.string().optional(),
  })),
};
```
`src/lib/tambo.ts`의 tools 배열에 등록하세요. 자세한 내용은 [Tambo Tools 문서](https://docs.tambo.co/concepts/tools)를 참조하세요.

### 모델 컨텍스트 프로토콜 (MCP)

설정 모달을 통해 MCP 서버를 구성하여 외부 데이터 소스에 연결합니다. 서버 정보는 브라우저의 localStorage에 저장되며 채팅 인터페이스에서 `TamboMcpProvider`로 래핑됩니다.

## 문서

Tambo에 대해 자세히 알아보기:
- [컴포넌트](https://docs.tambo.co/concepts/components)
- [상호작용 가능한 컴포넌트](https://docs.tambo.co/concepts/components/interactable-components)
- [도구](https://docs.tambo.co/concepts/tools)
- [추가 컨텍스트](https://docs.tambo.co/concepts/additional-context)

[Tambo AI](https://tambo.co)로 제작 - AI 기반 UI 구축을 위한 프레임워크입니다. Tambo는 오픈 소스입니다: [tambo-ai/tambo](https://github.com/tambo-ai/tambo).

![Tambo 템플릿 데모](https://raw.githubusercontent.com/tambo-ai/tambo/main/assets/template.gif)

## 기여

기여를 환영합니다! 가이드라인은 [CONTRIBUTING.md](https://raw.githubusercontent.com/michaelmagan/cheatsheet/main/./CONTRIBUTING.md)를 참조하세요.

## 라이선스

MIT 라이선스



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-01-16

---