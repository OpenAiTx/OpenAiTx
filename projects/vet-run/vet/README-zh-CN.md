
[![CI - 测试，代码检查](https://github.com/vet-run/vet/actions/workflows/ci.yml/badge.svg)](https://github.com/vet-run/vet/actions/workflows/ci.yml)

`vet` 是一个命令行工具，作为常见但风险较高的 `curl | bash` 模式的安全网。它允许你检查远程脚本的更改，使用代码检查工具运行它们，并在脚本执行前要求你明确批准。

**不要只是运行它，要用 `vet` 来检查它。**

---

## 问题所在

我们都见过这种安装软件的模式：


```bash
# This is convenient, but you're blindly trusting the remote script.
curl -sSL https://example.com/install.sh | bash
```


这是危险的。脚本可能是恶意的，服务器可能已被攻破，或者瞬时网络错误可能导致执行部分脚本。

### 解决方案：vet

`vet` 将此过程封装在一个安全的交互式工作流程中：

-   **获取：** 它将远程脚本下载到临时位置。

-   **差异与审查：** 它向你展示自上次运行此脚本以来发生了什么变化（如果有的话）。

-   **代码检查：** 如果你安装了 shellcheck，它会自动分析脚本中的潜在错误或恶意模式。

-   **确认：** 它在执行任何操作之前会提示你进行明确批准。


```bash
# The new, safer way.
vet https://example.com/install.sh
```


## 安装

我们认为你绝不应该盲目信任来自网络的脚本——即使是我们的。这就是 `vet` 存在的原因。安装过程本身就是 `vet` 解决问题的完美示范。

## Homebrew（macOS/Linux）- 推荐

安装 `vet` 最简单且推荐的方法是通过 Homebrew。

```
# First, tap the official repository
brew tap vet-run/vet

# Now, install the formula
brew install vet-run
```
**注意：** 该公式命名为 `vet-run` 以避免与 Homebrew 生态系统中的另一个工具冲突，但此命令将正确地在您的系统上安装 `vet` 可执行文件。

## 手动安装

### 安全方式
如果您不使用 Homebrew，或者您只是希望遵循 `vet` 所倡导的安全优先原则，您可以执行手动安装。这是一个两步的“下载，然后审查”过程，演示了 `vet` 为您自动完成的操作。

1. **下载安装程序**：

选择以下来源之一。第一个是官方项目域名，第二个是 GitHub 发布资产的直接链接。

*选项 A：官方项目域名*
```bash
curl -o install_vet.sh https://getvet.sh/install.sh
```
*选项 B：直接 GitHub 发布链接*
```bash
curl -L -o install_vet.sh https://github.com/vet-run/vet/releases/latest/download/install.sh
```
2. **审查安装程序的代码。** 在文本编辑器中打开它，或使用 less 确保它没有执行任何可疑操作。它是一个简单的脚本，会下载正确的 vet 脚本并将其移动到 /usr/local/bin。
```bash
less install_vet.sh
```
3. **运行您刚刚审核过的安装程序：**
```bash
bash install_vet.sh
```


恭喜！您刚刚手动执行了兽医现在将为您自动完成的流程。

### “信任”一行代码（反模式）

```bash
# This is the curl-to-bash pattern.
# Don't actually do this. That's the whole point.
curl -sL https://getvet.sh/install.sh | bash
```
---
### 用法
```bash
# Basic usage
vet <URL>

# Example with a real-world installer
vet https://raw.githubusercontent.com/nvm-sh/nvm/v0.39.1/install.sh

# Pass arguments to the remote script
# All arguments after the URL are passed directly to the script.
vet https://example.com/setup.sh --user myuser --version latest

# Non-interactive mode for trusted scripts in automated environments (e.g., CI/CD)
vet --force https://my-trusted-internal-script.sh
```
#### 选项

\-f, \

跳过所有交互提示并立即执行。请谨慎使用。

\-h, \--help

显示帮助信息。

## 项目理念与技术决策

### 需要 Bash 4 及以上版本

`vet` 有意利用现代 bash 特性（数组、\[\[ ... \]\]、pipefail）编写。我们认为，对于一个以安全为核心的工具来说，为了兼容 POSIX sh 而牺牲健壮性和可读性是一个危险的权衡。

现代 bash 提供的安全特性是 `vet` 使命的底线，不容妥协。

如果您处于精简环境（如 Alpine 容器），请将 bash 作为显式依赖安装：

```bash
apk add --no-cache bash
```
## 贡献

欢迎贡献！如果您有新功能的想法或发现了错误，请打开一个问题。对于拉取请求，请确保您的更改已被测试覆盖。

-   分叉仓库。

-   创建一个新的功能分支（git checkout -b feature/my-amazing-feature）。

-   进行您的更改。

-   运行测试（bats tests/）。

-   提交您的更改（git commit -am 'Add some amazing feature'）。

-   推送到分支（git push origin feature/my-amazing-feature）。

-   打开一个新的拉取请求。

## 致谢

这个项目因其贡献者而更加完善。请参阅我们的[贡献者](https://raw.githubusercontent.com/vet-run/vet/main/CONTRIBUTORS.md)文件，以感谢那些帮助塑造`vet`的人。

## 许可

本项目采用MIT许可证 - 详情请参阅[LICENSE](https://spdx.org/licenses/MIT.html)文件。


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-16

---