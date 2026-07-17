<p align="center">
  <b>蛋白质视图</b>
</p>

<p align="center">
  <em>在终端中探索分子结构</em>
</p>

<p align="center">
  <a href="LICENSE"><img src="https://img.shields.io/badge/License-MIT-blue.svg" alt="许可协议：MIT"></a>
  <a href="https://www.rust-lang.org/"><img src="https://img.shields.io/badge/Rust-1.85%2B-orange.svg" alt="Rust"></a>
  <img src="https://img.shields.io/badge/version-0.3.0-green.svg" alt="版本">
  <a href="https://github.com/001TMF/ProteinView/pulls"><img src="https://img.shields.io/badge/PRs-welcome-brightgreen.svg" alt="欢迎提交PR"></a>
  <a href="https://www.linkedin.com/in/tristan-farmer-973b7a17a/"><img src="https://img.shields.io/badge/LinkedIn-Tristan%20Farmer-0A66C2?logo=linkedin" alt="LinkedIn"></a>
</p>

<p align="center">
  <img src="https://raw.githubusercontent.com/001TMF/ProteinView/master/assets/hero-histone.png" alt="以FullHD模式渲染的含组蛋白和DNA的核小体核心颗粒" width="700">
</p>

<p align="center">
  <sub>核小体核心颗粒 — 组蛋白八聚体包裹DNA，采用Kitty图形协议渲染</sub>
</p>

---

终端分子结构查看器 — 直接在终端加载、旋转和探索蛋白质、核酸及小分子，支持PDB/CIF文件。无需浏览器、无需图形界面、无依赖。

## 功能特点

- **三级渲染模式** — 点字模式、高清模式和全高清模式（Sixel/Kitty），自动检测SSH环境
- **PNG压缩的Kitty协议** — 比原始RGBA小约10-20倍，使全高清模式在SSH下可用
- **卡通带状可视化** — 采用朗伯阴影和深度雾效表现螺旋、折叠片和卷曲结构
- **RNA/DNA支持** — 骨架、线框和卡通模式，配以碱基类型着色
- **小分子渲染** — 配体以球棒模型显示，离子以球体显示
- **界面分析** — 链间接触、结合口袋及相互作用可视化（氢键、盐桥、疏水接触）
- **7种配色方案** — 结构、链、元素（CPK）、B因子、彩虹、pLDDT（AlphaFold）
- **交互式控制** — 类vim风格旋转、缩放、平移及自动旋转
- **支持PDB与mmCIF格式** — 支持两种格式，支持RCSB PDB文件下载（`--fetch`）
- **单文件静态二进制** — 零运行时依赖
## 渲染模式

三种渲染等级以匹配您的终端和连接：

<p align="center">
  <img src="https://raw.githubusercontent.com/001TMF/ProteinView/master/assets/render-modes-grid.png" alt="盲文 vs 高清 vs 全高清渲染对比" width="700">
</p>

<p align="center">
  <sub>左：盲文（适用于所有环境，包括 SSH/tmux）· 中：高清（Lambert 阴影盲文）· 右：全高清（Kitty 像素图形）</sub>
</p>

| 模式 | 快捷键 | 质量 | SSH 性能 |
|------|-------|-------|----------|
| **盲文** | 默认 | 基于文本，单色每格 | 优秀 |
| **高清** | `m` | 带光照和深度雾的阴影盲文 | 优秀 |
| **全高清** | `M` | Sixel/Kitty 像素图形 | 良好（PNG 压缩） |

`--hd` 支持 SSH：SSH 下默认使用高清，本地使用全高清。使用 `--fullhd` 强制像素图形。

## 可视化模式

<p align="center">
  <img src="https://raw.githubusercontent.com/001TMF/ProteinView/master/assets/viz-modes-grid.png" alt="卡通、线框和骨架可视化模式" width="700">
</p>

<p align="center">
  <sub>左：卡通（丝带）· 中：线框（全原子）· 右：骨架（CA 轨迹）</sub>
</p>

| 模式 | 描述 |
|------|-------|
| **卡通** | 平滑丝带渲染——螺旋、β-折叠和卷曲，带 Lambert 阴影。默认。 |
| **线框** | 包含残基间肽键和磷酸二酯键的全原子键。 |
| **骨架** | CA 轨迹（蛋白质）/ C4' 轨迹（核酸），带球体和粗连接线。 |

## 界面分析与交互

