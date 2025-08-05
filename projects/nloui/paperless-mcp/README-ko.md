[![MseeP.ai 보안 평가 배지](https://mseep.net/pr/nloui-paperless-mcp-badge.png)](https://mseep.ai/app/nloui-paperless-mcp)

# Paperless-NGX MCP 서버

[![smithery 배지](https://smithery.ai/badge/@nloui/paperless-mcp)](https://smithery.ai/server/@nloui/paperless-mcp)

Paperless-NGX API 서버와 상호작용하기 위한 MCP(모델 컨텍스트 프로토콜) 서버입니다. 이 서버는 Paperless-NGX 인스턴스에서 문서, 태그, 연락처 및 문서 유형을 관리하는 도구를 제공합니다.

## 빠른 시작

### Smithery를 통한 설치

[Smithery](https://smithery.ai/server/@nloui/paperless-mcp)를 통해 Claude Desktop용 Paperless NGX MCP 서버를 자동으로 설치하려면:

```bash
npx -y @smithery/cli install @nloui/paperless-mcp --client claude
```

### 수동 설치
1. MCP 서버를 설치합니다:
```bash
npm install -g paperless-mcp
```
2. Claude의 MCP 구성에 추가하세요:

VSCode 확장 프로그램의 경우, `~/Library/Application Support/Code/User/globalStorage/saoudrizwan.claude-dev/settings/cline_mcp_settings.json`을 편집하세요:

```json
{
  "mcpServers": {
    "paperless": {
      "command": "npx",
      "args": ["paperless-mcp", "http://your-paperless-instance:8000", "your-api-token"]
    }
  }
}
```

Claude 데스크탑 앱의 경우, `~/Library/Application Support/Claude/claude_desktop_config.json` 파일을 편집하세요:
```json
{
  "mcpServers": {
    "paperless": {
      "command": "npx",
      "args": ["paperless-mcp", "http://your-paperless-instance:8000", "your-api-token"]
    }
  }
}
```
3. API 토큰 받기:
   1. Paperless-NGX 인스턴스에 로그인하세요
   2. 오른쪽 상단의 사용자 이름을 클릭하세요
   3. "내 프로필"을 선택하세요
   4. 원형 화살표 버튼을 클릭하여 새 토큰을 생성하세요

4. MCP 설정에서 자리 표시자를 교체하세요:
   - `http://your-paperless-instance:8000`을 Paperless-NGX URL로 교체
   - `your-api-token`을 방금 생성한 토큰으로 교체

이게 전부입니다! 이제 Claude에게 Paperless-NGX 문서 관리를 요청할 수 있습니다.

## 사용 예시

Claude에게 요청할 수 있는 몇 가지 예시는 다음과 같습니다:

- "'Invoice'로 태그된 모든 문서 보여줘"
- "'tax return'이 포함된 문서 검색해줘"
- "색상 #FF0000으로 'Receipts'라는 새 태그 만들어줘"
- "문서 #123 다운로드해줘"
- "모든 연락처 목록 보여줘"
- "'Bank Statement'라는 새 문서 유형 만들어줘"

## 사용 가능한 도구

### 문서 작업

#### list_documents
모든 문서의 페이지별 목록을 가져옵니다.

매개변수:
- page (선택 사항): 페이지 번호
- page_size (선택 사항): 페이지당 문서 수


```typescript
list_documents({
  page: 1,
  page_size: 25
})
```

#### get_document
ID로 특정 문서를 가져옵니다.

매개변수:
- id: 문서 ID

```typescript
get_document({
  id: 123
})
```

#### search_documents
문서 전체에 대한 전체 텍스트 검색.

매개변수:
- query: 검색 쿼리 문자열

```typescript
search_documents({
  query: "invoice 2024"
})
```
#### download_document
ID로 문서 파일을 다운로드합니다.

매개변수:
- id: 문서 ID
- original (선택 사항): true인 경우 보관된 버전 대신 원본 파일을 다운로드합니다.


```typescript
download_document({
  id: 123,
  original: false
})
```
#### bulk_edit_documents
여러 문서에 대해 일괄 작업을 수행합니다.

Parameters:
- documents: 문서 ID 배열
- method: 다음 중 하나:
  - set_correspondent: 문서에 담당자 설정
  - set_document_type: 문서 유형 설정
  - set_storage_path: 문서 저장 경로 설정
  - add_tag: 문서에 태그 추가
  - remove_tag: 문서에서 태그 제거
  - modify_tags: 여러 태그 추가 및/또는 제거
  - delete: 문서 삭제
  - reprocess: 문서 재처리
  - set_permissions: 문서 권한 설정
  - merge: 여러 문서 병합
  - split: 문서 여러 개로 분할
  - rotate: 문서 페이지 회전
  - delete_pages: 문서에서 특정 페이지 삭제
- 메서드에 따른 추가 매개변수:
  - correspondent: set_correspondent용 ID
  - document_type: set_document_type용 ID
  - storage_path: set_storage_path용 ID
  - tag: add_tag/remove_tag용 ID
  - add_tags: modify_tags용 태그 ID 배열
  - remove_tags: modify_tags용 태그 ID 배열
  - permissions: set_permissions용 소유자, 권한, 병합 플래그가 포함된 객체
  - metadata_document_id: 병합 시 메타데이터 출처를 지정하는 ID
  - delete_originals: 병합/분할 시 원본 삭제 여부 불리언
  - pages: 분할용 "[1,2-3,4,5-7]" 또는 delete_pages용 "[2,3,4]" 문자열
  - degrees: 회전 각도 (90, 180 또는 270) 숫자

Examples:

```typescript
// Add a tag to multiple documents
bulk_edit_documents({
  documents: [1, 2, 3],
  method: "add_tag",
  tag: 5
})

// Set correspondent and document type
bulk_edit_documents({
  documents: [4, 5],
  method: "set_correspondent",
  correspondent: 2
})

// Merge documents
bulk_edit_documents({
  documents: [6, 7, 8],
  method: "merge",
  metadata_document_id: 6,
  delete_originals: true
})

// Split document into parts
bulk_edit_documents({
  documents: [9],
  method: "split",
  pages: "[1-2,3-4,5]"
})

// Modify multiple tags at once
bulk_edit_documents({
  documents: [10, 11],
  method: "modify_tags",
  add_tags: [1, 2],
  remove_tags: [3, 4]
})
```
#### post_document
Paperless-NGX에 새 문서를 업로드합니다.

Parameters:
- file: Base64로 인코딩된 파일 내용
- filename: 파일 이름
- title (optional): 문서 제목
- created (optional): 문서가 생성된 날짜 및 시간 (예: "2024-01-19" 또는 "2024-01-19 06:15:00+02:00")
- correspondent (optional): 상대방 ID
- document_type (optional): 문서 유형 ID
- storage_path (optional): 저장 경로 ID
- tags (optional): 태그 ID 배열
- archive_serial_number (optional): 아카이브 일련 번호
- custom_fields (optional): 사용자 정의 필드 ID 배열


```typescript
post_document({
  file: "base64_encoded_content",
  filename: "invoice.pdf",
  title: "January Invoice",
  created: "2024-01-19",
  correspondent: 1,
  document_type: 2,
  tags: [1, 3],
  archive_serial_number: "2024-001"
})
```

### 태그 작업

#### list_tags
모든 태그를 가져옵니다.

```typescript
list_tags()
```
#### create_tag
새 태그를 생성합니다.

매개변수:
- name: 태그 이름
- color (선택 사항): 16진수 색상 코드 (예: "#ff0000")
- match (선택 사항): 일치시킬 텍스트 패턴
- matching_algorithm (선택 사항): "any", "all", "exact", "regular expression", "fuzzy" 중 하나


```typescript
create_tag({
  name: "Invoice",
  color: "#ff0000",
  match: "invoice",
  matching_algorithm: "fuzzy"
})
```

### 대리점 운영

#### list_correspondents
모든 대리점을 가져옵니다.

```typescript
list_correspondents()
```

#### create_correspondent
새로운 담당자를 생성합니다.

매개변수:
- name: 담당자 이름
- match (선택 사항): 일치시킬 텍스트 패턴
- matching_algorithm (선택 사항): "any", "all", "exact", "regular expression", "fuzzy" 중 하나

```typescript
create_correspondent({
  name: "ACME Corp",
  match: "ACME",
  matching_algorithm: "fuzzy"
})
```

### 문서 유형 작업

#### list_document_types
모든 문서 유형을 가져옵니다.

```typescript
list_document_types()
```

#### create_document_type
새 문서 유형을 만듭니다.

매개변수:
- name: 문서 유형 이름
- match (선택 사항): 일치시킬 텍스트 패턴
- matching_algorithm (선택 사항): "any", "all", "exact", "regular expression", "fuzzy" 중 하나

```typescript
create_document_type({
  name: "Invoice",
  match: "invoice total amount due",
  matching_algorithm: "any"
})
```
## 오류 처리

서버는 다음과 같은 경우 명확한 오류 메시지를 표시합니다:
- Paperless-NGX URL 또는 API 토큰이 올바르지 않은 경우
- Paperless-NGX 서버에 연결할 수 없는 경우
- 요청한 작업이 실패한 경우
- 제공된 매개변수가 유효하지 않은 경우

## 개발

서버에 기여하거나 수정하고 싶으신가요? 알아야 할 사항은 다음과 같습니다:

1. 저장소를 클론하세요
2. 의존성을 설치하세요:

```bash
npm install
```

3. server.js 파일을 수정하세요  
4. 로컬에서 테스트하세요:
```bash
node server.js http://localhost:8000 your-test-token
```
서버는 다음으로 구축되었습니다:
- [litemcp](https://github.com/wong2/litemcp): MCP 서버를 구축하기 위한 TypeScript 프레임워크
- [zod](https://github.com/colinhacks/zod): TypeScript 우선 스키마 검증

## API 문서

이 MCP 서버는 Paperless-NGX REST API의 엔드포인트를 구현합니다. 기본 API에 대한 자세한 내용은 [공식 문서](https://docs.paperless-ngx.com/api/)를 참조하세요.

## MCP 서버 실행

MCP 서버는 두 가지 모드로 실행할 수 있습니다:

### 1. stdio (기본)

이 모드는 기본 모드입니다. 서버는 stdio를 통해 통신하며, CLI 및 직접 통합에 적합합니다.


```
npm run start -- <baseUrl> <token>
```

### 2. HTTP (스트리밍 가능한 HTTP 전송)

서버를 HTTP 서비스로 실행하려면 `--http` 플래그를 사용하세요. 포트는 `--port`로 지정할 수 있습니다(기본값: 3000). 이 모드는 [Express](https://expressjs.com/)가 설치되어 있어야 합니다(종속성에 포함되어 있음).

```
npm run start -- <baseUrl> <token> --http --port 3000
```
- MCP API는 지정된 포트에서 `POST /mcp`로 제공됩니다.  
- 각 요청은 [StreamableHTTPServerTransport](https://github.com/modelcontextprotocol/typescript-sdk) 패턴에 따라 상태 비저장 방식으로 처리됩니다.  
- `/mcp`에 대한 GET 및 DELETE 요청은 405 Method Not Allowed를 반환합니다.  



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-05

---