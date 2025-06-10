# TypeScript 7

[이게 뭔지 잘 모르시겠나요? 공지 게시물을 읽어보세요!](https://devblogs.microsoft.com/typescript/typescript-native-port/)

## 미리보기

미리보기 빌드는 npm에서 `@typescript/native-preview`로 제공됩니다.

```sh
npm install @typescript/native-preview
npx tsgo # tsc처럼 사용하세요.
```

미리보기용 VS Code 확장 프로그램이 [VS Code 마켓플레이스](https://marketplace.visualstudio.com/items?itemName=TypeScriptTeam.native-preview)에 제공됩니다.

이 확장 프로그램을 사용하려면, VS Code 설정에 다음을 추가하세요:

```json
{
    "typescript.experimental.useTsgo": true
}
```

## 빌드 및 실행 방법

이 저장소는 [Go 1.24 이상](https://go.dev/dl/), [Rust 1.85 이상](https://www.rust-lang.org/tools/install), [Node.js와 npm](https://nodejs.org/), 그리고 [`hereby`](https://www.npmjs.com/package/hereby)를 사용합니다.

테스트 및 코드 생성을 위해, 이 저장소에는 포팅 중인 커밋을 가리키는 메인 TypeScript 저장소의 git 서브모듈이 포함되어 있습니다.
클론할 때는 서브모듈과 함께 클론하는 것이 좋습니다:

```sh
git clone --recurse-submodules https://github.com/microsoft/typescript-go.git
```

이미 저장소를 클론했다면, 다음 명령어로 서브모듈을 초기화할 수 있습니다:

```sh
git submodule update --init --recursive
```

서브모듈이 준비되고 `npm ci`를 실행한 후에는 TypeScript 저장소와 비슷하게 `hereby`를 통해 작업을 실행할 수 있습니다:

```sh
hereby build          # 프로젝트 빌드 검증
hereby test           # 모든 테스트 실행
hereby install-tools  # 린터 등 추가 도구 설치
hereby lint           # 모든 린터 실행
hereby format         # 모든 코드 포맷팅
hereby generate       # 모든 Go 코드 생성 (예: 진단 코드, 저장소에 커밋됨)
```

추가 작업 항목은 개발 중입니다.

저장소 작업에 `hereby`가 필수는 아니며, 일반적인 `go` 도구 (예: `go build`, `go test ./...`)도 정상적으로 사용할 수 있습니다.
`hereby` 작업은 TypeScript 저장소에 익숙한 분들을 위한 편의 기능입니다.

### `tsgo` 실행하기

`hereby build`를 실행한 후에는, `built/local/tsgo`를 실행할 수 있으며, 이는 대부분 `tsc`와 동일하게 동작합니다.

### LSP 프로토타입 실행

VS Code 확장 프로그램을 전역 설치 없이 디버깅 및 실행하려면:

* 저장소 작업 공간에서 VS Code 실행 (`code .`)
* `.vscode/launch.template.json` 파일을 `.vscode/launch.json`으로 복사
* <kbd>F5</kbd> (또는 커맨드 팔레트에서 `Debug: Start Debugging`)

이렇게 하면 백엔드로 Corsa LS를 사용하는 새로운 VS Code 인스턴스가 실행됩니다. 올바르게 설정되었다면, TypeScript 또는 JavaScript 파일을 열 때 상태 표시줄에 "tsgo"가 표시됩니다:

![LSP Prototype Screenshot](https://raw.githubusercontent.com/microsoft/typescript-go/main/.github/ls-screenshot.png)


## 현재까지 동작하는 기능은?

아직 개발 진행 중이며, TypeScript와 완전한 기능 호환성에 도달하지 않았습니다. 버그가 있을 수 있습니다. 새로운 이슈를 등록하거나 의도적인 변경이라고 가정하기 전에 이 목록을 꼭 확인하세요.

| 기능 | 상태 | 비고 |
|---------|--------|-------|
| 프로그램 생성 | 완료 | TS5.8과 동일한 파일 및 모듈 해석. 아직 모든 해석 모드 지원되지 않음. |
| 파싱/스캐닝 | 완료 | TS5.8과 동일한 구문 오류 |
| 커맨드라인 및 `tsconfig.json` 파싱 | 거의 완료 | 진입점이 현재 약간 다름 |
| 타입 해석 | 완료 | TS5.8과 동일한 타입 |
| 타입 체크 | 완료 | TS5.8과 동일한 오류, 위치, 메시지. 오류 내 타입 출력이 다를 수 있음(개발 중) |
| JavaScript 전용 추론 및 JS Doc | 준비 안 됨 | - |
| JSX | 완료 | - |
| 선언 emit | 개발 중 | 대부분의 일반 기능은 구현됨. 일부 에지 케이스 및 기능 플래그는 아직 미지원 |
| Emit (JS 출력) | 개발 중 | `target: esnext`는 잘 지원됨, 다른 타깃에는 미지원 부분 있음 |
| Watch 모드 | 프로토타입 | 파일 감시 및 리빌드, 증분 재검사 없음 |
| 빌드 모드 / 프로젝트 참조 | 준비 안 됨 | - |
| 증분 빌드 | 준비 안 됨 | - |
| 언어 서비스 (LSP) | 프로토타입 | 최소한의 기능(오류, hover, go to def). 더 많은 기능이 곧 추가 예정 |
| API | 준비 안 됨 | - |

정의:

 * **완료** 또는 "believed done": 현재 결함이나 주요 남은 작업을 인지하지 못함. 버그 신고 가능
 * **개발 중**: 현재 작업 중; 일부 기능은 동작하고 일부는 아닐 수 있음. 패닉 관련 신고만 가능, 그 외는 삼가주세요
 * **프로토타입**: 개념 증명만 해당; 버그 신고는 삼가주세요
 * **준비 안 됨**: 아직 시작하지 않았거나, 손대기엔 준비가 너무 안 된 상태

## 기타 참고사항

장기적으로는 이 저장소와 그 내용이 `microsoft/TypeScript`에 병합될 예정입니다.
따라서 typescript-go 저장소와 이슈 트래커는 결국 종료될 예정이므로, 논의/이슈를 그에 맞게 다뤄주세요.

TypeScript 5.7과 관련된 의도적인 변경 목록은 CHANGES.md를 참고하세요.

## 기여 안내

이 프로젝트는 기여와 제안을 환영합니다. 대부분의 기여는
Contributor License Agreement (CLA) 동의를 필요로 하며, 해당 기여에 대한 권리가 있고
실제로 그 권리를 저희에게 부여한다는 것을 선언해야 합니다. 자세한 내용은 [Contributor License Agreements](https://cla.opensource.microsoft.com)를 참고하세요.

풀 리퀘스트를 제출하면 CLA 봇이 자동으로 CLA 제공 필요 여부를 판단하고 PR에 표시(예: 상태 체크, 코멘트 등)합니다.
봇이 안내하는 지시에 따라주시면 됩니다. CLA는 저희 CLA를 사용하는 모든 저장소에서 한 번만 동의하시면 됩니다.

이 프로젝트는 [Microsoft 오픈소스 행동 강령](https://opensource.microsoft.com/codeofconduct/)을 채택하였습니다.
자세한 내용은 [행동 강령 FAQ](https://opensource.microsoft.com/codeofconduct/faq/)를 참고하거나
추가 문의사항이 있으시면 [opencode@microsoft.com](mailto:opencode@microsoft.com)으로 연락주세요.

## 상표 관련

이 프로젝트에는 프로젝트, 제품 또는 서비스의 상표 또는 로고가 포함될 수 있습니다. Microsoft
상표 또는 로고의 공식적인 사용은
[Microsoft 상표 및 브랜드 가이드라인](https://www.microsoft.com/legal/intellectualproperty/trademarks/usage/general)을 따라야 하며, 이에 따라야 합니다.
이 프로젝트의 수정된 버전에서 Microsoft 상표 또는 로고를 사용할 때 혼동을 야기하거나 Microsoft의 후원을 암시해서는 안 됩니다.
타사 상표 또는 로고의 사용은 해당 타사의 정책을 따릅니다.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-10

---