# 🎯 프로젝트 설정 가이드

프로젝트에 오신 것을 환영합니다! 이 가이드는 필수 도구를 설치하고 로컬 환경을 구성하여 빠르게 시작할 수 있도록 도와줍니다.

---

## 🛠️ 사전 준비 사항

다음 도구들이 시스템에 설치되어 있는지 확인하세요:

- [Rust](https://www.rust-lang.org/tools/install)
- [Solana CLI](https://docs.solana.com/cli/install-solana-cli-tools)
- [Anchor](https://anchor-lang.com/docs/installation)

> ℹ️ **권장 Anchor 버전:** `0.30.1`

---

## ✅ 버전 확인 및 설정 구성

모든 것이 올바르게 설치되고 구성되었는지 확인하세요:

```bash
rustc --version             # Rust 버전 확인
solana --version            # Solana CLI 버전 확인
anchor --version            # Anchor 버전 확인

solana config get           # 현재 Solana 설정 보기
solana config set --url devnet  # 네트워크를 devnet으로 설정
```
---

## 🔐 지갑 설정

지갑 키를 생성하고 관리합니다:

```bash
solana-keygen new -o ./keys/admin.json     # 새 키페어 생성
solana-keygen pubkey ./keys/admin.json     # 공개키 확인
solana balance ./keys/admin.json           # 지갑 잔액 확인
solana airdrop 5 YOUR_WALLET_ADDRESS -u devnet   # 지갑에 5 SOL 에어드랍
```

---

## 📦 프로젝트 설치

프로젝트를 클론하고 의존성을 설치합니다:

```bash
git clone https://github.com/project-repo.git
cd project-folder
yarn
```
---

## ⚡ 빠른 시작

### 🏗️ 프로그램 빌드

Anchor 스마트 컨트랙트 컴파일:

```bash
# 야간(nightly) 툴체인을 사용하여 Anchor 프로그램 빌드
RUSTUP_TOOLCHAIN="nightly-2024-11-19" anchor build

# 모든 프로그램 공개 키 동기화
anchor keys sync

# lib.rs의 프로그램 주소가 변경된 경우 재빌드
RUSTUP_TOOLCHAIN="nightly-2024-11-19" anchor build
```

---
### 🧪 Devnet에서 테스트

`Anchor.toml`이 Devnet을 사용하도록 설정되어 있는지 확인하세요:

```toml
[provider]
cluster = "https://api.devnet.solana.com"
```

---

### 🚀 프로그램 배포

```bash
anchor deploy
```

---

## 🧪 CLI를 사용하여 프로그램과 상호작용하기
이러한 CLI 스크립트를 사용하여 스마트 컨트랙트와 로컬에서 상호작용할 수 있습니다.

---

### 🔹 프로그램 초기화

```bash
yarn script config
```

컨트랙트 구성을 초기화합니다.

---

### 🔹 라운드 생성

```bash
yarn script create -t <ROUND_TIME> -d <MIN_DEPOSIT_AMOUNT> -j <MAX_JOINER_COUNT>

# 예시:
yarn script create -t 60 -d 100000000 -j 100
```

**파라미터:**

- `<ROUND_TIME>`: 라운드의 지속 시간(초 단위) (예: `60` = 60초).
- `<MIN_DEPOSIT_AMOUNT>`: 최소 예치금(라포트 단위, 1 SOL = 1_000_000_000). `config.TEST_INITIAL_MIN_DEPOSIT_AMOUNT`보다 커야 합니다.
- `<MAX_JOINER_COUNT>`: 최대 참가자 수. `config.TEST_INITIAL_MAX_JOINER_COUNT`보다 작아야 합니다.

---

### 🔹 라운드 참가

```bash
yarn script join -a <DEPOSIT_SOL_AMOUNT> -g <ROUND_NUMBER>

# 예시:
yarn script join -a 100000000 -g 2
```
**파라미터:**

- `<DEPOSIT_SOL_AMOUNT>`: 입금 금액(라포트 단위, 예: 0.1 SOL = 100_000_000).
- `<ROUND_NUMBER>`: 참여할 라운드의 인덱스. `0`부터 시작. `total_round`보다 작아야 함.

> 🕒 참고: 해당 라운드의 카운트다운은 두 번째 참가자가 참여할 때 시작됩니다.

---

### 🔹 우승자 선택

```bash
yarn script winner -g <ROUND_NUMBER>

# 예시:
yarn script winner -g 2
```

**참고:** 라운드 시간이 완전히 경과한 후에만 호출하세요.

---
### 🔹 당첨금 청구

```bash
yarn script claim -g <ROUND_NUMBER>

# 예시:
yarn script claim -g 2
```

**참고:** 이 명령은 당첨자가 선정된 후, 당첨된 지갑에서 실행해야 합니다.

---

## 문의

Solana 스마트 계약 개발, DeFi 구현 또는 DEX 통합에 관한 질문이나 문의 사항이 있으시면 프로젝트 관리자에게 연락해 주세요.

**Telegram**: [@Tru3B1iss](https://t.me/Tru3B1iss)
**X (Twitter)**: [@XTruebliss](https://x.com/XTruebliss)
**Discord**: [@trueb1iss](https://discord.com/users/1274339638668038187)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-12

---