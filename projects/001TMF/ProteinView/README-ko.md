<p align="center">
  <b>프로틴뷰 (P R O T E I N V I E W)</b>
</p>

<p align="center">
  <em>터미널에서 분자 구조 탐색하기</em>
</p>

<p align="center">
  <a href="LICENSE"><img src="https://img.shields.io/badge/License-MIT-blue.svg" alt="License: MIT"></a>
  <a href="https://www.rust-lang.org/"><img src="https://img.shields.io/badge/Rust-1.85%2B-orange.svg" alt="Rust"></a>
  <img src="https://img.shields.io/badge/version-0.3.0-green.svg" alt="Version">
  <a href="https://github.com/001TMF/ProteinView/pulls"><img src="https://img.shields.io/badge/PRs-welcome-brightgreen.svg" alt="PRs Welcome"></a>
  <a href="https://www.linkedin.com/in/tristan-farmer-973b7a17a/"><img src="https://img.shields.io/badge/LinkedIn-Tristan%20Farmer-0A66C2?logo=linkedin" alt="LinkedIn"></a>
</p>

<p align="center">
  <img src="https://raw.githubusercontent.com/001TMF/ProteinView/master/assets/hero-histone.png" alt="히스톤 단백질과 DNA가 렌더링된 뉴클레오솜 코어 입자, FullHD 모드" width="700">
</p>

<p align="center">
  <sub>뉴클레오솜 코어 입자 — 히스톤 옥타머가 DNA에 감싸여 있으며 Kitty 그래픽 프로토콜로 렌더링됨</sub>
</p>

---

터미널 분자 구조 뷰어 — PDB/CIF 파일에서 단백질, 핵산, 소분자를 불러와 회전시키고 탐색하세요. 브라우저, GUI, 의존성 없이 사용 가능합니다.

## 기능

- **3단계 렌더 모드** — 브레일, HD, FullHD (Sixel/Kitty) 및 자동 SSH 감지 지원
- **PNG 압축된 Kitty 프로토콜** — 원시 RGBA 대비 약 10-20배 작아 SSH 환경에서 FullHD 사용 가능
- **카툰 리본 시각화** — 헬릭스, 시트, 코일에 깊이 안개가 적용된 램버트 음영 리본
- **RNA/DNA 지원** — 골격, 와이어프레임, 카툰 모드 및 염기 유형별 색상 표시
- **소분자 렌더링** — 리간드는 볼 앤 스틱, 이온은 구체로 표시
- **인터페이스 분석** — 사슬 간 접촉, 결합 주머니, 상호작용 시각화 (수소 결합, 염다리, 소수성 접촉)
- **7가지 색상 체계** — 구조, 사슬, 원소(CPK), B-팩터, 무지개, pLDDT (AlphaFold)
- **대화형 제어** — vim 스타일 회전, 확대, 이동 및 자동 회전 지원
- **PDB & mmCIF 지원** — 두 포맷 모두 지원하며 RCSB PDB 가져오기(`--fetch`) 가능
- **단일 정적 바이너리** — 런타임 의존성 전혀 없음
## 렌더링 모드

터미널과 연결 상태에 맞는 세 가지 렌더링 단계:

<p align="center">
  <img src="https://raw.githubusercontent.com/001TMF/ProteinView/master/assets/render-modes-grid.png" alt="Braille vs HD vs FullHD 렌더링 비교" width="700">
</p>

<p align="center">
  <sub>왼쪽: 브레일 (SSH/tmux 포함 어디서나 작동) · 가운데: HD (램버트 음영 브레일) · 오른쪽: FullHD (Kitty 픽셀 그래픽)</sub>
</p>

| 모드 | 키 | 품질 | SSH 성능 |
|------|-----|---------|-----------------|
| **브레일** | 기본값 | 셀별 단색 텍스트 기반 | 우수 |
| **HD** | `m` | 조명 및 깊이 안개가 적용된 음영 브레일 | 우수 |
| **FullHD** | `M` | Sixel/Kitty 픽셀 그래픽 | 좋음 (PNG 압축) |

`--hd`는 SSH 인식: SSH 시 HD가 기본, 로컬에서는 FullHD가 기본입니다. 픽셀 그래픽을 강제하려면 `--fullhd`를 사용하세요.

## 시각화 모드

<p align="center">
  <img src="https://raw.githubusercontent.com/001TMF/ProteinView/master/assets/viz-modes-grid.png" alt="카툰, 와이어프레임, 백본 시각화 모드" width="700">
</p>

<p align="center">
  <sub>왼쪽: 카툰 (리본) · 가운데: 와이어프레임 (전 원자) · 오른쪽: 백본 (CA 추적)</sub>
</p>

| 모드 | 설명 |
|------|-------------|
| **카툰** | 매끄러운 리본 렌더링 — 헬릭스, 베타 시트, 코일을 램버트 음영과 함께 표현. 기본값. |
| **와이어프레임** | 잔기질 펩타이드 및 인산다이에스터 결합을 포함한 전 원자 결합. |
| **백본** | CA 추적(단백질) / C4' 추적(핵산)으로 구와 두꺼운 연결선 포함. |

## 인터페이스 분석 및 상호작용

<p align="center">

  <img src="https://raw.githubusercontent.com/001TMF/ProteinView/master/assets/interface-grid.png" alt="상호작용 시각화가 포함된 인터페이스 분석" width="700">
</p>

<p align="center">
  <sub>왼쪽: 사이드바 패널이 있는 인터페이스 잔기 색상 표시 · 오른쪽: 점선 상호작용 선 (수소 결합, 염교, 소수성 접촉)</sub>
