# opencode-anthropic-oauth

Anthropic Claude Pro/Max OAuth 로그인을 위한 OpenCode 플러그인 — Claude Code가 필요 없습니다.

## 기능

브라우저 OAuth를 통해 OpenCode에서 직접 Claude Pro/Max 구독으로 인증할 수 있습니다. Claude Code를 설치하거나 자격 증명 파일을 관리할 필요가 없습니다.

## 설치

```bash
npm install -g opencode-anthropic-oauth
```

그런 다음 `opencode.json`에 추가하세요:

```json
{
  "plugin": ["opencode-anthropic-oauth"]
}
```
## 사용법

1. OpenCode에서 `/connect` 실행 (또는 CLI에서 `oc auth login`)
2. **Anthropic** > **Claude Pro/Max** 선택
3. 브라우저에서 링크를 열고 인증
4. 코드를 복사하여 OpenCode에 붙여넣기
5. 완료 — 모든 Anthropic 모델 사용 가능

## 작동 방식

- Anthropic의 인증 엔드포인트에 직접 OAuth PKCE 플로우 구현
- 인증을 위해 브라우저를 열고 Claude 계정으로 로그인
- 인증 코드를 액세스 및 리프레시 토큰으로 교환
- **토큰 만료 시 자동 갱신** — 수동 인증 불필요
- Anthropic 요청에 필요한 API 헤더 설정
- **프롬프트 캐싱 유지**로 효율적인 토큰 사용

## 변경 내역

### 0.4.1
- **높은 토큰 사용 문제 해결** — 프롬프트 캐싱을 비활성화하던 `cache_control` 제거
- 올바른 토큰 추적을 위한 `x-anthropic-billing-header` 추가
- 공식 Claude CLI 플러그인과 베타 플래그 정렬

### 0.4.0
- OAuth 호환을 위한 `?beta=true` URL 매개변수 추가
- claude-code 베타용 시스템 아이덴티티 접두사 주입
- `cache_control` 제거 (0.4.1에서 다시 복구)

### 0.3.0
- 로더 훅을 통한 자동 토큰 갱신 추가
- 백그라운드 선제 갱신 타이머 (5분 간격)

## 환경 변수 오버라이드

모든 OAuth 매개변수는 환경 변수로 덮어쓸 수 있습니다. Anthropic이 업데이트 전에 변경사항이 있을 경우 환경 변수를 설정하여 계속 작업하세요:

| 변수 | 설명 |
|---|---|

| `ANTHROPIC_CLIENT_ID` | OAuth 클라이언트 ID |
| `ANTHROPIC_CLI_VERSION` | User-Agent용 Claude CLI 버전 |
| `ANTHROPIC_USER_AGENT` | 전체 User-Agent 문자열 (버전 무시) |
| `ANTHROPIC_AUTHORIZE_URL` | OAuth 승인 엔드포인트 |
| `ANTHROPIC_TOKEN_URL` | OAuth 토큰 엔드포인트 |
| `ANTHROPIC_REDIRECT_URI` | OAuth 리디렉션 URI |
| `ANTHROPIC_SCOPES` | OAuth 범위 |
| `ANTHROPIC_BETA_FLAGS` | Anthropic 베타 기능 플래그 |

예:

```bash
export ANTHROPIC_CLI_VERSION=2.2.0
```

## 면책 조항

이 플러그인은 Anthropic의 공개 OAuth 클라이언트 ID를 사용하여 인증합니다. Anthropic의 서비스 약관(2026년 2월)에 따르면 Claude Pro/Max 구독 토큰은 공식 Anthropic 클라이언트와 함께 사용해야 합니다. 이 플러그인은 커뮤니티 차원의 우회 방법으로 존재하며, Anthropic이 OAuth 인프라를 변경할 경우 작동이 중단될 수 있습니다. 사용은 본인의 책임 하에 이루어져야 합니다.

## 라이선스

MIT


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-06-20

---