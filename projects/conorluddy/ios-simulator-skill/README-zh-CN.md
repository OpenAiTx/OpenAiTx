# iOS 模拟器技能用于 Claude 代码

面向生产的 iOS 应用测试和构建自动化。21 个脚本，针对人类开发者和 AI 代理进行了优化。

这基本上是我的 XCode MCP 的技能版本：[https://github.com/conorluddy/xc-mcp](https://github.com/conorluddy/xc-mcp)

MCP 在激活时会加载大量令牌到上下文窗口，但似乎效果非常好。技能则不加载任何上下文。我接下来会制作一个插件，尝试找到平衡点……

更新：插件版本让你可以轻松禁用不同工具组的 MCP。通过只启用你正在使用的工具（如 xcodebuild）来优化你的上下文窗口：[https://github.com/conorluddy/xclaude-plugin](https://github.com/conorluddy/xclaude-plugin)

## 功能介绍

它不是基于像素的导航，那种导航在 UI 改变时会失效：

```bash
# Fragile - breaks if UI changes
idb ui tap 320 400

# Robust - finds by meaning
python scripts/navigator.py --find-text "Login" --tap
```

使用无障碍 API 上的语义导航，通过元素的含义而非坐标进行交互。适用于不同屏幕尺寸，并能适应 UI 重设计。

## 功能

- **21 个生产脚本** 用于构建、测试和自动化
- **语义导航** - 通过文本、类型或 ID 查找元素
- **令牌优化** - 相比原始工具减少 96%（默认 3-5 行）
- **零配置** - 在 macOS 上配合 Xcode 即可使用
- **结构化输出** - JSON 和格式化文本，易于解析
- **自动 UDID 检测** - 无需每次指定设备
- **批量操作** - 一次启动、删除、擦除多个模拟器
- **全面测试** - WCAG 合规性、视觉差异、无障碍审核
- **CI/CD 准备** - JSON 输出、退出码、自动设备生命周期

## 安装

### 作为 Claude 代码技能

```bash
# Personal installation
git clone https://github.com/conorluddy/ios-simulator-skill.git ~/.claude/skills/ios-simulator-skill

# Project installation
git clone https://github.com/conorluddy/ios-simulator-skill.git .claude/skills/ios-simulator-skill
```
重新启动 Claude Code。该技能会自动加载。

### 从发布版开始


```bash
# Download latest release
curl -L https://github.com/conorluddy/ios-simulator-skill/releases/download/vX.X.X/ios-simulator-skill-vX.X.X.zip -o skill.zip

# Extract
unzip skill.zip -d ~/.claude/skills/ios-simulator-skill
```

## 前提条件

- macOS 12 及以上版本
- Xcode 命令行工具（`xcode-select --install`）
- Python 3
- IDB（可选，用于交互功能：`brew tap facebook/fb && brew install idb-companion`）

## 快速开始

```bash
# 1. Check environment
bash ~/.claude/skills/ios-simulator-skill/scripts/sim_health_check.sh

# 2. Launch your app
python ~/.claude/skills/ios-simulator-skill/scripts/app_launcher.py --launch com.example.app

# 3. See what's on screen
python ~/.claude/skills/ios-simulator-skill/scripts/screen_mapper.py
# Output:
# Screen: LoginViewController (45 elements, 7 interactive)
# Buttons: "Login", "Cancel", "Forgot Password"
# TextFields: 2 (0 filled)

# 4. Tap login button
python ~/.claude/skills/ios-simulator-skill/scripts/navigator.py --find-text "Login" --tap

# 5. Enter text
python ~/.claude/skills/ios-simulator-skill/scripts/navigator.py --find-type TextField --enter-text "user@test.com"

# 6. Check accessibility
python ~/.claude/skills/ios-simulator-skill/scripts/accessibility_audit.py
```
## 21 个按类别组织的脚本

### 构建与开发
- **build_and_test.py** - 构建项目，运行测试，解析结果
- **log_monitor.py** - 实时日志监控

### 导航与交互
- **screen_mapper.py** - 分析当前屏幕
- **navigator.py** - 查找并交互元素
- **gesture.py** - 滑动、滚动、捏合
- **keyboard.py** - 文本输入和硬件按钮
- **app_launcher.py** - 应用生命周期控制

### 测试与分析
- **accessibility_audit.py** - WCAG 合规检查
- **visual_diff.py** - 截图对比
- **test_recorder.py** - 自动化测试文档
- **app_state_capture.py** - 调试快照
- **sim_health_check.sh** - 环境验证

### 高级测试与权限
- **clipboard.py** - 剪贴板管理
- **status_bar.py** - 状态栏控制
- **push_notification.py** - 推送通知
- **privacy_manager.py** - 权限管理

### 设备生命周期
- **simctl_boot.py** - 启动模拟器
- **simctl_shutdown.py** - 关闭模拟器
- **simctl_create.py** - 创建模拟器
- **simctl_delete.py** - 删除模拟器
- **simctl_erase.py** - 恢复出厂设置

详见 **SKILL.md** 获取完整参考。

## 与 Claude Code 的工作方式

Claude Code 会根据您的请求自动检测何时使用此技能。您无需手动调用。


**示例对话：**

```
You: "Set up my iOS app for testing"
Claude: [Uses simctl_boot.py and app_launcher.py automatically]

You: "Tap the login button"
Claude: [Uses navigator.py to find and tap]

You: "Check if the form is accessible"
Claude: [Uses accessibility_audit.py]
```
你也可以在需要时手动运行脚本。

## 使用示例

### 示例 1：登录流程


```bash
# Launch app
python scripts/app_launcher.py --launch com.example.app

# Map screen to find fields
python scripts/screen_mapper.py

# Enter credentials
python scripts/navigator.py --find-type TextField --index 0 --enter-text "user@test.com"
python scripts/navigator.py --find-type SecureTextField --enter-text "password"

# Tap login
python scripts/navigator.py --find-text "Login" --tap

# Verify accessibility
python scripts/accessibility_audit.py
```

### 示例 2：测试文档

```bash
# Record test execution
python scripts/test_recorder.py --test-name "Login Flow" --output test-reports/

# Generates:
# - Screenshots per step
# - Accessibility trees
# - Markdown report with timing
```

### 示例 3：视觉测试

```bash
# Capture baseline
python scripts/app_state_capture.py --output baseline/

# Make changes...

# Compare
python scripts/visual_diff.py baseline/screenshot.png current/screenshot.png
```

### 示例 4：权限测试

```bash
# Grant permissions
python scripts/privacy_manager.py --bundle-id com.example.app --grant camera,location

# Test app behavior with permissions...

# Revoke permissions
python scripts/privacy_manager.py --bundle-id com.example.app --revoke camera,location
```

### 示例 5：CI/CD 中的设备生命周期

```bash
# Create test device
DEVICE_ID=$(python scripts/simctl_create.py --device "iPhone 16 Pro" --json | jq -r '.new_udid')

# Run tests
python scripts/build_and_test.py --project MyApp.xcodeproj

# Clean up
python scripts/simctl_delete.py --udid $DEVICE_ID --yes
```

## 设计原则

**语义导航**：通过含义（文本、类型、ID）查找元素，而非像素坐标。能适应UI变化，支持不同设备尺寸。

**令牌效率**：默认输出3-5行。使用`--verbose`获取详细信息，或`--json`供机器解析。相比原始工具减少96%。

**无障碍优先**：基于iOS无障碍API构建，可靠性高。对有无障碍需求的用户友好，自动化更稳健。

**零配置**：在任意安装Xcode的macOS上即刻可用。无复杂设置，无配置文件。

**结构化数据**：脚本输出JSON或格式化文本，而非原始日志。便于解析、集成和理解。

**自动学习**：构建系统学习设备偏好并记忆，下次自动应用。

## 要求

**系统：**
- macOS 12或更高版本
- Xcode命令行工具
- Python 3

**可选：**
- IDB（用于交互功能）
- Pillow（用于visual_diff.py：`pip3 install pillow`）

## 文档

- **SKILL.md** - 完整脚本参考和目录
- **CLAUDE.md** - 架构与开发者指南
- **references/** - 主题深度文档
- **examples/** - 完整自动化工作流程

## 输出效率

所有脚本默认最小化输出：

| 任务 | 原始工具 | 本技能 | 节省比例 |
|------|-----------|-----------|---------|
| 屏幕分析 | 200+行 | 5行 | 97.5% |
| 查找并点击按钮 | 100+ 行 | 1 行 | 99% |
| 输入文本 | 50+ 行 | 1 行 | 98% |
| 登录流程 | 400+ 行 | 15 行 | 96% |

此效率保持 AI 代理对话的集中和成本效益。

## 故障排除

### 环境问题

```bash
# Run health check
bash ~/.claude/skills/ios-simulator-skill/scripts/sim_health_check.sh

# Checks: macOS, Xcode, simctl, IDB, Python, simulators, packages
```

### 脚本帮助

```bash
# All scripts support --help
python scripts/navigator.py --help
python scripts/accessibility_audit.py --help
```

### 未找到元素

```bash
# Use verbose mode to see all elements
python scripts/screen_mapper.py --verbose

# Check for exact text match
python scripts/navigator.py --find-text "Exact Button Text" --tap
```

## 贡献

贡献应当：
- 保持令牌效率（最小默认输出）
- 遵循无障碍优先设计
- 支持 `--help` 文档
- 支持 CI/CD 的 `--json`
- 通过 Black 格式化和 Ruff 代码检查
- 包含类型提示
- 更新 SKILL.md

## 许可证

MIT 许可证 - 允许商业使用和分发。

## 支持

- **问题**：创建带有重现步骤的 GitHub 问题
- **文档**：参见 SKILL.md 和 references/
- **示例**：查看 examples/ 目录
- **技能文档**：https://docs.claude.com/en/docs/claude-code/skills

---

**为 AI 代理构建。为开发者优化。**


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-12-18

---