# Chrome 精简工具

一个为基于 Chromium 的浏览器（Chrome、Brave 和 Edge）生成策略的工具，用于禁用不必要的功能、遥测和预装软件，同时启用一些提升使用体验的改进。

## 功能

- 尝试禁用遥测和使用报告
- 移除不必要的功能和预装的冗余软件
- 阻止推广内容和不必要的界面元素
- 在降低资源使用的同时保持浏览器功能完整
- 预配置必备扩展：
  - uBlock Origin
  - Cookie AutoDelete
  - Don't f*** with paste
  - I still don't care about cookies
  - SponsorBlock
  - BlockTube
  - BlankTab
  - Decentraleyes

### 支持的浏览器

| 浏览器 | Windows | macOS | Linux |
|---------|---------|-------|-------|
| Google Chrome | ✅ | ✅ | ✅ |
| Microsoft Edge | ✅ | ✅ | ✅ |
| Brave | ✅ | ✅ | ✅ |

## 快速开始

### Windows
1.  从 [`generated/windows/`](./generated/windows/) 下载对应浏览器的 `.reg` 文件。
2.  打开下载的 `.reg` 文件，将设置添加到 Windows 注册表。
3.  重启浏览器，或访问 `chrome://policy`（或 `edge://policy`、`brave://policy`）并点击“重新加载策略”。

### macOS
1.  从 [`generated/macos/`](./generated/macos/) 下载对应浏览器的 `.mobileconfig` 文件。
2.  打开下载的 `.mobileconfig` 文件，开始配置文件安装。
3.  前往“系统设置” > “隐私与安全” > “配置文件”，批准新配置文件。
4.  重启浏览器，或访问 `chrome://policy`（或 `edge://policy`、`brave://policy`）并点击“重新加载策略”。
### Linux
1.  从 [`generated/linux/`](./generated/linux/) 下载适用于您的浏览器的 `.json` 文件。
2.  将下载的文件移动到正确的策略目录（如果需要，请创建该目录）：
    *   **Chrome:** `/etc/opt/chrome/policies/managed/chrome.json`
    *   **Edge:** `/etc/opt/edge/policies/managed/edge.json`
    *   **Brave:** `/etc/brave/policies/managed/brave.json`
    *   *注意：您可能需要 `sudo` 权限来执行此操作。*
3.  重启浏览器或访问 `chrome://policy`（或 `edge://policy`，`brave://policy`），然后点击“重新加载策略”。

## 自定义配置

如果您想自定义策略：

1. 克隆此仓库
2. 安装依赖：

   ```bash
   uv sync
   ```
3. 根据您的需求修改 `policies.yaml`  
4. 生成新的配置文件：
   ```bash
   uv run main.py
   ```
5. 在 `generated/` 目录中找到生成的文件


### 卸载策略

**Windows:**
1.  进入本仓库中的 [`uninstall/windows/`](./uninstall/) 目录。
2.  运行与你的浏览器对应的 `.reg` 文件（例如，`uninstall_chrome.reg`）。这将移除安装期间添加的注册表项。
3.  重启浏览器或访问 `chrome://policy`（或 `edge://policy`，`brave://policy`），点击“重新加载策略”。

**macOS:**
1.  进入“系统设置” > “隐私与安全” > “配置文件”。
2.  选择与你的浏览器相关的配置文件（例如，“Chrome 去膨胀策略”）。
3.  点击“-”按钮以移除该配置文件。
4.  重启浏览器或访问 `chrome://policy`（或 `edge://policy`，`brave://policy`），点击“重新加载策略”。

**Linux:**
1.  从浏览器特定目录中移除策略 JSON 文件（可能需要 `sudo` 权限）：
    *   **Chrome:** `sudo rm /etc/opt/chrome/policies/managed/chrome.json`
    *   **Edge:** `sudo rm /etc/opt/edge/policies/managed/edge.json`
    *   **Brave:** `sudo rm /etc/brave/policies/managed/brave.json`
2.  重启浏览器或访问 `chrome://policy`（或 `edge://policy`，`brave://policy`），点击“重新加载策略”。

## 策略文档

- [Chrome 企业策略](https://chromeenterprise.google/policies/)
- [Brave 策略](https://support.brave.com/hc/en-us/articles/360039248271-Group-Policy)
- [Microsoft Edge 策略](https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies)

## 许可

[Apache 2.0](./LICENSE)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-02-23

---