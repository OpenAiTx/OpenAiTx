# Raindrop.io MCP 서버

[![smithery 배지](https://smithery.ai/badge/@adeze/raindrop-mcp)](https://smithery.ai/server/@adeze/raindrop-mcp)
[![npm 버전](https://badge.fury.io/js/%40adeze%2Fraindrop-mcp.svg)](https://www.npmjs.com/package/@adeze/raindrop-mcp)
[![Claude 데스크탑 MCPB](https://img.shields.io/badge/Claude%20Desktop-MCPB-5B61FF?logo=claude&logoColor=white)](https://github.com/adeze/raindrop-mcp/releases)

간단한 MCP 서버로 Raindrop.io를 AI 어시스턴트에 연결하세요. 자연어로 북마크를 정리, 검색 및 관리하는 데 사용합니다.

## 기능

- 컬렉션 및 북마크 생성, 업데이트, 삭제
- 태그, 도메인, 유형, 날짜 등으로 북마크 검색
- 태그 관리(목록, 이름 변경, 병합, 삭제)
- 북마크에서 하이라이트 읽기
- 컬렉션 내 북마크 대량 편집
- 끊어진 링크 및 중복 감사, 휴지통 관리

## 도구

- **diagnostics** - 서버 진단 정보 및 라이브러리 상태 지표
- **collection_list** - 모든 컬렉션을 평면 목록으로 표시
- **get_collection_tree** - 전체 경로가 포함된 계층적 컬렉션 뷰
- **collection_manage** - 컬렉션 생성, 업데이트 또는 삭제
- **bookmark_search** - 필터, 태그, 페이지네이션을 통한 고급 검색
- **bookmark_manage** - 북마크 생성, 업데이트 또는 삭제
- **get_raindrop** - ID로 단일 북마크 가져오기
- **list_raindrops** - 페이지네이션이 있는 컬렉션 북마크 목록
- **get_suggestions** - URL 또는 북마크에 대한 AI 기반 조직 조언(태그/컬렉션)
- **suggest_tags** - AI 지원 분석으로 북마크 메타데이터에서 관련 태그 제안
- **bulk_edit_raindrops** - 특정 컬렉션 내 북마크 대량 업데이트, 이동 또는 제거
- **tag_manage** - 태그 이름 변경, 병합 또는 삭제
- **highlight_manage** - 하이라이트 생성, 업데이트 또는 삭제
- **library_audit** - 끊어진 링크, 중복, 태그 없는 항목 스캔
- **empty_trash** - 휴지통 영구 비우기(확인 필요)
- **cleanup_collections** - 빈 컬렉션 제거(확인 필요)
- **remove_duplicates** - 안전한 확인 절차를 통한 중복 북마크 탐색 및 제거

## 설치

### 빠른 시작 (한 줄 명령어)
| 도구                | 한 줄 명령어                                                       |
| :----------------- | :----------------------------------------------------------------- |
| **Gemini CLI**     | `gemini extensions install https://github.com/adeze/raindrop-mcp`  |
| **Codex CLI**      | `codex mcp add raindrop -- npx -y @adeze/raindrop-mcp`             |
| **Claude Code**    | `claude mcp add raindrop -- npx -y @adeze/raindrop-mcp`            |
| **GitHub Copilot** | `gh copilot config mcp add raindrop -- npx -y @adeze/raindrop-mcp` |
| **Vercel Skills**  | `npx skills add adeze/raindrop-mcp`                                |

> **참고**: `npx`를 통해 MCP 서버를 추가하는 도구의 경우, 셸 또는 도구의 환경 구성에 `RAINDROP_ACCESS_TOKEN` 환경 변수가 설정되어 있어야 합니다.

### Vercel Skills (npx skills)

이 프로젝트는 [Vercel Skills](https://github.com/vercel/skills) 시스템과 호환됩니다. 모든 필수 매니페스트가 포함되어 있습니다:

- `manifest.json`: 서버 정의를 위한 표준 MCP 매니페스트입니다.
- `SKILL.md`: 에이전트 검색을 위한 표준화된 스킬 설명입니다.
- `mcp.json`: MCP 클라이언트 및 레지스트리를 위한 루트 구성입니다.

이 서버를 로컬 스킬 디렉터리에 추가하려면:


```bash
npx skills add adeze/raindrop-mcp --global
```
이것을 [Vercel Skills Registry](https://github.com/vercel/skills/tree/main/registry)에 기여하려면, 이 저장소 URL을 레지스트리에 추가하는 Pull Request를 제출하세요.

### Claude Desktop (MCPB)

GitHub Release에서 최신 raindrop-mcp.mcpb를 다운로드하여 Claude Desktop에 추가하세요:

- Releases: https://github.com/adeze/raindrop-mcp/releases

Claude Desktop에서 번들을 추가하고 다음 환경 변수를 설정하세요:

- RAINDROP_ACCESS_TOKEN (Raindrop.io 통합 설정에서 가져옴)

### NPX (CLI)

API 토큰을 환경 변수로 설정하고 다음을 실행하세요:


```bash
export RAINDROP_ACCESS_TOKEN=YOUR_RAINDROP_ACCESS_TOKEN
npx @adeze/raindrop-mcp
```

### 수동 MCP 구성 (mcp.json)

MCP 클라이언트 구성에 다음을 추가하세요:

```json
{
  "servers": {
    "raindrop": {
      "type": "stdio",
      "command": "npx",
      "args": ["@adeze/raindrop-mcp@latest"],
      "env": {
        "RAINDROP_ACCESS_TOKEN": "YOUR_RAINDROP_ACCESS_TOKEN"
      }
    }
  }
}
```
## 요구 사항

- Raindrop.io 계정
- Raindrop.io API 액세스 토큰: https://app.raindrop.io/settings/integrations

## 지원

- 이슈: https://github.com/adeze/raindrop-mcp/issues

## 릴리스

이 저장소는 `semantic-release`를 유일한 지원 릴리스 플로우로 사용합니다.

### 배포 작동 방식

- 릴리스는 `.github/workflows/ci.yml`을 통해 `master` 브랜치로 푸시될 때 실행됩니다.
- `semantic-release`는 Conventional Commit 메시지를 분석하고, 다음 버전을 계산하며, `CHANGELOG.md`를 업데이트하고, GitHub에 태그/릴리스를 생성하고, npm에 배포합니다.
- 릴리스 준비 중에 `.releaserc.json`은 `manifest.json`, `mcp.json`, `gemini-extension.json`을 동기화한 후 `raindrop-mcp.mcpb`를 빌드하여 GitHub 릴리스에 번들이 포함되도록 합니다.

### 사전 릴리스 드라이런

- 공개 릴리스를 하기 전에 **Run workflow**로 `.github/workflows/release-dry-run.yml`을 실행하세요.
- 이는 퍼블리싱 없이 시맨틱 버전 계산, 레지스트리 인증, 릴리스 파이프라인 동작을 검증합니다.

### 필수 시크릿

- `GITHUB_TOKEN`은 릴리스 자동화를 위해 GitHub Actions에서 제공합니다.

### npm 신뢰 출판

- npm 출판은 GitHub Actions OIDC 신뢰 출판을 통해 구성됩니다.
- 표준 CI 릴리스 경로에서는 `NPM_TOKEN`이 필요하지 않습니다.

### 병합 전 로컬 검증


```bash
bun run lint
bun run type-check
bun run test
bun run build
```
### 커밋 메시지 예시

- `fix: 빈 태그 병합 페이로드 처리`
- `feat: 컬렉션 경로 필터 추가`
- `feat!: 더 이상 사용되지 않는 검색 매개변수 제거`

일반 릴리스의 경우 버전을 수동으로 올리거나, 릴리스 태그를 푸시하거나, 수동으로 npm publish 명령을 실행하지 마십시오.

## 📋 최근 향상 (v2.4.x)

### 스마트 조직 및 계층 구조

- **AI 제안**: 새로운 `get_suggestions` 도구는 Raindrop API와 MCP 샘플링을 사용하여 조직 조언을 제공합니다.
- **컬렉션 트리**: `get_collection_tree` 도구는 전체 빵 부스러기 경로와 함께 계층적 뷰를 제공합니다.
- **대량 이동**: 효율적인 라이브러리 구성을 위해 `bulk_edit_raindrops`에 `move` 작업이 추가되었습니다.
- **페이징 지원**: 대형 라이브러리를 위해 `list_raindrops` 및 `bookmark_search`가 표준화된 페이징을 지원합니다.

### 안전 및 품질

- **확인 로직**: 파괴적 도구(`empty_trash`, `cleanup_collections`)는 이제 명시적 확인을 요구합니다.
- **표준화된 명명법**: 모든 도구는 일관된 스네이크케이스 명명 규칙을 사용합니다.
- **CI/CD 파이프라인**: 자동 린팅, 타입 검사 및 교차 전송 테스트를 포함하도록 GitHub Actions가 강화되었습니다.
- **코드 품질**: 유지보수 가능한 개발을 위해 ESLint 및 Prettier 구성이 확립되었습니다.

## 📋 이전 향상 (v2.3.3)

### 고급 정리 및 라이브러리 감사

## 📋 이전 향상 (v2.3.2)

### MCP 리소스 링크 구현

- 최신 MCP SDK 모범 사례를 따른 현대적인 `resource` 콘텐츠
- 효율적인 데이터 접근: 도구가 전체 페이로드 대신 경량 링크를 반환
- 향상된 성능: 클라이언트는 필요할 때만 전체 북마크/컬렉션 데이터를 가져옴
- 동적 리소스 시스템(`mcp://raindrop/{id}`)과 원활한 통합

### SDK 및 API 업데이트


- 이 저장소에서 최신 지원 MCP SDK로 업데이트됨  
- 향상된 설명과 함께 현대적인 도구 등록  
- API 엔드포인트 및 경로 매개변수 수정  
- 모든 핵심 도구 완전 작동  

### 도구 최적화  

- 북마크/컬렉션 목록에 대한 자원 효율적 응답  
- `mcp://collection/{id}` 및 `mcp://raindrop/{id}`를 통한 동적 자원 접근  
- 가벼운 목록 페이로드로 클라이언트 UX 개선  
- 공식 SDK 패턴과 완전한 MCP 준수  

### 서비스 계층 개선  

- 공통 헬퍼 추출로 코드 감소  
- 일관된 오류 처리 및 응답 처리  
- 제네릭 핸들러로 타입 안정성 향상  
- 중앙 집중식 엔드포인트 빌딩  

### 테스트 개선  

- MCP 도구 실행에 대한 강력한 엔드투엔드 커버리지  
- 실제 클라이언트 흐름을 위한 통합 테스트 확장  

### MCP 2.0 준비 (대량 작업)  

- MCP 2.0 대량 작업 워크플로우 및 도구를 위한 기반 마련  

### OAuth (곧 출시 예정)  

- 수동 토큰 없이 설정을 간소화하는 OAuth 기반 인증 흐름  

### 참고  

최근 몇 번의 빌드로 인해 영향을 받으신 분들께 사과드립니다. 인내와 보고에 감사드립니다.  

## 라이선스  

이 프로젝트는 MIT 라이선스 하에 있습니다 - 자세한 내용은 [LICENSE](LICENSE) 파일을 참조하세요.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-05-11

---