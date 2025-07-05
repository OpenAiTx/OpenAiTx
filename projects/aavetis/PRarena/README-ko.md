### PR 분석: 볼륨 vs 성공률 (자동 업데이트)

이 통계에 대한 [인터랙티브 대시보드](https://prarena.ai)를 확인하세요.

## 지표 이해하기

다양한 AI 코딩 에이전트는 풀 리퀘스트(PR)를 생성할 때 서로 다른 워크플로우를 따릅니다:

- **전체 PR**: 에이전트가 생성한 모든 풀 리퀘스트, DRAFT PR 포함
- **Ready PR**: 리뷰 및 병합이 가능한 비-드래프트 풀 리퀘스트
- **Merged PR**: 코드베이스에 성공적으로 병합된 풀 리퀘스트

**주요 워크플로우 차이점**: **Codex**와 같은 일부 에이전트는 비공개로 반복하고 바로 Ready PR을 생성하여 드래프트는 거의 없지만 병합률이 높습니다. 반면 **Copilot**과 **Codegen**은 먼저 드래프트 PR을 만들고, 리뷰 전에 공개적으로 반복을 유도합니다.

아래 통계는 **Ready PR만**을 대상으로 하여, 에이전트들이 서로 다른 워크플로우를 사용하더라도 병합 가능한 코드를 생산하는 능력을 공정하게 비교합니다(공개적으로 반복하든, 비공개로 반복하든 상관없이).

## 데이터 소스

사용된 GitHub 검색 쿼리를 확인해보세요:



- **Copilot 전체 PR**: [https://github.com/search?q=is:pr+head:copilot/&type=pullrequests](https://github.com/search?q=is:pr+head:copilot/&type=pullrequests)
- **Copilot 병합 PR**: [https://github.com/search?q=is:pr+head:copilot/+is:merged&type=pullrequests](https://github.com/search?q=is:pr+head:copilot/+is:merged&type=pullrequests)
  

- **Codex 전체 PR**: [https://github.com/search?q=is:pr+head:codex/&type=pullrequests](https://github.com/search?q=is:pr+head:codex/&type=pullrequests)
- **Codex 병합 PR**: [https://github.com/search?q=is:pr+head:codex/+is:merged&type=pullrequests](https://github.com/search?q=is:pr+head:codex/+is:merged&type=pullrequests)
  

- **Cursor 전체 PR**: [https://github.com/search?q=is:pr+head:cursor/&type=pullrequests](https://github.com/search?q=is:pr+head:cursor/&type=pullrequests)
- **Cursor 병합 PR**: [https://github.com/search?q=is:pr+head:cursor/+is:merged&type=pullrequests](https://github.com/search?q=is:pr+head:cursor/+is:merged&type=pullrequests)
  

- **Devin 전체 PR**: [https://github.com/search?q=is:pr+author:devin-ai-integration[bot]&type=pullrequests](https://github.com/search?q=is:pr+author:devin-ai-integration[bot]&type=pullrequests)
- **Devin 병합 PR**: [https://github.com/search?q=is:pr+author:devin-ai-integration[bot]+is:merged&type=pullrequests](https://github.com/search?q=is:pr+author:devin-ai-integration[bot]+is:merged&type=pullrequests)
  

- **Codegen 전체 PR**: [https://github.com/search?q=is:pr+author:codegen-sh[bot]&type=pullrequests](https://github.com/search?q=is:pr+author:codegen-sh[bot]&type=pullrequests)
- **Codegen 병합 PR**: [https://github.com/search?q=is:pr+author:codegen-sh[bot]+is:merged&type=pullrequests](https://github.com/search?q=is:pr+author:codegen-sh[bot]+is:merged&type=pullrequests)
  

---

![chart](https://raw.githubusercontent.com/aavetis/PRarena/main/docs/chart.png)

## 현재 통계

| 프로젝트 | Ready PR | 병합 PR | 성공률 |
| ------- | --------- | ---------- | ------------ |
| Copilot | 16,355 | 15,073 | 92.16% |
| Codex | 594,884 | 520,690 | 87.53% |
| Cursor | 7,474 | 5,560 | 74.39% |
| Devin | 29,168 | 19,221 | 65.9% |
| Codegen | 2,108 | 1,682 | 79.79% |

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-05

---