</p>

`f` 키를 눌러 인터페이스 모드를 전환하세요 — 체인 경계를 넘는 접촉 잔기를 강조하며 상세한 사이드바를 표시합니다. `I` 키를 눌러 상호작용 선을 오버레이하세요:

| 색상 | 상호작용 | 거리 |
|-------|-------------|----------|
| 청록색 | 수소 결합 | &le; 3.5 &Aring; |
| 빨간색 | 염교 | &le; 4.0 &Aring; |
| 노란색 | 소수성 접촉 | &le; 4.5 &Aring; |
| 회색 | 기타 | &le; 4.5 &Aring; |

## 핵산

<p align="center">
  <img src="https://raw.githubusercontent.com/001TMF/ProteinView/master/assets/dna-element.png" alt="원소(CPK) 색상으로 표시된 B-DNA 이중 나선" width="500">
</p>

<p align="center">
  <sub>CPK 원소 색상으로 표현된 와이어프레임 모드의 B-DNA 도데카머</sub>
</p>

DNA 및 RNA 구조를 완벽 지원 — 골격 추적, 와이어프레임 결합, 뉴클레오타이드 염기 유형 색상(A=빨강, U/T=파랑, G=초록, C=노랑)의 만화 리본.

## AlphaFold 및 pLDDT

<p align="center">
  <img src="https://raw.githubusercontent.com/001TMF/ProteinView/master/assets/plddt-cartoon.png" alt="pLDDT 신뢰도 색상으로 표시된 AlphaFold 예측" width="500">
</p>

<p align="center">
  <sub>pLDDT 신뢰도 색상으로 표시된 AlphaFold 예측 — 파랑(높은 신뢰도)에서 주황/노랑(낮은 신뢰도)까지</sub>
</p>

AlphaFold 구조를 자동 감지하고 pLDDT 신뢰도 색상을 제공합니다. `c` 키로 색상 체계를 순환하세요.

## 설치

[러스트 1.85+](https://www.rust-lang.org/tools/install)가 필요합니다. 러스트가 없다면 다음 명령어로 설치하세요:

```bash
curl --proto '=https' --tlsv1.2 -sSf https://sh.rustup.rs | sh
```

그런 다음 proteinview를 설치합니다:

```bash
git clone https://github.com/001TMF/ProteinView.git
cd ProteinView

# Basic install
cargo install --path .

# With RCSB PDB fetch support
cargo install --path . --features fetch

# Update an existing installation
cargo install --path . --force
```

## 빠른 시작

```bash
# View a local PDB file
proteinview examples/1AOI.pdb

# HD mode (fast text-based shading)
proteinview examples/4HHB.pdb --hd

# FullHD pixel mode (Kitty/Sixel terminals)
proteinview examples/4HHB.pdb --fullhd

# Fetch from RCSB PDB
proteinview --fetch 1UBQ

# Choose color scheme and visualization
proteinview examples/1UBQ.pdb --color rainbow --mode wireframe
```
## 단축키

| 키 | 동작 |
|-----|--------|
| `h`/`l` | Y 축 회전 |
| `j`/`k` | X 축 회전 |
| `u`/`i` | 롤링 |
| `+`/`-` | 줌 |
| `w`/`a`/`s`/`d` | 팬 이동 |
| `r` | 뷰 초기화 |
| `c` | 색상 스킴 변경 |
| `v` | 시각화 모드 변경 |
| `m` | 브라유 / HD |
| `M` | HD / FullHD |
| `f` | 인터페이스 분석 |
| `I` | 인터페이스 상호작용 |
| `g` | 리간드 토글 |
| `[`/`]` | 이전/다음 체인 |
| `Space` | 자동 회전 |
| `?` | 도움말 |
| `q` | 종료 |

## 색상 스킴

| 스킴 | 설명 |
|--------|-------------|
| **구조** | 헬릭스(빨강), 시트(노랑), 코일(초록). 기본값. |
| **체인** | 체인별 구분 색상. |
| **원소** | CPK 색상법 (C, N, O, S, P, 금속). |
| **B-인자** | 파랑(단단함)에서 빨강(유연함). |
| **무지개** | N-말단(파랑)에서 C-말단(빨강). |
| **pLDDT** | AlphaFold 신뢰도 (파랑=높음, 주황=낮음). |

## 터미널 지원

| 터미널 | 브라유 | HD | FullHD |
|----------|---------|-----|--------|
| 모든 유니코드 터미널 | 가능 | 가능 | -- |
| Kitty | 가능 | 가능 | 가능 (PNG) |

| WezTerm | 예 | 예 | 예 (Sixel) |
| iTerm2 | 예 | 예 | 예 |
| foot | 예 | 예 | 예 (Sixel) |
| tmux/screen | 예 | 예 | -- |

## 빌드하기

```bash
cargo build --release

# With RCSB fetch support
cargo build --release --features fetch
```
## 기여하기

기여를 환영합니다! 시작하는 방법은 다음과 같습니다:

1. 저장소를 포크하세요
2. 기능 브랜치 생성 (`git checkout -b feature/my-feature`)
3. 변경 사항을 만들고 테스트를 추가하세요
4. `cargo test`를 실행하여 검증하세요
5. `develop` 브랜치에 대해 풀 리퀘스트를 열어주세요

주요 변경 사항에 대해서는 먼저 이슈를 열어 접근 방식을 논의해주세요.

## 라이선스

[MIT](LICENSE)



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-07-17

---