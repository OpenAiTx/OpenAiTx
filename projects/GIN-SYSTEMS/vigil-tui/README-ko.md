<div align="center">

# VIGIL

**실시간 터미널 전력 모니터 — CPU · GPU · RAM · 네트워크 · 프로세스**

[![CI](https://github.com/GIN-SYSTEMS/vigil-tui/actions/workflows/ci.yml/badge.svg)](https://github.com/GIN-SYSTEMS/vigil-tui/actions)
[![Python](https://img.shields.io/badge/python-3.11%2B-blue?logo=python&logoColor=white)](https://www.python.org/)
[![Platform](https://img.shields.io/badge/platform-Linux%20%7C%20Windows-lightgrey)](https://github.com/GIN-SYSTEMS/vigil-tui)
[![License](https://img.shields.io/badge/license-MIT-green)](LICENSE)

</div>

---

![vigil-tui dashboard](https://raw.githubusercontent.com/GIN-SYSTEMS/vigil-tui/main/assets/screenshot.png)

---

## 개요

vigil은 고해상도 터미널 대시보드로서 모든 주요 구성 요소에 대해 **실시간 와트수, 온도, 클럭 속도, 효율 점수, 전기 요금**을 표시합니다 — 브라우저, 백그라운드 서비스, 텔레메트리 없이 터미널 내에서 모두 실행됩니다.

하드웨어 센서(hwmon, RAPL, LibreHardwareMonitor, NVML)에서 직접 읽으며 센서가 없을 경우 유연하게 대체합니다. 모든 패널은 실시간으로 업데이트되며, 전체가 단일 `vigil` 명령어로 실행됩니다.

---

## 기능

### 전력 및 온도
- **CPU 패키지 전력** — hwmon (k10temp / zenpower / amd_energy) → RAPL → LibreHardwareMonitor WMI → CPU% × TDP 추정치
- **GPU 전력** — NVIDIA NVML: 와트, 온도, 사용률, 코어/메모리 클럭, VRAM, 팬 속도
- **RAM 와트수** — DDR4 전력 모델 (슬롯 수 × 사용률)
- **스로틀 감지** — CPU 또는 GPU 온도 스로틀 시 깜빡이는 `THROTTLE` 배지 표시

### 차트 및 시각화
- **전력 이력** — 고해상도 브레일 영역 차트, CPU + GPU 오버레이
- **클럭 이력** — CPU 평균 주파수 + GPU 코어 클럭과 부스트 한계 표시기
- **코어별 바** — 모든 코어의 사용률 % + 실시간 주파수

### 프로세스 인텔리전스
- **프로세스 테이블** — 추정 와트 기여도 순위별 정렬
- **스파크라인 추세** — 프로세스별 와트 이력 미니 차트
- **EST.W 열** — 패키지 전력의 CPU% 점유율에서 유도된 프로세스별 와트

### 효율성 및 비용
- **효율 점수** — `OPTIMAL` · `NORMAL` · `LOW EFF` · `THROTTLE`
- **전기 비용** — /시간, /일, 세션 총액 (설정 가능한 kWh 가격 + 통화)
- **기준 모드** — 스냅샷 대기 상태, 실시간으로 라이브 델타 비교

### 알림 및 로깅
- **웹훅 알림** — CPU 온도 또는 전력 임계값 초과 시 HTTP POST
- **세션 로깅** — 선택적 JSONL 틱 로그 (`--log` 플래그)
- **SVG 스크린샷** — 전체 대시보드 내보내기 `s` 키 사용

### 테마 및 UX
- **TacticalCyberpunk** (다크) — 거의 검정 바탕에 녹색 / 호박색 / 청록색
- **GhostWhite** (라이트) — 고대비 단색
- **설정 마법사** — 첫 실행 시 TDP + kWh 구성 가이드
- **라이브 강조색 재조정** — 재시작 없이 사이드바 색상 변경

---

## 플랫폼 지원

| 플랫폼 | CPU 전력 | CPU 온도 | GPU 전력 | GPU 온도 |
|---|---|---|---|---|
| **리눅스** | hwmon · RAPL · 추정 | hwmon | NVML | NVML |
| **윈도우 11 / 10** | LibreHardwareMonitor · 추정 | LHM | NVML | NVML |
| **macOS** | 추정만 지원 | — | NVML (존재 시) | NVML |

### 윈도우 — 정확한 CPU 읽기

vigil은 **[LibreHardwareMonitor](https://github.com/LibreHardwareMonitor/LibreHardwareMonitor) (MPL-2.0)** 의 WMI 인터페이스를 통해 실제 CPU 와트 수를 읽습니다. 없으면 vigil은 자동으로 CPU% × TDP 추정값을 사용합니다.

1. [LibreHardwareMonitor](https://github.com/LibreHardwareMonitor/LibreHardwareMonitor/releases) 다운로드
2. **관리자 권한으로 실행**
3. vigil 실행 — LHM이 자동 감지됨

> vigil은 LibreHardwareMonitor를 번들하거나 수정하지 않습니다. 실행 시 WMI 인터페이스에 연결합니다. LHM은 별도로 실행 중이어야 합니다.

---

## Installation

**Requirements:** Python 3.11+

```bash
# Clone
git clone https://github.com/GIN-SYSTEMS/vigil-tui
cd vigil-tui

# Linux / macOS
pip install .

# Windows (includes WMI + pywin32 for LHM support)
pip install ".[windows]"
```

**Run:**
```bash
vigil           # launch dashboard
vigil --log     # launch + write JSONL tick log
vigil --help    # all options
```

---

## 주요 단축키

| 키 | 동작 |
|-----|--------|
| `*` / `?` | 도움말 오버레이 전환 |
| `q` / Ctrl+C | 종료 |
| `p` | 샘플링 일시정지 / 재개 |
| `r` | 차트 기록 초기화 |
| `+` / `-` | Y축 확대 / 축소 |
| `b` | 기준선 스냅샷 — 다시 누르면 삭제 |
| `s` | SVG 스크린샷 저장 |
| `t` | 테마 전환 (다크 ↔ 라이트) |
| `c` | 설정 / 설치 마법사 열기 |

---

## 설정

첫 실행 시 `~/.config/vigil/config.toml` 생성:

```toml
[hardware]
cpu_tdp_watts       = 65.0     # CPU TDP ceiling for estimation
gpu_tdp_watts       = 165.0    # GPU TDP ceiling
update_interval     = 1.0      # seconds between ticks
history_len         = 120      # chart ring-buffer depth

[cost]
kwh_price           = 2.0      # electricity price per kWh
currency_symbol     = "₺"

[alerts]
webhook_url         = ""       # HTTP POST endpoint — empty = disabled
cpu_temp_thresh     = 90       # °C
cpu_watt_thresh_pct = 90       # % of TDP

[ui]
theme               = "tactical"   # "tactical" or "ghost"
```

---

## How the power waterfall works

```
vigil starts
│
├─ Linux?
│   ├─ hwmon sysfs (k10temp / zenpower / amd_energy)   ← real sensor
│   ├─ RAPL powercap energy_uj delta                   ← kernel counter
│   └─ CPU% × TDP estimate                             ← always available
│
└─ Windows?
    ├─ LibreHardwareMonitor WMI (requires Admin + LHM) ← real sensor
    └─ CPU% × TDP estimate                             ← always available

GPU → NVML (pynvml) on all platforms
     if no NVIDIA GPU: panel shows "unavailable", no crash
```

---

## Project Structure

```
vigil-tui/
├── src/vigil/
│   ├── app.py                   # Textual app, layout, tick loop
│   ├── config.py                # Static constants
│   ├── config_manager.py        # TOML config loader/writer
│   ├── session.py               # Cost tracking, webhooks, JSONL logging
│   ├── collectors/
│   │   ├── base.py              # Collector ABC + SensorReading
│   │   ├── cpu.py               # hwmon → RAPL → LHM → estimate
│   │   ├── gpu.py               # NVIDIA NVML
│   │   ├── ram.py               # RAM wattage model
│   │   ├── netdisk.py           # Network + disk I/O rates
│   │   └── system.py            # Orchestrator → SystemSnapshot
│   └── widgets/
│       ├── power_header.py      # Top bar: wordmark + gauge
│       ├── cpu_panel.py         # Left: CPU + per-core bars
│       ├── braille_chart.py     # Center: power history
│       ├── clock_chart.py       # Center: clock history
│       ├── process_table.py     # Center: process ranking
│       ├── gpu_panel.py         # Right: GPU metrics
│       ├── financial_widget.py  # Cost display
│       ├── netdisk_widget.py    # Network + disk rates
│       ├── status_bar.py        # Footer
│       ├── boot_screen.py       # Splash screen
│       ├── help_overlay.py      # Key bindings overlay
│       └── setup_wizard.py      # First-run wizard
├── .github/workflows/ci.yml
├── pyproject.toml
├── requirements.txt
└── LICENSE
```

---

## 의존성

| 패키지 | 용도 |
|---------|---------|
| `textual >= 0.80` | TUI 프레임워크 |
| `psutil >= 5.9.8` | CPU%, 프로세스 목록, 네트워크/디스크 I/O |
| `pynvml >= 11.5.0` | NVIDIA GPU 메트릭 |
| `wmi >= 1.5.1` *(Windows)* | LHM WMI 브리지 |
| `pywin32 >= 306` *(Windows)* | Windows COM/WMI 지원 |

---

## 라이선스

[MIT](LICENSE) — 자유롭게 사용, 수정 및 배포 가능.

---

<div align="center">
built by <a href="https://github.com/GIN-SYSTEMS">GIN-SYSTEMS</a>
</div>


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-07-17

---