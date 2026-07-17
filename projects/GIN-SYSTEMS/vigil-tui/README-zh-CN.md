<div align="center">

# VIGIL

**实时终端功率监控 — CPU · GPU · 内存 · 网络 · 进程**

[![CI](https://github.com/GIN-SYSTEMS/vigil-tui/actions/workflows/ci.yml/badge.svg)](https://github.com/GIN-SYSTEMS/vigil-tui/actions)
[![Python](https://img.shields.io/badge/python-3.11%2B-blue?logo=python&logoColor=white)](https://www.python.org/)
[![Platform](https://img.shields.io/badge/platform-Linux%20%7C%20Windows-lightgrey)](https://github.com/GIN-SYSTEMS/vigil-tui)
[![License](https://img.shields.io/badge/license-MIT-green)](LICENSE)

</div>

---

![vigil-tui dashboard](https://raw.githubusercontent.com/GIN-SYSTEMS/vigil-tui/main/assets/screenshot.png)

---

## 概述

vigil 是一个高分辨率终端仪表盘，显示**实时功率、温度、时钟频率、效率评分和电费成本**，覆盖所有主要组件——全部在终端内，无需浏览器，无需后台服务，无需遥测。

它直接读取硬件传感器数据（hwmon、RAPL、LibreHardwareMonitor、NVML），在传感器不可用时优雅降级。每个面板实时更新，整个程序只需一个 `vigil` 命令即可运行。

---

## 功能

### 功率与温度
- **CPU 整包功率** — hwmon (k10temp / zenpower / amd_energy) → RAPL → LibreHardwareMonitor WMI → CPU% × TDP 估算
- **GPU 功率** — NVIDIA NVML：功率、温度、利用率、核心/显存时钟、显存容量、风扇速度
- **内存功率** — DDR4 功率模型（插槽数量 × 利用率）
- **节流检测** — CPU 或 GPU 温度节流时闪烁 `THROTTLE` 标识

### 图表与可视化
- **功率历史** — 高分辨率盲文区域图，CPU + GPU 叠加显示
- **时钟历史** — CPU 平均频率 + GPU 核心时钟及加速上限标记
- **每核柱状图** — 每个核心的利用率 % + 实时频率

### 进程智能  
- **进程表** — 按估算功率贡献排序  
- **折线趋势** — 每个进程的功率历史迷你图  
- **EST.W 列** — 由 CPU% 占包功率比例推算的每进程瓦数  

### 效率与成本  
- **效率评分** — `OPTIMAL` · `NORMAL` · `LOW EFF` · `THROTTLE`  
- **电费成本** — /小时，/天，整个会话总计（可配置的千瓦时价格+货币）  
- **基线模式** — 快照空闲状态，实时比较实时差值  

### 警报与日志  
- **Webhook 警报** — 当 CPU 温度或功率阈值被触发时发送 HTTP POST  
- **会话日志** — 可选 JSONL 记录（`--log` 参数）  
- **SVG 截图** — 使用 `s` 导出完整仪表板  

### 主题与用户体验  
- **TacticalCyberpunk**（暗色） — 近黑背景上的绿色 / 琥珀色 / 青色  
- **GhostWhite**（浅色） — 高对比度单色调  
- **设置向导** — 首次运行引导配置 TDP + 千瓦时价格  
- **实时强调色重设** — 侧边栏颜色调整，无需重启  

---

## 平台支持  

| 平台 | CPU 功率 | CPU 温度 | GPU 功率 | GPU 温度 |  
|---|---|---|---|---|  
| **Linux** | hwmon · RAPL · 估算 | hwmon | NVML | NVML |  
| **Windows 11 / 10** | LibreHardwareMonitor · 估算 | LHM | NVML | NVML |  
| **macOS** | 仅估算 | — | NVML（若存在） | NVML |  

### Windows — 精准 CPU 读数  

vigil 通过 **[LibreHardwareMonitor](https://github.com/LibreHardwareMonitor/LibreHardwareMonitor) (MPL-2.0)** 的 WMI 接口读取真实 CPU 瓦数。没有它时，vigil 会自动回退到 CPU% × TDP 的估算。  

1. 下载 [LibreHardwareMonitor](https://github.com/LibreHardwareMonitor/LibreHardwareMonitor/releases)  
2. 以 **管理员身份** 运行它  
3. 启动 vigil — 系统自动检测到 LHM  

> vigil 不包含或修改 LibreHardwareMonitor。它在运行时连接其 WMI 接口。LHM 必须单独运行。

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

## 快捷键绑定

| 键 | 操作 |
|-----|--------|
| `*` / `?` | 切换帮助覆盖层 |
| `q` / Ctrl+C | 退出 |
| `p` | 暂停 / 恢复采样 |
| `r` | 重置图表历史 |
| `+` / `-` | 放大 / 缩小 Y 轴 |
| `b` | 快照基线 — 再次按下清除 |
| `s` | 保存 SVG 截图 |
| `t` | 切换主题（深色 ↔ 浅色） |
| `c` | 打开配置 / 设置向导 |

---

## 配置

首次启动会创建 `~/.config/vigil/config.toml`：

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

## 依赖项

| 软件包 | 作用 |
|---------|---------|
| `textual >= 0.80` | TUI 框架 |
| `psutil >= 5.9.8` | CPU%，进程列表，网络/磁盘 I/O |
| `pynvml >= 11.5.0` | NVIDIA GPU 指标 |
| `wmi >= 1.5.1` *(Windows)* | LHM WMI 桥接 |
| `pywin32 >= 306` *(Windows)* | Windows COM/WMI 支持 |

---

## 许可证

[MIT](LICENSE) — 免费使用、修改和分发。

---

<div align="center">
由 <a href="https://github.com/GIN-SYSTEMS">GIN-SYSTEMS</a> 构建
</div>


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-07-17

---