<p align="center">

  <img src="https://raw.githubusercontent.com/001TMF/ProteinView/master/assets/interface-grid.png" alt="界面分析与相互作用可视化" width="700">
</p>

<p align="center">
  <sub>左：界面残基着色及侧边栏面板 · 右：虚线相互作用线（氢键、盐桥、疏水接触）</sub>
</p>

按 `f` 切换界面模式 — 高亮显示链间接触残基并显示详细侧边栏。按 `I` 叠加相互作用线：

| 颜色 | 相互作用 | 距离 |
|-------|-------------|----------|
| 青色 | 氢键 | &le; 3.5 &Aring; |
| 红色 | 盐桥 | &le; 4.0 &Aring; |
| 黄色 | 疏水接触 | &le; 4.5 &Aring; |
| 灰色 | 其他 | &le; 4.5 &Aring; |

## 核酸

<p align="center">
  <img src="https://raw.githubusercontent.com/001TMF/ProteinView/master/assets/dna-element.png" alt="带元素（CPK）着色的B-DNA双螺旋" width="500">
</p>

<p align="center">
  <sub>线框模式下带CPK元素着色的B-DNA十二聚体</sub>
</p>

完全支持DNA和RNA结构 — 骨架轨迹、线框键及带核苷酸碱基类型着色的卡通带（A=红色，U/T=蓝色，G=绿色，C=黄色）。

## AlphaFold 与 pLDDT

<p align="center">
  <img src="https://raw.githubusercontent.com/001TMF/ProteinView/master/assets/plddt-cartoon.png" alt="带pLDDT置信度着色的AlphaFold预测" width="500">
</p>

<p align="center">
  <sub>带pLDDT置信度着色的AlphaFold预测 — 蓝色（高置信度）至橙色/黄色（低置信度）</sub>
</p>

自动检测AlphaFold结构并提供pLDDT置信度着色。使用 `c` 循环切换配色方案。

## 安装

需要 [Rust 1.85+](https://www.rust-lang.org/tools/install)。如果你还没有安装 Rust，请使用以下命令安装：

```bash
curl --proto '=https' --tlsv1.2 -sSf https://sh.rustup.rs | sh
```

然后安装proteinview：

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

## 快速开始

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
## 快捷键

| 键 | 操作 |
|-----|--------|
| `h`/`l` | 绕Y轴旋转 |
| `j`/`k` | 绕X轴旋转 |
| `u`/`i` | 翻滚 |
| `+`/`-` | 缩放 |
| `w`/`a`/`s`/`d` | 平移 |
| `r` | 重置视图 |
| `c` | 循环颜色方案 |
| `v` | 循环可视化模式 |
| `m` | 盲文 / 高清 |
| `M` | 高清 / 全高清 |
| `f` | 界面分析 |
| `I` | 界面交互 |
| `g` | 切换配体显示 |
| `[`/`]` | 上一个/下一个链 |
| `Space` | 自动旋转 |
| `?` | 帮助 |
| `q` | 退出 |

## 颜色方案

| 方案 | 描述 |
|--------|-------------|
| **结构** | 螺旋（红色）、片层（黄色）、线圈（绿色）。默认。 |
| **链** | 每条链不同颜色。 |
| **元素** | CPK 着色（C、N、O、S、P、金属）。 |
| **B因子** | 蓝色（刚性）到红色（柔性）。 |
| **彩虹** | N 端（蓝色）到 C 端（红色）。 |
| **pLDDT** | AlphaFold 置信度（蓝色=高，橙色=低）。 |

## 终端支持

| 终端 | 盲文 | 高清 | 全高清 |
|----------|---------|-----|--------|
| 任意 Unicode 终端 | 是 | 是 | -- |
| Kitty | 是 | 是 | 是（PNG） |

| WezTerm | 是 | 是 | 是（Sixel） |
| iTerm2 | 是 | 是 | 是 |
| foot | 是 | 是 | 是（Sixel） |
| tmux/screen | 是 | 是 | -- |

## 构建

```bash
cargo build --release

# With RCSB fetch support
cargo build --release --features fetch
```

## 贡献

欢迎贡献！以下是入门指南：

1. Fork 本仓库
2. 创建功能分支（`git checkout -b feature/my-feature`）
3. 进行修改并添加测试
4. 运行 `cargo test` 进行验证
5. 提交针对 `develop` 分支的拉取请求

重大变更请先打开 issue 讨论方案。

## 许可证

[MIT](LICENSE)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-07-17

---