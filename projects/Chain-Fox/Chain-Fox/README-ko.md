<div align="center">
  <img src="https://www.chain-fox.com/logo.png" width="128" height="128">
  <h1>체인-폭스</h1>
  <p>자동 검증이 가능한 에이전트형 체커에 집중합니다. 이것이 우리의 현재 초점입니다.</p>
  <!-- <p>블록체인 보안에 자동화된 분석 제공.</p>
  <p>X 계정 ChainFoxHQ는 더 이상 유지되지 않습니다. 모든 업데이트는 X 계정 ChainFoxAI에 게시됩니다.</p>
  <p>새로운 CFX 토큰을 **Bags**에서 출시합니다!</p>
  <p>개발자는 **100%** 로열티를 받습니다.</p> 
  <p>추가로, 수익의 5%는 기존 CFX 보유자에게 스테이킹 보상으로 분배됩니다.</p> -->

  [![Website](https://img.shields.io/badge/Website-Chain--Fox-blue)](https://www.chain-fox.com)
  [![Discord](https://img.shields.io/badge/Discord-Join-7289DA)](https://discord.gg/pNB3C42wjs)
  [![Telegram](https://img.shields.io/badge/Telegram-Join-26A5E4)](https://t.me/chainfox_sol)
  [![X](https://img.shields.io/badge/X-Follow-black)](https://x.com/ChainFoxAI)

  **CA:** `Fo9wJVqWYXEgsG3UKekvK1R7YVewyUGodRfBrmjaBAGS`

  **체인-폭스**는 블록체인 프로젝트를 위한 **올인원 자동 보안 플랫폼**입니다.  
  우리는 최고의 오픈소스 체커들을 단일 프레임워크로 통합하여, 모든 개발자와 사용자가 고급 보안을  
  **저렴하고, 접근 가능하며, 확장 가능하게** 사용할 수 있도록 합니다.
</div>

## 🎯 왜 체인-폭스인가

- 보안 감사는 **비싸고 시간이 많이 소요**됩니다.  
- 기존 도구들은 **분산되어 있고 통합이 어렵습니다.**  
- 많은 팀이 감사를 완전히 건너뛰어 중요한 취약점이 운영 환경에 남아 있습니다.

**체인-폭스가 이를 바꿉니다.**  
우리는 자동화되고 다중 언어를 지원하는 보안 탐지를 제공하여, 워크플로우에 쉽게 통합할 수 있게 하며  
개발자가 수동 감사의 높은 비용 없이 더 안전한 코드를 배포할 수 있도록 돕습니다.

---

## 🛣️ 로드맵

체인-폭스는 코드 감사에서 스킬과 에이전트를 활용한 완전한 Web3 위험 분석으로 진화하고 있습니다.  
자세한 내용은 [ROADMAP.md](https://raw.githubusercontent.com/Chain-Fox/Chain-Fox/main/./ROADMAP.md)를 참조하세요.   

### 단기 (1개월)
- 러그풀 탐지 (권한 + 온체인 동작)
- Web3 웹사이트 위험 검사
- 스킬 기반 계약 감사  
- 코드 검사기를 에이전트화하고 스킬 인식 가능하게 만듦  
- 베타 테스트 및 피드백 수집  

### 중기 (2개월차)  
- 신호 개선 및 오탐/미탐 감소  
- 더 많은 스킬과 전문화된 코드 검사기 추가  
- 과거 온체인 패턴 추적  
- API 문서화 및 통합  

### 장기 (분기)  
- 다중 에이전트 스킬 시스템  
- 위협 인텔리전스 레이어  
- CI/CD 및 알림 통합  
- 브라우저 확장 프로그램 (읽기 전용)  
- 오픈 소스 스킬 및 커뮤니티 기여  

---  

## 📊 영향 증명  

- **14개의 고급 검사기** 통합 (Rust, Go, Solidity, C/C++).  
- **200개 이상의 버그 발견 및 수정** 실제 프로젝트 전반에 걸쳐.  
- 몇 분 만에 시작할 수 있는 내장 CI/CD 통합 가이드 제공.  

실제 예제는 [탐지 결과](https://raw.githubusercontent.com/Chain-Fox/Chain-Fox/main/./detection-results/'Github Bug Report.xlsx')  
및 [감사 보고서](./audit_reports) 를 확인하세요.  

## 🔍 지원하는 검사기  

우리는 생태계 전반의 선도 도구들을 한데 모았습니다:  

| 검사기       | 언어       | 유형       | 탐지 대상               |  
| ------------ | ---------- | ---------- | ----------------------- |  
| lockbud      | Rust       | 정적       | 메모리 및 동시성 버그    |  
| rudra        | Rust       | 정적       | 메모리 안전, 분산, 수명 버그 |  
| RAPx         | Rust       | 정적       | Use-after-free, 메모리 누수 |  
| AtomVChecker | Rust       | 정적       | 원자적 동시성 버그       |  
| Cocoon       | Rust       | 정적       | 비밀 누출                |  
| MIRAI        | Rust       | 정적       | 패닉 및 정확성 문제       |
| ERASan       | Rust       | 동적      | 메모리 접근 버그 |
| shuttle      | Rust       | 동적      | 동시성 버그 |
| kani         | Rust       | 검증기    | 안전성, 어설션, 패닉 |
| GCatch       | Go         | 정적      | 동시성 버그 |
| GFuzz        | Go         | 동적      | 동시성 버그 |
| cppcheck     | C/C++      | 정적      | 일반적인 C/C++ 버그 |
| slither      | Solidity   | 정적      | Solidity 버그 |
| PeCatch      | Solidity   | 정적      | 가스 수수료 비효율성 |

👉 다가오는 추가 도구는 [Awesome Rust Checker](https://github.com/Chain-Fox/Awesome-Rust-Checker) 목록을 참조하세요.  


## 🤝 참여하기

커뮤니티의 기여를 환영합니다! 다음은 참여 방법입니다:

1. 저장소를 포크하세요
2. 기능 브랜치를 만드세요 (`git checkout -b feature/amazing-feature`)
3. 변경 사항을 커밋하세요 (`git commit -m 'Add some amazing feature'`)
4. 브랜치에 푸시하세요 (`git push origin feature/amazing-feature`)
5. 풀 리퀘스트를 열어주세요

자세한 내용은 [기여 지침](https://raw.githubusercontent.com/Chain-Fox/Chain-Fox/main/CODE_OF_CONDUCT.md)을 읽어주세요.

## 📄 라이선스

이 프로젝트는 BSD 3조항 라이선스 하에 있습니다 - 자세한 내용은 [LICENSE](LICENSE) 파일을 참조하세요.

## 🔒 보안

보안 관련 문제는 [보안 정책](https://raw.githubusercontent.com/Chain-Fox/Chain-Fox/main/SECURITY.md)을 참고하세요.



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-06-23

---