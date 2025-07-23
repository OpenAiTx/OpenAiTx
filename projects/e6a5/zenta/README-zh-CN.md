
# 🧘 zenta

> **适合你的编码流程的正念**

当你编码时心神游离，只需回归呼吸。无跟踪，无指标，无干扰——只在终端中纯粹觉察。

**觉察本身就是练习。** ✨

---

## ⚡ 快速开始


```bash
# Install (one-liner)
curl -fsSL https://raw.githubusercontent.com/e6a5/zenta/main/install.sh | bash

# Set up zen aliases
echo "alias breath='zenta now --quick'" >> ~/.zshrc
echo "alias breathe='zenta now'" >> ~/.zshrc
echo "alias anchor='zenta anchor'" >> ~/.zshrc
echo "alias reflect='zenta reflect'" >> ~/.zshrc
source ~/.zshrc

# Use instantly
breath    # When mind wanders → return to breath (1 breath cycle)
breathe   # Need deeper centering → longer session (3 breath cycles)
anchor    # Find your rhythm → interactive breathing anchor
reflect   # Evening → gentle day review
```
---

## 🌸 为什么选择 zenta？

### **契合你的真实工作流程**

1. **提醒**：“我卡在了计划思路里”
2. **回归**：`呼吸`
3. **继续**：回到编码，更加专注

### **真正的禅意方法**

- ✅ **无跟踪** → 觉察不是用来优化的数据
- ✅ **无分析** → 练习即是目标
- ✅ **无干扰** → 保持在你的终端中
- ✅ **只需呼吸** → 纯粹的正念

### **为开发者打造**

- 终端原生（契合你的工作流程）
- 单一二进制文件（无依赖）
- 私密（无数据收集）
- 即时响应（`呼吸` 只需一键）

---

## 🌊 美丽的呼吸


```bash
$ breath

       Let's breathe 🌸

    🌬️ Breathe in gently, let your body expand...

                      ○
                    ○ · ○
                     ···
              ○ · · ·   · · · ○
                     ···
                    ○ · ○
                      ·

       Carry this calm with you throughout your day 🙏
```
_纯视觉呼吸指导，配以柔和动画_

---

## 💡 命令

### **基本命令（含别名）**

| 命令       | 循环次数 | 功能说明                              | 适用场景                          |
| --------- | -------- | ---------------------------------- | -------------------------------- |
| `breath`  | 1 次循环 | 快速呼吸 + 智慧语录                | 思绪游离时                        |
| `breathe` | 3 次循环 | 标准呼吸 + 智慧语录                | 重要任务前                      |
| `anchor`  | 用户控制 | 交互式节奏锚点                     | 需要自行掌控节奏时              |
| `reflect` | -        | 柔和的夜间回顾                     | 一天结束时的沉思                |

### **完整命令**

| 命令                      | 循环次数 | 功能说明                             |
| ------------------------ | -------- | ---------------------------------- |
| `zenta now`              | 3 次循环 | 标准呼吸 + 智慧语录                |
| `zenta now --quick`      | 1 次循环 | 快速呼吸 + 智慧语录                |
| `zenta now --extended`   | 5 次循环 | 延长呼吸 + 智慧语录                |
| `zenta anchor`           | 用户控制 | 交互式节奏锚点                     |
| `zenta now --silent`     | 3 次循环 | 仅呼吸，无语录                     |
| `zenta now --simple`     | 3 次循环 | 简易线条动画（终端兼容）           |

**混合选项：** `zenta now --quick --silent`（1 次循环，无语录）

---

## 🔧 终端兼容性

**精美圆圈 vs 简易线条：**

- **大多数终端**：华丽的扩展/收缩呼吸圆圈
- **macOS Terminal.app**：自动检测并使用简易线条动画
- **tmux/screen**：复杂动画表现良好

**强制简易模式：** 在任意命令后添加 `--simple`


```bash
breath --simple     # Force simple animation
zenta now --simple  # Works with any options
```
**为什么？** 只有 macOS Terminal.app 存在 ANSI 转义序列的特殊情况。zenta 会自动检测并调整，以提供最佳体验。

---

## 🎯 真正的正念 vs 假正念

**✅ 真正的正念（zenta 的方式）：**

- 注意到心念游离时
- 立即回到呼吸
- 带着觉知继续工作
- 无需测量

**❌ 假正念：**

- 跟踪冥想连续天数
- 优化觉知指标
- 量化内心的平静
- 使正念变得有生产力

---

## 🌿 哲学

> _“你越安静，就越能听见。”_

**zenta 相信：**

- 正念工具应融入实践而消失
- 注意本身就是觉悟
- 开发者需要的是当下，而非生产力技巧
- 真正的禅无指标

---

## 🚀 安装

### **选项 1：预编译二进制文件（推荐）**

**macOS/Linux：**


```bash
# Download and install the latest binary for your platform
curl -s https://api.github.com/repos/e6a5/zenta/releases/latest \
| grep "browser_download_url.*$(uname -s | tr '[:upper:]' '[:lower:]')-$(uname -m | sed 's/x86_64/amd64/')" \
| cut -d '"' -f 4 \
| xargs curl -L -o zenta.tar.gz \
&& tar -xzf zenta.tar.gz \
&& sudo mv zenta-* /usr/local/bin/zenta \
&& rm zenta.tar.gz

# Or download manually from GitHub Releases
```
**Windows：**
从 [GitHub Releases](https://github.com/e6a5/zenta/releases) 下载最新的 `.zip` 文件，解压后将可执行文件添加到您的 PATH 中。

**手动下载：** [GitHub Releases](https://github.com/e6a5/zenta/releases) - 选择您的平台

### **选项 2：从源码构建**

_需要安装 Go 1.23 及以上版本_


```bash
git clone https://github.com/e6a5/zenta.git && cd zenta && make install-system
```
**先安装 Go：** [https://golang.org/dl/](https://golang.org/dl/)

_支持：Linux、macOS、Windows、FreeBSD（所有架构）_

---

## 🧘 加入实践

- 🐛 **错误报告** → [问题](https://github.com/e6a5/zenta/issues)
- 💭 **正念讨论** → [讨论](https://github.com/e6a5/zenta/discussions)
- 🔧 **贡献** → [CONTRIBUTING.md](https://raw.githubusercontent.com/e6a5/zenta/main/CONTRIBUTING.md)

---

## 📄 许可证

MIT 许可证 - [LICENSE](LICENSE)

---

> _“照顾未来的最好方法是照顾当下的时刻。”_ — 一行禅师

**今天就开始你的正念编码实践吧：**


```bash
breath  # Just try it 🙏
```


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-20

---